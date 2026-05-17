using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Kutuphaneoto.Models;
using Kutuphaneoto.DataStructures;

namespace Kutuphaneoto
{
    public partial class FrmIadeAl : Form
    {
        OgrenciLinkedList ogrenciler = new OgrenciLinkedList();
        KitapLinkedList   kitaplar   = new KitapLinkedList();

        Ogrenci secilenOgrenci;
        Kitap   secilenKitap;

        public FrmIadeAl()
        {
            InitializeComponent();
        }

        private void FrmIadeAl_Load(object sender, EventArgs e)
        {
            OgrencileriYukle();
            KitaplariYukle();
            OduncleriYukle();
            OgrenciListesiniDoldur();
            BeklemeSiralariniYukle();
        }

        void OgrenciListesiniDoldur()
        {
            listBoxOgrenciler.Items.Clear();
            foreach (var ogr in ogrenciler.TumunuGetir())
                listBoxOgrenciler.Items.Add(ogr);
        }

        private void txtOgrenciAra_TextChanged(object sender, EventArgs e)
        {
            string aranan = txtOgrenciAra.Text.ToLower();
            listBoxOgrenciler.Items.Clear();

            foreach (var ogr in ogrenciler.TumunuGetir())
            {
                if (ogr.OgrenciNo.ToLower().Contains(aranan) ||
                    ogr.AdSoyad.ToLower().Contains(aranan))
                    listBoxOgrenciler.Items.Add(ogr);
            }
        }

        private void listBoxOgrenciler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxOgrenciler.SelectedItem == null) return;

            secilenOgrenci = (Ogrenci)listBoxOgrenciler.SelectedItem;

            txtSecilenOgrNo.Text   = secilenOgrenci.OgrenciNo;
            txtSecilenAdSoyad.Text = secilenOgrenci.AdSoyad;

            listBoxOgrenciKitaplar.Items.Clear();
            foreach (var kitap in secilenOgrenci.UzerindekiKitaplar)
                listBoxOgrenciKitaplar.Items.Add(kitap);
        }

        private void listBoxOgrenciKitaplar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxOgrenciKitaplar.SelectedItem == null) return;

            secilenKitap = (Kitap)listBoxOgrenciKitaplar.SelectedItem;

            txtKitapAdi.Text  = secilenKitap.KitapAdi;
            txtYazar.Text     = secilenKitap.Yazar;
            txtISBN.Text      = secilenKitap.ISBN;

            // ── YENİ: Tarih ve gecikme bilgisini kategori alanında göster ──
            txtKategori.Text = secilenKitap.GecikmeMetni();

            // Gecikmiş kitap kırmızı arka plan
            if (secilenKitap.SonIadeTarihi.HasValue && DateTime.Now > secilenKitap.SonIadeTarihi.Value)
                txtKategori.BackColor = Color.LightCoral;
            else
                txtKategori.BackColor = Color.LightGreen;
        }

        private void buttonIadeAl_Click(object sender, EventArgs e)
        {
            if (listBoxOgrenciler.SelectedItem == null || listBoxOgrenciKitaplar.SelectedItem == null)
            {
                MessageBox.Show("Lütfen öğrenci ve iade edilecek kitabı seçin.");
                return;
            }

            Ogrenci ogrenci = (Ogrenci)listBoxOgrenciler.SelectedItem;
            Kitap   kitap   = (Kitap)listBoxOgrenciKitaplar.SelectedItem;

            // ── YENİ: Gecikme hesabı ──
            int gecikmeGun = 0;
            if (kitap.SonIadeTarihi.HasValue && DateTime.Now > kitap.SonIadeTarihi.Value)
                gecikmeGun = (int)(DateTime.Now - kitap.SonIadeTarihi.Value).TotalDays;

            // 1. Öğrenciden kitabı kaldır
            ogrenci.UzerindekiKitaplar.Remove(kitap);

            // 2. Bekleyen var mı?
            if (kitap.BekleyenOgrenciNolari.Count > 0)
            {
                string  ogrNo    = kitap.BekleyenOgrenciNolari.Dequeue();
                Ogrenci siradaki = ogrenciler.TumunuGetir().FirstOrDefault(o => o.OgrenciNo == ogrNo);

                if (siradaki != null)
                {
                    kitap.OduncAlinmis = true;

                    // ── YENİ: Sıradaki öğrenciye yeni tarih ata ──
                    kitap.AlisTarihi    = DateTime.Now;
                    kitap.SonIadeTarihi = DateTime.Now.AddDays(15);

                    siradaki.UzerindekiKitaplar.Add(kitap);

                    TumOduncleriKaydet();
                    BeklemeSiralariniKaydet();

                    // ── YENİ: Gecikme varsa mesaja ekle ──
                    string gecikmeStr = gecikmeGun > 0
                        ? $"\n\n⚠ Gecikme: {gecikmeGun} gün"
                        : "";

                    MessageBox.Show(
                        $"Kitap iade alındı.{gecikmeStr}\n\n" +
                        $"Otomatik olarak {siradaki.AdSoyad} adlı öğrenciye verildi.\n" +
                        $"Yeni Son İade Tarihi: {kitap.SonIadeTarihi:dd.MM.yyyy}",
                        "İade Alındı",
                        MessageBoxButtons.OK,
                        gecikmeGun > 0 ? MessageBoxIcon.Warning : MessageBoxIcon.Information
                    );

                    LogStack.LogEkle($"Kitap iade edildi: {kitap.KitapAdi} - {ogrenci.AdSoyad}" +
                                     (gecikmeGun > 0 ? $" ({gecikmeGun} gün gecikmeli)" : ""));
                    LogStack.LogEkle($"Kitap kuyruktaki öğrenciye otomatik verildi: {siradaki.AdSoyad}");
                }
            }
            else
            {
                // 3. Kimse beklemiyorsa kitap boşa çıkar
                kitap.OduncAlinmis   = false;
                kitap.AlisTarihi     = null;
                kitap.SonIadeTarihi  = null;

                TumOduncleriKaydet();

                // ── YENİ: Gecikme varsa göster ──
                string gecikmeStr = gecikmeGun > 0
                    ? $"\n\n⚠ Gecikme: {gecikmeGun} gün"
                    : "";

                MessageBox.Show(
                    $"Kitap iade alındı ve müsait duruma geçti.{gecikmeStr}",
                    "İade Alındı",
                    MessageBoxButtons.OK,
                    gecikmeGun > 0 ? MessageBoxIcon.Warning : MessageBoxIcon.Information
                );

                LogStack.LogEkle($"Kitap iade edildi: {kitap.KitapAdi} - {ogrenci.AdSoyad}" +
                                 (gecikmeGun > 0 ? $" ({gecikmeGun} gün gecikmeli)" : ""));
            }

            // Ekranı yenile
            listBoxOgrenciler_SelectedIndexChanged(null, null);
            listBoxOgrenciKitaplar.Items.Clear();
            txtKategori.BackColor = SystemColors.Window;
        }

        // ── Dosya İşlemleri ───────────────────────────────────────────

        void TumOduncleriKaydet()
        {
            using (StreamWriter sw = new StreamWriter("oduncler.txt"))
            {
                foreach (var ogr in ogrenciler.TumunuGetir())
                {
                    foreach (var kitap in ogr.UzerindekiKitaplar)
                    {
                        string alis    = kitap.AlisTarihi?.ToString("dd.MM.yyyy")    ?? DateTime.Now.ToString("dd.MM.yyyy");
                        string sonIade = kitap.SonIadeTarihi?.ToString("dd.MM.yyyy") ?? DateTime.Now.AddDays(15).ToString("dd.MM.yyyy");
                        sw.WriteLine($"{ogr.OgrenciNo}|{kitap.ISBN}|{alis}|{sonIade}");
                    }
                }
            }
        }

        void OduncleriYukle()
        {
            if (!File.Exists("oduncler.txt")) return;

            foreach (string satir in File.ReadAllLines("oduncler.txt"))
            {
                string[] p = satir.Split('|');
                if (p.Length < 2) continue;

                Ogrenci ogr   = ogrenciler.TumunuGetir().FirstOrDefault(o => o.OgrenciNo == p[0]);
                Kitap   kitap = kitaplar.TumunuGetir().FirstOrDefault(k => k.ISBN == p[1]);

                if (ogr != null && kitap != null)
                {
                    kitap.OduncAlinmis = true;

                    // ── YENİ: Tarihleri yükle ──
                    if (p.Length >= 4)
                    {
                        kitap.AlisTarihi    = DateTime.Parse(p[2]);
                        kitap.SonIadeTarihi = DateTime.Parse(p[3]);
                    }
                    else
                    {
                        kitap.AlisTarihi    = DateTime.Now;
                        kitap.SonIadeTarihi = DateTime.Now.AddDays(15);
                    }

                    if (!ogr.UzerindekiKitaplar.Contains(kitap))
                        ogr.UzerindekiKitaplar.Add(kitap);
                }
            }
        }

        void KitaplariYukle()
        {
            if (!File.Exists("kitaplar.txt")) return;

            foreach (string satir in File.ReadAllLines("kitaplar.txt"))
            {
                string[] p = satir.Split('|');
                if (p.Length == 4)
                    kitaplar.Ekle(new Kitap(p[0], p[1], p[2], p[3]));
            }
        }

        void OgrencileriYukle()
        {
            if (!File.Exists("ogrenciler.txt")) return;

            foreach (string satir in File.ReadAllLines("ogrenciler.txt"))
            {
                string[] p = satir.Split('|');
                if (p.Length == 6)
                    ogrenciler.Ekle(new Ogrenci(p[0], p[1], p[2], p[3], p[4], DateTime.Parse(p[5])));
            }
        }

        void BeklemeSiralariniYukle()
        {
            if (!File.Exists("bekleme.txt")) return;

            foreach (string satir in File.ReadAllLines("bekleme.txt"))
            {
                var p = satir.Split('|');
                if (p.Length != 2) continue;

                var kitap = kitaplar.TumunuGetir().FirstOrDefault(k => k.ISBN == p[0]);
                if (kitap != null)
                    kitap.BekleyenOgrenciNolari.Enqueue(p[1]);
            }
        }

        void BeklemeSiralariniKaydet()
        {
            using (StreamWriter sw = new StreamWriter("bekleme.txt"))
            {
                foreach (var kitap in kitaplar.TumunuGetir())
                    foreach (var ogrNo in kitap.BekleyenOgrenciNolari)
                        sw.WriteLine($"{kitap.ISBN}|{ogrNo}");
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

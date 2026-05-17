using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kutuphaneoto.DataStructures;
using Kutuphaneoto.Models;
using System.IO;

namespace Kutuphaneoto
{
    public partial class FrmOduncVer : Form
    {
        Ogrenci secilenOgrenci;

        OgrenciLinkedList ogrenciler = new OgrenciLinkedList();
        KitapLinkedList kitaplar = new KitapLinkedList();

        public FrmOduncVer()
        {
            InitializeComponent();
        }

        private void FrmOduncVer_Load(object sender, EventArgs e)
        {
            OgrencileriYukle();
            OgrenciListesiniDoldur();
            KitaplariYukle();
            KitapListesiniDoldur();
            OduncleriYukle();
            BeklemeSiralariniYukle();
        }

        void OgrenciListesiniDoldur()
        {
            listBoxOgrenciler.Items.Clear();
            foreach (var ogr in ogrenciler.TumunuGetir())
                listBoxOgrenciler.Items.Add(ogr);
        }

        void KitapListesiniDoldur()
        {
            listBoxKitaplar.Items.Clear();
            foreach (var kitap in kitaplar.TumunuGetir())
                listBoxKitaplar.Items.Add(kitap);
        }

        private void listBoxOgrenciler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxOgrenciler.SelectedItem == null) return;

            Ogrenci secilen = (Ogrenci)listBoxOgrenciler.SelectedItem;

            txtSecilenOgrNo.Text = secilen.OgrenciNo;
            txtSecilenAdSoyad.Text = secilen.AdSoyad;

            listBoxOgrenciKitaplar.Items.Clear();
            foreach (var kitap in secilen.UzerindekiKitaplar)
                listBoxOgrenciKitaplar.Items.Add(kitap);
        }

        void OgrencileriYukle()
        {
            if (!File.Exists("ogrenciler.txt")) return;

            foreach (string satir in File.ReadAllLines("ogrenciler.txt"))
            {
                string[] p = satir.Split('|');
                if (p.Length == 6)
                {
                    ogrenciler.Ekle(new Ogrenci(p[0], p[1], p[2], p[3], p[4], DateTime.Parse(p[5])));
                }
            }
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

        private void txtKitapAra_TextChanged(object sender, EventArgs e)
        {
            string aranan = txtKitapAra.Text.ToLower();
            listBoxKitaplar.Items.Clear();

            foreach (var kitap in kitaplar.TumunuGetir())
            {
                if (kitap.KitapAdi.ToLower().Contains(aranan) ||
                    kitap.Yazar.ToLower().Contains(aranan))
                    listBoxKitaplar.Items.Add(kitap);
            }
        }

        private void listBoxKitaplar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxKitaplar.SelectedItem == null) return;

            Kitap secilen = (Kitap)listBoxKitaplar.SelectedItem;

            txtSecilenKitapAdi.Text = secilen.KitapAdi;
            txtSecilenYazar.Text = secilen.Yazar;
            txtSecilenISBN.Text = secilen.ISBN;
            txtSecilenKategori.Text = secilen.Kategori;
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

        private void btnOduncVer_Click(object sender, EventArgs e)
        {
            if (listBoxOgrenciler.SelectedItem == null || listBoxKitaplar.SelectedItem == null)
            {
                MessageBox.Show("Lütfen öğrenci ve kitap seçin.");
                return;
            }

            Ogrenci ogrenci = (Ogrenci)listBoxOgrenciler.SelectedItem;
            Kitap kitap = (Kitap)listBoxKitaplar.SelectedItem;

            // Max 3 kitap kontrolü
            if (ogrenci.UzerindekiKitaplar.Count >= 3)
            {
                MessageBox.Show("Bu öğrenci en fazla 3 kitap alabilir.");
                return;
            }

            // Kitap müsait mi kontrolü
            if (!kitap.OduncAlinmis)
            {
                kitap.OduncAlinmis = true;
                ogrenci.UzerindekiKitaplar.Add(kitap);

                OduncKaydet(ogrenci, kitap);

                // ── YENİ: Son iade tarihini göster ──
                MessageBox.Show(
                    $"Kitap başarıyla ödünç verildi.\n\n" +
                    $"Alış Tarihi   : {kitap.AlisTarihi:dd.MM.yyyy}\n" +
                    $"Son İade Tarihi: {kitap.SonIadeTarihi:dd.MM.yyyy}\n\n" +
                    $"Süre: 15 gün",
                    "Ödünç Verildi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LogStack.LogEkle($"Kitap ödünç alındı: {kitap.KitapAdi} - {ogrenci.AdSoyad} (İade: {kitap.SonIadeTarihi:dd.MM.yyyy})");
            }
            else
            {
                MessageBox.Show(
                    "Bu kitap şu anda ödünçte.\n" +
                    "İsterseniz 'Sıraya Ekle' butonunu kullanabilirsiniz."
                );
            }

            listBoxOgrenciler_SelectedIndexChanged(null, null);
        }

        private void btnSirayaEkle_Click(object sender, EventArgs e)
        {
            if (listBoxOgrenciler.SelectedItem == null || listBoxKitaplar.SelectedItem == null)
            {
                MessageBox.Show("Lütfen öğrenci ve kitap seçin.");
                return;
            }

            Ogrenci ogrenci = (Ogrenci)listBoxOgrenciler.SelectedItem;
            Kitap kitap = (Kitap)listBoxKitaplar.SelectedItem;

            if (!kitap.OduncAlinmis)
            {
                MessageBox.Show("Bu kitap şu an müsait. Ödünç verebilirsiniz.");
                return;
            }

            if (kitap.BeklemeSirasi.Contains(ogrenci))
            {
                MessageBox.Show("Bu öğrenci zaten bekleme sırasında.");
                return;
            }

            kitap.BekleyenOgrenciNolari.Enqueue(ogrenci.OgrenciNo);
            BeklemeSiralariniKaydet();

            MessageBox.Show(
                $"Öğrenci bekleme sırasına eklendi.\n" +
                $"Sıra numaranız: {kitap.BekleyenOgrenciNolari.Count}"
            );
            LogStack.LogEkle($"Kuyruğa eklendi: {ogrenci.AdSoyad} → {kitap.KitapAdi}");
        }

        // ── Dosya İşlemleri ───────────────────────────────────────────

        void OduncKaydet(Ogrenci ogr, Kitap kitap)
        {
            // ── YENİ: Tarihleri ata (15 günlük süre) ──
            kitap.AlisTarihi = DateTime.Now;
            kitap.SonIadeTarihi = DateTime.Now.AddDays(15);

            // Tüm aktif ödünçleri tarihlerle birlikte yeniden yaz
            TumOduncleriKaydet();

            // İstatistik geçmişine ekle (format değişmedi)
            using (StreamWriter sw = new StreamWriter("odunc_gecmisi.txt", true))
            {
                sw.WriteLine($"{ogr.OgrenciNo}|{kitap.ISBN}");
            }
        }

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
                        // Eski format → varsayılan tarih ata
                        kitap.AlisTarihi    = DateTime.Now;
                        kitap.SonIadeTarihi = DateTime.Now.AddDays(15);
                    }

                    if (!ogr.UzerindekiKitaplar.Contains(kitap))
                        ogr.UzerindekiKitaplar.Add(kitap);
                }
            }
        }

        private void btnGeriodver_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}

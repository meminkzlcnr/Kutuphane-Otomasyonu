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
        KitapLinkedList kitaplar = new KitapLinkedList();

        Ogrenci secilenOgrenci;
        Kitap secilenKitap;

        public FrmIadeAl()
        {
            InitializeComponent();
        }

        private void FrmIadeAl_Load(object sender, EventArgs e)
        {
            OgrencileriYukle();                                                             // fonksiyonları çağırır
            KitaplariYukle();
            OduncleriYukle();

            OgrenciListesiniDoldur();
            BeklemeSiralariniYukle();


        }
        void OgrenciListesiniDoldur()                                                        // listbox temizler 
        {
            listBoxOgrenciler.Items.Clear();

            foreach (var ogr in ogrenciler.TumunuGetir())                                       // tumunu getir fonksiyonunu çağırıp ogreni bilgilerini ekler
            {
                listBoxOgrenciler.Items.Add(ogr);
            }
        }

        private void txtOgrenciAra_TextChanged(object sender, EventArgs e)                      // ogrenciara textboxunda arama yapar
        {
            string aranan = txtOgrenciAra.Text.ToLower();                       
            listBoxOgrenciler.Items.Clear();

            foreach (var ogr in ogrenciler.TumunuGetir())                                   
            {
                if (
                    ogr.OgrenciNo.ToLower().Contains(aranan) ||                                 
                    ogr.AdSoyad.ToLower().Contains(aranan)
                )
                {
                    listBoxOgrenciler.Items.Add(ogr);
                }
            }
        }

        private void listBoxOgrenciler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxOgrenciler.SelectedItem == null)
                return;

            secilenOgrenci = (Ogrenci)listBoxOgrenciler.SelectedItem;

            txtSecilenOgrNo.Text = secilenOgrenci.OgrenciNo;                                        // seçilen öğrencinin bilgilerini ekler
            txtSecilenAdSoyad.Text = secilenOgrenci.AdSoyad;

            listBoxOgrenciKitaplar.Items.Clear();

            foreach (var kitap in secilenOgrenci.UzerindekiKitaplar)
            {
                listBoxOgrenciKitaplar.Items.Add(kitap);
            }
        }

        private void listBoxOgrenciKitaplar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxOgrenciKitaplar.SelectedItem == null)        
                return;

            secilenKitap = (Kitap)listBoxOgrenciKitaplar.SelectedItem;

            txtKitapAdi.Text = secilenKitap.KitapAdi;
            txtYazar.Text = secilenKitap.Yazar;                                                     // kitap bilgilerini textboxlara ekler
            txtISBN.Text = secilenKitap.ISBN;
            txtKategori.Text = secilenKitap.Kategori;
        }

        private void buttonIadeAl_Click(object sender, EventArgs e)
        {
            if (listBoxOgrenciler.SelectedItem == null || listBoxOgrenciKitaplar.SelectedItem == null)          //butona tıklandığında öğrenci seçilmemişse uyarı verir
            {
                MessageBox.Show("Lütfen öğrenci ve iade edilecek kitabı seçin.");
                return;
            }

            Ogrenci ogrenci = (Ogrenci)listBoxOgrenciler.SelectedItem;
            Kitap kitap = (Kitap)listBoxOgrenciKitaplar.SelectedItem;

            // 1️.Öğrenciden kitabı kaldır
            ogrenci.UzerindekiKitaplar.Remove(kitap);

            // 2️.Bekleyen var mı
            if (kitap.BekleyenOgrenciNolari.Count > 0)
            {
                string ogrNo = kitap.BekleyenOgrenciNolari.Dequeue();

                Ogrenci siradaki = ogrenciler.TumunuGetir().FirstOrDefault(o => o.OgrenciNo == ogrNo);


                if (siradaki != null)
                {
                    kitap.OduncAlinmis = true;
                    siradaki.UzerindekiKitaplar.Add(kitap);

                    TumOduncleriKaydet();                                                       // ödünçleri ve bekleme sırasını kaydeder
                    BeklemeSiralariniKaydet();

                    MessageBox.Show($"Kitap iade alındı.\n" + $"Otomatik olarak {siradaki.AdSoyad} adlı öğrenciye verildi.");           // messagebox ile bilgi verir
                    LogStack.LogEkle($"Kitap kuyruktaki öğrenciye otomatik verildi: {siradaki.AdSoyad}");                               // log stack ine ekler

                }
            }
            else
            {
                // 3️. Kimse beklemiyorsa kitap boşa çıkar
                kitap.OduncAlinmis = false;
                TumOduncleriKaydet();

                MessageBox.Show("Kitap iade alındı ve müsait duruma geçti.");                                   // massage box ile bilgi verir
                LogStack.LogEkle($"Kitap iade edildi: {kitap.KitapAdi} - {ogrenci.AdSoyad}");                   // stack e log ekler

            }

            // 4️⃣ Ekranı yenile
            listBoxOgrenciler_SelectedIndexChanged(null, null);
            listBoxOgrenciKitaplar.Items.Clear();
        }
        void TumOduncleriKaydet()                                                                           // odunçleri kaydeden fonksiyondur
        {
            using (StreamWriter sw = new StreamWriter("oduncler.txt"))
            {
                foreach (var ogr in ogrenciler.TumunuGetir())
                {
                    foreach (var kitap in ogr.UzerindekiKitaplar)
                    {
                        sw.WriteLine($"{ogr.OgrenciNo}|{kitap.ISBN}");
                    }
                }
            }
        }
        void OduncleriYukle()                                                                       // ödünçleri program çalışınca yükleyen fonksiyondur
        {
            if (!File.Exists("oduncler.txt"))
                return;

            string[] satirlar = File.ReadAllLines("oduncler.txt");

            foreach (string satir in satirlar)
            {
                string[] p = satir.Split('|');
                if (p.Length != 2) continue;

                string ogrNo = p[0];
                string isbn = p[1];

                Ogrenci ogr = ogrenciler.TumunuGetir().FirstOrDefault(o => o.OgrenciNo == ogrNo);


                Kitap kitap = kitaplar.TumunuGetir().FirstOrDefault(k => k.ISBN == isbn);


                if (ogr != null && kitap != null)
                {
                    kitap.OduncAlinmis = true;
                    ogr.UzerindekiKitaplar.Add(kitap);
                }
            }
        }
        void KitaplariYukle()                                                   // kitapları yükleyen fonksiyondur
        {
            if (!File.Exists("kitaplar.txt"))
                return;

            string[] satirlar = File.ReadAllLines("kitaplar.txt");

            foreach (string satir in satirlar)
            {
                string[] p = satir.Split('|');

                if (p.Length == 4)
                {
                    Kitap kitap = new Kitap(
                        p[0], // kitap adı
                        p[1], // yazar
                        p[2], // ISBN
                        p[3]  // kategori
                    );

                    kitaplar.Ekle(kitap);
                }
            }
        }
        void OgrencileriYukle()               // ogrenci yukleyen fonksiyondur
        {
            if (!File.Exists("ogrenciler.txt"))
                return;

            string[] satirlar = File.ReadAllLines("ogrenciler.txt");

            foreach (string satir in satirlar)
            {
                string[] p = satir.Split('|');

                if (p.Length == 6)
                {
                    Ogrenci ogr = new Ogrenci(
                        p[0], // ogr no
                        p[1], // ad soyad
                        p[2], // bolum
                        p[3], // fakulte
                        p[4], // sinif
                        DateTime.Parse(p[5])
                    );

                    ogrenciler.Ekle(ogr);
                }
            }
        }
        void OduncKaydet(Ogrenci ogr, Kitap kitap)
        {
            using (StreamWriter sw = new StreamWriter("oduncler.txt", true))
            {
                sw.WriteLine($"{ogr.OgrenciNo}|{kitap.ISBN}");
            }
        }
        void BeklemeSiralariniYukle()                               // uygulama çalışınca bekleme sıralarını yükler
        {
            if (!File.Exists("bekleme.txt"))
                return;

            foreach (string satir in File.ReadAllLines("bekleme.txt"))
            {
                var p = satir.Split('|');
                if (p.Length != 2) continue;

                var kitap = kitaplar.TumunuGetir().FirstOrDefault(k => k.ISBN == p[0]);
                if (kitap != null)
                    kitap.BekleyenOgrenciNolari.Enqueue(p[1]);
            }
        }
        void BeklemeSiralariniKaydet()                                                  // program kapatılınca bekleme sıralarını kaydeder
        {
            using (StreamWriter sw = new StreamWriter("bekleme.txt"))
            {
                foreach (var kitap in kitaplar.TumunuGetir())
                {
                    foreach (var ogrNo in kitap.BekleyenOgrenciNolari)
                    {
                        sw.WriteLine($"{kitap.ISBN}|{ogrNo}");
                    }
                }
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)                                  // onceki sayfaya geri döner
        {
            this.Close();
        }
    }
}

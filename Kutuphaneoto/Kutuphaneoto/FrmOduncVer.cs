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
            OgrencileriYukle();                                             // form çalışırken fonksiyonları çalıştırır
            OgrenciListesiniDoldur();
            KitaplariYukle();
            KitapListesiniDoldur();
            foreach (var kitap in kitaplar.TumunuGetir())
            {
                listBoxKitaplar.Items.Add(kitap);
            }
            OduncleriYukle();
            BeklemeSiralariniYukle();



        }
        void OgrenciListesiniDoldur()                               // program çalışırken listbox daki öğrencileri doldurur
        {   
            listBoxOgrenciler.Items.Clear();

            foreach (var ogr in ogrenciler.TumunuGetir())
            {
                listBoxOgrenciler.Items.Add(ogr);
            }
        }
        void KitapListesiniDoldur()                                    // program çalışırken kitap listbox ını doldurur
        {
            listBoxKitaplar.Items.Clear();

            foreach (var kitap in kitaplar.TumunuGetir())
            {
                listBoxKitaplar.Items.Add(kitap);
            }
        }

        private void listBoxOgrenciler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxOgrenciler.SelectedItem == null)
                return;

            Ogrenci secilen = (Ogrenci)listBoxOgrenciler.SelectedItem;

            txtSecilenOgrNo.Text = secilen.OgrenciNo;
            txtSecilenAdSoyad.Text = secilen.AdSoyad;

            listBoxOgrenciKitaplar.Items.Clear();

            foreach (var kitap in secilen.UzerindekiKitaplar)
            {
                listBoxOgrenciKitaplar.Items.Add(kitap);
            }
        }
        void OgrencileriYukle()                                             // program çalışırken öğrencileri yükler
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

        private void txtOgrenciAra_TextChanged(object sender, EventArgs e)                  // öğrenci araması yapar
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
         
        private void txtKitapAra_TextChanged(object sender, EventArgs e)          // kitap araması yapar
        {
            string aranan = txtKitapAra.Text.ToLower();
            listBoxKitaplar.Items.Clear();

            foreach (var kitap in kitaplar.TumunuGetir())
            {
                if (
                    kitap.KitapAdi.ToLower().Contains(aranan) ||
                    kitap.Yazar.ToLower().Contains(aranan)
                )
                {
                    listBoxKitaplar.Items.Add(kitap);
                }
            }
        }

        private void listBoxKitaplar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxKitaplar.SelectedItem == null)
                return;

            Kitap secilen = (Kitap)listBoxKitaplar.SelectedItem;                  // listboxtan seçilen kitabın bilgilerini texboxlara atar

            txtSecilenKitapAdi.Text = secilen.KitapAdi;
            txtSecilenYazar.Text = secilen.Yazar;
            txtSecilenISBN.Text = secilen.ISBN;
            txtSecilenKategori.Text = secilen.Kategori;

        }
        void KitaplariYukle()                                                 // program çalışırken kitapları yükler
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

        private void btnOduncVer_Click(object sender, EventArgs e)                                             
        {
            if (listBoxOgrenciler.SelectedItem == null || listBoxKitaplar.SelectedItem == null)             // odunc ver butonuna tıklayınca 
            {
                MessageBox.Show("Lütfen öğrenci ve kitap seçin.");                                          // ogrenci seçilmemişse uyarı verir
                return;
            }

            Ogrenci ogrenci = (Ogrenci)listBoxOgrenciler.SelectedItem;
            Kitap kitap = (Kitap)listBoxKitaplar.SelectedItem;

            // 1️. Max 3 kitap kontrolü
            if (ogrenci.UzerindekiKitaplar.Count >= 3)                                                      
            {
                MessageBox.Show("Bu öğrenci en fazla 3 kitap alabilir.");
                return;
            }

            // 2️. Kitap alınmış mı kontrolü
            if (!kitap.OduncAlinmis)
            {
                kitap.OduncAlinmis = true;
                ogrenci.UzerindekiKitaplar.Add(kitap);

                OduncKaydet(ogrenci, kitap); // ✅ SADECE BURADA

                MessageBox.Show("Kitap başarıyla ödünç verildi.");
                LogStack.LogEkle($"Kitap ödünç alındı: {kitap.KitapAdi} - {ogrenci.AdSoyad}");

            }
            else
            {
                MessageBox.Show(
                    "Bu kitap şu anda ödünçte.\n" +
                    "İsterseniz 'Sıraya Ekle' butonunu kullanabilirsiniz."
                );
            }

            //  güncelleme
            listBoxOgrenciler_SelectedIndexChanged(null, null);

        }

        private void btnSirayaEkle_Click(object sender, EventArgs e)                               // rezervasyon kuyruğuna ekleme butonuna basılınca 
        {
            if (listBoxOgrenciler.SelectedItem == null || listBoxKitaplar.SelectedItem == null)       // öğrenci ve kitap seçilmiş mi kontrol edilir
            {
                MessageBox.Show("Lütfen öğrenci ve kitap seçin.");                                      // seçilmemişse  uyarı verir
                return;
            }

            Ogrenci ogrenci = (Ogrenci)listBoxOgrenciler.SelectedItem;
            Kitap kitap = (Kitap)listBoxKitaplar.SelectedItem;

            if (!kitap.OduncAlinmis)
            {
                MessageBox.Show("Bu kitap şu an müsait. Ödünç verebilirsiniz.");                    // kitabı alan yoksa kitağ müasit der.
                return;
            }
                
            if (kitap.BeklemeSirasi.Contains(ogrenci))                                              // öğrenci bekleme sırasındaysa önceden uyarı verir
            {   
                MessageBox.Show("Bu öğrenci zaten bekleme sırasında.");
                return;
            }

            kitap.BekleyenOgrenciNolari.Enqueue(ogrenci.OgrenciNo);
            BeklemeSiralariniKaydet();                                                          // bekleme sıralarını kaydeder


            MessageBox.Show(
                "Öğrenci bekleme sırasına eklendi.\n" +
                $"Bekleyen kişi sayısı: {kitap.BeklemeSirasi.Count}"                            // sıra bilgisini gösterir
            );
            LogStack.LogEkle($"Kitap meşgul olduğu için öğrenci kuyruğa eklendi: {ogrenci.AdSoyad}");       // stack e log ekler


        }   
        void OduncKaydet(Ogrenci ogr, Kitap kitap)                                              // ödünçleri kaydeder
        {
            using (StreamWriter sw = new StreamWriter("oduncler.txt", true))
            {
                sw.WriteLine($"{ogr.OgrenciNo}|{kitap.ISBN}");
            }
            using (StreamWriter sw = new StreamWriter("odunc_gecmisi.txt", true))
            {
                sw.WriteLine($"{ogr.OgrenciNo}|{kitap.ISBN}");
            }
        }   
        void OduncleriYukle()                                                               // ödünçleri program başlayınca yukleme fonksiyonudur
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

        private void btnGeriodver_Click(object sender, EventArgs e)                 // önceki sayfaya döner
        {
            this.Close();
        }
        void BeklemeSiralariniKaydet()                                              // bekleme sıralarını kaydeden fonksiyondur
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
        void BeklemeSiralariniYukle()                             // program başlayınca bekleme sıralarını yukleyen fonksiyondur
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


    }
}

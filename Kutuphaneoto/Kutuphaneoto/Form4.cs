using Kutuphaneoto.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kutuphaneoto.Models;
using Kutuphaneoto.DataStructures;
using System.IO;


namespace Kutuphaneoto
{
    public partial class FrmOgrenciYonetimi : Form
    {
        public FrmOgrenciYonetimi()
        {
            InitializeComponent();
        }

        private void buttonGeriOgrenci_Click(object sender, EventArgs e)          // geri butonuna tıklayınca önceki forma geçmemizi sağlar
        {
            this.Close();
        }

        OgrenciLinkedList ogrenciler = new OgrenciLinkedList();                  
        private void btnOgrenciEkle_Click(object sender, EventArgs e)              // ogrenci ekle butonuna tıklayınca 
        {
            Ogrenci ogr = new Ogrenci(
                txtOgrNo.Text,
                txtAdSoyad.Text,                                                // öğrencini bilgilerini alır
                txtBolum.Text,
                txtFakulte.Text,
                txtSinif.Text,
                dtpDogumTarihi.Value
            );
            

            ogrenciler.Ekle(ogr);                                               // öğrenciyi ekler
            ListeyiGuncelle();                                                  // listeyi günceller
            LogStack.LogEkle("Yeni öğrenci eklendi: " + ogr.AdSoyad);           // öğrenci eklendi diye log kaydı alır
            Temizle();                                                          // öürenci bilgi değişkenlerini temizler
        }
        void ListeyiGuncelle()                                                  // listeyi günceller
        {
            listBoxOgrenciler.Items.Clear();

            foreach (var ogr in ogrenciler.TumunuGetir())
            {
                listBoxOgrenciler.Items.Add(ogr);
            }
        }
        void Temizle()                                                      // öğrenci bilgi değişkenlerini temizleyen fonksiyondur
        {
            txtOgrNo.Clear();
            txtAdSoyad.Clear();
            txtBolum.Clear();
            txtFakulte.Clear();
            txtSinif.Clear();
            dtpDogumTarihi.Value = DateTime.Now;
        }

        private void txtOgrenciAra_TextChanged(object sender, EventArgs e)           // öğrenci arama textbox u na bir şey yazdığımızda
        {
            string aranan = txtOgrenciAra.Text;                                     // yazdığımızı değişkene atar 

            listBoxOgrenciler.Items.Clear();

            foreach (var ogr in ogrenciler.TumunuGetir())
            {
                if (ogr.OgrenciNo.Contains(aranan))
                {
                    listBoxOgrenciler.Items.Add(ogr);
                }
            }

        }

        private void listBoxOgrenciler_SelectedIndexChanged(object sender, EventArgs e)         
        {
            if (listBoxOgrenciler.SelectedItem != null)                                 // listbox da öğrenci seçip seçmedimizi kontrol eder
            {
                Ogrenci secilen = (Ogrenci)listBoxOgrenciler.SelectedItem;               // eğer seçtiysek seçtiğimiz öğrenciyi secilen öğrenci textboxunda gösteririr
                txtSecilenOgrenci.Text = secilen.DetayliBilgi();
            }

        }

        private void btnOgrenciSil_Click(object sender, EventArgs e)                    // öğrenci butonuna tıkladığımızda ne olacağını gösteren fonksiyondur
        {
            if (listBoxOgrenciler.SelectedItem != null)                                // listboxtan öğrenci seçip seçmediğimizi kontrol eder
            {
                Ogrenci secilen = (Ogrenci)listBoxOgrenciler.SelectedItem;             

                ogrenciler.Sil(secilen.OgrenciNo);                                      // seçtiysek öğreniyi siler
                ListeyiGuncelle();                                                      // listeyi günceller
                LogStack.LogEkle("Öğrenci silindi: " + secilen.AdSoyad);                // öğrenci silindi diye log kaydı alırız
                txtSecilenOgrenci.Clear();                                              // seçilen öğrenci textbox u temizlenir
            }
            else
            {
                MessageBox.Show("Lütfen silinecek öğrenciyi seçin.");                   // öğrenci seçmediğimizde uyarı verir
            }
        }
        void OgrencileriKaydet()                                                        
        {
            using (StreamWriter sw = new StreamWriter("ogrenciler.txt"))                // öğrenci ekleme silme değişiklerini dosyaya kayededen fonksiyonudr
            {
                foreach (var ogr in ogrenciler.TumunuGetir())
                {
                    sw.WriteLine(
                        $"{ogr.OgrenciNo}|{ogr.AdSoyad}|{ogr.Bolum}|{ogr.Fakulte}|{ogr.Sinif}|{ogr.DogumTarihi}"
                    );
                }
            }
        }
        void OgrencileriYukle()                                                     // önceden dosyaya kaydetiğimiz öğrencileri yükleyen fonksiyondur
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
                        p[0],                        // ogrenci no
                        p[1],                        // ad soyad
                        p[2],                        // bolum
                        p[3],                        // fakulte
                        p[4],                         // sinif
                        DateTime.Parse(p[5])           // dogum tarihi
                    );

                    ogrenciler.Ekle(ogr);
                }
            }
        }

        private void FrmOgrenciYonetimi_Load(object sender, EventArgs e)
        {
            OgrencileriYukle();                                             // form yüklenirken öğrencileri dosyadan yükleyen fonksiyon
            ListeyiGuncelle();                                               // lsiteyi güncelleyen fonksiyon
        }

        private void FrmOgrenciYonetimi_FormClosing(object sender, FormClosingEventArgs e)
        {
            OgrencileriKaydet();                                            // form kapandığında öğrenci ekleme silme gibi değişiklikleri doyaya kaydeden fonksiyon
        }

        private void btnDetay_Click(object sender, EventArgs e)             // detay formuna tıklayınca 
        {
            FrmOgrenciDetay frm = new FrmOgrenciDetay(ogrenciler);          // öğrencidetay formunu açar
            frm.ShowDialog();
        }
    }
}



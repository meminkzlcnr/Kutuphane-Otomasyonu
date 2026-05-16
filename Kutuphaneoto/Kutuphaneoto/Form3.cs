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
    // kitap ekle kitap sil gibi işlemleri yaptığımız kitap yönetimi formumuzdur
    public partial class FrmKitapYonetimi : Form
    {
        void DosyayaKaydet()
        {
            using (StreamWriter sw = new StreamWriter("kitaplar.txt"))                              // eklediğimiz kitapları dosyaya kaydeder
            {
                foreach (var kitap in kitaplar.TumunuGetir())
                {
                    sw.WriteLine($"{kitap.KitapAdi}|{kitap.Yazar}|{kitap.ISBN}|{kitap.Kategori}");
                }
            }
        }

        void DosyadanYukle()                                                   // önceden kaydetiğimiz kitapları yükler
        {
            if (!File.Exists("kitaplar.txt"))                                   // "kitaplar.txt" dosyası yoksa bir şey yapmaz
                return;

            string[] satirlar = File.ReadAllLines("kitaplar.txt");               // liste varsa okur 

            foreach (string satir in satirlar)
            {
                string[] parcalar = satir.Split('|');

                if (parcalar.Length == 4)                                    
                {
                    Kitap kitap = new Kitap(
                        parcalar[0],
                        parcalar[1],
                        parcalar[2],
                        parcalar[3]
                    );

                    kitaplar.Ekle(kitap);                                    // kitapları ekler
                }
            }
        }
        KitapLinkedList kitaplar = new KitapLinkedList();

        public FrmKitapYonetimi()
        {
            InitializeComponent();
        }

        private void buttonGeriKitap_Click(object sender, EventArgs e)             // geri butonuna basınca önceki forma geçer
        {
            this.Close();
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)                 // kitap ekle butonuna tıklayınca 
        {
            Kitap yeniKitap = new Kitap(                                            // yeni kitap oluşturur bilgileri atar
                txtKitapAdi.Text,
                txtYazar.Text,                                                      
                txtISBN.Text,
                txtKategori.Text
            );

            kitaplar.Ekle(yeniKitap);                                               // kitabı ekler
            ListeyiGuncelle();                                                       // kitap listesini günceller
            LogStack.LogEkle("Yeni kitap eklendi: " + yeniKitap.KitapAdi);            // kitap eklendi diye log kaydını alır + kitap adını yazar

            Temizle();                                                               // temizle fonk çalıştırır. fonk kitap adı vs değişkenlerini temizler
        }
        void ListeyiGuncelle()                                                     // kitap ekledikten sonra ya da silindikten sonra listeyi günceller
        {
            listBoxKitaplar.Items.Clear();

            foreach (var kitap in kitaplar.TumunuGetir())
            {
                listBoxKitaplar.Items.Add(kitap);
            }
        }

        void Temizle()
        {
            txtKitapAdi.Clear();                       // yeni kitap ekleyebilmek şiçin txtkitap vs değişkenlerini temizler
            txtYazar.Clear();
            txtISBN.Clear();
            txtKategori.Clear();
        }
        private void txtKitapAra_TextChanged_1(object sender, EventArgs e)    // textbox kitap ara ile kitap arar 
        {
            string aranan = txtKitapAra.Text.ToLower();                       // aramaya yazdığımız kitabı büyük harfe çevirir arar
            listBoxKitaplar.Items.Clear();

            foreach (var kitap in kitaplar.TumunuGetir())
            {
                if (kitap.KitapAdi.ToLower().Contains(aranan))
                {
                    listBoxKitaplar.Items.Add(kitap);
                }
            }
        }
        private void listBoxKitaplar_SelectedIndexChanged_1(object sender, EventArgs e)    
        {
            if (listBoxKitaplar.SelectedItem != null)                                      // listbox da tıkladğımız kitabı 
            {
                Kitap secilen = (Kitap)listBoxKitaplar.SelectedItem;
                txtSecilenKitap.Text = secilen.ToString();                                  // secilenkitap textbox una yazar
            }

        }

        private void btnKitapSil_Click(object sender, EventArgs e)                    // kitap sil butonuna tıkladığımızda 
        {
            if (listBoxKitaplar.SelectedItem != null)                                 // kitap seçildi mi diye kontrol eder eğer seçilmişse
            {
                Kitap secilen = (Kitap)listBoxKitaplar.SelectedItem;

                kitaplar.Sil(secilen.ISBN);                                         // kitabı siler

                ListeyiGuncelle();                                                  // ve listeyi günceller
                LogStack.LogEkle("Kitap silindi: " + secilen.KitapAdi);             // log kaydı alır :"kitap silindi + kitabına dı"

                txtSecilenKitap.Clear();                                            // secilen kitap textbox değişkenini temizler
            }
            else
            {
                MessageBox.Show("Lütfen silinecek kitabı seçin.");                  // kitap seçilmemişse uyarı mesaji verir
            }

        }

        private void FrmKitapYonetimi_Load(object sender, EventArgs e)          // kitap yönetimi çalışırken
        {
            DosyadanYukle();                                                    // dosyadan yukle fonk çağırır
            ListeyiGuncelle();                                                  // listeyi güncelle fonk çağırır
        }

        private void FrmKitapYonetimi_FormClosing(object sender, FormClosingEventArgs e)        // form kapatılırken
        {
            DosyayaKaydet();                                                                    // değişiklikleri dosyaya kaydeder
        }
    }
}



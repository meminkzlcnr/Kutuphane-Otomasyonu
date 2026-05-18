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
    public partial class FrmKitapYonetimi : Form
    {
        private string kullaniciRolu = "Ogrenci"; 

        public FrmKitapYonetimi(string rol)
        {
            InitializeComponent();
            kullaniciRolu = rol;
        }

        public FrmKitapYonetimi()
        {
            InitializeComponent();
        }

        void DosyayaKaydet()
        {
            if (kullaniciRolu == "Ogrenci") return;

            using (StreamWriter sw = new StreamWriter("kitaplar.txt"))
            {
                foreach (var kitap in kitaplar.TumunuGetir())
                {
                    sw.WriteLine($"{kitap.KitapAdi}|{kitap.Yazar}|{kitap.ISBN}|{kitap.Kategori}");
                }
            }
        }

        void DosyadanYukle()
        {
            if (!File.Exists("kitaplar.txt"))
                return;

            string[] satirlar = File.ReadAllLines("kitaplar.txt");

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

                    kitaplar.Ekle(kitap);
                }
            }
        }
        
        KitapLinkedList kitaplar = new KitapLinkedList();

        private void buttonGeriKitap_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            Kitap yeniKitap = new Kitap(
                txtKitapAdi.Text,
                txtYazar.Text,                                                       
                txtISBN.Text,
                txtKategori.Text
            );

            kitaplar.Ekle(yeniKitap);
            ListeyiGuncelle();
            LogStack.LogEkle("Yeni kitap eklendi: " + yeniKitap.KitapAdi);

            Temizle();
        }
        
        void ListeyiGuncelle()
        {
            listBoxKitaplar.Items.Clear();

            foreach (var kitap in kitaplar.TumunuGetir())
            {
                listBoxKitaplar.Items.Add(kitap);
            }
        }

        void Temizle()
        {
            txtKitapAdi.Clear();
            txtYazar.Clear();
            txtISBN.Clear();
            txtKategori.Clear();
        }
        
        private void txtKitapAra_TextChanged_1(object sender, EventArgs e)
        {
            string aranan = txtKitapAra.Text.ToLower().Trim();
            listBoxKitaplar.Items.Clear();

            foreach (var kitap in kitaplar.TumunuGetir())
            {
                if (kitap.KitapAdi.ToLower().Contains(aranan) ||
                    kitap.Yazar.ToLower().Contains(aranan) ||
                    kitap.ISBN.ToLower().Contains(aranan) ||
                    kitap.Kategori.ToLower().Contains(aranan))
                {
                    listBoxKitaplar.Items.Add(kitap);
                }
            }
        }
        
        private void listBoxKitaplar_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listBoxKitaplar.SelectedItem != null)
            {
                Kitap secilen = (Kitap)listBoxKitaplar.SelectedItem;

                txtSecilenKitap.Text = $"📖 Kitap Adı: {secilen.KitapAdi}\r\n" +
                                       $"✍️ Yazarı: {secilen.Yazar}\r\n" +
                                       $"🆔 ISBN No: {secilen.ISBN}\r\n" +
                                       $"🗂️ Kategorisi: {secilen.Kategori}";
            }
        }

        private void btnKitapSil_Click(object sender, EventArgs e)
        {
            if (listBoxKitaplar.SelectedItem != null)
            {
                Kitap secilen = (Kitap)listBoxKitaplar.SelectedItem;

                kitaplar.Sil(secilen.ISBN);

                ListeyiGuncelle();
                LogStack.LogEkle("Kitap silindi: " + secilen.KitapAdi);

                txtSecilenKitap.Clear();
            }
            else
            {
                MessageBox.Show("Lütfen silinecek kitabı seçin.");
            }
        }

        private void FrmKitapYonetimi_Load(object sender, EventArgs e)
        {
            txtSecilenKitap.Height = 120;

            DosyadanYukle();
            ListeyiGuncelle();

            if (kullaniciRolu == "Ogrenci")
            {
                btnKitapEkle.Visible = false;
                btnKitapSil.Visible = false;
                
                txtKitapAdi.Visible = false;
                txtYazar.Visible = false;
                txtISBN.Visible = false;
                txtKategori.Visible = false;

                this.Text = "Kütüphane Otomasyonu - Öğrenci Kitap Arama ve Listeleme";
            }
            else
            {
                this.Text = "Kütüphane Otomasyonu - Yönetici Paneli";
            }
        }

        private void FrmKitapYonetimi_FormClosing(object sender, FormClosingEventArgs e)
        {
            DosyayaKaydet();
        }
    }
}

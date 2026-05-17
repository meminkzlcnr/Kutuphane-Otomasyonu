using System;
using System.IO;
using System.Windows.Forms;
using Kutuphaneoto.Models;
using Kutuphaneoto.DataStructures;

namespace Kutuphaneoto
{
    // Kullanıcı ekleme, güncelleme ve silme işlemlerini yaptığımız formdur
    public partial class FrmKullaniciYonetimi : Form
    {
        KullaniciLinkedList kullanicilar = new KullaniciLinkedList();

        public FrmKullaniciYonetimi()
        {
            InitializeComponent();
        }

        private void FrmKullaniciYonetimi_Load(object sender, EventArgs e)
        {
            KullanicilariYukle();    // dosyadan yükle
            ListeyiGuncelle();       // listbox'ı doldur
        }

        private void FrmKullaniciYonetimi_FormClosing(object sender, FormClosingEventArgs e)
        {
            KullanicilariKaydet();   // kapanırken dosyaya kaydet
        }

        // ── Dosya İşlemleri ────────────────────────────────────────────

        void KullanicilariYukle()
        {
            // kullanicilar.txt yoksa varsayılan admin hesabını oluştur
            if (!File.Exists("kullanicilar.txt"))
            {
                kullanicilar.Ekle(new Kullanici("admin", "admin123", "Sistem Yöneticisi", "Yönetici"));
                KullanicilariKaydet();
                return;
            }

            string[] satirlar = File.ReadAllLines("kullanicilar.txt");

            foreach (string satir in satirlar)
            {
                string[] p = satir.Split('|');
                if (p.Length == 4)
                {
                    kullanicilar.Ekle(new Kullanici(p[0], p[1], p[2], p[3]));
                }
            }
        }

        void KullanicilariKaydet()
        {
            using (StreamWriter sw = new StreamWriter("kullanicilar.txt"))
            {
                foreach (var k in kullanicilar.TumunuGetir())
                {
                    sw.WriteLine($"{k.KullaniciAdi}|{k.Sifre}|{k.AdSoyad}|{k.Rol}");
                }
            }
        }

        // ── Yardımcı Fonksiyonlar ──────────────────────────────────────

        void ListeyiGuncelle()
        {
            listBoxKullanicilar.Items.Clear();
            foreach (var k in kullanicilar.TumunuGetir())
            {
                listBoxKullanicilar.Items.Add(k);
            }
        }

        void Temizle()
        {
            txtKullaniciAdi.Clear();
            txtSifre.Clear();
            txtAdSoyad.Clear();
            cmbRol.SelectedIndex = -1;
            txtKullaniciAdi.ReadOnly = false;   // yeni ekleme için tekrar açık olsun
        }

        // ── Buton Olayları ─────────────────────────────────────────────

        private void btnEkle_Click(object sender, EventArgs e)
        {
            // Boş alan kontrolü
            if (string.IsNullOrWhiteSpace(txtKullaniciAdi.Text) ||
                string.IsNullOrWhiteSpace(txtSifre.Text) ||
                string.IsNullOrWhiteSpace(txtAdSoyad.Text) ||
                cmbRol.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Aynı kullanıcı adı var mı kontrolü
            if (kullanicilar.Bul(txtKullaniciAdi.Text) != null)
            {
                MessageBox.Show("Bu kullanıcı adı zaten mevcut.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Kullanici yeni = new Kullanici(
                txtKullaniciAdi.Text,
                txtSifre.Text,
                txtAdSoyad.Text,
                cmbRol.SelectedItem.ToString()
            );

            kullanicilar.Ekle(yeni);
            ListeyiGuncelle();
            LogStack.LogEkle("Yeni kullanıcı eklendi: " + yeni.KullaniciAdi);
            Temizle();
            MessageBox.Show("Kullanıcı başarıyla eklendi.", "Başarılı",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (listBoxKullanicilar.SelectedItem == null)
            {
                MessageBox.Show("Lütfen güncellenecek kullanıcıyı seçin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSifre.Text) ||
                string.IsNullOrWhiteSpace(txtAdSoyad.Text) ||
                cmbRol.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen şifre, ad soyad ve rol alanlarını doldurun.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Kullanici secilen = (Kullanici)listBoxKullanicilar.SelectedItem;

            kullanicilar.Guncelle(
                secilen.KullaniciAdi,
                txtSifre.Text,
                txtAdSoyad.Text,
                cmbRol.SelectedItem.ToString()
            );

            ListeyiGuncelle();
            LogStack.LogEkle("Kullanıcı güncellendi: " + secilen.KullaniciAdi);
            Temizle();
            txtSecilenBilgi.Clear();
            MessageBox.Show("Kullanıcı başarıyla güncellendi.", "Başarılı",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (listBoxKullanicilar.SelectedItem == null)
            {
                MessageBox.Show("Lütfen silinecek kullanıcıyı seçin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Kullanici secilen = (Kullanici)listBoxKullanicilar.SelectedItem;

            // Son yönetici silinemez kontrolü
            int yoneticiSayisi = kullanicilar.TumunuGetir()
                .FindAll(k => k.Rol == "Yönetici").Count;

            if (secilen.Rol == "Yönetici" && yoneticiSayisi <= 1)
            {
                MessageBox.Show("Son yönetici hesabı silinemez!", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult sonuc = MessageBox.Show(
                $"'{secilen.KullaniciAdi}' kullanıcısı silinecek. Emin misiniz?",
                "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (sonuc == DialogResult.Yes)
            {
                kullanicilar.Sil(secilen.KullaniciAdi);
                ListeyiGuncelle();
                LogStack.LogEkle("Kullanıcı silindi: " + secilen.KullaniciAdi);
                txtSecilenBilgi.Clear();
                Temizle();
                MessageBox.Show("Kullanıcı başarıyla silindi.", "Başarılı",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // ── ListBox & Arama Olayları ───────────────────────────────────

        private void listBoxKullanicilar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxKullanicilar.SelectedItem == null)
                return;

            Kullanici secilen = (Kullanici)listBoxKullanicilar.SelectedItem;

            // Formlara doldur (güncelleme kolaylığı için)
            txtKullaniciAdi.Text = secilen.KullaniciAdi;
            txtKullaniciAdi.ReadOnly = true;     // seçili kullanıcının adı değiştirilemez
            txtSifre.Text = secilen.Sifre;
            txtAdSoyad.Text = secilen.AdSoyad;
            cmbRol.SelectedItem = secilen.Rol;

            // Detay paneline yaz
            txtSecilenBilgi.Text = secilen.DetayliBilgi();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            string aranan = txtAra.Text.ToLower();
            listBoxKullanicilar.Items.Clear();

            foreach (var k in kullanicilar.TumunuGetir())
            {
                if (k.KullaniciAdi.ToLower().Contains(aranan) ||
                    k.AdSoyad.ToLower().Contains(aranan))
                {
                    listBoxKullanicilar.Items.Add(k);
                }
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

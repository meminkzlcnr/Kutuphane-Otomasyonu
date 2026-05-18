using System;
using System.IO;
using System.Windows.Forms;

namespace Kutuphaneoto
{
    public partial class FrmGirisEkrani : Form
    {
        // Program açılınca giriş ekranı gelir. Kullanıcı adı ve şifre alınır.
        public FrmGirisEkrani()
        {
            InitializeComponent();
        }

        private void girisbutton_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = textBoxKullaniciadi.Text.Trim();
            string sifre = textBoxSifre.Text.Trim();

            // Giriş doğrulaması yaparken aynı zamanda kullanıcının rolünü de alıyoruz
            string rol = RoluGetir(kullaniciAdi, sifre);

            if (rol != null) // rol null değilse giriş başarılı demektir
            {
                MessageBox.Show($"{rol} Girişi Başarılı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // ── YETKİLENDİRME BURADA YAPILIYOR ──
                // Ana menüyü açarken giriş yapan kişinin rolünü (Admin veya Ogrenci) gönderiyoruz
                FrmAnaMenu frmAnaMenu = new FrmAnaMenu(rol);
                frmAnaMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(
                    "Kullanıcı adı veya şifre hatalı!",
                    "Hatalı Giriş",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Giriş yapan kullanıcının rolünü (Admin/Ogrenci) döndürür, hatalıysa null döndürür.
        string RoluGetir(string kullaniciAdi, string sifre)
        {
            // Dosya yoksa varsayılan olarak admin kontrolü yap ve rolü "Admin" olarak döndür
            if (!File.Exists("kullanicilar.txt"))
            {
                if (kullaniciAdi == "admin" && sifre == "admin123")
                {
                    return "Admin";
                }
                return null;
            }

            string[] satirlar = File.ReadAllLines("kullanicilar.txt");

            foreach (string satir in satirlar)
            {
                string[] p = satir.Split('|');
                // Format: KullaniciAdi|Sifre|AdSoyad|Rol
                if (p.Length >= 4 && p[0] == kullaniciAdi && p[1] == sifre)
                {
                    return p[3].Trim(); // Dosyadaki 4. parçayı (Rol: Admin, Ogrenci vb.) döndürür
                }
            }

            return null; // Dosyada bulunamadıysa
        }
    }
}

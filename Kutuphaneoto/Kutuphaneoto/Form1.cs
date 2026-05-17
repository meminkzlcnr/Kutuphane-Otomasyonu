using System.IO;

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
            string kullaniciAdi = textBoxKullaniciadi.Text;
            string sifre = textBoxSifre.Text;

            if (GirisDogrula(kullaniciAdi, sifre))
            {
                FrmAnaMenu frmAnaMenu = new FrmAnaMenu();
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

        // kullanicilar.txt dosyasından giriş doğrulaması yapar.
        // Dosya yoksa varsayılan admin/admin123 ile giriş yapılır.
        bool GirisDogrula(string kullaniciAdi, string sifre)
        {
            if (!File.Exists("kullanicilar.txt"))
            {
                return kullaniciAdi == "admin" && sifre == "admin123";
            }

            string[] satirlar = File.ReadAllLines("kullanicilar.txt");

            foreach (string satir in satirlar)
            {
                string[] p = satir.Split('|');
                // format: KullaniciAdi|Sifre|AdSoyad|Rol
                if (p.Length >= 2 && p[0] == kullaniciAdi && p[1] == sifre)
                    return true;
            }

            return false;
        }
    }
}

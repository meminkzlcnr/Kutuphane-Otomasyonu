namespace Kutuphaneoto
{
    public partial class FrmGirisEkrani : Form
    {
        // program açýlýrkenki giriþ ekraný. kullanýcý adý ve þifre alýnýr.
        public FrmGirisEkrani()
        {
            InitializeComponent();
        }

        private void girisbutton_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = textBoxKullaniciadi.Text;              // girdiðimiz kullanýcý adýný alýr
            string sifre = textBoxSifre.Text;                            // girdiðimiz þifreyi alýr

            if (kullaniciAdi == "admin" && sifre == "admin123")          // kullanýcý adý ve þifre doðru mu diye bakar  
            {
                FrmAnaMenu frmAnaMenu = new FrmAnaMenu();                // doðru ise ana forma geçiþ yapar
                frmAnaMenu.Show();
                this.Hide();                                             // Giriþ ekranýný gizler.
            }
            else
            {
                MessageBox.Show(
                    "Kullanýcý adý veya þifre hatalý!",                   // kullanýcý adý veya þifre hatalý ise
                    "Hatalý Giriþ",                                        // hatalý giriþ yaptýnýz der.
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}

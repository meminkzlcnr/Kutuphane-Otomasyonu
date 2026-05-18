using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphaneoto
{
    public partial class FrmAnaMenu : Form
    {
        private string girenRol = "Ogrenci";

        public FrmAnaMenu(string rol)
        {
            InitializeComponent();
            girenRol = rol;
        }

        public FrmAnaMenu()
        {
            InitializeComponent();
        }

        private void FrmAnaMenu_Load(object sender, EventArgs e)
        {
            if (girenRol == "Ogrenci")
            {
                buttonOgrenciYon.Visible = false;
                buttonLogKay.Visible = false;
                buttonKullaniciYon.Visible = false;
                buttonİstatistik.Visible = false;
            }
        }

        private void buttonKitapYon_Click(object sender, EventArgs e) 
        {
            this.Hide(); 
            FrmKitapYonetimi frm = new FrmKitapYonetimi(girenRol); 
            frm.ShowDialog();
            this.Show();
        }
        
        private void buttonOgrenciYon_Click(object sender, EventArgs e)
        {                                                                         
            this.Hide();                                                          
            FrmOgrenciYonetimi frm = new FrmOgrenciYonetimi(); 
            frm.ShowDialog();
            this.Show();    
        }

        private void buttonOduncİade_Click(object sender, EventArgs e) 
        {
            this.Hide();   
            FrmOduncIade frm = new FrmOduncIade();                                 
            frm.ShowDialog();
            this.Show();
        }

        private void buttonİstatistik_Click(object sender, EventArgs e) 
        {
            this.Hide(); 
            FrmIstatistikler frm = new FrmIstatistikler(); 
            frm.ShowDialog();
            this.Show();
        }

        private void buttonLogKay_Click(object sender, EventArgs e) 
        {
            this.Hide(); 
            FrmLogKayitlari frm = new FrmLogKayitlari(); 
            frm.ShowDialog();
            this.Show();
        }

        private void buttonKullaniciYon_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmKullaniciYonetimi frm = new FrmKullaniciYonetimi();
            frm.ShowDialog();
            this.Show();
        }
    }
}

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
    // kitap ve öğrenci yönetimi, ödünç iade, istatistikler, log kayıtlarına geçmemizi sağlayan ana formumuzdur.
    public partial class FrmAnaMenu : Form
    {
        public FrmAnaMenu()
        {
            InitializeComponent();
        }

        private void buttonKitapYon_Click(object sender, EventArgs e)            // kitap yonetimi butonuna tıklayınca 
        {
            this.Hide();                                                         // ana formu gilzer

            FrmKitapYonetimi frm = new FrmKitapYonetimi();                       // kitap yönetimi formunu açar
            frm.ShowDialog();

            this.Show();
        }
        
        private void buttonOgrenciYon_Click(object sender, EventArgs e)           // öğrenci yönetimi butonuna tıklayınca
        {                                                                          
            this.Hide();                                                          // ana formu gizler          

            FrmOgrenciYonetimi frm = new FrmOgrenciYonetimi();                    // öğrenci yönetimi formunu açar
            frm.ShowDialog();

            this.Show();    
        }

        private void buttonOduncİade_Click(object sender, EventArgs e)           // ödünç ve iade işlemleri butonuna tıklayınca
        {
            this.Hide();                                                         // ana formu gizler   

            FrmOduncIade frm = new FrmOduncIade();                                // odunç ve iade işlemleri formunu açar  
            frm.ShowDialog();

            this.Show();
        }

        private void buttonİstatistik_Click(object sender, EventArgs e)            // istatistikler butonuna tıklayınca
        {
            this.Hide();                                                            // ana formu gizler

            FrmIstatistikler frm = new FrmIstatistikler();                          // istatistikler formunu açar
            frm.ShowDialog();

            this.Show();
        }

        private void buttonLogKay_Click(object sender, EventArgs e)                // log kayıtları butonuna tıklayınca 
        {
            this.Hide();                                                            // ana formu gizler

            FrmLogKayitlari frm = new FrmLogKayitlari();                            // log kayıtları formunu açar
            frm.ShowDialog();

            this.Show();
        }
    }
}

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
    public partial class FrmOduncIade : Form
    {
        public FrmOduncIade()
        {
            InitializeComponent();
        }

        private void buttonGeriOdunc_Click(object sender, EventArgs e)         // butona tıklayınca önceki sayfaya döner
        {
            this.Close();
        }

        private void btnOduncVer_Click(object sender, EventArgs e)             // ödünç verme butonuna tıklayınca
        {
            FrmOduncVer frm = new FrmOduncVer();                                // ödünç verme formuna geçer
            frm.ShowDialog();

        }

        private void btnIadeAl_Click(object sender, EventArgs e)                // iade alma butonuna tıklayınca 
        {
            FrmIadeAl frm = new FrmIadeAl();                                     // iade alma formuna geçer
            frm.ShowDialog();
        }
    }
}

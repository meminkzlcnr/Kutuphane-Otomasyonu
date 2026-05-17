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

        private void buttonGeriOdunc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOduncVer_Click(object sender, EventArgs e)
        {
            FrmOduncVer frm = new FrmOduncVer();
            frm.ShowDialog();
        }

        private void btnIadeAl_Click(object sender, EventArgs e)
        {
            FrmIadeAl frm = new FrmIadeAl();
            frm.ShowDialog();
        }

        // ── YENİ: Gecikmiş İadeler butonu ──
        private void btnGecikmisList_Click(object sender, EventArgs e)
        {
            FrmGecikmisList frm = new FrmGecikmisList();
            frm.ShowDialog();
        }
    }
}

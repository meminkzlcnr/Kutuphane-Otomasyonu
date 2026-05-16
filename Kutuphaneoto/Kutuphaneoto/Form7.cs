using Kutuphaneoto.Models;
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
    public partial class FrmLogKayitlari : Form
    {
        public FrmLogKayitlari()
        {
            InitializeComponent();
        }

        private void buttonGeriLog_Click(object sender, EventArgs e)             // geri butonuyla önceki sayfaya döner
        {
            this.Close();
        }

        private void FrmLogKayitlari_Load(object sender, EventArgs e)
        {
            LoglariYukle();                                                      // logları yukle fonksiyonunu çağırır

        }
        void LoglariYukle()
        {
            listBoxLoglar.Items.Clear();

            if (!File.Exists("loglar.txt"))
                return;

            List<string> loglar = new List<string>();

            using (StreamReader sr = new StreamReader("loglar.txt"))
            {
                while (!sr.EndOfStream)
                {
                    loglar.Add(sr.ReadLine());
                }
            }

            // son log en üstte alıyoruz
            for (int i = loglar.Count - 1; i >= 0; i--)
            {
                listBoxLoglar.Items.Add(loglar[i]);
            }
        }

        private void FrmLogKayitlari_Activated(object sender, EventArgs e)
        {
            LoglariYukle();
        }
    }
}

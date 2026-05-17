using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Kutuphaneoto.Models;
using Kutuphaneoto.DataStructures;

namespace Kutuphaneoto
{
    // Gecikmiş iade listesini gösteren formdur
    public partial class FrmGecikmisList : Form
    {
        OgrenciLinkedList ogrenciler = new OgrenciLinkedList();
        KitapLinkedList   kitaplar   = new KitapLinkedList();

        public FrmGecikmisList()
        {
            InitializeComponent();
        }

        private void FrmGecikmisList_Load(object sender, EventArgs e)
        {
            OgrencileriYukle();
            KitaplariYukle();
            GecikmisTumuYukle();
        }

        void GecikmisTumuYukle()
        {
            listViewGecikmiş.Items.Clear();
            lblToplamSayac.Text = "Gecikmiş İade: 0";

            if (!File.Exists("oduncler.txt")) return;

            int sayac = 0;

            foreach (string satir in File.ReadAllLines("oduncler.txt"))
            {
                string[] p = satir.Split('|');
                if (p.Length < 4) continue;

                string ogrNo   = p[0];
                string isbn    = p[1];
                DateTime alis, sonIade;

                if (!DateTime.TryParse(p[2], out alis))    continue;
                if (!DateTime.TryParse(p[3], out sonIade)) continue;

                // Bugün son iade tarihini geçmiş mi?
                if (DateTime.Now.Date <= sonIade.Date) continue;

                int gecikmeGun = (int)(DateTime.Now.Date - sonIade.Date).TotalDays;

                // Öğrenci ve kitap bilgilerini bul
                Ogrenci ogr   = ogrenciler.TumunuGetir().FirstOrDefault(o => o.OgrenciNo == ogrNo);
                Kitap   kitap = kitaplar.TumunuGetir().FirstOrDefault(k => k.ISBN == isbn);

                string ogrAdi   = ogr   != null ? ogr.AdSoyad   : ogrNo;
                string kitapAdi = kitap != null ? kitap.KitapAdi : isbn;

                ListViewItem item = new ListViewItem(ogrNo);
                item.SubItems.Add(ogrAdi);
                item.SubItems.Add(kitapAdi);
                item.SubItems.Add(alis.ToString("dd.MM.yyyy"));
                item.SubItems.Add(sonIade.ToString("dd.MM.yyyy"));
                item.SubItems.Add($"{gecikmeGun} gün");

                // 7 günden fazla gecikmiş → koyu kırmızı
                item.BackColor = gecikmeGun >= 7
                    ? System.Drawing.Color.LightCoral
                    : System.Drawing.Color.LightYellow;

                listViewGecikmiş.Items.Add(item);
                sayac++;
            }

            lblToplamSayac.Text = $"Gecikmiş İade: {sayac} kitap";
        }

        void OgrencileriYukle()
        {
            if (!File.Exists("ogrenciler.txt")) return;

            foreach (string satir in File.ReadAllLines("ogrenciler.txt"))
            {
                string[] p = satir.Split('|');
                if (p.Length == 6)
                    ogrenciler.Ekle(new Ogrenci(p[0], p[1], p[2], p[3], p[4], DateTime.Parse(p[5])));
            }
        }

        void KitaplariYukle()
        {
            if (!File.Exists("kitaplar.txt")) return;

            foreach (string satir in File.ReadAllLines("kitaplar.txt"))
            {
                string[] p = satir.Split('|');
                if (p.Length == 4)
                    kitaplar.Ekle(new Kitap(p[0], p[1], p[2], p[3]));
            }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            ogrenciler = new OgrenciLinkedList();
            kitaplar   = new KitapLinkedList();
            OgrencileriYukle();
            KitaplariYukle();
            GecikmisTumuYukle();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

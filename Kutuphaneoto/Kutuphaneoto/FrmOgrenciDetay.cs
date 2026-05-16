using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kutuphaneoto.Models;
using Kutuphaneoto.DataStructures;


namespace Kutuphaneoto
{
    public partial class FrmOgrenciDetay : Form
    {
        OgrenciLinkedList ogrenciler;                                       // kendi yaptığımız öğrenci bağlı listesini kullanır
        public FrmOgrenciDetay(OgrenciLinkedList liste) 
        {
            InitializeComponent();
            ogrenciler = liste;
        }

        private void FrmOgrenciDetay_Load(object sender, EventArgs e)
        {
            ListeyiGuncelle();                                              // listeyi güncelle fonk çağırır
        }
        void ListeyiGuncelle()
        {
            listBoxOgrenciler.Items.Clear();                                // listbox tan öğrenci seçildikten sonra item i temizler

            foreach (var ogr in ogrenciler.TumunuGetir())
            {
                listBoxOgrenciler.Items.Add(ogr);
            }
        }

        private void txtAra_TextChanged(object sender, EventArgs e)     
        {
            string aranan = txtAra.Text.ToLower();                         // listboxtan öğrenci aranır
            listBoxOgrenciler.Items.Clear();

            foreach (var ogr in ogrenciler.TumunuGetir())
            {
                if (ogr.OgrenciNo.Contains(aranan) ||
                    ogr.AdSoyad.ToLower().Contains(aranan))            
                {
                    listBoxOgrenciler.Items.Add(ogr);
                }
            }
        }

        private void listBoxOgrenciler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxOgrenciler.SelectedItem == null)
                return;

            Ogrenci ogr = (Ogrenci)listBoxOgrenciler.SelectedItem;   // seçilen öğrencinin bilgileri textboxlara yazılır

            txtDetayOgrNo.Text = ogr.OgrenciNo;                               
            txtDetayAdSoyad.Text = ogr.AdSoyad;
            txtDetayBolum.Text = ogr.Bolum;
            txtDetayFakulte.Text = ogr.Fakulte;
            txtDetaySinif.Text = ogr.Sinif;
            txtDetayDogum.Text = ogr.DogumTarihi.ToShortDateString();
        }

        private void btnGeri_Click(object sender, EventArgs e)         // geri butonuna tıklayınca önceki form a döner
        {
            this.Close();
        }

    }

}


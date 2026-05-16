using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Kutuphaneoto.Models;
using Kutuphaneoto.DataStructures;


namespace Kutuphaneoto
{
    public partial class FrmIstatistikler : Form
    {
        OgrenciLinkedList ogrenciler = new OgrenciLinkedList();
        KitapLinkedList kitaplar = new KitapLinkedList();

        public FrmIstatistikler()
        {
            InitializeComponent();
        }

        private void buttonGeriİstatistik_Click(object sender, EventArgs e)            // geri butonuna tıklayınca önceki forma geçer
        {
            this.Close();
        }

        private void FrmIstatistikler_Load(object sender, EventArgs e)
        {
            OgrencileriYukle();                                                      // fonksiyonlar çağırılır.
            KitaplariYukle();

            EnCokAlinanKitaplariGetir();
            EnCokKitapAlanOgrencileriGetir();
        }
        void OgrencileriYukle()
        {
            if (!File.Exists("ogrenciler.txt"))                                      // "ogrenciler.txt" dosyası var mı diye kontrol eder. yoksa bir şey yapmaz
                return;

            foreach (string satir in File.ReadAllLines("ogrenciler.txt"))            // dosyayı okur. öğrencileri yükler
            {
                string[] p = satir.Split('|');
                if (p.Length != 6) continue;

                Ogrenci ogr = new Ogrenci(
                    p[0], p[1], p[2], p[3], p[4], DateTime.Parse(p[5])
                );

                ogrenciler.Ekle(ogr);
            }
        }

        void KitaplariYukle()                                           
        {
            if (!File.Exists("kitaplar.txt"))                                          // kitplar.txt dosyası var mı diye bakar yoksa işlem yapmaz
                return;

            foreach (string satir in File.ReadAllLines("kitaplar.txt"))                  // dosyayı okur. kitapları yükler
            {
                string[] p = satir.Split('|');
                if (p.Length != 4) continue;

                Kitap kitap = new Kitap(p[0], p[1], p[2], p[3]);
                kitaplar.Ekle(kitap);
            }
        }
        void EnCokAlinanKitaplariGetir()
        {
            Dictionary<string, int> kitapSayac = new Dictionary<string, int>();         

            if (!File.Exists("odunc_gecmisi.txt"))                                      // odunc_gecmisi.txt var mı diye bakar yoksa işlem yapmaz
                return;

            foreach (string satir in File.ReadAllLines("odunc_gecmisi.txt"))            // dosyayı okur
            {
                string[] p = satir.Split('|');
                if (p.Length != 2) continue;                                            // en çok alınan kitapları buluruz

                string isbn = p[1];

                if (kitapSayac.ContainsKey(isbn))
                    kitapSayac[isbn]++;
                else
                    kitapSayac[isbn] = 1;
            }

            
            List<KeyValuePair<string, int>> liste = kitapSayac.ToList();

            // kendi yaptığımız buble sort algoritması:
            for (int i = 0; i < liste.Count - 1; i++)
            {
                for (int j = 0; j < liste.Count - i - 1; j++)
                {
                    if (liste[j].Value < liste[j + 1].Value)
                    {
                        var temp = liste[j];
                        liste[j] = liste[j + 1];
                        liste[j + 1] = temp;
                    }
                }
            }

            listBoxEnCokKitaplar.Items.Clear();                

            for (int i = 0; i < 5 && i < liste.Count; i++)
            {
                string isbn = liste[i].Key;

                foreach (var kitap in kitaplar.TumunuGetir())
                {
                    if (kitap.ISBN == isbn)
                    {
                        listBoxEnCokKitaplar.Items.Add(
                            $"{kitap.KitapAdi} | {kitap.Yazar}"
                        );
                        break;
                    }
                }
            }
        }
        
        void EnCokKitapAlanOgrencileriGetir()
        {
            Dictionary<string, int> ogrSayac = new Dictionary<string, int>();

            if (!File.Exists("odunc_gecmisi.txt"))                                   // odunc_gecmisi.txt dosyası var mı diye bakar yoksa işlem yapmaz
                return;

            foreach (string satir in File.ReadAllLines("odunc_gecmisi.txt"))        // odunc_gecisi dosyasını okur 
            {
                string[] p = satir.Split('|');                                      // en cok kitap alan öğrenciyi buluruz
                if (p.Length != 2) continue;

                string ogrNo = p[0];

                if (ogrSayac.ContainsKey(ogrNo))
                    ogrSayac[ogrNo]++;
                else
                    ogrSayac[ogrNo] = 1;
            }

            List<KeyValuePair<string, int>> liste = ogrSayac.ToList();

            //kendi yaptığımız buble sort algoritması
            for (int i = 0; i < liste.Count - 1; i++)
            {
                for (int j = 0; j < liste.Count - i - 1; j++)
                {
                    if (liste[j].Value < liste[j + 1].Value)
                    {
                        var temp = liste[j];
                        liste[j] = liste[j + 1];
                        liste[j + 1] = temp;
                    }
                }
            }

            listBoxEnCokOgrenciler.Items.Clear();

            for (int i = 0; i < 5 && i < liste.Count; i++)
            {
                string ogrNo = liste[i].Key;

                foreach (var ogr in ogrenciler.TumunuGetir())
                {
                    if (ogr.OgrenciNo == ogrNo)
                    {
                        listBoxEnCokOgrenciler.Items.Add(
                            $"{ogr.OgrenciNo} - {ogr.AdSoyad}"
                        );
                        break;
                    }
                }
            }
        }





    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphaneoto.Models
{
    // öğrencilerin bilgileri ve üzerindeki kitapları tutuyoruz
    public class Ogrenci
    {
        public string OgrenciNo { get; set; }                                             
        public string AdSoyad { get; set; }                                                
        public string Bolum { get; set; }                                                   
        public string Fakulte { get; set; }                                                  
        public string Sinif { get; set; }
        public DateTime DogumTarihi { get; set; }                                          // dogum tarihini burda DateTime olarak alıyoruz
        public List<Kitap> UzerindekiKitaplar { get; set; } = new List<Kitap>();          


        public Ogrenci(string ogrNo, string adSoyad, string bolum,                      // öğrenci eklenirken bilgileri atamak için kullanılır
                       string fakulte, string sinif, DateTime dogumTarihi)
        {
            OgrenciNo = ogrNo;
            AdSoyad = adSoyad;
            Bolum = bolum;
            Fakulte = fakulte;
            Sinif = sinif;
            DogumTarihi = dogumTarihi;
        }

        public override string ToString()
        {
            // ListBoxlarda öğrencinin nasıl görüneceği 
            return $"{OgrenciNo} - {AdSoyad}";
        }

        // Detaylı bilgi formunda öğrencinin tüm bilgilerini döndürür
        public string DetayliBilgi()
        {
            return
                $"Öğrenci No: {OgrenciNo}\r\n" +
                $"Ad Soyad: {AdSoyad}\r\n" +
                $"Bölüm: {Bolum}\r\n" +
                $"Fakülte: {Fakulte}\r\n" +
                $"Sınıf: {Sinif}\r\n" +
                $"Doğum Tarihi: {DogumTarihi}";
        }
        // öğrencinin kitap alıp alamayacağına bakılır. max 3 kitap alınır.
        public bool KitapAlabilirMi()
        {
            return UzerindekiKitaplar.Count < 3;
        }

    }
}

namespace Kutuphaneoto.Models
{
    public class Kitap
    {
        public string KitapAdi { get; set; }        // kitabın adı
        public string Yazar { get; set; }           // kitabın yazarı 
        public string ISBN { get; set; }            // kitabın İSBN numarası
        public string Kategori { get; set; }        // kitabın kategorisi
        public bool OduncAlinmis { get; set; } = false;        // kitap ödünç mü değil mi bool ile kontorl ediyoruz
        public Queue<Ogrenci> BeklemeSirasi { get; set; } = new Queue<Ogrenci>();      //kitap ödünç alınmış olduğunda kitabı bekleyenlerin sırası 
        public Queue<string> BekleyenOgrenciNolari { get; set; } = new Queue<string>();      // bekleyenlerin öğrenci numaralarını kuyrukla tutuyoruz


        // kitap oluşturulduğunda kitabın bilgileri atanır
        public Kitap(string kitapAdi, string yazar, string isbn, string kategori)
        {
            KitapAdi = kitapAdi;
            Yazar = yazar;
            ISBN = isbn;
            Kategori = kategori;
        }
        
        // ListBoxlarda kitabın;  kitap adı|yazar   olarak görünmesi sağlanır
        public override string ToString()
        {
            return $"{KitapAdi} | {Yazar}";
        }
    }
}

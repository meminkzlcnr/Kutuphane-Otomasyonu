namespace Kutuphaneoto.Models
{
    public class Kullanici
    {
        public string KullaniciAdi { get; set; }   // giriş için kullanıcı adı
        public string Sifre { get; set; }           // giriş şifresi
        public string AdSoyad { get; set; }         // kullanıcının gerçek adı
        public string Rol { get; set; }             // "Yönetici" veya "Personel"

        public Kullanici(string kullaniciAdi, string sifre, string adSoyad, string rol)
        {
            KullaniciAdi = kullaniciAdi;
            Sifre = sifre;
            AdSoyad = adSoyad;
            Rol = rol;
        }

        // ListBox'larda görünüm: kullaniciAdi | AdSoyad | Rol
        public override string ToString()
        {
            return $"{KullaniciAdi} | {AdSoyad} | {Rol}";
        }

        // Detay panelinde tüm bilgileri gösterir
        public string DetayliBilgi()
        {
            return
                $"Kullanıcı Adı: {KullaniciAdi}\r\n" +
                $"Ad Soyad: {AdSoyad}\r\n" +
                $"Rol: {Rol}";
        }
    }
}

namespace Kutuphaneoto.Models
{
    public class Kitap
    {
        public string KitapAdi { get; set; }
        public string Yazar { get; set; }
        public string ISBN { get; set; }
        public string Kategori { get; set; }
        public bool OduncAlinmis { get; set; } = false;
        public Queue<Ogrenci> BeklemeSirasi { get; set; } = new Queue<Ogrenci>();
        public Queue<string> BekleyenOgrenciNolari { get; set; } = new Queue<string>();

        // ── YENİ: Tarih alanları ─────────────────────────────────────
        public DateTime? AlisTarihi { get; set; }       // kitabın ödünç alınış tarihi
        public DateTime? SonIadeTarihi { get; set; }    // son iade tarihi (alış + 15 gün)

        public Kitap(string kitapAdi, string yazar, string isbn, string kategori)
        {
            KitapAdi = kitapAdi;
            Yazar = yazar;
            ISBN = isbn;
            Kategori = kategori;
        }

        public override string ToString()
        {
            return $"{KitapAdi} | {Yazar}";
        }

        // İade formunda gecikme durumunu döndürür
        public string GecikmeMetni()
        {
            if (!SonIadeTarihi.HasValue) return "";

            int kalanGun = (int)(SonIadeTarihi.Value - DateTime.Now).TotalDays;

            if (kalanGun > 0)
                return $"Son İade: {SonIadeTarihi:dd.MM.yyyy}  ({kalanGun} gün kaldı)";
            else if (kalanGun == 0)
                return $"Son İade: {SonIadeTarihi:dd.MM.yyyy}  (Bugün son gün!)";
            else
                return $"Son İade: {SonIadeTarihi:dd.MM.yyyy}  ⚠ {Math.Abs(kalanGun)} GÜN GECİKTİ!";
        }
    }
}

using Kutuphaneoto.Models;

namespace Kutuphaneoto.DataStructures
{
    // Kullanıcı bağlı listesi için düğüm yapısı
    public class KullaniciNode
    {
        public Kullanici Data;        // düğümdeki kullanıcı verisi
        public KullaniciNode Next;    // sonraki düğüme işaretçi

        public KullaniciNode(Kullanici kullanici)
        {
            Data = kullanici;
            Next = null;
        }
    }
}

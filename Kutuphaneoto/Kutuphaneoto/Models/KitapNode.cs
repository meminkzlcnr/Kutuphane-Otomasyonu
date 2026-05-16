using Kutuphaneoto.Models;

namespace Kutuphaneoto.DataStructures
{
    //bağlı listemiz için yaptığımız düğümdür 
    public class KitapNode
    {
        public Kitap Data;                    //kitabın verisi  
        public KitapNode Next;                // sonraki düğümü gösteren pointer    

        public KitapNode(Kitap kitap)        // yeni düğüm oluşturduğumuzda kitap bilgisini atar 
        {
            Data = kitap;
            Next = null;
        }
    }
}

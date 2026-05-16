using System.Collections.Generic;
using Kutuphaneoto.Models;

namespace Kutuphaneoto.DataStructures
{
    // Kitaplar için kendi yazdığımız bağlı listemiz
    public class KitapLinkedList
    { 
        private KitapNode head;                              // listenin başını tutar

        // Kitap ekleme
        public void Ekle(Kitap kitap)                        // yeni kitabı listenin sonuna ekler
        {
            KitapNode yeni = new KitapNode(kitap);      

            if (head == null)
            {
                head = yeni;
            }
            else
            {
                KitapNode temp = head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = yeni;
            }
        }

        // ISBN ye göre kitap silme
        public bool Sil(string isbn)
        {
            if (head == null)
                return false;

            if (head.Data.ISBN == isbn)
            {
                head = head.Next;
                return true;
            }

            KitapNode temp = head;
            while (temp.Next != null)
            {
                if (temp.Next.Data.ISBN == isbn)
                {
                    temp.Next = temp.Next.Next;
                    return true;
                }
                temp = temp.Next;
            }
            return false;
        }

        // Tüm kitapları liste olarak döndürür
        public List<Kitap> TumunuGetir()
        {
            List<Kitap> liste = new List<Kitap>();
            KitapNode temp = head;

            while (temp != null)
            {
                liste.Add(temp.Data);
                temp = temp.Next;
            }

            return liste;
        }
    }
}


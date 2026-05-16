using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Kutuphaneoto.Models;

namespace Kutuphaneoto.DataStructures
{
    // öğrencileri tutmak için kendi bağlı listemiz
    public class OgrenciLinkedList
    {
        private OgrenciNode head;                         //ilk düğümü tutar

        public void Ekle(Ogrenci ogr)                      // bağlı listenin sonuna yeni öğrenci ekler
        {
            OgrenciNode yeni = new OgrenciNode(ogr);       // yeni düğüm oluşturur
            if (head == null) head = yeni;                 // liste boşsa yeni düğüm head olur
            else
            {
                var t = head;
                while (t.Next != null) t = t.Next;        // boş değilse son düğümün next i yeni düğüm olur
                t.Next = yeni;
            }
        }
        // öğrenci no ya göre öğrenci siler
        public bool Sil(string ogrNo)                  
        {
            if (head == null) return false;
            if (head.Data.OgrenciNo == ogrNo)
            {
                head = head.Next; 
                return true;
            }
            var t = head;
            while (t.Next != null)
            {
                if (t.Next.Data.OgrenciNo == ogrNo)
                {
                    t.Next = t.Next.Next; return true;
                }
                t = t.Next;
            }
            return false;
        }
        // bağlı listedeki tüm öğrencileri döndürür , listboxlarda kullanıyoruz
        public List<Ogrenci> TumunuGetir()
        {
            var list = new List<Ogrenci>();
            var t = head;
            while (t != null)
            {
                list.Add(t.Data);
                t = t.Next;
            }
            return list;
        }
    }
}


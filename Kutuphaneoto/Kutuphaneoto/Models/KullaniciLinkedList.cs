using System.Collections.Generic;
using Kutuphaneoto.Models;

namespace Kutuphaneoto.DataStructures
{
    // Kullanıcıları tutmak için kendi yazdığımız bağlı liste
    public class KullaniciLinkedList
    {
        private KullaniciNode head;   // listenin ilk düğümü

        // Listeye yeni kullanıcı ekler (sona ekler)
        public void Ekle(Kullanici kullanici)
        {
            KullaniciNode yeni = new KullaniciNode(kullanici);

            if (head == null)
            {
                head = yeni;
            }
            else
            {
                KullaniciNode temp = head;
                while (temp.Next != null)
                    temp = temp.Next;
                temp.Next = yeni;
            }
        }

        // Kullanıcı adına göre siler, başarılıysa true döner
        public bool Sil(string kullaniciAdi)
        {
            if (head == null) return false;

            if (head.Data.KullaniciAdi == kullaniciAdi)
            {
                head = head.Next;
                return true;
            }

            KullaniciNode temp = head;
            while (temp.Next != null)
            {
                if (temp.Next.Data.KullaniciAdi == kullaniciAdi)
                {
                    temp.Next = temp.Next.Next;
                    return true;
                }
                temp = temp.Next;
            }
            return false;
        }

        // Kullanıcı adına göre şifre, ad soyad ve rolü günceller
        public bool Guncelle(string kullaniciAdi, string yeniSifre, string yeniAdSoyad, string yeniRol)
        {
            KullaniciNode temp = head;
            while (temp != null)
            {
                if (temp.Data.KullaniciAdi == kullaniciAdi)
                {
                    temp.Data.Sifre = yeniSifre;
                    temp.Data.AdSoyad = yeniAdSoyad;
                    temp.Data.Rol = yeniRol;
                    return true;
                }
                temp = temp.Next;
            }
            return false;
        }

        // Kullanıcı adına göre arar, bulamazsa null döner
        public Kullanici Bul(string kullaniciAdi)
        {
            KullaniciNode temp = head;
            while (temp != null)
            {
                if (temp.Data.KullaniciAdi == kullaniciAdi)
                    return temp.Data;
                temp = temp.Next;
            }
            return null;
        }

        // Tüm kullanıcıları liste olarak döndürür
        public List<Kullanici> TumunuGetir()
        {
            List<Kullanici> liste = new List<Kullanici>();
            KullaniciNode temp = head;
            while (temp != null)
            {
                liste.Add(temp.Data);
                temp = temp.Next;
            }
            return liste;
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;

namespace Kutuphaneoto.Models
{
    // log kayıtları için oluşturduğumuz stack veri yapısı
    public static class LogStack
    {
        static Stack<string> loglar = new Stack<string>();                        // log mesajını tutar

        //yeni log ekler. log "loglar.txt" dosyasına da kaydedilir
        public static void LogEkle(string mesaj)
        {
            string log = $"{DateTime.Now:dd.MM.yyyy HH:mm:ss} - {mesaj}";         // log a saat ve tarih bilgisi eklenir
            loglar.Push(log);                                                     // stack e push edilir

            using (StreamWriter sw = new StreamWriter("loglar.txt", true))        // loglar "loglar.txt" dosyasına kaydedilir
            {
                sw.WriteLine(log);
            }
        }

        public static List<string> TumLoglariGetir()                              // stack deki logları liste olarak döndürür
        {
            return new List<string>(loglar);
        }

        public static void LoglariYukle()                                         // program çalıştırıldığında önceden kaydedilen logları yükler
        {
            if (!File.Exists("loglar.txt"))                                       // log dosyası yoksa işlem yapmaz
                return;

            string[] satirlar = File.ReadAllLines("loglar.txt");                  

            for (int i = satirlar.Length - 1; i >= 0; i--)                        // dosyadaki loglar tersten stack e eklenir 
            {                                                                     // çünkü en son logun en başta görünmesini istiyoruz
                loglar.Push(satirlar[i]);
            }
        }
    }
}


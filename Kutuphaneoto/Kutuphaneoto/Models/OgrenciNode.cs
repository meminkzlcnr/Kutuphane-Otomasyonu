using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kutuphaneoto.Models;

namespace Kutuphaneoto.DataStructures
{
    // öğrenci bağlı listesi için kullandığımız node yapısıdır
    public class OgrenciNode
    {
        public Ogrenci Data;                   // düğümdeki veri 
        public OgrenciNode Next;               

        public OgrenciNode(Ogrenci ogr)        // yeni düğüme öğrenci bilgisini atar
        {
            Data = ogr;
            Next = null;
        }
    }
}


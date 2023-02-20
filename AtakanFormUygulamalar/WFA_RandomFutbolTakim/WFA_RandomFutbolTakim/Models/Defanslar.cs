using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_RandomFutbolTakim.Models
{
    public class Defanslar : Futbolcu, ISavunma
    {
        public int Savunma { get; set; }
        public int Pres { get; set; }
        public int Mücadele { get; set; }
        static int index1 = 0;
        static int index2 = 0;
        public override string AdVer()
        {

            Random rnd = new Random();
            while (index1 == index2)
            {
                index1 = rnd.Next(0, 5);
            }
            index2 = index1;

            // List<int> randomSayilar = new List<int>() { sayi1, sayi2, sayi3, sayi4, sayi5 };

            return Futbolcu.defansAdi[index1];

        }
        public Defanslar()
        {
            Random rnd = new Random();
            Savunma = rnd.Next(70, 100);
            Pres = rnd.Next(70, 100);
            Mücadele = rnd.Next(70, 100);
        }
    }
}

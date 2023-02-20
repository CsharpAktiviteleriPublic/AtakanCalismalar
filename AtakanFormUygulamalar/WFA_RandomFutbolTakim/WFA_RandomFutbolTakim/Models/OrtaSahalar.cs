using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_RandomFutbolTakim.Models
{
    public class OrtaSahalar : Futbolcu, IPas, IDuranTop
    {
        Random rnd = new Random();
        public int Penalti { get; set; }
        public int Frikik { get; set; }
        public int Korner { get; set; }
        public int UzunPas { get; set; }
        public int KısaPas { get; set; }
        public int AraPas { get; set; }
        public static int i = 0;
        public override string AdVer()
        {
            Random rnd = new Random();
            int sayi1 = rnd.Next(0, 10);
            int sayi2 = rnd.Next(0, 10);
            int sayi3 = rnd.Next(0, 10);
            int sayi4 = rnd.Next(0, 10);
            int sayi5 = rnd.Next(0, 10);
            List<int> randomSayilar = new List<int>() { sayi1, sayi2, sayi3, sayi4, sayi5 };

            return Futbolcu.ortaSahaAdi[randomSayilar[i++]];

      
        }
        public OrtaSahalar()
        {
            Penalti = rnd.Next(70, 100);
            Frikik = rnd.Next(70, 100);
            Korner = rnd.Next(70, 100);
            UzunPas = rnd.Next(70, 100);
            KısaPas = rnd.Next(70, 100);
            AraPas = rnd.Next(70, 100);
        }
    }
}

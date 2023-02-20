using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_RandomFutbolTakim.Models
{
    
    public class Kaleciler : Futbolcu, IRefleks
    {

        public int Refleks { get; set ; }
        public int Kalecilik { get; set ; }
        public int Degaj { get ; set; }
        public int Esneklik { get ; set; }
        public int Atlama { get ; set ; }
        public int OyunBaslatma { get ; set ; }
        public static int i = 0;
        public override string AdVer()
        {
            Random rnd = new Random();
            int sayi1 = rnd.Next(0, 10);
            int sayi2 = rnd.Next(0, 10);
            int sayi3 = rnd.Next(0, 10);
            int sayi4 = rnd.Next(0, 10);
            int sayi5 = rnd.Next(0, 10);            
            List<int> randomSayilar = new List<int>() {sayi1,sayi2,sayi3,sayi4,sayi5 };
            
            return Futbolcu.kaleciAdi[randomSayilar[i++]];
        }
        public Kaleciler()
        {
            Random rnd = new Random();
            Refleks = rnd.Next(70, 100);
            Kalecilik = rnd.Next(70, 100);
            Degaj = rnd.Next(70, 100);
            Esneklik = rnd.Next(70, 100);
            Atlama = rnd.Next(70, 100);
            OyunBaslatma = rnd.Next(70, 100);
        }
    }
}

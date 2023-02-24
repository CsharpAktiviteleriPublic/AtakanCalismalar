using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Hamburger_Atakan
{
    internal class Ekstra
    {
        public static Dictionary<string, decimal> malzemeler = new Dictionary<string, decimal>(); // ekstra malzemeler fiyat ve 
        public static string SecilenMalzemeler = "";
        public static decimal MalzemeUcreti = 0;
        static Ekstra()
        {
            malzemeler.Add("Ketcap", 1);
            malzemeler.Add("Mayonez", 1);
            malzemeler.Add("Hardal", 2);
            malzemeler.Add("BBQ", 2);
            malzemeler.Add("Ranch", 2);
            malzemeler.Add("Buffalo", 2);
        }
    }
}

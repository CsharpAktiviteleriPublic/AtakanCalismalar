using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Hamburger_Atakan
{
    internal class Menuler
    {       
        

        public static Dictionary<string, decimal> menuler = new Dictionary<string, decimal>();
        
        static Menuler() 
        {
            menuler.Add("Big King Menü",87m);
            menuler.Add("Double King Chicken Menü",77m);
            menuler.Add("Steakhouse Menü",104m);
            menuler.Add("Whooper Menü",89m);
            menuler.Add("Whooper Jr. Menü",66m);
            menuler.Add("Chicken Royal Menü",70m);            
        }
       

    }
}

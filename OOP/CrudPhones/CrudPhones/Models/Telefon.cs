using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace CrudPhones.Models
{
    internal class Telefon
    {       
        public static List<Telefon> telefonlarList = new List<Telefon>();
        public static int indexNo { get; set; }

        public enum Durum
        {
            Satista,
            Kullanimda,
            Hurda
        }

        public string Marka { get; set; }
        public string Model { get; set; }
        public int Yil { get; set; }
        public string Durumu { get; set; }        
        public SoundPlayer Sound { get; set; }
        public Image Image { get; set; }

        public override string ToString()
        {
            return $"{Marka} | {Model}| {Yil} | {Durumu}";
        }


    }
}

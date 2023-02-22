using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Hamburger_Atakan
{
    internal class Fonksiyonlar
    {
        public static void MenuEkle()
        {

        }
        public static void Ekle(Dictionary<string, decimal> dic, string malzemeAdi, decimal fiyat)
        {
            if (malzemeAdi == string.Empty || dic.Keys.Contains(malzemeAdi)) // Malzeme adi empty değilse ve fiyat pozitif ise,
            {
                System.Windows.Forms.MessageBox.Show("Menüde mevcut ya da boş bir Menü adı girdiniz.");
            }
            else
            {
                dic.Add(malzemeAdi, fiyat);
                System.Windows.Forms.MessageBox.Show("Menüye Eklendi.");
            }
        }

       
        public static string MenuAdiToTittleCase(string menuAdi)
        {
            menuAdi = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(menuAdi).Trim();
            return menuAdi;
        }

        internal static void YuklemeleriYap()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Hamburger_Atakan
{
    internal class Fonksiyonlar
    {
        private static decimal _siparisTutari; 
      
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
        public static string MenuAdiToTitleCase(string menuAdi)
        {
            menuAdi = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(menuAdi).Trim();
            return menuAdi;
        }
        public static decimal ToplamSiparisTutariAl(decimal menu, decimal boyut, decimal ekstra, int adet)
        {
            _siparisTutari = (menu + boyut + ekstra) * adet;
            return _siparisTutari;
        }        
        public static decimal EkstraMalzemelerFiyatiAl(FlowLayoutPanel flp)
        {
            foreach (CheckBox item in flp.Controls)
            {
                if (item.Checked)
                {
                    Ekstra.MalzemeUcreti += Ekstra.malzemeler[item.Text];
                }
            }
            return Ekstra.MalzemeUcreti;
        }
        public static decimal BoyutFiyatiAl(GroupBox grp)
        {
            foreach (RadioButton item in grp.Controls)
            {
                if (item.Checked)
                {
                    Siparis.BoyutUcreti = Convert.ToDecimal(Enum.Parse(typeof(EnumClass.Boyut), item.Text.ToLower()));
                    break;
                }
            }
            return Siparis.BoyutUcreti;
        }
        public static decimal MenuFiyatiAl(ComboBox comboBox)
        {
            Menuler.Ucret = Menuler.menuler[comboBox.SelectedItem.ToString()];
            return Menuler.Ucret;
        }        
        public static int AdetFiyatAl(NumericUpDown num)
        {
            Siparis.Adet = (int)num.Value;
            return Siparis.Adet;
        }
        public static string LabelFiyatAl(Label lbl)
        {
            lbl.Text = ToplamSiparisTutariAl(Menuler.Ucret, Siparis.BoyutUcreti, Ekstra.MalzemeUcreti, Siparis.Adet).ToString();

            return lbl.Text;
        }
      
    }
}

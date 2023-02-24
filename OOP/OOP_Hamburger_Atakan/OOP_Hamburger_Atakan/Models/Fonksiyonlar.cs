using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;

namespace OOP_Hamburger_Atakan
{
    internal class Fonksiyonlar
    {
        private static decimal _siparisTutari;

        public static void Ekle(Dictionary<string, decimal> dic, string malzemeAdi, decimal fiyat)
        {
            if (malzemeAdi == string.Empty || dic.Keys.Contains(malzemeAdi)) // Malzeme adi empty değilse ve fiyat pozitif ise,
            {
                System.Windows.Forms.MessageBox.Show("Lütfen menüde olmayan bir ürün ekleyiniz. Ürün ismi boş olamaz.!");
            }
            else
            {
                malzemeAdi = MenuAdiToTitleCase(malzemeAdi);
                dic.Add(malzemeAdi, fiyat);
                System.Windows.Forms.MessageBox.Show("Ekleme Başarılı.!");
            }
        }

        public static void MenuleriYukle(ComboBox cb, Dictionary<string, decimal> menuler)
        {
            cb.Items.Clear();
            foreach (var menuAdi in menuler)
            {
                cb.Items.Add(menuAdi.Key);
            }
        }

        public static void SoslariYukle(FlowLayoutPanel flp, Dictionary<string, decimal> dic)
        {

            flp.Controls.Clear();
            foreach (var sosAdi in Ekstra.malzemeler)
            {
                CheckBox chc = new CheckBox();
                chc.Name = "chc" + sosAdi.Key.Replace(" ", "");
                chc.Text = sosAdi.Key;
                flp.Controls.Add(chc);
                chc.CheckedChanged += Chc_CheckedChanged;
            }          
            
        }

        public static void Chc_CheckedChanged(object sender, EventArgs e)
        {
            MyMdiParent.siparisOlustur.SiparisTutariAl(sender, e);
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
            Ekstra.MalzemeUcreti = 0;
            foreach (CheckBox item in flp.Controls)
            {
                foreach (var dicEleman in Ekstra.malzemeler)
                {
                    if (item.Checked && (item.Text == dicEleman.Key))
                    {
                        Ekstra.MalzemeUcreti += dicEleman.Value;
                    }
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

        /// <summary>
        /// Dictionary'e combobox'ın Key'ini gönderir, Value döner.
        /// </summary>
        /// <param name="comboBox"></param>
        /// <returns>Menüler Class'ından ücret döndürmektedir.</returns>
        public static decimal MenuFiyatiAl(ComboBox comboBox)
        {

            if (comboBox.SelectedItem != null)
            {
                Menuler.Ucret = Menuler.menuler[comboBox.SelectedItem.ToString()];
            }

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

        public static void ListBoxEkle(ListBox lst,Dictionary<string,decimal> dic)
        {
          
        }
        public static void SecilenMalzemeAdlari(FlowLayoutPanel flp)
        {
            Ekstra.SecilenMalzemeler = "";
            foreach (CheckBox secilenMalzemeler in flp.Controls)
            {
                if (secilenMalzemeler.Checked)
                {
                    Ekstra.SecilenMalzemeler += secilenMalzemeler.Text + " ";
                }
            }
        }
        public static void SiparisListeEkle(ComboBox cbMenuler, ListBox lstSiparisler)
        {
            Siparis.listeMetinFormat = $"{cbMenuler.SelectedItem} x {Siparis.Adet} Adet x {Siparis.boyutAdi} Boy x ({Ekstra.SecilenMalzemeler})";
            lstSiparisler.Items.Add(Siparis.listeMetinFormat);
        }

        public static void SecilenBoyutAdi(GroupBox grpHamburgerBoyut)
        {
            foreach (RadioButton item in grpHamburgerBoyut.Controls)
            {
                if (item.Checked)
                {
                    Siparis.boyutAdi = item.Text;
                }
            }
        }
        public static void LabelFiyatYazdir(Label lblToplamTutar)
        {
            lblToplamTutar.Text = Fonksiyonlar.LabelFiyatAl(lblToplamTutar);
        }
    }
}

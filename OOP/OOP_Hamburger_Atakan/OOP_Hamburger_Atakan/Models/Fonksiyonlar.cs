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
        /// <summary>
        /// (Menu Fiyatı + Boyut + Ekstra Malzemeler) toplamını Siparis adediyle çarpılmış halidir.
        /// </summary>
        public static decimal SiparisTutari;

        /// <summary>
        /// Gönderilen Dictionary Key = Malzeme Adı , Dictionary Value = Fiyat olacaktır..
        /// </summary>
        /// <param name="dic"></param>
        /// <param name="malzemeAdi"></param>
        /// <param name="fiyat"></param>
        public static void Ekle(Dictionary<string, decimal> dic, string malzemeAdi, decimal fiyat)
        {
            if (malzemeAdi == string.Empty || dic.Keys.Contains(malzemeAdi))
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

        /// <summary>
        /// Gönderilen Combobax itemlarına dictionary Key değerlerini ekler.
        /// </summary>
        /// <param name="cb"></param>
        /// <param name="menuler"></param>
        public static void MenuleriYukle(ComboBox cb, Dictionary<string, decimal> menuler)
        {
            cb.Items.Clear();
            foreach (var menuAdi in menuler)
            {
                cb.Items.Add(menuAdi.Key);
            }
        }

        /// <summary>
        /// Flowlayout temizler sonra dictionary'deki elemanları checkbox oluşturarak itemlarına ekler.
        /// </summary>
        /// <param name="flp"></param>
        /// <param name="dic"></param>
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

        /// <summary>
        /// Oluşturulan checkbox eventini,SiparisTutariAl Metoduna gönderir.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>     
        public static void Chc_CheckedChanged(object sender, EventArgs e)
        {
            MyMdiParent.siparisOlustur.SiparisTutariAl(sender, e);
        }

        /// <summary>
        /// Gönderilen String ifadeyi ToTitleCase ile düzenler ve Trimler.
        /// </summary>
        /// <param name="menuAdi"></param>
        /// <returns></returns>
        public static string MenuAdiToTitleCase(string menuAdi)
        {
            menuAdi = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(menuAdi).Trim();
            return menuAdi;
        }

        /// <summary>
        /// Menü fiyatı + Boyut Farkı + Ekstra Malzeme ücretini toplayıp Adet ile çarpar.
        /// </summary>
        /// <param name="menu"></param>
        /// <param name="boyut"></param>
        /// <param name="ekstra"></param>
        /// <param name="adet"></param>
        /// <returns>Kullanıcının seçtiği menülere göre fiyat hesaplayıp değer döndürmektedir.</returns>
        public static decimal ToplamSiparisTutariAl(decimal menu, decimal boyut, decimal ekstra, int adet)
        {
            SiparisTutari = (menu + boyut + ekstra) * adet;
            return SiparisTutari;
        }

        /// <summary>
        /// Gönderilen FlowLayoutPanel içerisindeki CheckBox'lardan seçili olanları kontrol eder. 
        /// </summary>
        /// <param name="flp"></param>
        /// <returns>Seçili checkbox'ların text'ini dictionary göndererek value'sunu Malzeme Ücretine ekler ve döndürür.</returns>
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

        /// <summary>
        /// GroupBox içindeki RadioButtonları kontrol eder. Seçili olanın değerini Enum Class'ından alır.
        /// </summary>
        /// <param name="grp"></param>
        /// <returns>Boyut farkını hesaplar.</returns>
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

        public static void ListBoxEkle(ListBox lst, Dictionary<string, decimal> dic)
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

        public static void MalzemeUcretleriDefaultAl()
        {
            Siparis.Adet = 0;
            Menuler.Ucret = 0;
            Siparis.BoyutUcreti = 0;
            Siparis.ToplamTutar = 0;
            Ekstra.MalzemeUcreti = 0;
        }

        public static void FormDuzenle(Form frm)
        {
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
        }

        public static void LabelFiyatYazdir(Label lblToplamTutar)
        {
            lblToplamTutar.Text = Fonksiyonlar.LabelFiyatAl(lblToplamTutar);
        }

        public static void LabelFiyatYazdir(Label lblCiro, Label lblEkstraMalGeliri, Label lblSiparisSayisi, Label lblUrunAdedi)
        {
            lblCiro.Text = Siparis.Ciro.ToString();
            lblSiparisSayisi.Text = Siparis.ToplamSiparisSayisi.ToString();
            lblUrunAdedi.Text = Siparis.ToplamAdet.ToString();
            lblEkstraMalGeliri.Text = Siparis.EkstraMalzemeGeliri.ToString();
        }




    }
}

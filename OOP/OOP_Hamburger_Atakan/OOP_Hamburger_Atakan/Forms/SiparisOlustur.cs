using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Hamburger_Atakan
{
    public partial class SiparisOlustur : Form
    {

        public SiparisOlustur()
        {
            InitializeComponent();
        }

       
        private void SiparisOlustur_Load(object sender, EventArgs e)
        {

            Fonksiyonlar.FormDuzenle(this);
            Fonksiyonlar.SoslariYukle(flpEkstraMalzemeler, Ekstra.malzemeler);
            Fonksiyonlar.MenuleriYukle(cbMenuler, Menuler.menuler);
        } //Form Düzenleme-Sos ve menülerin Yüklenmesi yapıldı..


        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            Fonksiyonlar.ToplamSiparisMesaji(lblToplamTutar);
        }        

        public void ListeEklemeBicimi()
        {
            Fonksiyonlar.SecilenBoyutAdi(grpHamburgerBoyut);
            Fonksiyonlar.SecilenMalzemeAdlari(flpEkstraMalzemeler);
            Siparis.ToplamSiparisSayisi++;
            Siparis.ToplamAdet += (int)numAdet.Value;
            Siparis.EkstraMalzemeGeliri += Fonksiyonlar.EkstraMalzemelerFiyatiAl(flpEkstraMalzemeler) * Fonksiyonlar.AdetFiyatAl(numAdet);
            Siparis.Ciro += Fonksiyonlar.ToplamSiparisTutariAl(Menuler.Ucret, Siparis.BoyutUcreti, Ekstra.MalzemeUcreti, Siparis.Adet);
            Fonksiyonlar.SiparisListeEkle(cbMenuler, lstSiparisler);
        }

        private void cbMenuler_Click(object sender, EventArgs e)
        {
            Fonksiyonlar.MenuleriYukle(cbMenuler, Menuler.menuler);
        }

        public void SiparisTutariAl(object sender, EventArgs e)
        {
            Fonksiyonlar.ButonEnableTrue(btnSiparisiTamamla);
            Siparis.Adet = Fonksiyonlar.AdetFiyatAl(numAdet);
            Menuler.Ucret = Fonksiyonlar.MenuFiyatiAl(cbMenuler);
            Siparis.BoyutUcreti = Fonksiyonlar.BoyutFiyatiAl(grpHamburgerBoyut);
            Siparis.ToplamTutar = Fonksiyonlar.ToplamSiparisTutariAl(Menuler.Ucret, Siparis.BoyutUcreti, Ekstra.MalzemeUcreti, Siparis.Adet);
            Ekstra.MalzemeUcreti = Fonksiyonlar.EkstraMalzemelerFiyatiAl(flpEkstraMalzemeler);
            Fonksiyonlar.LabelFiyatYazdir(lblToplamTutar);
        }

        private void btnSiparisiTamamla_Click(object sender, EventArgs e)
        {
            Fonksiyonlar.ButonEnableFalse(btnSiparisiTamamla);
            MyMdiParent.siparisBilgileri.lstSiparisler.Items.AddRange(lstSiparisler.Items);
            Fonksiyonlar.ListeTemizle(lstSiparisler);
            Fonksiyonlar.MalzemeUcretleriDefaultAl();
            MyMdiParent.siparisBilgileri.Show();
        }
    }
}

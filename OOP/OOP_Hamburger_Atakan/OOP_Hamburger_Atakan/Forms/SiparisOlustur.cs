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
            
            FormDuzenle();
            Fonksiyonlar.SoslariYukle(flpEkstraMalzemeler,Ekstra.malzemeler);
            Fonksiyonlar.MenuleriYukle(cbMenuler,Menuler.menuler);
        }

        private void FormDuzenle()
        {
            FormBorderStyle = FormBorderStyle.None;
            Dock = DockStyle.Fill;
        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show($"Toplam Sipariş Tutarı : {lblToplamTutar.Text} ₺\nSatın almayı tamamlamak ister misiniz? ", "Sipariş Bilgisi", MessageBoxButtons.YesNo);


            if (dr == DialogResult.Yes)
            {              
                Fonksiyonlar.SecilenBoyutAdi(grpHamburgerBoyut);
                Fonksiyonlar.SecilenMalzemeAdlari(flpEkstraMalzemeler);
                Fonksiyonlar.SiparisListeEkle(cbMenuler, lstSiparisler);
                Siparis.ToplamSiparisSayisi++;
                Siparis.ToplamAdet += (int)numAdet.Value;
                Siparis.EkstraMalzemeGeliri += Fonksiyonlar.EkstraMalzemelerFiyatiAl(flpEkstraMalzemeler);
                Siparis.Ciro += Fonksiyonlar.ToplamSiparisTutariAl(Menuler.Ucret, Siparis.BoyutUcreti, Ekstra.MalzemeUcreti, Siparis.Adet);
            }
            else
            {
                MessageBox.Show("İptal Edildi!");
            }

        }
        private void cbMenuler_Click(object sender, EventArgs e)
        {            
            Fonksiyonlar.MenuleriYukle(cbMenuler, Menuler.menuler);
        }  
        public void SiparisTutariAl(object sender, EventArgs e)
        {          
            Siparis.Adet = Fonksiyonlar.AdetFiyatAl(numAdet);
            Menuler.Ucret = Fonksiyonlar.MenuFiyatiAl(cbMenuler);
            Siparis.BoyutUcreti = Fonksiyonlar.BoyutFiyatiAl(grpHamburgerBoyut);   
            Siparis.ToplamTutar = Fonksiyonlar.ToplamSiparisTutariAl(Menuler.Ucret, Siparis.BoyutUcreti, Ekstra.MalzemeUcreti, Siparis.Adet);
            Ekstra.MalzemeUcreti = Fonksiyonlar.EkstraMalzemelerFiyatiAl(flpEkstraMalzemeler);
            Fonksiyonlar.LabelFiyatYazdir(lblToplamTutar);
        }

        private void btnSiparisiTamamla_Click(object sender, EventArgs e)
        {
            MyMdiParent.siparisBilgileri.Show();
        }
    }
}

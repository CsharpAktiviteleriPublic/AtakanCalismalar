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
            FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
            MenuleriYukle();
        }

        private void MenuleriYukle()
        {
            foreach (var menuAdi in Menuler.menuler)
            {
                cbMenuler.Items.Add(menuAdi.Key);
            }
        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show($"Toplam Sipariş Tutarı : {lblToplamTutar.Text} ₺\nSatın almayı tamamlamak ister misiniz? ", "Sipariş Bilgisi", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                MyMdiParent.siparisBilgileri.Show();
            }
            else
            {
                MessageBox.Show("İptal Edildi!");
            }

        }

        private void cbMenuler_Click(object sender, EventArgs e)
        {
            cbMenuler.Items.Clear();
            foreach (var menuAdi in Menuler.menuler)
            {
                cbMenuler.Items.Add(menuAdi.Key);
            }
        }

        private void cbMenuler_SelectedIndexChanged(object sender, EventArgs e)
        {
            Siparis.Adet = Fonksiyonlar.AdetFiyatAl(numAdet);
            Menuler.Ucret = Fonksiyonlar.MenuFiyatiAl(cbMenuler);
            Siparis.BoyutUcreti = Fonksiyonlar.BoyutFiyatiAl(grpHamburgerBoyut);
            Ekstra.MalzemeUcreti = Fonksiyonlar.EkstraMalzemelerFiyatiAl(flpEkstraMalzemeler);
            Siparis.ToplamTutar = Fonksiyonlar.ToplamSiparisTutariAl(Menuler.Ucret, Siparis.BoyutUcreti, Ekstra.MalzemeUcreti, Siparis.Adet);

            //foreach (RadioButton item in grpHamburgerBoyut.Controls)
            //{
            //    if (item.Checked)
            //    {
            //        MessageBox.Show(Siparis.BoyutUcreti.ToString());
            //    }
            //}
            //----------------------------------------------------------------------------
            //foreach (CheckBox item in flpEkstraMalzemeler.Controls)
            //{
            //    if (item.Checked)
            //    {
            //        Ekstra.MalzemeUcreti += Ekstra.malzemeler[item.Text];
            //    }
            //}

        }
    }
}

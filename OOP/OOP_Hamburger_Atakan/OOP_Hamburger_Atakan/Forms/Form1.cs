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
    public partial class MyMdiParent : Form
    {
        public MyMdiParent()
        {
            InitializeComponent();

        }       
                
        internal static SiparisOlustur siparisOlustur = new SiparisOlustur();
        internal static SiparisBilgileri siparisBilgileri = new SiparisBilgileri();
        internal static MenuEkle menuEkle = new MenuEkle();
        internal static EkstraMalzemeEkle ekstraMalzemeEkle = new EkstraMalzemeEkle();
        private void MyMdiParent_Load(object sender, EventArgs e) 
        {    
            siparisOlustur.MdiParent = this;
            siparisBilgileri.MdiParent = this;
            Fonksiyonlar.Ekle()
        }
        private void siparisOlusturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            siparisBilgileri.Hide();
            siparisOlustur.Show();
        }
        private void siparisBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            siparisOlustur.Hide();
            siparisBilgileri.Show();
        }
        private void menuEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuEkle.ShowDialog();
        }
        private void malzemeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ekstraMalzemeEkle.ShowDialog();
        }
    }
}

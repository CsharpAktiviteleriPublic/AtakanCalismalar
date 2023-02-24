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
    public partial class EkstraMalzemeEkle : Form
    {
        public EkstraMalzemeEkle()
        {
            InitializeComponent();
        }

        private void btnMalzemeEkle_Click(object sender, EventArgs e)
        {
            Fonksiyonlar.Ekle(Ekstra.malzemeler, txtEkstraMalzemeAdi.Text, numFiyat.Value);
            Fonksiyonlar.SoslariYukle(MyMdiParent.siparisOlustur.flpEkstraMalzemeler, Ekstra.malzemeler);
        }
    }
}

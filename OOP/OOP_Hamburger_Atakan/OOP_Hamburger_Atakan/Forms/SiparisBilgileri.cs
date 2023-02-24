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
    public partial class SiparisBilgileri : Form
    {
        public SiparisBilgileri()
        {
            InitializeComponent();
        }

        private void SiparisBilgileri_Load(object sender, EventArgs e)
        {
            Fonksiyonlar.FormDuzenle(this);
            Fonksiyonlar.LabelFiyatYazdir(lblCiro, lblEkstraMalGeliri, lblSiparisSayisi,lblUrunAdedi); ;
      
        }

        private void SiparisBilgileri_Load_1(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathGames
{
    public partial class KullaniciKayit : Form
    {
        public KullaniciKayit()
        {
            InitializeComponent();
        }

        private int sayac = 0;

        private void tmrLabelYanipSönme_Tick(object sender, EventArgs e)
        {
            if (sayac==0)
            {

            }
            else if(sayac==1)
            {

            }
            else if (sayac == 2)
            {

            }
            else if (sayac == 3)
            {

            }
            else
            {

            }
            sayac++;

        }

        private void KullaniciKayit_Load(object sender, EventArgs e)
        {
            tmrLabelYanipSönme.Start();
        }

        private void btnAnaSayfayaDon_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}

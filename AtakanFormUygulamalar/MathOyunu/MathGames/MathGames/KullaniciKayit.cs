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

        private void tmrLabelYanipSönme_Tick(object sender, EventArgs e)
        {
            lblUyari.Visible = lblUyari.Visible == true ? false : true;
            //if (lblUyari.Visible == true) lblUyari.Visible = false;

            //else lblUyari.Visible = true;
        }

        private void KullaniciKayit_Load(object sender, EventArgs e)
        {
            tmrLabelYanipSönme.Start();
        }
    }
}

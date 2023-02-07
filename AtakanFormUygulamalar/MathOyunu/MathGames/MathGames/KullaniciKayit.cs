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
                lblSifre.ForeColor = Color.White;
                lblKullaniciAdi.ForeColor = Color.WhiteSmoke;
                lblSoyad.ForeColor = Color.Gainsboro;
                lblAd.ForeColor = Color.LightGray;
            }
            else if(sayac==1)
            {
                lblSifre.ForeColor = Color.WhiteSmoke;
                lblKullaniciAdi.ForeColor = Color.Gainsboro;
                lblSoyad.ForeColor = Color.LightGray;
                lblAd.ForeColor = Color.Silver;
            }
            else if (sayac == 2)
            {
                lblSifre.ForeColor = Color.Gainsboro;
                lblKullaniciAdi.ForeColor = Color.LightGray;
                lblSoyad.ForeColor = Color.Silver;
                lblAd.ForeColor = Color.DarkGray;
            }
            else if (sayac == 3)
            {
                lblSifre.ForeColor = Color.LightGray;
                lblKullaniciAdi.ForeColor = Color.Silver;
                lblSoyad.ForeColor = Color.DarkGray;
                lblAd.ForeColor = Color.Gray;
            }
            else if (sayac == 4)
            {
                lblSifre.ForeColor = Color.Silver;
                lblKullaniciAdi.ForeColor = Color.DarkGray;
                lblSoyad.ForeColor = Color.Gray;
                lblAd.ForeColor = Color.DimGray;
            }
            else if (sayac == 5)
            {
                lblSifre.ForeColor = Color.DarkGray;
                lblKullaniciAdi.ForeColor = Color.Gray;
                lblSoyad.ForeColor = Color.DimGray;
                lblAd.ForeColor = Color.White;
            }
            else if (sayac == 6)
            {
                lblSifre.ForeColor = Color.Gray;
                lblKullaniciAdi.ForeColor = Color.DimGray;
                lblSoyad.ForeColor = Color.White;
                lblAd.ForeColor = Color.WhiteSmoke;
            }
            else
            {
                lblSifre.ForeColor = Color.DimGray;
                lblKullaniciAdi.ForeColor = Color.White;
                lblSoyad.ForeColor = Color.WhiteSmoke;
                lblAd.ForeColor = Color.Gainsboro;
                sayac = -1;
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

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hesap oluşturuldu.");
        }
    }
}

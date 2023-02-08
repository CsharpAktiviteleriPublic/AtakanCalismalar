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
        KullaniciGiris kullaniciGiris = new KullaniciGiris();
        


        private void KullaniciKayit_Load(object sender, EventArgs e)
        {

            tmrLabelYanipSönme.Start();
        }
        private void tmrLabelYanipSönme_Tick(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                lblSifre.ForeColor = Color.White;//0 
                lblKullaniciAdi.ForeColor = Color.WhiteSmoke;//1
                lblSoyad.ForeColor = Color.Gainsboro;//2
                lblAd.ForeColor = Color.LightGray;//3
            }
            else if (sayac == 1)
            {
                lblSifre.ForeColor = Color.WhiteSmoke;//1
                lblKullaniciAdi.ForeColor = Color.Gainsboro;//2
                lblSoyad.ForeColor = Color.LightGray;//3
                lblAd.ForeColor = Color.Silver;//4
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
                lblSifre.ForeColor = Color.Silver;//4
                lblKullaniciAdi.ForeColor = Color.DarkGray;//5
                lblSoyad.ForeColor = Color.Gray;//6
                lblAd.ForeColor = Color.DimGray;//7
            }
            else if (sayac == 5)
            {
                lblSifre.ForeColor = Color.DarkGray;//5
                lblKullaniciAdi.ForeColor = Color.Gray;//6
                lblSoyad.ForeColor = Color.DimGray;//7
                lblAd.ForeColor = Color.White;//1
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
                lblSifre.ForeColor = Color.DimGray;//7
                lblKullaniciAdi.ForeColor = Color.White;//1
                lblSoyad.ForeColor = Color.WhiteSmoke;//2
                lblAd.ForeColor = Color.Gainsboro;//3
                sayac = -1;
            }

            sayac++;

        }
        private void btnAnaSayfayaDon_Click(object sender, EventArgs e)
        {
            kullaniciGiris.count = 1;
            kullaniciGiris.Show();
            Hide();
        }
        private void btnKayitOl_Click(object sender, EventArgs e)
        {            
            kullaniciGiris.kullaniciAdi = txtKullaniciAdi.Text;
            kullaniciGiris.sifre = txtSifre.Text;
            kullaniciGiris.ad = txtAd.Text;
            kullaniciGiris.soyad = txtSoyad.Text;
            kullaniciGiris.adSoyadID = kullaniciGiris.ad+" "+kullaniciGiris.soyad+" "+kullaniciGiris.kullaniciAdi;
           
            kullaniciGiris.uyeBilgisi.Add(kullaniciGiris.sifre, kullaniciGiris.adSoyadID);




            MessageBox.Show("Hesap oluşturuldu.");
        }
    }
}

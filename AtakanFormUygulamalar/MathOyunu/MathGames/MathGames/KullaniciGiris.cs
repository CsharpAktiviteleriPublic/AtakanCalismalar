using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathGames
{
    public partial class KullaniciGiris : Form
    {
        public KullaniciGiris()
        {
            InitializeComponent();
        }
        private string welcomeMessage;
        private int i = 0;
        public int count = 0;

        public Dictionary<string, string> uyeBilgisi = new Dictionary<string, string>();
        public string kullaniciAdi = "";
        public string sifre = "";
        public string ad = "";
        public string soyad = "";
        public string adSoyadID = "";



        private void KullaniciGiris_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.math;

            grpGiris.Top = this.Height;

            welcomeMessage = "Bu programın kullanım amacı temel işlem bilgilerinizi hızlandırmak, sayısal işlemlerde seri düşünebilmenizi sağlamaktır. \n\nToplama Çıkarma ve Çarpma işlemlerini ne kadar hızlı çözüp cevaplarsanız, o kadar puan kazanırsınız!\n\nDenemek için lütfen aşağıdan giriş yapınız.\nEğer hesabınız yoksa öncelikle kayıt olunuz.!";


            if (count != 0)
            {
                lblWelcomeMessage.Text = welcomeMessage;
                grpGiris.Visible = true;
                grpGiris.Top = this.Height - grpGiris.Height - 60;
            }
            else
            {
                tmrWelcome.Start();

            }
        }

        private void tmrWelcome_Tick(object sender, EventArgs e)
        {
            if (i >= welcomeMessage.Length - 1)
            {
                grpGiris.Visible = true;
                tmrMoveGroupBox.Start();
                tmrWelcome.Stop();
            }
            lblWelcomeMessage.Text += welcomeMessage[i++];
        }

        private void tmrMoveGroupBox_Tick(object sender, EventArgs e)
        {
            if (this.Height <= grpGiris.Bottom + 40) grpGiris.Top -= 5;
            else tmrMoveGroupBox.Stop();
        }

        private void linkKayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KullaniciKayit kullaniciKayit = new KullaniciKayit();
            Hide();
            kullaniciKayit.Show();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string[] adSoyadK = new string[3];
            

            if (uyeBilgisi.ContainsKey(txtSifre.Text))
            {
                if (uyeBilgisi[txtSifre.Text].Split(' ')[uyeBilgisi[txtSifre.Text].Split(' ').Length - 1] == txtID.Text)
                {
                    OyunEkrani oyunEkrani = new OyunEkrani();
                    
                    adSoyadK = uyeBilgisi[txtSifre.Text].Split(' ');
                    oyunEkrani.ad = adSoyadK[0];
                    oyunEkrani.soyad = adSoyadK[1];
                    oyunEkrani.kullaniciAdi = adSoyadK[2] ;
                    oyunEkrani.sifre = txtSifre.Text;
                    oyunEkrani.adSoyadID = ad+" "+soyad+" "+kullaniciAdi;

                    oyunEkrani.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Şifre veya kullanıcı adı hatalıdır.");
                }

            }
            else
            {
                MessageBox.Show("Böyle bir şifre bulunamadı!");
            }


        }

    }
}

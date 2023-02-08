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
        KullaniciKayit kullaniciKayit = new KullaniciKayit();
        OyunEkrani oyunEkrani = new OyunEkrani();

        private void KullaniciGiris_Load(object sender, EventArgs e)
        {
            grpGiris.Top = this.Height;

            welcomeMessage = "Bu programın kullanım amacı temel işlem bilgilerinizi hızlandırmak, sayısal işlemlerde seri düşünebilmenizi sağlamaktır. \n\nToplama Çıkarma ve Çarpma işlemlerini ne kadar hızlı çözüp cevaplarsanız, o kadar puan kazanırsınız!\n\nDenemek için lütfen aşağıdan giriş yapınız.\nEğer hesabınız yoksa öncelikle kayıt olunuz.!";
            
            
            if (count != 0)
            {
                lblWelcomeMessage.Text = welcomeMessage;
                grpGiris.Visible = true;
                grpGiris.Top = this.Height - grpGiris.Height-60;
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
            kullaniciKayit.Show();
            Hide();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            oyunEkrani.Show();
            Hide();
        }
        
    }
}

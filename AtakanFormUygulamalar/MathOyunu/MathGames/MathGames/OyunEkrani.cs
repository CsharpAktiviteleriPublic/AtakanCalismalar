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
    public partial class OyunEkrani : Form
    {
        public OyunEkrani()
        {
            InitializeComponent();
        }

        private int i = 4;
        Random rnd = new Random();
        int num1 = 0;
        int num2 = 0;
        int islem = 0;
        int sum = 0;
        int userSum;
        public int score = 0;


        private void OyunEkrani_Load(object sender, EventArgs e)
        {

            IslemOlustur(num1, num2, islem);
            tmrSayacUc.Start();
        }
        private void IslemOlustur(int num1, int num2, int islem)
        {
            num1 = rnd.Next(0, 11);
            num2 = rnd.Next(0, 11);
            islem = rnd.Next(1, 4);
            lblNum1.Text = num1.ToString();
            lblNum2.Text = num2.ToString();
            switch (islem)
            {
                case 1:
                    lblIslem.Text = "+";
                    sum = num1 + num2;
                    break;
                case 2:
                    lblIslem.Text = "-";
                    sum = num1 - num2;
                    break;
                case 3:
                    lblIslem.Text = "x";
                    sum = num1 * num2;
                    break;
            }
        }

        private void tmrSayacUc_Tick(object sender, EventArgs e)
        {
            if (i >= 1 && i <= 3)
            {
                lblSayacUc.Text = i.ToString();
            }
            else if (i == 4)
            {
                lblSayacUc.Text = "HAZIR OL!";
            }
            else if (i == 0)
            {
                lblSayacUc.Text = "BAŞLA!";
            }
            else
            {
                lblSayacUc.Visible = false;
                tmrSayacUc.Stop();
                flpIslem.Visible = true;
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                tmrSure.Start();
            }
            i--;

        }
        private void txtSonuc_KeyPress(object sender, KeyPressEventArgs e)
        {



            if (e.KeyChar == (Char)Keys.Enter)
            {

                bool isNumber = int.TryParse(txtSonuc.Text, out userSum);

                if (isNumber && userSum == sum)
                {
                    CorrectSoundPlayer(sender, e);
                    txtSonuc.BackColor = Color.Green;
                    score++;
                    IslemOlustur(num1, num2, sum);
                    txtSonuc.Clear();
                }
                else
                {
                    MistakeSoundPlayer(sender, e);
                    txtSonuc.BackColor = Color.Red;
                    score--;
                }
            }
            else if (!(e.KeyChar == (Char)Keys.Delete || e.KeyChar == 45 /* '-' işareti */ || e.KeyChar == (Char)Keys.Back || char.IsNumber(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        private void tmrSure_Tick(object sender, EventArgs e)
        {
            if (pbarSure.Value != 0)
            {
                pbarSure.Value--;
            }
            else
            {
                tmrSure.Stop();
                MessageBox.Show(score.ToString());
                SkorTablosu skorTablosu = new SkorTablosu();
                skorTablosu.ShowDialog();
            }
        }
        private void CorrectSoundPlayer(object sender, EventArgs e)
        {
            SoundPlayer correctSound = new SoundPlayer(Properties.Resources.correct_choice_43861);
            correctSound.Play();

        }

        private void MistakeSoundPlayer(object sender, EventArgs e)
        {
            SoundPlayer mistakeSoundPlayer = new SoundPlayer(Properties.Resources.failure_drum_sound_effect_2_7184);
            mistakeSoundPlayer.Play();
        }

        private void tmrAdOynuyor_Tick(object sender, EventArgs e)
        {            
              
        }
    }
}

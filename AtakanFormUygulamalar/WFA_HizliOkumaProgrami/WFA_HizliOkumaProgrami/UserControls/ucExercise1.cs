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
using WFA_HizliOkumaProgrami.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WFA_HizliOkumaProgrami.UserControls
{
    public partial class ucExercise1 : UserControl
    {
        Label _label = new Label();
        int count = 3;

        public ucExercise1()
        {
            InitializeComponent();
        }

        public void CreateTimers()
        {
            pbBall.Visible = false;
            CreateStopWatch();
            tmrStopWatch.Start();
        }

        private void CreateStopWatch()
        {
            _label.AutoSize = false;
            _label.Dock = DockStyle.Fill;
            _label.TextAlign = ContentAlignment.MiddleCenter;
            Font LargeFont = new Font("Arial", 80);
            _label.Font = LargeFont;
            pnlBallArea.Controls.Add(_label);
        }
        private void tmrStopWatch_Tick(object sender, EventArgs e)
        {
            _label.Text = count.ToString();
            if (count >= 0)
            {
                count--;
            }          
            else
            {
                count = 3;
                _label.Text = count.ToString();
                pnlBallArea.Controls.Remove(_label);
                tmrStopWatch.Stop();
                tmrMoveBall.Start();
            }
        }

        private void tmrMoveBall_Tick(object sender, EventArgs e)
        {

            pbBall.Visible = true;            
            Stream str = Resources.Clap_03;
            SoundPlayer soundPlayer = new SoundPlayer(str);
            soundPlayer.Play();
            if (rbtnHighLevel.Checked) tmrMoveBall.Interval = 300;
            else if (rbtnProfessional.Checked) tmrMoveBall.Interval = 200;
            else tmrMoveBall.Interval = 400;
            pbBall.Location = new Point(Form1.rnd.Next(pnlBallArea.Width - pbBall.Width), Form1.rnd.Next(pnlBallArea.Height - pbBall.Height));
        }
    }
}

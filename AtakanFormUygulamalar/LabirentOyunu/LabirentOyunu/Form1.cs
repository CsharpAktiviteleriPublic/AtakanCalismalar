using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabirentOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<PictureBox> pbList = new List<PictureBox>();
        int topHizi;
        int userScore = 0;
        int computerScore = 0;
        int computerScoreBefore = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            tmrYol.Start();
            tmrGoalKeeper.Start();
            pbList.Add(pbT1);
            pbList.Add(pbT2);
            pbList.Add(pbT3);
            pbList.Add(pbT4);
            pbList.Add(pbT5);
            pbList.Add(pbT6);
            pbList.Add(pbT7);
            pbList.Add(pbT8);
            pbList.Add(pbT9);
            pbList.Add(pbT10);
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {

                case Keys.Up:
                    if (pbKarakter.Bounds.IntersectsWith(pnlAlan.Bounds))
                    {
                        pbKarakter.Top -= 5;
                    }
                    break;
                case Keys.Down:
                    if (!(pbKarakter.Top + pbKarakter.Height >= pnlAlan.Height))
                    {
                        pbKarakter.Top += 5;
                    }
                    break;
                case Keys.Space:
                    topHizi = 100;
                    pbTop.Left = pbKarakter.Left + pbKarakter.Width;
                    pbTop.Top = pbKarakter.Top + pbKarakter.Height - pbTop.Height;
                    pbTop.Visible = true;
                    tmrTop.Start();
                    break;
            }
        }
        private void tmrYol_Tick(object sender, EventArgs e)
        {

            foreach (PictureBox pb in pbList)
            {
                if (pb.Left + pb.Width <= 0)
                {
                    pb.Left = Width;
                }
                else
                    pb.Left -= 3;
            }
        }
        private void tmrTop_Tick(object sender, EventArgs e)
        {


            if (topHizi > 0)
            {
                if ((pbTop.Bounds.IntersectsWith(lblGoalKeeper.Bounds))) //kaleci kurtarırsa
                {                    
                    computerScore++;
                    lblComputerScore.Text = computerScore.ToString();
                    pbTop.Visible = false;
                    tmrTop.Stop();
                }

                else if ((pbTop.Bounds.IntersectsWith(lblGoal.Bounds)))//gol olursa
                {
                    userScore++;
                    lblUserScore.Text = (userScore).ToString();
                    pbTop.Visible = false;
                    tmrTop.Stop();
                }

                else // top giderken
                {
                   
                    topHizi -= 1;
                    pbTop.Left += topHizi;
                }

            }         
        }

        int goalKeeperV = 3;
        private void tmrGoalKeeper_Tick(object sender, EventArgs e)
        {
            lblGoalKeeper.Top += goalKeeperV;
            if (lblGoalKeeper.Top + lblGoalKeeper.Height >= pnlAlan.Height || lblGoalKeeper.Top <= 0)
            {
                goalKeeperV = goalKeeperV * -1;
            }

        }
    }
}

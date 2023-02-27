using System;
using System.Media;
using WFA_HizliOkumaProgrami.Properties;
using WFA_HizliOkumaProgrami.UserControls;

namespace WFA_HizliOkumaProgrami
{
    public partial class Form1 : Form
    {
        public static Random rnd = new Random();
        ucExercise1 _ucExercise1 = new ucExercise1();
<<<<<<< HEAD
        ucAnasayfa _ucAnasayfa = new ucAnasayfa();
=======
        ucExercise2 _ucExercise2 = new ucExercise2();

>>>>>>> 9bd3600a4c0a31942b5f5e9b401ee5a468781130

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetNowDateTime();
            tmrDate.Start();    
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            TimerStop();
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            TimerStop();
            this.Close();
        }

        private void tmrDate_Tick(object sender, EventArgs e)
        {
            GetNowDateTime();
        }

        private void GetNowDateTime()
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
            lblDate.Text = DateTime.Now.ToString("dd.MMM.yyyy");
        }

        public void TimerStop()
        {
            _ucExercise1.tmrMoveBall.Stop();
            _ucExercise1.tmrStopWatch.Stop();
        }
        private void btnHomePage_Click(object sender, EventArgs e)
        {
            TimerStop();
            pnlActivePage.Top = btnHomePage.Top;
            pnlAlan.Controls.Clear();
            pnlAlan.Controls.Add(_ucAnasayfa);
        }
        private void btnFastRead_Click(object sender, EventArgs e)
        {
            TimerStop();
            pnlActivePage.Top = btnFastRead.Top;
            pnlAlan.Controls.Clear();
            pnlAlan.Controls.Add(new ucFastRead());
        }

        private void btnTeachers_Click(object sender, EventArgs e)
        {
            TimerStop();
            pnlActivePage.Top = btnTeachers.Top;
            pnlAlan.Controls.Clear();

        }

        private void btnExercise1_Click(object sender, EventArgs e)
        {

            TimerStop();
            _ucExercise1.CreateTimers();
            pnlActivePage.Top = btnExercise1.Top;
            pnlAlan.Controls.Clear();
            pnlAlan.Controls.Add(_ucExercise1);
        }

        private void btnExercise2_Click(object sender, EventArgs e)
        {
            TimerStop();
            pnlActivePage.Top = btnExercise2.Top;
            pnlAlan.Controls.Clear();
        }

        private void btnExercise3_Click(object sender, EventArgs e)
        {
            TimerStop();
            pnlActivePage.Top = btnExercise3.Top;
            pnlAlan.Controls.Clear();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            TimerStop();
            pnlActivePage.Top = btnTest.Top;
            pnlAlan.Controls.Clear();
        }
    }
}

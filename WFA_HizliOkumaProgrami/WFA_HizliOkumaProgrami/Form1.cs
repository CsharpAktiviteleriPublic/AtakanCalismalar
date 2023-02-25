namespace WFA_HizliOkumaProgrami
{
    public partial class Form1 : Form
    {
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
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
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

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            pnlActivePage.Top = btnHomePage.Top;

        }
        private void btnFastRead_Click(object sender, EventArgs e)
        {
            pnlActivePage.Top = btnFastRead.Top;
        }

        private void btnTeachers_Click(object sender, EventArgs e)
        {
            pnlActivePage.Top = btnTeachers.Top;
        }

        private void btnExercise1_Click(object sender, EventArgs e)
        {
            pnlActivePage.Top = btnExercise1.Top;
        }

        private void btnExercise2_Click(object sender, EventArgs e)
        {
            pnlActivePage.Top = btnExercise2.Top;
        }

        private void btnExercise3_Click(object sender, EventArgs e)
        {
            pnlActivePage.Top = btnExercise3.Top;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            pnlActivePage.Top = btnTest.Top;
        }
    }
}

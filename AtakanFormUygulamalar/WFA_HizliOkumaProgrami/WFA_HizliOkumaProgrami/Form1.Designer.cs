namespace WFA_HizliOkumaProgrami
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pnlUp = new Panel();
            btnClose = new Button();
            btnMin = new Button();
            btnHomePage = new Button();
            pnlDown = new Panel();
            lblDate = new Label();
            lblTime = new Label();
            pnlLeft = new Panel();
            pnlActivePage = new Panel();
            btnTest = new Button();
            btnExercise3 = new Button();
            btnExercise2 = new Button();
            btnExercise1 = new Button();
            btnTeachers = new Button();
            btnFastRead = new Button();
            pnlRight = new Panel();
            pnlAlan = new Panel();
            ucAnasayfa1 = new ucAnasayfa();
            tmrDate = new System.Windows.Forms.Timer(components);
            pnlUp.SuspendLayout();
            pnlDown.SuspendLayout();
            pnlLeft.SuspendLayout();
            pnlAlan.SuspendLayout();
            SuspendLayout();
            // 
            // pnlUp
            // 
            pnlUp.BackColor = Color.Black;
            pnlUp.Controls.Add(btnClose);
            pnlUp.Controls.Add(btnMin);
            pnlUp.Dock = DockStyle.Top;
            pnlUp.Location = new Point(0, 0);
            pnlUp.Name = "pnlUp";
            pnlUp.Size = new Size(1250, 40);
            pnlUp.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseDownBackColor = Color.Cyan;
            btnClose.FlatAppearance.MouseOverBackColor = Color.Red;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = Color.Cyan;
            btnClose.Image = Properties.Resources.CloseButton2;
            btnClose.Location = new Point(1212, 3);
            btnClose.Name = "btnClose";
            btnClose.RightToLeft = RightToLeft.No;
            btnClose.Size = new Size(33, 33);
            btnClose.TabIndex = 3;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnMin
            // 
            btnMin.BackColor = Color.Transparent;
            btnMin.FlatAppearance.BorderSize = 0;
            btnMin.FlatAppearance.MouseDownBackColor = Color.Cyan;
            btnMin.FlatAppearance.MouseOverBackColor = Color.Red;
            btnMin.FlatStyle = FlatStyle.Flat;
            btnMin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnMin.ForeColor = Color.Cyan;
            btnMin.Image = Properties.Resources.Minus;
            btnMin.Location = new Point(1173, 3);
            btnMin.Name = "btnMin";
            btnMin.RightToLeft = RightToLeft.No;
            btnMin.Size = new Size(33, 33);
            btnMin.TabIndex = 3;
            btnMin.UseVisualStyleBackColor = false;
            btnMin.Click += btnMin_Click;
            // 
            // btnHomePage
            // 
            btnHomePage.FlatAppearance.BorderSize = 0;
            btnHomePage.FlatStyle = FlatStyle.Flat;
            btnHomePage.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnHomePage.ForeColor = Color.Cyan;
            btnHomePage.Image = Properties.Resources.HomePageButton2;
            btnHomePage.ImageAlign = ContentAlignment.MiddleLeft;
            btnHomePage.Location = new Point(26, 21);
            btnHomePage.Name = "btnHomePage";
            btnHomePage.RightToLeft = RightToLeft.No;
            btnHomePage.Size = new Size(129, 33);
            btnHomePage.TabIndex = 3;
            btnHomePage.Text = "ANASAYFA";
            btnHomePage.TextAlign = ContentAlignment.MiddleRight;
            btnHomePage.UseVisualStyleBackColor = true;
            btnHomePage.Click += btnHomePage_Click;
            // 
            // pnlDown
            // 
            pnlDown.BackColor = Color.Black;
            pnlDown.Controls.Add(lblDate);
            pnlDown.Controls.Add(lblTime);
            pnlDown.Dock = DockStyle.Bottom;
            pnlDown.Location = new Point(0, 560);
            pnlDown.Name = "pnlDown";
            pnlDown.Size = new Size(1250, 90);
            pnlDown.TabIndex = 1;
            // 
            // lblDate
            // 
            lblDate.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblDate.ForeColor = Color.FromArgb(192, 0, 0);
            lblDate.Location = new Point(1077, 44);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(161, 37);
            lblDate.TabIndex = 4;
            lblDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTime
            // 
            lblTime.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblTime.ForeColor = Color.FromArgb(192, 0, 0);
            lblTime.Location = new Point(1077, 3);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(161, 37);
            lblTime.TabIndex = 4;
            lblTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.FromArgb(64, 0, 0);
            pnlLeft.Controls.Add(pnlActivePage);
            pnlLeft.Controls.Add(btnTest);
            pnlLeft.Controls.Add(btnExercise3);
            pnlLeft.Controls.Add(btnExercise2);
            pnlLeft.Controls.Add(btnExercise1);
            pnlLeft.Controls.Add(btnTeachers);
            pnlLeft.Controls.Add(btnFastRead);
            pnlLeft.Controls.Add(btnHomePage);
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.Location = new Point(0, 40);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(194, 520);
            pnlLeft.TabIndex = 2;
            // 
            // pnlActivePage
            // 
            pnlActivePage.BackColor = Color.LawnGreen;
            pnlActivePage.Location = new Point(12, 21);
            pnlActivePage.Name = "pnlActivePage";
            pnlActivePage.Size = new Size(10, 33);
            pnlActivePage.TabIndex = 4;
            // 
            // btnTest
            // 
            btnTest.FlatAppearance.BorderSize = 0;
            btnTest.FlatStyle = FlatStyle.Flat;
            btnTest.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnTest.ForeColor = Color.Cyan;
            btnTest.Image = Properties.Resources.HomePageButton2;
            btnTest.ImageAlign = ContentAlignment.MiddleLeft;
            btnTest.Location = new Point(26, 441);
            btnTest.Name = "btnTest";
            btnTest.RightToLeft = RightToLeft.No;
            btnTest.Size = new Size(87, 33);
            btnTest.TabIndex = 3;
            btnTest.Text = "TEST";
            btnTest.TextAlign = ContentAlignment.MiddleRight;
            btnTest.UseVisualStyleBackColor = true;
            btnTest.Click += btnTest_Click;
            // 
            // btnExercise3
            // 
            btnExercise3.FlatAppearance.BorderSize = 0;
            btnExercise3.FlatStyle = FlatStyle.Flat;
            btnExercise3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExercise3.ForeColor = Color.Cyan;
            btnExercise3.Image = Properties.Resources.HomePageButton2;
            btnExercise3.ImageAlign = ContentAlignment.MiddleLeft;
            btnExercise3.Location = new Point(26, 371);
            btnExercise3.Name = "btnExercise3";
            btnExercise3.RightToLeft = RightToLeft.No;
            btnExercise3.Size = new Size(138, 33);
            btnExercise3.TabIndex = 3;
            btnExercise3.Text = "EGZERSİZ-3";
            btnExercise3.TextAlign = ContentAlignment.MiddleRight;
            btnExercise3.UseVisualStyleBackColor = true;
            btnExercise3.Click += btnExercise3_Click;
            // 
            // btnExercise2
            // 
            btnExercise2.FlatAppearance.BorderSize = 0;
            btnExercise2.FlatStyle = FlatStyle.Flat;
            btnExercise2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExercise2.ForeColor = Color.Cyan;
            btnExercise2.Image = Properties.Resources.HomePageButton2;
            btnExercise2.ImageAlign = ContentAlignment.MiddleLeft;
            btnExercise2.Location = new Point(26, 301);
            btnExercise2.Name = "btnExercise2";
            btnExercise2.RightToLeft = RightToLeft.No;
            btnExercise2.Size = new Size(138, 33);
            btnExercise2.TabIndex = 3;
            btnExercise2.Text = "EGZERSİZ-2";
            btnExercise2.TextAlign = ContentAlignment.MiddleRight;
            btnExercise2.UseVisualStyleBackColor = true;
            btnExercise2.Click += btnExercise2_Click;
            // 
            // btnExercise1
            // 
            btnExercise1.FlatAppearance.BorderSize = 0;
            btnExercise1.FlatStyle = FlatStyle.Flat;
            btnExercise1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExercise1.ForeColor = Color.Cyan;
            btnExercise1.Image = Properties.Resources.HomePageButton2;
            btnExercise1.ImageAlign = ContentAlignment.MiddleLeft;
            btnExercise1.Location = new Point(26, 231);
            btnExercise1.Name = "btnExercise1";
            btnExercise1.RightToLeft = RightToLeft.No;
            btnExercise1.Size = new Size(138, 33);
            btnExercise1.TabIndex = 3;
            btnExercise1.Text = "EGZERSİZ-1";
            btnExercise1.TextAlign = ContentAlignment.MiddleRight;
            btnExercise1.UseVisualStyleBackColor = true;
            btnExercise1.Click += btnExercise1_Click;
            // 
            // btnTeachers
            // 
            btnTeachers.FlatAppearance.BorderSize = 0;
            btnTeachers.FlatStyle = FlatStyle.Flat;
            btnTeachers.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnTeachers.ForeColor = Color.Cyan;
            btnTeachers.Image = Properties.Resources.HomePageButton2;
            btnTeachers.ImageAlign = ContentAlignment.MiddleLeft;
            btnTeachers.Location = new Point(26, 161);
            btnTeachers.Name = "btnTeachers";
            btnTeachers.RightToLeft = RightToLeft.No;
            btnTeachers.Size = new Size(165, 33);
            btnTeachers.TabIndex = 3;
            btnTeachers.Text = "OGRETMENLER";
            btnTeachers.TextAlign = ContentAlignment.MiddleRight;
            btnTeachers.UseVisualStyleBackColor = true;
            btnTeachers.Click += btnTeachers_Click;
            // 
            // btnFastRead
            // 
            btnFastRead.FlatAppearance.BorderSize = 0;
            btnFastRead.FlatStyle = FlatStyle.Flat;
            btnFastRead.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnFastRead.ForeColor = Color.Cyan;
            btnFastRead.Image = Properties.Resources.HomePageButton2;
            btnFastRead.ImageAlign = ContentAlignment.MiddleLeft;
            btnFastRead.Location = new Point(26, 91);
            btnFastRead.Name = "btnFastRead";
            btnFastRead.RightToLeft = RightToLeft.No;
            btnFastRead.Size = new Size(154, 33);
            btnFastRead.TabIndex = 3;
            btnFastRead.Text = "HIZLI OKUMA";
            btnFastRead.TextAlign = ContentAlignment.MiddleRight;
            btnFastRead.UseVisualStyleBackColor = true;
            btnFastRead.Click += btnFastRead_Click;
            // 
            // pnlRight
            // 
            pnlRight.BackColor = Color.FromArgb(64, 0, 0);
            pnlRight.Dock = DockStyle.Right;
            pnlRight.Location = new Point(1194, 40);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new Size(56, 520);
            pnlRight.TabIndex = 3;
            // 
            // pnlAlan
            // 
            pnlAlan.BackColor = SystemColors.AppWorkspace;
            pnlAlan.Controls.Add(ucAnasayfa1);
            pnlAlan.Dock = DockStyle.Fill;
            pnlAlan.ImeMode = ImeMode.NoControl;
            pnlAlan.Location = new Point(194, 40);
            pnlAlan.Name = "pnlAlan";
            pnlAlan.Size = new Size(1000, 520);
            pnlAlan.TabIndex = 4;
            // 
            // ucAnasayfa1
            // 
            ucAnasayfa1.BackgroundImageLayout = ImageLayout.Stretch;
            ucAnasayfa1.Location = new Point(0, 0);
            ucAnasayfa1.Name = "ucAnasayfa1";
            ucAnasayfa1.Size = new Size(1000, 520);
            ucAnasayfa1.TabIndex = 0;
            ucAnasayfa1.Visible = false;
            // 
            // tmrDate
            // 
            tmrDate.Interval = 1000;
            tmrDate.Tick += tmrDate_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1250, 650);
            Controls.Add(pnlAlan);
            Controls.Add(pnlRight);
            Controls.Add(pnlLeft);
            Controls.Add(pnlDown);
            Controls.Add(pnlUp);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hızlı Okuma Programı";
            Load += Form1_Load;
            pnlUp.ResumeLayout(false);
            pnlDown.ResumeLayout(false);
            pnlLeft.ResumeLayout(false);
            pnlAlan.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlUp;
        private Panel pnlDown;
        private Panel pnlLeft;
        private Button btnHomePage;
        private Button btnTest;
        private Button btnExercise3;
        private Button btnExercise2;
        private Button btnExercise1;
        private Button btnTeachers;
        private Button btnFastRead;
        private Button btnClose;
        private Button btnMin;
        private Panel pnlRight;
        private Panel pnlAlan;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label7;
        private System.Windows.Forms.Timer tmrDate;
        private Label lblDate;
        private Label lblTime;
        private Panel pnlActivePage;
        private ucAnasayfa ucAnasayfa1;
    }
}
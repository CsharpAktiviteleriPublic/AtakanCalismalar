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
            this.components = new System.ComponentModel.Container();
            this.pnlUp = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnHomePage = new System.Windows.Forms.Button();
            this.pnlDown = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlActivePage = new System.Windows.Forms.Panel();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnExercise3 = new System.Windows.Forms.Button();
            this.btnExercise2 = new System.Windows.Forms.Button();
            this.btnExercise1 = new System.Windows.Forms.Button();
            this.btnTeachers = new System.Windows.Forms.Button();
            this.btnFastRead = new System.Windows.Forms.Button();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlAlan = new System.Windows.Forms.Panel();
            this.tmrDate = new System.Windows.Forms.Timer(this.components);
            this.pnlUp.SuspendLayout();
            this.pnlDown.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUp
            // 
            this.pnlUp.BackColor = System.Drawing.Color.Black;
            this.pnlUp.Controls.Add(this.btnClose);
            this.pnlUp.Controls.Add(this.btnMin);
            this.pnlUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUp.Location = new System.Drawing.Point(0, 0);
            this.pnlUp.Name = "pnlUp";
            this.pnlUp.Size = new System.Drawing.Size(1250, 40);
            this.pnlUp.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.Cyan;
            this.btnClose.Image = global::WFA_HizliOkumaProgrami.Properties.Resources.CloseButton2;
            this.btnClose.Location = new System.Drawing.Point(1212, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnClose.Size = new System.Drawing.Size(33, 33);
            this.btnClose.TabIndex = 3;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.Transparent;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMin.ForeColor = System.Drawing.Color.Cyan;
            this.btnMin.Image = global::WFA_HizliOkumaProgrami.Properties.Resources.Minus;
            this.btnMin.Location = new System.Drawing.Point(1173, 3);
            this.btnMin.Name = "btnMin";
            this.btnMin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnMin.Size = new System.Drawing.Size(33, 33);
            this.btnMin.TabIndex = 3;
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnHomePage
            // 
            this.btnHomePage.FlatAppearance.BorderSize = 0;
            this.btnHomePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomePage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHomePage.ForeColor = System.Drawing.Color.Cyan;
            this.btnHomePage.Image = global::WFA_HizliOkumaProgrami.Properties.Resources.HomePageButton2;
            this.btnHomePage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHomePage.Location = new System.Drawing.Point(26, 21);
            this.btnHomePage.Name = "btnHomePage";
            this.btnHomePage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnHomePage.Size = new System.Drawing.Size(129, 33);
            this.btnHomePage.TabIndex = 3;
            this.btnHomePage.Text = "ANASAYFA";
            this.btnHomePage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHomePage.UseVisualStyleBackColor = true;
            this.btnHomePage.Click += new System.EventHandler(this.btnHomePage_Click);
            // 
            // pnlDown
            // 
            this.pnlDown.BackColor = System.Drawing.Color.Black;
            this.pnlDown.Controls.Add(this.lblDate);
            this.pnlDown.Controls.Add(this.lblTime);
            this.pnlDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDown.Location = new System.Drawing.Point(0, 560);
            this.pnlDown.Name = "pnlDown";
            this.pnlDown.Size = new System.Drawing.Size(1250, 90);
            this.pnlDown.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDate.Location = new System.Drawing.Point(1077, 44);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(161, 37);
            this.lblDate.TabIndex = 4;
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTime.Location = new System.Drawing.Point(1077, 3);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(161, 37);
            this.lblTime.TabIndex = 4;
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlLeft.Controls.Add(this.pnlActivePage);
            this.pnlLeft.Controls.Add(this.btnTest);
            this.pnlLeft.Controls.Add(this.btnExercise3);
            this.pnlLeft.Controls.Add(this.btnExercise2);
            this.pnlLeft.Controls.Add(this.btnExercise1);
            this.pnlLeft.Controls.Add(this.btnTeachers);
            this.pnlLeft.Controls.Add(this.btnFastRead);
            this.pnlLeft.Controls.Add(this.btnHomePage);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 40);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(194, 520);
            this.pnlLeft.TabIndex = 2;
            // 
            // pnlActivePage
            // 
            this.pnlActivePage.BackColor = System.Drawing.Color.LawnGreen;
            this.pnlActivePage.Location = new System.Drawing.Point(12, 21);
            this.pnlActivePage.Name = "pnlActivePage";
            this.pnlActivePage.Size = new System.Drawing.Size(10, 33);
            this.pnlActivePage.TabIndex = 4;
            // 
            // btnTest
            // 
            this.btnTest.FlatAppearance.BorderSize = 0;
            this.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTest.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTest.ForeColor = System.Drawing.Color.Cyan;
            this.btnTest.Image = global::WFA_HizliOkumaProgrami.Properties.Resources.HomePageButton2;
            this.btnTest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTest.Location = new System.Drawing.Point(26, 441);
            this.btnTest.Name = "btnTest";
            this.btnTest.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnTest.Size = new System.Drawing.Size(87, 33);
            this.btnTest.TabIndex = 3;
            this.btnTest.Text = "TEST";
            this.btnTest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnExercise3
            // 
            this.btnExercise3.FlatAppearance.BorderSize = 0;
            this.btnExercise3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExercise3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExercise3.ForeColor = System.Drawing.Color.Cyan;
            this.btnExercise3.Image = global::WFA_HizliOkumaProgrami.Properties.Resources.HomePageButton2;
            this.btnExercise3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExercise3.Location = new System.Drawing.Point(26, 371);
            this.btnExercise3.Name = "btnExercise3";
            this.btnExercise3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnExercise3.Size = new System.Drawing.Size(138, 33);
            this.btnExercise3.TabIndex = 3;
            this.btnExercise3.Text = "EGZERSİZ-3";
            this.btnExercise3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExercise3.UseVisualStyleBackColor = true;
            this.btnExercise3.Click += new System.EventHandler(this.btnExercise3_Click);
            // 
            // btnExercise2
            // 
            this.btnExercise2.FlatAppearance.BorderSize = 0;
            this.btnExercise2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExercise2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExercise2.ForeColor = System.Drawing.Color.Cyan;
            this.btnExercise2.Image = global::WFA_HizliOkumaProgrami.Properties.Resources.HomePageButton2;
            this.btnExercise2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExercise2.Location = new System.Drawing.Point(26, 301);
            this.btnExercise2.Name = "btnExercise2";
            this.btnExercise2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnExercise2.Size = new System.Drawing.Size(138, 33);
            this.btnExercise2.TabIndex = 3;
            this.btnExercise2.Text = "EGZERSİZ-2";
            this.btnExercise2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExercise2.UseVisualStyleBackColor = true;
            this.btnExercise2.Click += new System.EventHandler(this.btnExercise2_Click);
            // 
            // btnExercise1
            // 
            this.btnExercise1.FlatAppearance.BorderSize = 0;
            this.btnExercise1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExercise1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExercise1.ForeColor = System.Drawing.Color.Cyan;
            this.btnExercise1.Image = global::WFA_HizliOkumaProgrami.Properties.Resources.HomePageButton2;
            this.btnExercise1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExercise1.Location = new System.Drawing.Point(26, 231);
            this.btnExercise1.Name = "btnExercise1";
            this.btnExercise1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnExercise1.Size = new System.Drawing.Size(138, 33);
            this.btnExercise1.TabIndex = 3;
            this.btnExercise1.Text = "EGZERSİZ-1";
            this.btnExercise1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExercise1.UseVisualStyleBackColor = true;
            this.btnExercise1.Click += new System.EventHandler(this.btnExercise1_Click);
            // 
            // btnTeachers
            // 
            this.btnTeachers.FlatAppearance.BorderSize = 0;
            this.btnTeachers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeachers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTeachers.ForeColor = System.Drawing.Color.Cyan;
            this.btnTeachers.Image = global::WFA_HizliOkumaProgrami.Properties.Resources.HomePageButton2;
            this.btnTeachers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeachers.Location = new System.Drawing.Point(26, 161);
            this.btnTeachers.Name = "btnTeachers";
            this.btnTeachers.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnTeachers.Size = new System.Drawing.Size(165, 33);
            this.btnTeachers.TabIndex = 3;
            this.btnTeachers.Text = "OGRETMENLER";
            this.btnTeachers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTeachers.UseVisualStyleBackColor = true;
            this.btnTeachers.Click += new System.EventHandler(this.btnTeachers_Click);
            // 
            // btnFastRead
            // 
            this.btnFastRead.FlatAppearance.BorderSize = 0;
            this.btnFastRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFastRead.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFastRead.ForeColor = System.Drawing.Color.Cyan;
            this.btnFastRead.Image = global::WFA_HizliOkumaProgrami.Properties.Resources.HomePageButton2;
            this.btnFastRead.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFastRead.Location = new System.Drawing.Point(26, 91);
            this.btnFastRead.Name = "btnFastRead";
            this.btnFastRead.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnFastRead.Size = new System.Drawing.Size(154, 33);
            this.btnFastRead.TabIndex = 3;
            this.btnFastRead.Text = "HIZLI OKUMA";
            this.btnFastRead.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFastRead.UseVisualStyleBackColor = true;
            this.btnFastRead.Click += new System.EventHandler(this.btnFastRead_Click);
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(1194, 40);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(56, 520);
            this.pnlRight.TabIndex = 3;
            // 
            // pnlAlan
            // 
            this.pnlAlan.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlAlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAlan.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pnlAlan.Location = new System.Drawing.Point(194, 40);
            this.pnlAlan.Name = "pnlAlan";
            this.pnlAlan.Size = new System.Drawing.Size(1000, 520);
            this.pnlAlan.TabIndex = 4;
            // 
            // tmrDate
            // 
            this.tmrDate.Interval = 1000;
            this.tmrDate.Tick += new System.EventHandler(this.tmrDate_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 650);
            this.Controls.Add(this.pnlAlan);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlDown);
            this.Controls.Add(this.pnlUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hızlı Okuma Programı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlUp.ResumeLayout(false);
            this.pnlDown.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.ResumeLayout(false);

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
    }
}
namespace WFA_HizliOkumaProgrami.UserControls
{
    partial class ucExercise1
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tmrMoveBall = new System.Windows.Forms.Timer(this.components);
            this.tmrStopWatch = new System.Windows.Forms.Timer(this.components);
            this.pbBall = new System.Windows.Forms.PictureBox();
            this.pnlSpeedLevel = new System.Windows.Forms.Panel();
            this.rbtnProfessional = new System.Windows.Forms.RadioButton();
            this.rbtnHighLevel = new System.Windows.Forms.RadioButton();
            this.rbtnNormalLevel = new System.Windows.Forms.RadioButton();
            this.pnlBallArea = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbBall)).BeginInit();
            this.pnlSpeedLevel.SuspendLayout();
            this.pnlBallArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrMoveBall
            // 
            this.tmrMoveBall.Interval = 400;
            this.tmrMoveBall.Tick += new System.EventHandler(this.tmrMoveBall_Tick);
            // 
            // tmrStopWatch
            // 
            this.tmrStopWatch.Interval = 1000;
            this.tmrStopWatch.Tick += new System.EventHandler(this.tmrStopWatch_Tick);
            // 
            // pbBall
            // 
            this.pbBall.Image = global::WFA_HizliOkumaProgrami.Properties.Resources.Ball;
            this.pbBall.Location = new System.Drawing.Point(435, 98);
            this.pbBall.Name = "pbBall";
            this.pbBall.Size = new System.Drawing.Size(43, 44);
            this.pbBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBall.TabIndex = 0;
            this.pbBall.TabStop = false;
            this.pbBall.Visible = false;
            // 
            // pnlSpeedLevel
            // 
            this.pnlSpeedLevel.BackColor = System.Drawing.Color.Black;
            this.pnlSpeedLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSpeedLevel.Controls.Add(this.rbtnProfessional);
            this.pnlSpeedLevel.Controls.Add(this.rbtnHighLevel);
            this.pnlSpeedLevel.Controls.Add(this.rbtnNormalLevel);
            this.pnlSpeedLevel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSpeedLevel.ForeColor = System.Drawing.Color.Yellow;
            this.pnlSpeedLevel.Location = new System.Drawing.Point(0, 480);
            this.pnlSpeedLevel.Name = "pnlSpeedLevel";
            this.pnlSpeedLevel.Size = new System.Drawing.Size(1000, 40);
            this.pnlSpeedLevel.TabIndex = 1;
            // 
            // rbtnProfessional
            // 
            this.rbtnProfessional.AutoSize = true;
            this.rbtnProfessional.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtnProfessional.Location = new System.Drawing.Point(748, 3);
            this.rbtnProfessional.Name = "rbtnProfessional";
            this.rbtnProfessional.Size = new System.Drawing.Size(132, 32);
            this.rbtnProfessional.TabIndex = 0;
            this.rbtnProfessional.Text = "Profesyonel";
            this.rbtnProfessional.UseVisualStyleBackColor = true;
            // 
            // rbtnHighLevel
            // 
            this.rbtnHighLevel.AutoSize = true;
            this.rbtnHighLevel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtnHighLevel.Location = new System.Drawing.Point(425, 3);
            this.rbtnHighLevel.Name = "rbtnHighLevel";
            this.rbtnHighLevel.Size = new System.Drawing.Size(123, 32);
            this.rbtnHighLevel.TabIndex = 0;
            this.rbtnHighLevel.Text = "İleri Seviye";
            this.rbtnHighLevel.UseVisualStyleBackColor = true;
            // 
            // rbtnNormalLevel
            // 
            this.rbtnNormalLevel.AutoSize = true;
            this.rbtnNormalLevel.Checked = true;
            this.rbtnNormalLevel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtnNormalLevel.Location = new System.Drawing.Point(102, 3);
            this.rbtnNormalLevel.Name = "rbtnNormalLevel";
            this.rbtnNormalLevel.Size = new System.Drawing.Size(157, 32);
            this.rbtnNormalLevel.TabIndex = 0;
            this.rbtnNormalLevel.TabStop = true;
            this.rbtnNormalLevel.Text = "Normal Seviye";
            this.rbtnNormalLevel.UseVisualStyleBackColor = true;
            // 
            // pnlBallArea
            // 
            this.pnlBallArea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBallArea.Controls.Add(this.pbBall);
            this.pnlBallArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBallArea.Location = new System.Drawing.Point(0, 0);
            this.pnlBallArea.Name = "pnlBallArea";
            this.pnlBallArea.Size = new System.Drawing.Size(1000, 480);
            this.pnlBallArea.TabIndex = 2;
            // 
            // ucExercise1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlBallArea);
            this.Controls.Add(this.pnlSpeedLevel);
            this.Name = "ucExercise1";
            this.Size = new System.Drawing.Size(1000, 520);
            ((System.ComponentModel.ISupportInitialize)(this.pbBall)).EndInit();
            this.pnlSpeedLevel.ResumeLayout(false);
            this.pnlSpeedLevel.PerformLayout();
            this.pnlBallArea.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private PictureBox pbBall;
        private Panel pnlSpeedLevel;
        private RadioButton rbtnProfessional;
        private RadioButton rbtnHighLevel;
        private RadioButton rbtnNormalLevel;
        private Panel pnlBallArea;
        public System.Windows.Forms.Timer tmrStopWatch;
        public System.Windows.Forms.Timer tmrMoveBall;
    }
}

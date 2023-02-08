namespace MathGames
{
    partial class OyunEkrani
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblHosgeldinAdSoyad = new System.Windows.Forms.Label();
            this.lblSayacUc = new System.Windows.Forms.Label();
            this.tmrSayacUc = new System.Windows.Forms.Timer(this.components);
            this.lblNum2 = new System.Windows.Forms.Label();
            this.lblIslem = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.pbarSure = new System.Windows.Forms.ProgressBar();
            this.tmrSure = new System.Windows.Forms.Timer(this.components);
            this.lblAdOynuyor = new System.Windows.Forms.Label();
            this.tmrAdOynuyor = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHosgeldinAdSoyad
            // 
            this.lblHosgeldinAdSoyad.AutoSize = true;
            this.lblHosgeldinAdSoyad.Location = new System.Drawing.Point(1107, 13);
            this.lblHosgeldinAdSoyad.Name = "lblHosgeldinAdSoyad";
            this.lblHosgeldinAdSoyad.Size = new System.Drawing.Size(209, 25);
            this.lblHosgeldinAdSoyad.TabIndex = 0;
            this.lblHosgeldinAdSoyad.Text = "Hoşgeldin Ad Soyad";
            // 
            // lblSayacUc
            // 
            this.lblSayacUc.BackColor = System.Drawing.Color.Transparent;
            this.lblSayacUc.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayacUc.ForeColor = System.Drawing.Color.Red;
            this.lblSayacUc.Location = new System.Drawing.Point(12, 166);
            this.lblSayacUc.Name = "lblSayacUc";
            this.lblSayacUc.Size = new System.Drawing.Size(1304, 153);
            this.lblSayacUc.TabIndex = 1;
            this.lblSayacUc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrSayacUc
            // 
            this.tmrSayacUc.Interval = 1000;
            this.tmrSayacUc.Tick += new System.EventHandler(this.tmrSayacUc_Tick);
            // 
            // lblNum2
            // 
            this.lblNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNum2.Location = new System.Drawing.Point(151, 7);
            this.lblNum2.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(68, 48);
            this.lblNum2.TabIndex = 2;
            this.lblNum2.Text = "3";
            this.lblNum2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIslem
            // 
            this.lblIslem.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIslem.Location = new System.Drawing.Point(77, 7);
            this.lblIslem.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.lblIslem.Name = "lblIslem";
            this.lblIslem.Size = new System.Drawing.Size(68, 48);
            this.lblIslem.TabIndex = 2;
            this.lblIslem.Text = "+";
            this.lblIslem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(225, 7);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 48);
            this.label5.TabIndex = 2;
            this.label5.Text = "=";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNum1
            // 
            this.lblNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNum1.Location = new System.Drawing.Point(3, 7);
            this.lblNum1.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(68, 48);
            this.lblNum1.TabIndex = 2;
            this.lblNum1.Text = "5";
            this.lblNum1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.BackgroundImage = global::MathGames.Properties.Resources.black2;
            this.flowLayoutPanel1.Controls.Add(this.lblNum1);
            this.flowLayoutPanel1.Controls.Add(this.lblIslem);
            this.flowLayoutPanel1.Controls.Add(this.lblNum2);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.txtSonuc);
            this.flowLayoutPanel1.Controls.Add(this.pbarSure);
            this.flowLayoutPanel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(442, 166);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(417, 80);
            this.flowLayoutPanel1.TabIndex = 3;
            this.flowLayoutPanel1.Visible = false;
            // 
            // txtSonuc
            // 
            this.txtSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSonuc.Location = new System.Drawing.Point(299, 3);
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.Size = new System.Drawing.Size(114, 55);
            this.txtSonuc.TabIndex = 3;
            this.txtSonuc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSonuc_KeyPress);
            // 
            // pbarSure
            // 
            this.pbarSure.ForeColor = System.Drawing.Color.Black;
            this.pbarSure.Location = new System.Drawing.Point(3, 64);
            this.pbarSure.Maximum = 30;
            this.pbarSure.Name = "pbarSure";
            this.pbarSure.Size = new System.Drawing.Size(410, 16);
            this.pbarSure.TabIndex = 5;
            this.pbarSure.Value = 30;
            // 
            // tmrSure
            // 
            this.tmrSure.Interval = 1000;
            this.tmrSure.Tick += new System.EventHandler(this.tmrSure_Tick);
            // 
            // lblAdOynuyor
            // 
            this.lblAdOynuyor.BackColor = System.Drawing.Color.Transparent;
            this.lblAdOynuyor.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblAdOynuyor.Location = new System.Drawing.Point(437, 330);
            this.lblAdOynuyor.Name = "lblAdOynuyor";
            this.lblAdOynuyor.Size = new System.Drawing.Size(422, 67);
            this.lblAdOynuyor.TabIndex = 0;
            this.lblAdOynuyor.Text = "AD Oynuyor...";
            this.lblAdOynuyor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrAdOynuyor
            // 
            this.tmrAdOynuyor.Interval = 20;
            this.tmrAdOynuyor.Tick += new System.EventHandler(this.tmrAdOynuyor_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = global::MathGames.Properties.Resources.ezgif_com_rotate__2_;
            this.pictureBox2.Location = new System.Drawing.Point(1239, 166);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(90, 66);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::MathGames.Properties.Resources.ezgif_com_rotate__1_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 166);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 66);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // OyunEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1328, 683);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblAdOynuyor);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lblSayacUc);
            this.Controls.Add(this.lblHosgeldinAdSoyad);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OyunEkrani";
            this.Text = "Oyun Ekrani";
            this.Load += new System.EventHandler(this.OyunEkrani_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHosgeldinAdSoyad;
        private System.Windows.Forms.Label lblSayacUc;
        private System.Windows.Forms.Timer tmrSayacUc;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Label lblIslem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox txtSonuc;
        private System.Windows.Forms.ProgressBar pbarSure;
        private System.Windows.Forms.Timer tmrSure;
        private System.Windows.Forms.Label lblAdOynuyor;
        private System.Windows.Forms.Timer tmrAdOynuyor;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
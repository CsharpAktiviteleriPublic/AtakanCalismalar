namespace MathGames
{
    partial class KullaniciGiris
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.linkKayitOl = new System.Windows.Forms.LinkLabel();
            this.grpGiris = new System.Windows.Forms.GroupBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.lblWelcomeMessage = new System.Windows.Forms.Label();
            this.tmrWelcome = new System.Windows.Forms.Timer(this.components);
            this.tmrMoveGroupBox = new System.Windows.Forms.Timer(this.components);
            this.grpGiris.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(27, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şifre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(46, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(89, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 30);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(89, 74);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(176, 30);
            this.textBox2.TabIndex = 2;
            // 
            // linkKayitOl
            // 
            this.linkKayitOl.AutoSize = true;
            this.linkKayitOl.BackColor = System.Drawing.Color.Transparent;
            this.linkKayitOl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.linkKayitOl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkKayitOl.LinkColor = System.Drawing.Color.MediumSpringGreen;
            this.linkKayitOl.Location = new System.Drawing.Point(6, 136);
            this.linkKayitOl.Name = "linkKayitOl";
            this.linkKayitOl.Size = new System.Drawing.Size(89, 26);
            this.linkKayitOl.TabIndex = 4;
            this.linkKayitOl.TabStop = true;
            this.linkKayitOl.Text = "Kayıt OL";
            this.linkKayitOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkKayitOl_LinkClicked);
            // 
            // grpGiris
            // 
            this.grpGiris.BackColor = System.Drawing.Color.Transparent;
            this.grpGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.grpGiris.Controls.Add(this.btnGiris);
            this.grpGiris.Controls.Add(this.linkKayitOl);
            this.grpGiris.Controls.Add(this.textBox2);
            this.grpGiris.Controls.Add(this.textBox1);
            this.grpGiris.Controls.Add(this.label2);
            this.grpGiris.Controls.Add(this.label1);
            this.grpGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpGiris.ForeColor = System.Drawing.Color.White;
            this.grpGiris.Location = new System.Drawing.Point(309, 185);
            this.grpGiris.Name = "grpGiris";
            this.grpGiris.Size = new System.Drawing.Size(310, 161);
            this.grpGiris.TabIndex = 0;
            this.grpGiris.TabStop = false;
            this.grpGiris.Text = "Hesabınız yoksa kayıt olunuz!";
            this.grpGiris.Visible = false;
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.Black;
            this.btnGiris.Location = new System.Drawing.Point(143, 106);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(122, 29);
            this.btnGiris.TabIndex = 3;
            this.btnGiris.Text = "GİRİŞ YAP";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // lblWelcomeMessage
            // 
            this.lblWelcomeMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcomeMessage.ForeColor = System.Drawing.Color.YellowGreen;
            this.lblWelcomeMessage.Location = new System.Drawing.Point(26, 18);
            this.lblWelcomeMessage.Name = "lblWelcomeMessage";
            this.lblWelcomeMessage.Size = new System.Drawing.Size(870, 135);
            this.lblWelcomeMessage.TabIndex = 0;
            this.lblWelcomeMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tmrWelcome
            // 
            this.tmrWelcome.Interval = 20;
            this.tmrWelcome.Tick += new System.EventHandler(this.tmrWelcome_Tick);
            // 
            // tmrMoveGroupBox
            // 
            this.tmrMoveGroupBox.Interval = 1;
            this.tmrMoveGroupBox.Tick += new System.EventHandler(this.tmrMoveGroupBox_Tick);
            // 
            // KullaniciGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MathGames.Properties.Resources.black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(918, 358);
            this.Controls.Add(this.lblWelcomeMessage);
            this.Controls.Add(this.grpGiris);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "KullaniciGiris";
            this.Text = "Kullanıcı Giriş";
            this.Load += new System.EventHandler(this.KullaniciGiris_Load);
            this.grpGiris.ResumeLayout(false);
            this.grpGiris.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.LinkLabel linkKayitOl;
        private System.Windows.Forms.GroupBox grpGiris;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Label lblWelcomeMessage;
        private System.Windows.Forms.Timer tmrWelcome;
        private System.Windows.Forms.Timer tmrMoveGroupBox;
    }
}


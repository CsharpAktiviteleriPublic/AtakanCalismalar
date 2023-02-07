namespace MathGames
{
    partial class KullaniciKayit
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
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnKayitOl = new System.Windows.Forms.Button();
            this.tmrLabelYanipSönme = new System.Windows.Forms.Timer(this.components);
            this.tmrHarfRenk = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAnaSayfayaDon = new System.Windows.Forms.Button();
            this.pnlAdSoyadIdSifre = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlAdSoyadIdSifre.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(55, 3);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(63, 20);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "Adınız:";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(27, 45);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(91, 20);
            this.lblSoyad.TabIndex = 0;
            this.lblSoyad.Text = "Soyadınız:";
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(7, 86);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(111, 20);
            this.lblKullaniciAdi.TabIndex = 0;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(66, 128);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(52, 20);
            this.lblSifre.TabIndex = 0;
            this.lblSifre.Text = "Şifre:";
            // 
            // txtAd
            // 
            this.txtAd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtAd.Location = new System.Drawing.Point(207, 18);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(205, 26);
            this.txtAd.TabIndex = 1;
            // 
            // txtSoyad
            // 
            this.txtSoyad.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtSoyad.Location = new System.Drawing.Point(207, 59);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(205, 26);
            this.txtSoyad.TabIndex = 1;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtKullaniciAdi.Location = new System.Drawing.Point(207, 100);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(205, 26);
            this.txtKullaniciAdi.TabIndex = 1;
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtSifre.Location = new System.Drawing.Point(207, 141);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(205, 26);
            this.txtSifre.TabIndex = 1;
            // 
            // btnKayitOl
            // 
            this.btnKayitOl.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnKayitOl.Location = new System.Drawing.Point(207, 177);
            this.btnKayitOl.Name = "btnKayitOl";
            this.btnKayitOl.Size = new System.Drawing.Size(205, 38);
            this.btnKayitOl.TabIndex = 3;
            this.btnKayitOl.Text = "Kayıt Ol";
            this.btnKayitOl.UseVisualStyleBackColor = false;
            // 
            // tmrLabelYanipSönme
            // 
            this.tmrLabelYanipSönme.Interval = 300;
            this.tmrLabelYanipSönme.Tick += new System.EventHandler(this.tmrLabelYanipSönme_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = global::MathGames.Properties.Resources.ezgif_com_rotate__2_;
            this.pictureBox2.Location = new System.Drawing.Point(482, 55);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 70);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::MathGames.Properties.Resources.ezgif_com_rotate__1_;
            this.pictureBox1.Location = new System.Drawing.Point(-6, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 70);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnAnaSayfayaDon
            // 
            this.btnAnaSayfayaDon.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAnaSayfayaDon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAnaSayfayaDon.Location = new System.Drawing.Point(0, 247);
            this.btnAnaSayfayaDon.Name = "btnAnaSayfayaDon";
            this.btnAnaSayfayaDon.Size = new System.Drawing.Size(562, 30);
            this.btnAnaSayfayaDon.TabIndex = 3;
            this.btnAnaSayfayaDon.Text = "ANA SAYFAYA DÖN";
            this.btnAnaSayfayaDon.UseVisualStyleBackColor = false;
            this.btnAnaSayfayaDon.Click += new System.EventHandler(this.btnAnaSayfayaDon_Click);
            // 
            // pnlAdSoyadIdSifre
            // 
            this.pnlAdSoyadIdSifre.Controls.Add(this.lblAd);
            this.pnlAdSoyadIdSifre.Controls.Add(this.lblSoyad);
            this.pnlAdSoyadIdSifre.Controls.Add(this.lblKullaniciAdi);
            this.pnlAdSoyadIdSifre.Controls.Add(this.lblSifre);
            this.pnlAdSoyadIdSifre.ForeColor = System.Drawing.Color.White;
            this.pnlAdSoyadIdSifre.Location = new System.Drawing.Point(80, 18);
            this.pnlAdSoyadIdSifre.Name = "pnlAdSoyadIdSifre";
            this.pnlAdSoyadIdSifre.Size = new System.Drawing.Size(121, 149);
            this.pnlAdSoyadIdSifre.TabIndex = 6;
            // 
            // KullaniciKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(562, 277);
            this.Controls.Add(this.pnlAdSoyadIdSifre);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAnaSayfayaDon);
            this.Controls.Add(this.btnKayitOl);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "KullaniciKayit";
            this.Text = "Kullanici Kayit";
            this.Load += new System.EventHandler(this.KullaniciKayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlAdSoyadIdSifre.ResumeLayout(false);
            this.pnlAdSoyadIdSifre.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnKayitOl;
        private System.Windows.Forms.Timer tmrLabelYanipSönme;
        private System.Windows.Forms.Timer tmrHarfRenk;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnAnaSayfayaDon;
        private System.Windows.Forms.Panel pnlAdSoyadIdSifre;
    }
}
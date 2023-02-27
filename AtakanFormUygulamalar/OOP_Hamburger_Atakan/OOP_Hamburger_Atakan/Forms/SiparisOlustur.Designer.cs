namespace OOP_Hamburger_Atakan
{
    partial class SiparisOlustur
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbMenuler = new System.Windows.Forms.ComboBox();
            this.rbtnKucuk = new System.Windows.Forms.RadioButton();
            this.rbtnOrta = new System.Windows.Forms.RadioButton();
            this.rbtnBuyuk = new System.Windows.Forms.RadioButton();
            this.grpHamburgerBoyut = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSiparisEkle = new System.Windows.Forms.Button();
            this.numAdet = new System.Windows.Forms.NumericUpDown();
            this.pbHamburger = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.lstSiparisler = new System.Windows.Forms.ListBox();
            this.btnSiparisiTamamla = new System.Windows.Forms.Button();
            this.flpEkstraMalzemeler = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.grpHamburgerBoyut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHamburger)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 238);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "MENÜ SEÇİN";
            // 
            // cbMenuler
            // 
            this.cbMenuler.BackColor = System.Drawing.SystemColors.Info;
            this.cbMenuler.FormattingEnabled = true;
            this.cbMenuler.Location = new System.Drawing.Point(12, 261);
            this.cbMenuler.Name = "cbMenuler";
            this.cbMenuler.Size = new System.Drawing.Size(342, 28);
            this.cbMenuler.Sorted = true;
            this.cbMenuler.TabIndex = 2;
            this.cbMenuler.SelectedIndexChanged += new System.EventHandler(this.SiparisTutariAl);
            this.cbMenuler.Click += new System.EventHandler(this.cbMenuler_Click);
            // 
            // rbtnKucuk
            // 
            this.rbtnKucuk.AutoSize = true;
            this.rbtnKucuk.Checked = true;
            this.rbtnKucuk.Location = new System.Drawing.Point(16, 25);
            this.rbtnKucuk.Name = "rbtnKucuk";
            this.rbtnKucuk.Size = new System.Drawing.Size(76, 24);
            this.rbtnKucuk.TabIndex = 3;
            this.rbtnKucuk.TabStop = true;
            this.rbtnKucuk.Text = "Kucuk";
            this.rbtnKucuk.UseVisualStyleBackColor = true;
            this.rbtnKucuk.CheckedChanged += new System.EventHandler(this.SiparisTutariAl);
            // 
            // rbtnOrta
            // 
            this.rbtnOrta.AutoSize = true;
            this.rbtnOrta.Location = new System.Drawing.Point(117, 25);
            this.rbtnOrta.Name = "rbtnOrta";
            this.rbtnOrta.Size = new System.Drawing.Size(62, 24);
            this.rbtnOrta.TabIndex = 3;
            this.rbtnOrta.TabStop = true;
            this.rbtnOrta.Text = "Orta";
            this.rbtnOrta.UseVisualStyleBackColor = true;
            this.rbtnOrta.CheckedChanged += new System.EventHandler(this.SiparisTutariAl);
            // 
            // rbtnBuyuk
            // 
            this.rbtnBuyuk.AutoSize = true;
            this.rbtnBuyuk.Location = new System.Drawing.Point(199, 25);
            this.rbtnBuyuk.Name = "rbtnBuyuk";
            this.rbtnBuyuk.Size = new System.Drawing.Size(76, 24);
            this.rbtnBuyuk.TabIndex = 3;
            this.rbtnBuyuk.TabStop = true;
            this.rbtnBuyuk.Text = "Buyuk";
            this.rbtnBuyuk.UseVisualStyleBackColor = true;
            this.rbtnBuyuk.CheckedChanged += new System.EventHandler(this.SiparisTutariAl);
            // 
            // grpHamburgerBoyut
            // 
            this.grpHamburgerBoyut.BackColor = System.Drawing.Color.Transparent;
            this.grpHamburgerBoyut.Controls.Add(this.rbtnKucuk);
            this.grpHamburgerBoyut.Controls.Add(this.rbtnBuyuk);
            this.grpHamburgerBoyut.Controls.Add(this.rbtnOrta);
            this.grpHamburgerBoyut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grpHamburgerBoyut.Location = new System.Drawing.Point(12, 302);
            this.grpHamburgerBoyut.Name = "grpHamburgerBoyut";
            this.grpHamburgerBoyut.Size = new System.Drawing.Size(342, 60);
            this.grpHamburgerBoyut.TabIndex = 4;
            this.grpHamburgerBoyut.TabStop = false;
            this.grpHamburgerBoyut.Text = "BOYUT SEÇİNİZ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 531);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "ADET";
            // 
            // btnSiparisEkle
            // 
            this.btnSiparisEkle.Location = new System.Drawing.Point(208, 525);
            this.btnSiparisEkle.Name = "btnSiparisEkle";
            this.btnSiparisEkle.Size = new System.Drawing.Size(146, 33);
            this.btnSiparisEkle.TabIndex = 7;
            this.btnSiparisEkle.Text = "SİPARİŞ EKLE";
            this.btnSiparisEkle.UseVisualStyleBackColor = true;
            this.btnSiparisEkle.Click += new System.EventHandler(this.btnSiparisEkle_Click);
            // 
            // numAdet
            // 
            this.numAdet.Location = new System.Drawing.Point(82, 529);
            this.numAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAdet.Name = "numAdet";
            this.numAdet.Size = new System.Drawing.Size(120, 26);
            this.numAdet.TabIndex = 8;
            this.numAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAdet.ValueChanged += new System.EventHandler(this.SiparisTutariAl);
            // 
            // pbHamburger
            // 
            this.pbHamburger.Image = global::OOP_Hamburger_Atakan.Properties.Resources.hamburger1;
            this.pbHamburger.Location = new System.Drawing.Point(12, 18);
            this.pbHamburger.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbHamburger.Name = "pbHamburger";
            this.pbHamburger.Size = new System.Drawing.Size(342, 207);
            this.pbHamburger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHamburger.TabIndex = 0;
            this.pbHamburger.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(386, 515);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "TOPLAM TUTAR : ";
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(538, 515);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "₺";
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.ForeColor = System.Drawing.Color.Red;
            this.lblToplamTutar.Location = new System.Drawing.Point(551, 515);
            this.lblToplamTutar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(45, 20);
            this.lblToplamTutar.TabIndex = 1;
            this.lblToplamTutar.Text = "0";
            // 
            // lstSiparisler
            // 
            this.lstSiparisler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstSiparisler.FormattingEnabled = true;
            this.lstSiparisler.HorizontalScrollbar = true;
            this.lstSiparisler.ItemHeight = 16;
            this.lstSiparisler.Location = new System.Drawing.Point(361, 14);
            this.lstSiparisler.Name = "lstSiparisler";
            this.lstSiparisler.Size = new System.Drawing.Size(471, 484);
            this.lstSiparisler.TabIndex = 9;
            // 
            // btnSiparisiTamamla
            // 
            this.btnSiparisiTamamla.Enabled = false;
            this.btnSiparisiTamamla.Location = new System.Drawing.Point(628, 506);
            this.btnSiparisiTamamla.Name = "btnSiparisiTamamla";
            this.btnSiparisiTamamla.Size = new System.Drawing.Size(202, 38);
            this.btnSiparisiTamamla.TabIndex = 7;
            this.btnSiparisiTamamla.Text = "SİPARİŞİ TAMAMLA";
            this.btnSiparisiTamamla.UseVisualStyleBackColor = true;
            this.btnSiparisiTamamla.Click += new System.EventHandler(this.btnSiparisiTamamla_Click);
            // 
            // flpEkstraMalzemeler
            // 
            this.flpEkstraMalzemeler.AutoScroll = true;
            this.flpEkstraMalzemeler.BackColor = System.Drawing.Color.White;
            this.flpEkstraMalzemeler.Location = new System.Drawing.Point(12, 402);
            this.flpEkstraMalzemeler.Name = "flpEkstraMalzemeler";
            this.flpEkstraMalzemeler.Padding = new System.Windows.Forms.Padding(10);
            this.flpEkstraMalzemeler.Size = new System.Drawing.Size(342, 117);
            this.flpEkstraMalzemeler.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(29, 379);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "EKSTRA MALZEME SEÇİN";
            // 
            // SiparisOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 631);
            this.Controls.Add(this.flpEkstraMalzemeler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstSiparisler);
            this.Controls.Add(this.numAdet);
            this.Controls.Add(this.btnSiparisiTamamla);
            this.Controls.Add(this.btnSiparisEkle);
            this.Controls.Add(this.grpHamburgerBoyut);
            this.Controls.Add(this.cbMenuler);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbHamburger);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SiparisOlustur";
            this.Text = "SiparisOlustur";
            this.Load += new System.EventHandler(this.SiparisOlustur_Load);
            this.grpHamburgerBoyut.ResumeLayout(false);
            this.grpHamburgerBoyut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHamburger)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbHamburger;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnKucuk;
        private System.Windows.Forms.RadioButton rbtnOrta;
        private System.Windows.Forms.RadioButton rbtnBuyuk;
        private System.Windows.Forms.GroupBox grpHamburgerBoyut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSiparisEkle;
        private System.Windows.Forms.NumericUpDown numAdet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.ListBox lstSiparisler;
        private System.Windows.Forms.Button btnSiparisiTamamla;
        internal System.Windows.Forms.ComboBox cbMenuler;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.FlowLayoutPanel flpEkstraMalzemeler;
    }
}
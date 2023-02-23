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
            this.chcKetcap = new System.Windows.Forms.CheckBox();
            this.chcHardal = new System.Windows.Forms.CheckBox();
            this.chcMayonez = new System.Windows.Forms.CheckBox();
            this.chcBBQ = new System.Windows.Forms.CheckBox();
            this.chcRanch = new System.Windows.Forms.CheckBox();
            this.chcBuffalo = new System.Windows.Forms.CheckBox();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpHamburgerBoyut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHamburger)).BeginInit();
            this.flpEkstraMalzemeler.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.cbMenuler.TabIndex = 2;
            this.cbMenuler.SelectedIndexChanged += new System.EventHandler(this.SiparisTutariAl);
            this.cbMenuler.Click += new System.EventHandler(this.cbMenuler_Click);
            // 
            // rbtnKucuk
            // 
            this.rbtnKucuk.AutoSize = true;
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
            // chcKetcap
            // 
            this.chcKetcap.AutoSize = true;
            this.chcKetcap.Location = new System.Drawing.Point(15, 15);
            this.chcKetcap.Margin = new System.Windows.Forms.Padding(5);
            this.chcKetcap.Name = "chcKetcap";
            this.chcKetcap.Size = new System.Drawing.Size(84, 24);
            this.chcKetcap.TabIndex = 5;
            this.chcKetcap.Text = "Ketcap";
            this.chcKetcap.UseVisualStyleBackColor = true;
            this.chcKetcap.CheckedChanged += new System.EventHandler(this.SiparisTutariAl);
            // 
            // chcHardal
            // 
            this.chcHardal.AutoSize = true;
            this.chcHardal.Location = new System.Drawing.Point(109, 15);
            this.chcHardal.Margin = new System.Windows.Forms.Padding(5);
            this.chcHardal.Name = "chcHardal";
            this.chcHardal.Size = new System.Drawing.Size(81, 24);
            this.chcHardal.TabIndex = 5;
            this.chcHardal.Text = "Hardal";
            this.chcHardal.UseVisualStyleBackColor = true;
            this.chcHardal.CheckedChanged += new System.EventHandler(this.SiparisTutariAl);
            // 
            // chcMayonez
            // 
            this.chcMayonez.AutoSize = true;
            this.chcMayonez.Location = new System.Drawing.Point(200, 15);
            this.chcMayonez.Margin = new System.Windows.Forms.Padding(5);
            this.chcMayonez.Name = "chcMayonez";
            this.chcMayonez.Size = new System.Drawing.Size(99, 24);
            this.chcMayonez.TabIndex = 5;
            this.chcMayonez.Text = "Mayonez";
            this.chcMayonez.UseVisualStyleBackColor = true;
            this.chcMayonez.CheckedChanged += new System.EventHandler(this.SiparisTutariAl);
            // 
            // chcBBQ
            // 
            this.chcBBQ.AutoSize = true;
            this.chcBBQ.Location = new System.Drawing.Point(15, 49);
            this.chcBBQ.Margin = new System.Windows.Forms.Padding(5);
            this.chcBBQ.Name = "chcBBQ";
            this.chcBBQ.Size = new System.Drawing.Size(65, 24);
            this.chcBBQ.TabIndex = 5;
            this.chcBBQ.Text = "BBQ";
            this.chcBBQ.UseVisualStyleBackColor = true;
            this.chcBBQ.CheckedChanged += new System.EventHandler(this.SiparisTutariAl);
            // 
            // chcRanch
            // 
            this.chcRanch.AutoSize = true;
            this.chcRanch.Location = new System.Drawing.Point(90, 49);
            this.chcRanch.Margin = new System.Windows.Forms.Padding(5);
            this.chcRanch.Name = "chcRanch";
            this.chcRanch.Size = new System.Drawing.Size(80, 24);
            this.chcRanch.TabIndex = 5;
            this.chcRanch.Text = "Ranch";
            this.chcRanch.UseVisualStyleBackColor = true;
            this.chcRanch.CheckedChanged += new System.EventHandler(this.SiparisTutariAl);
            // 
            // chcBuffalo
            // 
            this.chcBuffalo.AutoSize = true;
            this.chcBuffalo.Location = new System.Drawing.Point(180, 49);
            this.chcBuffalo.Margin = new System.Windows.Forms.Padding(5);
            this.chcBuffalo.Name = "chcBuffalo";
            this.chcBuffalo.Size = new System.Drawing.Size(86, 24);
            this.chcBuffalo.TabIndex = 5;
            this.chcBuffalo.Text = "Buffalo";
            this.chcBuffalo.UseVisualStyleBackColor = true;
            this.chcBuffalo.CheckedChanged += new System.EventHandler(this.SiparisTutariAl);
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
            this.lblToplamTutar.Text = "3,32";
            // 
            // lstSiparisler
            // 
            this.lstSiparisler.FormattingEnabled = true;
            this.lstSiparisler.ItemHeight = 20;
            this.lstSiparisler.Location = new System.Drawing.Point(361, 14);
            this.lstSiparisler.Name = "lstSiparisler";
            this.lstSiparisler.Size = new System.Drawing.Size(471, 484);
            this.lstSiparisler.TabIndex = 9;
            // 
            // btnSiparisiTamamla
            // 
            this.btnSiparisiTamamla.Location = new System.Drawing.Point(613, 506);
            this.btnSiparisiTamamla.Name = "btnSiparisiTamamla";
            this.btnSiparisiTamamla.Size = new System.Drawing.Size(217, 38);
            this.btnSiparisiTamamla.TabIndex = 7;
            this.btnSiparisiTamamla.Text = "SİPARİŞİ TAMAMLA";
            this.btnSiparisiTamamla.UseVisualStyleBackColor = true;
            // 
            // flpEkstraMalzemeler
            // 
            this.flpEkstraMalzemeler.BackColor = System.Drawing.Color.White;
            this.flpEkstraMalzemeler.Controls.Add(this.chcKetcap);
            this.flpEkstraMalzemeler.Controls.Add(this.chcHardal);
            this.flpEkstraMalzemeler.Controls.Add(this.chcMayonez);
            this.flpEkstraMalzemeler.Controls.Add(this.chcBBQ);
            this.flpEkstraMalzemeler.Controls.Add(this.chcRanch);
            this.flpEkstraMalzemeler.Controls.Add(this.chcBuffalo);
            this.flpEkstraMalzemeler.Location = new System.Drawing.Point(14, 28);
            this.flpEkstraMalzemeler.Name = "flpEkstraMalzemeler";
            this.flpEkstraMalzemeler.Padding = new System.Windows.Forms.Padding(10);
            this.flpEkstraMalzemeler.Size = new System.Drawing.Size(319, 117);
            this.flpEkstraMalzemeler.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(15, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "EKSTRA MALZEME SEÇİN";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.flpEkstraMalzemeler);
            this.panel1.Controls.Add(this.label2);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(12, 368);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 151);
            this.panel1.TabIndex = 11;
            // 
            // SiparisOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 631);
            this.Controls.Add(this.panel1);
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
            this.flpEkstraMalzemeler.ResumeLayout(false);
            this.flpEkstraMalzemeler.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.CheckBox chcKetcap;
        private System.Windows.Forms.CheckBox chcHardal;
        private System.Windows.Forms.CheckBox chcMayonez;
        private System.Windows.Forms.CheckBox chcBBQ;
        private System.Windows.Forms.CheckBox chcRanch;
        private System.Windows.Forms.CheckBox chcBuffalo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSiparisEkle;
        private System.Windows.Forms.NumericUpDown numAdet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.ListBox lstSiparisler;
        private System.Windows.Forms.Button btnSiparisiTamamla;
        internal System.Windows.Forms.ComboBox cbMenuler;
        private System.Windows.Forms.FlowLayoutPanel flpEkstraMalzemeler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}
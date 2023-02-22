namespace OOP_Hamburger_Atakan
{
    partial class EkstraMalzemeEkle
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
            this.grpMalzemeBilgileri = new System.Windows.Forms.GroupBox();
            this.btnMalzemeEkle = new System.Windows.Forms.Button();
            this.numFiyat = new System.Windows.Forms.NumericUpDown();
            this.txtEkstraMalzemeAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpMalzemeBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMalzemeBilgileri
            // 
            this.grpMalzemeBilgileri.Controls.Add(this.btnMalzemeEkle);
            this.grpMalzemeBilgileri.Controls.Add(this.numFiyat);
            this.grpMalzemeBilgileri.Controls.Add(this.txtEkstraMalzemeAdi);
            this.grpMalzemeBilgileri.Controls.Add(this.label4);
            this.grpMalzemeBilgileri.Controls.Add(this.label3);
            this.grpMalzemeBilgileri.Controls.Add(this.label2);
            this.grpMalzemeBilgileri.Controls.Add(this.label1);
            this.grpMalzemeBilgileri.Location = new System.Drawing.Point(14, 23);
            this.grpMalzemeBilgileri.Name = "grpMalzemeBilgileri";
            this.grpMalzemeBilgileri.Size = new System.Drawing.Size(381, 160);
            this.grpMalzemeBilgileri.TabIndex = 3;
            this.grpMalzemeBilgileri.TabStop = false;
            this.grpMalzemeBilgileri.Text = "EKSTRA MALZEME BİLGİLERİ";
            // 
            // btnMalzemeEkle
            // 
            this.btnMalzemeEkle.Location = new System.Drawing.Point(215, 108);
            this.btnMalzemeEkle.Name = "btnMalzemeEkle";
            this.btnMalzemeEkle.Size = new System.Drawing.Size(152, 46);
            this.btnMalzemeEkle.TabIndex = 4;
            this.btnMalzemeEkle.Text = "MALZEME EKLE";
            this.btnMalzemeEkle.UseVisualStyleBackColor = true;
            this.btnMalzemeEkle.Click += new System.EventHandler(this.btnMalzemeEkle_Click);
            // 
            // numFiyat
            // 
            this.numFiyat.Location = new System.Drawing.Point(215, 76);
            this.numFiyat.Name = "numFiyat";
            this.numFiyat.Size = new System.Drawing.Size(152, 26);
            this.numFiyat.TabIndex = 3;
            // 
            // txtEkstraMalzemeAdi
            // 
            this.txtEkstraMalzemeAdi.Location = new System.Drawing.Point(215, 36);
            this.txtEkstraMalzemeAdi.Name = "txtEkstraMalzemeAdi";
            this.txtEkstraMalzemeAdi.Size = new System.Drawing.Size(152, 26);
            this.txtEkstraMalzemeAdi.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fiyatı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ekstra Malzeme Adı";
            // 
            // EkstraMalzemeEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 208);
            this.Controls.Add(this.grpMalzemeBilgileri);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EkstraMalzemeEkle";
            this.Text = "EkstraMalzemeEkle";
            this.grpMalzemeBilgileri.ResumeLayout(false);
            this.grpMalzemeBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFiyat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMalzemeBilgileri;
        private System.Windows.Forms.Button btnMalzemeEkle;
        private System.Windows.Forms.NumericUpDown numFiyat;
        private System.Windows.Forms.TextBox txtEkstraMalzemeAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
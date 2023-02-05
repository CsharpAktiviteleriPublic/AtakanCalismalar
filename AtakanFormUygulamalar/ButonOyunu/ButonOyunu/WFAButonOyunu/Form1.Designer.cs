namespace WFAButonOyunu
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flpButonlar = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBasla = new System.Windows.Forms.Button();
            this.txtPlayer1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKurallar = new System.Windows.Forms.TextBox();
            this.lblKurallar = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPlayer2 = new System.Windows.Forms.TextBox();
            this.lstSonuc = new System.Windows.Forms.ListBox();
            this.lblOynayanBilgisi = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.grpKurallar = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tmrRenk = new System.Windows.Forms.Timer(this.components);
            this.lblSonuc1 = new System.Windows.Forms.Label();
            this.lblSonuc2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grpKurallar.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpButonlar
            // 
            this.flpButonlar.BackColor = System.Drawing.Color.White;
            this.flpButonlar.Location = new System.Drawing.Point(25, 176);
            this.flpButonlar.Name = "flpButonlar";
            this.flpButonlar.Size = new System.Drawing.Size(284, 223);
            this.flpButonlar.TabIndex = 0;
            // 
            // btnBasla
            // 
            this.btnBasla.BackColor = System.Drawing.Color.Silver;
            this.btnBasla.Location = new System.Drawing.Point(10, 92);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(290, 35);
            this.btnBasla.TabIndex = 1;
            this.btnBasla.Text = "Başla";
            this.btnBasla.UseVisualStyleBackColor = false;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // txtPlayer1
            // 
            this.txtPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPlayer1.Location = new System.Drawing.Point(121, 22);
            this.txtPlayer1.Name = "txtPlayer1";
            this.txtPlayer1.Size = new System.Drawing.Size(179, 23);
            this.txtPlayer1.TabIndex = 2;
            this.txtPlayer1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Oyuncu1 Adı:";
            // 
            // txtKurallar
            // 
            this.txtKurallar.BackColor = System.Drawing.Color.White;
            this.txtKurallar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKurallar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKurallar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtKurallar.Location = new System.Drawing.Point(0, 0);
            this.txtKurallar.Multiline = true;
            this.txtKurallar.Name = "txtKurallar";
            this.txtKurallar.Size = new System.Drawing.Size(183, 362);
            this.txtKurallar.TabIndex = 5;
            this.txtKurallar.Text = "\r\n\r\n\r\n1 PUAN KAZANDIRIR \r\n\r\n\r\n\r\n\r\n1 PUAN KAYBETTİRİR\r\n\r\n\r\n\r\n\r\nOYUN BİTER,PUAN YAZ" +
    "ILIR\r\n\r\n\r\n";
            this.txtKurallar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblKurallar
            // 
            this.lblKurallar.BackColor = System.Drawing.Color.Silver;
            this.lblKurallar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblKurallar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKurallar.Location = new System.Drawing.Point(345, 9);
            this.lblKurallar.Name = "lblKurallar";
            this.lblKurallar.Size = new System.Drawing.Size(257, 25);
            this.lblKurallar.TabIndex = 6;
            this.lblKurallar.Text = "Kurallar için farenizi üstüne getiriniz";
            this.lblKurallar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblKurallar.MouseEnter += new System.EventHandler(this.lblKurallar_MouseEnter);
            this.lblKurallar.MouseLeave += new System.EventHandler(this.lblKurallar_MouseLeave);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPlayer2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPlayer1);
            this.groupBox1.Controls.Add(this.btnBasla);
            this.groupBox1.Location = new System.Drawing.Point(9, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 133);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(6, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Oyuncu2 Adı:";
            // 
            // txtPlayer2
            // 
            this.txtPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPlayer2.Location = new System.Drawing.Point(121, 58);
            this.txtPlayer2.Name = "txtPlayer2";
            this.txtPlayer2.Size = new System.Drawing.Size(179, 23);
            this.txtPlayer2.TabIndex = 2;
            this.txtPlayer2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lstSonuc
            // 
            this.lstSonuc.FormattingEnabled = true;
            this.lstSonuc.ItemHeight = 20;
            this.lstSonuc.Location = new System.Drawing.Point(345, 35);
            this.lstSonuc.Name = "lstSonuc";
            this.lstSonuc.Size = new System.Drawing.Size(257, 364);
            this.lstSonuc.TabIndex = 8;
            // 
            // lblOynayanBilgisi
            // 
            this.lblOynayanBilgisi.BackColor = System.Drawing.Color.Transparent;
            this.lblOynayanBilgisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOynayanBilgisi.Location = new System.Drawing.Point(93, 151);
            this.lblOynayanBilgisi.Name = "lblOynayanBilgisi";
            this.lblOynayanBilgisi.Size = new System.Drawing.Size(175, 22);
            this.lblOynayanBilgisi.TabIndex = 12;
            this.lblOynayanBilgisi.Text = "Atakan oynuyor...";
            this.lblOynayanBilgisi.Visible = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.White;
            this.button10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button10.BackgroundImage")));
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button10.Location = new System.Drawing.Point(39, 85);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(96, 67);
            this.button10.TabIndex = 6;
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.White;
            this.button12.BackgroundImage = global::WFAButonOyunu.Properties.Resources.bomba;
            this.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button12.Location = new System.Drawing.Point(39, 279);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(96, 67);
            this.button12.TabIndex = 6;
            this.button12.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.White;
            this.button11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button11.BackgroundImage")));
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button11.Location = new System.Drawing.Point(39, 184);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(96, 67);
            this.button11.TabIndex = 6;
            this.button11.UseVisualStyleBackColor = false;
            // 
            // grpKurallar
            // 
            this.grpKurallar.BackColor = System.Drawing.Color.White;
            this.grpKurallar.Controls.Add(this.label2);
            this.grpKurallar.Controls.Add(this.button10);
            this.grpKurallar.Controls.Add(this.button12);
            this.grpKurallar.Controls.Add(this.button11);
            this.grpKurallar.Controls.Add(this.txtKurallar);
            this.grpKurallar.Location = new System.Drawing.Point(608, 9);
            this.grpKurallar.Name = "grpKurallar";
            this.grpKurallar.Size = new System.Drawing.Size(186, 390);
            this.grpKurallar.TabIndex = 13;
            this.grpKurallar.TabStop = false;
            this.grpKurallar.Text = "groupBox2";
            this.grpKurallar.Visible = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 53);
            this.label2.TabIndex = 7;
            this.label2.Text = "Bomba 1 adet diğerleri rastgele oluşmaktadır.";
            // 
            // lblSonuc1
            // 
            this.lblSonuc1.AutoSize = true;
            this.lblSonuc1.BackColor = System.Drawing.Color.Transparent;
            this.lblSonuc1.Location = new System.Drawing.Point(315, 34);
            this.lblSonuc1.Name = "lblSonuc1";
            this.lblSonuc1.Size = new System.Drawing.Size(19, 20);
            this.lblSonuc1.TabIndex = 14;
            this.lblSonuc1.Text = "0";
            // 
            // lblSonuc2
            // 
            this.lblSonuc2.AutoSize = true;
            this.lblSonuc2.BackColor = System.Drawing.Color.Transparent;
            this.lblSonuc2.Location = new System.Drawing.Point(315, 70);
            this.lblSonuc2.Name = "lblSonuc2";
            this.lblSonuc2.Size = new System.Drawing.Size(19, 20);
            this.lblSonuc2.TabIndex = 14;
            this.lblSonuc2.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.BackgroundImage = global::WFAButonOyunu.Properties.Resources.white_shadow;
            this.ClientSize = new System.Drawing.Size(802, 408);
            this.Controls.Add(this.lblSonuc2);
            this.Controls.Add(this.lblSonuc1);
            this.Controls.Add(this.grpKurallar);
            this.Controls.Add(this.lblOynayanBilgisi);
            this.Controls.Add(this.lstSonuc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblKurallar);
            this.Controls.Add(this.flpButonlar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Bir Bire Oyunu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpKurallar.ResumeLayout(false);
            this.grpKurallar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpButonlar;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.TextBox txtPlayer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKurallar;
        private System.Windows.Forms.Label lblKurallar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPlayer2;
        private System.Windows.Forms.ListBox lstSonuc;
        private System.Windows.Forms.Label lblOynayanBilgisi;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.GroupBox grpKurallar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer tmrRenk;
        private System.Windows.Forms.Label lblSonuc1;
        private System.Windows.Forms.Label lblSonuc2;
    }
}


﻿namespace MathGames
{
    partial class SkorTablosu
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnAnaSayfaDön = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listBox1.FormatString = "atakan bektas 123";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(942, 478);
            this.listBox1.TabIndex = 0;
            // 
            // btnAnaSayfaDön
            // 
            this.btnAnaSayfaDön.Location = new System.Drawing.Point(784, 420);
            this.btnAnaSayfaDön.Name = "btnAnaSayfaDön";
            this.btnAnaSayfaDön.Size = new System.Drawing.Size(142, 45);
            this.btnAnaSayfaDön.TabIndex = 1;
            this.btnAnaSayfaDön.Text = "ANASAYFA";
            this.btnAnaSayfaDön.UseVisualStyleBackColor = true;
            this.btnAnaSayfaDön.Click += new System.EventHandler(this.btnTekrarOyna_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(694, 420);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 45);
            this.button2.TabIndex = 1;
            this.button2.Text = "ÇIKIŞ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SkorTablosu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 478);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAnaSayfaDön);
            this.Controls.Add(this.listBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SkorTablosu";
            this.Text = "Skor Tablosu";
            this.Load += new System.EventHandler(this.SkorTablosu_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAnaSayfaDön;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.ListBox listBox1;
    }
}
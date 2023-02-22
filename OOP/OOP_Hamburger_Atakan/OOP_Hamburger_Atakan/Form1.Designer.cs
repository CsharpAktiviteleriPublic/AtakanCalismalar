namespace OOP_Hamburger_Atakan
{
    partial class MyMdiParent
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.siparisYonetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparisOlusturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparisBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urunYonetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.malzemeEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparisYonetimiToolStripMenuItem,
            this.urunYonetimiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(849, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // siparisYonetimiToolStripMenuItem
            // 
            this.siparisYonetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparisOlusturToolStripMenuItem,
            this.siparisBilgileriToolStripMenuItem});
            this.siparisYonetimiToolStripMenuItem.Name = "siparisYonetimiToolStripMenuItem";
            this.siparisYonetimiToolStripMenuItem.Size = new System.Drawing.Size(103, 19);
            this.siparisYonetimiToolStripMenuItem.Text = "Siparis Yonetimi";
            // 
            // siparisOlusturToolStripMenuItem
            // 
            this.siparisOlusturToolStripMenuItem.Name = "siparisOlusturToolStripMenuItem";
            this.siparisOlusturToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.siparisOlusturToolStripMenuItem.Text = "Siparis Olustur";
            this.siparisOlusturToolStripMenuItem.Click += new System.EventHandler(this.siparisOlusturToolStripMenuItem_Click);
            // 
            // siparisBilgileriToolStripMenuItem
            // 
            this.siparisBilgileriToolStripMenuItem.Name = "siparisBilgileriToolStripMenuItem";
            this.siparisBilgileriToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.siparisBilgileriToolStripMenuItem.Text = "Siparis Bilgileri";
            this.siparisBilgileriToolStripMenuItem.Click += new System.EventHandler(this.siparisBilgileriToolStripMenuItem_Click);
            // 
            // urunYonetimiToolStripMenuItem
            // 
            this.urunYonetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEkleToolStripMenuItem,
            this.malzemeEkleToolStripMenuItem});
            this.urunYonetimiToolStripMenuItem.Name = "urunYonetimiToolStripMenuItem";
            this.urunYonetimiToolStripMenuItem.Size = new System.Drawing.Size(95, 19);
            this.urunYonetimiToolStripMenuItem.Text = "Urun Yonetimi";
            // 
            // menuEkleToolStripMenuItem
            // 
            this.menuEkleToolStripMenuItem.Name = "menuEkleToolStripMenuItem";
            this.menuEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.menuEkleToolStripMenuItem.Text = "Menu Ekle";
            this.menuEkleToolStripMenuItem.Click += new System.EventHandler(this.menuEkleToolStripMenuItem_Click);
            // 
            // malzemeEkleToolStripMenuItem
            // 
            this.malzemeEkleToolStripMenuItem.Name = "malzemeEkleToolStripMenuItem";
            this.malzemeEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.malzemeEkleToolStripMenuItem.Text = "Ekstra Malzeme Ekle";
            this.malzemeEkleToolStripMenuItem.Click += new System.EventHandler(this.malzemeEkleToolStripMenuItem_Click);
            // 
            // MyMdiParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(849, 631);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MyMdiParent";
            this.Text = "MyMdiForm";
            this.Load += new System.EventHandler(this.MyMdiParent_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem siparisYonetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparisOlusturToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparisBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urunYonetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem malzemeEkleToolStripMenuItem;
    }
}


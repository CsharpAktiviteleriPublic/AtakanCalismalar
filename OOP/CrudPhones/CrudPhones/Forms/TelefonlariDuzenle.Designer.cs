namespace CrudPhones
{
    partial class TelefonlariDuzenle
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
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtYil = new System.Windows.Forms.TextBox();
            this.grpTelefonDurum = new System.Windows.Forms.GroupBox();
            this.rbtnHurda = new System.Windows.Forms.RadioButton();
            this.rbtnKullanimda = new System.Windows.Forms.RadioButton();
            this.rbtnSatista = new System.Windows.Forms.RadioButton();
            this.lstTelefonlar = new System.Windows.Forms.ListBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.grpTelefonDurum.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marka";
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(130, 10);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(254, 26);
            this.txtMarka.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Model";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(130, 56);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(254, 26);
            this.txtModel.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Yıl";
            // 
            // txtYil
            // 
            this.txtYil.Location = new System.Drawing.Point(130, 106);
            this.txtYil.Name = "txtYil";
            this.txtYil.Size = new System.Drawing.Size(254, 26);
            this.txtYil.TabIndex = 1;
            // 
            // grpTelefonDurum
            // 
            this.grpTelefonDurum.Controls.Add(this.rbtnHurda);
            this.grpTelefonDurum.Controls.Add(this.rbtnKullanimda);
            this.grpTelefonDurum.Controls.Add(this.rbtnSatista);
            this.grpTelefonDurum.Location = new System.Drawing.Point(4, 195);
            this.grpTelefonDurum.Name = "grpTelefonDurum";
            this.grpTelefonDurum.Size = new System.Drawing.Size(411, 100);
            this.grpTelefonDurum.TabIndex = 2;
            this.grpTelefonDurum.TabStop = false;
            this.grpTelefonDurum.Text = "Durumu";
            // 
            // rbtnHurda
            // 
            this.rbtnHurda.AutoSize = true;
            this.rbtnHurda.Location = new System.Drawing.Point(329, 49);
            this.rbtnHurda.Name = "rbtnHurda";
            this.rbtnHurda.Size = new System.Drawing.Size(76, 24);
            this.rbtnHurda.TabIndex = 0;
            this.rbtnHurda.TabStop = true;
            this.rbtnHurda.Text = "Hurda";
            this.rbtnHurda.UseVisualStyleBackColor = true;
            // 
            // rbtnKullanimda
            // 
            this.rbtnKullanimda.AutoSize = true;
            this.rbtnKullanimda.Location = new System.Drawing.Point(153, 49);
            this.rbtnKullanimda.Name = "rbtnKullanimda";
            this.rbtnKullanimda.Size = new System.Drawing.Size(114, 24);
            this.rbtnKullanimda.TabIndex = 0;
            this.rbtnKullanimda.TabStop = true;
            this.rbtnKullanimda.Text = "Kullanimda";
            this.rbtnKullanimda.UseVisualStyleBackColor = true;
            // 
            // rbtnSatista
            // 
            this.rbtnSatista.AutoSize = true;
            this.rbtnSatista.Location = new System.Drawing.Point(6, 49);
            this.rbtnSatista.Name = "rbtnSatista";
            this.rbtnSatista.Size = new System.Drawing.Size(84, 24);
            this.rbtnSatista.TabIndex = 0;
            this.rbtnSatista.TabStop = true;
            this.rbtnSatista.Text = "Satista";
            this.rbtnSatista.UseVisualStyleBackColor = true;
            // 
            // lstTelefonlar
            // 
            this.lstTelefonlar.FormattingEnabled = true;
            this.lstTelefonlar.ItemHeight = 20;
            this.lstTelefonlar.Location = new System.Drawing.Point(441, 22);
            this.lstTelefonlar.Name = "lstTelefonlar";
            this.lstTelefonlar.Size = new System.Drawing.Size(386, 184);
            this.lstTelefonlar.TabIndex = 3;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Lime;
            this.btnEkle.Location = new System.Drawing.Point(441, 234);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(113, 39);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.BackColor = System.Drawing.Color.Yellow;
            this.btnGüncelle.Location = new System.Drawing.Point(574, 234);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(113, 39);
            this.btnGüncelle.TabIndex = 4;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = false;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Red;
            this.btnSil.Location = new System.Drawing.Point(714, 234);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(113, 39);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // TelefonlariDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 303);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lstTelefonlar);
            this.Controls.Add(this.grpTelefonDurum);
            this.Controls.Add(this.txtYil);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TelefonlariDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelefonlariDuzenle";
            this.grpTelefonDurum.ResumeLayout(false);
            this.grpTelefonDurum.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtYil;
        private System.Windows.Forms.GroupBox grpTelefonDurum;
        private System.Windows.Forms.RadioButton rbtnHurda;
        private System.Windows.Forms.RadioButton rbtnKullanimda;
        private System.Windows.Forms.RadioButton rbtnSatista;
        private System.Windows.Forms.ListBox lstTelefonlar;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Button btnSil;
    }
}
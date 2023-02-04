using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tmrRenk.Start();
            tmrHaraket.Start();
        }

        Random rnd = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void tmrRenk_Tick(object sender, EventArgs e)
        {
            lblHesapMakinesi.ForeColor = Color.FromArgb(rnd.Next(25, 50), rnd.Next(25, 100), rnd.Next(25, 50));

        }
        private void number_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            lblSonuc.Text += btn.Text;
            txtSayiGiris.Text += btn.Text;
        }
        private void operator_Click(object sender, EventArgs e)
        {
            var btnOperator = sender as Button;            
            lblSonuc.Text += $" {btnOperator.Text} ";
            txtSayiGiris.Clear();
        }  
        private void btnEsittir_Click(object sender, EventArgs e)
        {
            txtSayiGiris.Text = "";
            string[] sayiVeOperatorler = lblSonuc.Text.Split(' ');
            double sonuc = double.Parse(sayiVeOperatorler.First());
            for (int i = 1; i < sayiVeOperatorler.Length; i+=2)
            {
                switch (sayiVeOperatorler[i])
                {
                    case "+":
                        
                        sonuc += double.Parse(sayiVeOperatorler[i + 1]);
                        break;
                    case "-":
                        sonuc -= double.Parse(sayiVeOperatorler[i + 1]);
                        break;
                    case "*":
                        sonuc *= double.Parse(sayiVeOperatorler[i + 1]);
                        break;
                    case "/":
                        sonuc /= double.Parse(sayiVeOperatorler[i + 1]);
                        break;
                }
            }

            lblSonuc.Text = sonuc.ToString();
            txtSayiGiris.Text = sonuc.ToString();
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtSayiGiris.Text = "";
            lblSonuc.Text = "";
            
        }

       
        private void tmrHaraket_Tick(object sender, EventArgs e)
        {
            lblHesapMakinesi.Left += 2;
            if (lblHesapMakinesi.Left>=groupBox1.Right)
            {
                lblHesapMakinesi.Left = groupBox1.Left;
            }
        }
    }
}

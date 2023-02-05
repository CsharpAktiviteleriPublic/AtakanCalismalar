using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAButonOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void lblKurallar_MouseEnter(object sender, EventArgs e)
        {
            grpKurallar.Visible = true;
            lblKurallar.Text = "KURALLAR";
            lblKurallar.Width = 120;
            lblKurallar.Left = lstSonuc.Left + (lblKurallar.Width / 2);

        }

        private void lblKurallar_MouseLeave(object sender, EventArgs e)
        {
            grpKurallar.Visible = false;
        }

        Random rnd = new Random();

        private void btnBasla_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                Button btn = new Button();
                btn.Width = 50;
                btn.Height = 50;
                btn.Tag = rnd.Next(0, 2);
                btn.Text = rnd.Next(0, 2).ToString();
                flpButonlar.Controls.Add(btn);




                btn.Click += Button_Click;
                
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            
        }
    }
}

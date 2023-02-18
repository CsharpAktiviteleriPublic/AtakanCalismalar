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
            lblSonuc1.Visible = true;

            flpButonlar.Controls.Clear();
            lblSonuc1.Text = "0";

            int bomba = rnd.Next(0, 20);

            for (int i = 0; i < 20; i++)
            {
                Button btn = new Button();
                btn.Width = 50;
                btn.Height = 50;
                flpButonlar.Controls.Add(btn);
                
                if (bomba != i)
                {
                    btn.Tag = rnd.Next(0, 2);
                }
                else
                {
                    btn.Tag = 2;
                }

                btn.Click += Button_Click;

            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            
            if ((int)btn.Tag==0)
            {
               btn.BackgroundImage = Properties.Resources.green1;
                lblSonuc1.Text = (Convert.ToInt32(lblSonuc1.Text) + 1).ToString();





            }
            else if ((int)btn.Tag == 1)
            {
                btn.BackgroundImage = Properties.Resources.red1;
                lblSonuc1.Text = (Convert.ToInt32(lblSonuc1.Text) - 1).ToString();




            }
            else
            {
                btn.BackgroundImage = Properties.Resources.bomba;
                lstSonuc.Items.Add(lblSonuc1.Text + " " + txtPlayer1.Text);



                lblSonuc1.Visible = false;
                lblSonuc2.Visible = false;

            }

        }
    }
}

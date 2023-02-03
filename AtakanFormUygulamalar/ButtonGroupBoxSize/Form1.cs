using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonGroupBoxSize
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            int adet = int.Parse(cboxAdet.Text) - 1;    

            button1.Width = (groupBox1.Width - button1.Margin.Left * adet)/(adet+1);
            button2.Width = (groupBox1.Width - button1.Margin.Left * adet)/(adet+1);
            button3.Width = (groupBox1.Width - button1.Margin.Left * adet)/(adet+1);
            button4.Width = (groupBox1.Width - button1.Margin.Left * adet)/(adet+1);


            flowLayoutPanel1.HorizontalScroll.Maximum = 0;
            flowLayoutPanel1.AutoScroll = false;
            flowLayoutPanel1.HorizontalScroll.Visible = false;
            flowLayoutPanel1.AutoScroll = true;



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            cboxAdet.Items.Add(1);
            cboxAdet.Items.Add(2);
            cboxAdet.Items.Add(3);
            cboxAdet.Items.Add(4);
            cboxAdet.SelectedItem = 3;
            int adet = int.Parse(cboxAdet.Text) - 1;
            button1.Width = (groupBox1.Width - button1.Margin.Left * adet) / (adet + 1);
            button2.Width = (groupBox1.Width - button1.Margin.Left * adet) / (adet + 1);
            button3.Width = (groupBox1.Width - button1.Margin.Left * adet) / (adet + 1);
            button4.Width = (groupBox1.Width - button1.Margin.Left * adet) / (adet + 1);

 


        }
    }
}

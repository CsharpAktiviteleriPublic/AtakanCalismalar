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
        }

        private void lblKurallar_MouseLeave(object sender, EventArgs e)
        {            
            grpKurallar.Visible = false;
        }
    }
}

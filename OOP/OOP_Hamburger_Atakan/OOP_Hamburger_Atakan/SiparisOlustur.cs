using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Hamburger_Atakan
{
    public partial class SiparisOlustur : Form
    {
        public SiparisOlustur()
        {
            InitializeComponent();
          
        }

        private void SiparisOlustur_Load(object sender, EventArgs e)
        {
          
            FormBorderStyle = FormBorderStyle.None;           
            this.Dock = DockStyle.Fill;
            
            
            //Height = ParentForm.Height;
        }

        
    }
}

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
    public partial class MenuEkle : Form
    {
        public MenuEkle()
        {
            InitializeComponent();
        }
        
        private void btnMenuEkle_Click(object sender, EventArgs e)
        {            
            Fonksiyonlar.Ekle(Menuler.menuler, Fonksiyonlar.MenuAdiToTitleCase(txtMenuAdi.Text), numMenuFiyat.Value);              
            
        }

        private void MenuEkle_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathGames
{
    public partial class SkorTablosu : Form
    {
        public SkorTablosu()
        {
            InitializeComponent();
        }

        public string ad = "";
        public string soyad = "";

        private void SkorTablosu_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.math;
        }

        private void btnTekrarOyna_Click(object sender, EventArgs e)
        {
            KullaniciGiris kullaniciGiris = new KullaniciGiris();
            kullaniciGiris.count = 1;
            kullaniciGiris.Show();           
            
            Hide();
        }
    }
}

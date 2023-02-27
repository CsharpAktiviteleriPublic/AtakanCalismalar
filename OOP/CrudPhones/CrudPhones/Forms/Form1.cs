using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudPhones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        void ChildForm(Form childForm)
        {
            bool durum = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form.Text == childForm.Text)
                {
                    durum = true;
                    form.Activate();

                }
                else
                {
                    form.Close();
                }
            }
            if (durum == false)
            {
                childForm.MdiParent = this;
                childForm.Show();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void telefonlarıDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            TelefonlariDuzenle duzenle = new TelefonlariDuzenle();
            FormuDuzenle(duzenle);
            ChildForm(duzenle);       
        }

        private void FormuDuzenle(Form frm)
        {
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;            
        }
        private void telefonlarıListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelefonlariListele listele = new TelefonlariListele();
            FormuDuzenle(listele);
            ChildForm(listele);
            ChildForm(new TelefonlariListele());       
        }


    }
}

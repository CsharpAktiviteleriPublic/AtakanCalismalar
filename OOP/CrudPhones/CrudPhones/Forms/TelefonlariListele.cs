using CrudPhones.Models;
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
    public partial class TelefonlariListele : Form
    {
        public TelefonlariListele()
        {
            InitializeComponent();
        }

        private void TelefonlariListele_Activated(object sender, EventArgs e)
        {
            cbTelefonlar.Items.Clear();
            cbTelefonlar.Items.AddRange(Telefon.telefonlarList.ToArray());
        }

        private void cbTelefonlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblMarka.Text = Telefon.telefonlarList[cbTelefonlar.SelectedIndex].Marka;
            lblModel.Text = Telefon.telefonlarList[cbTelefonlar.SelectedIndex].Model;
            lblYil.Text = Telefon.telefonlarList[cbTelefonlar.SelectedIndex].Yil.ToString();
            lblDurum.Text = Telefon.telefonlarList[cbTelefonlar.SelectedIndex].Durumu;
        }
    }
}

using CrudPhones.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
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
            Stream nokia = Properties.Resources.Nokia_3310_telefonzilsesleri_mobi;
            Stream iphone = Properties.Resources.Iphone_2013_telefonzilsesleri_mobi;
            SoundPlayer soundNokia = new SoundPlayer(nokia);
            SoundPlayer soundIphone = new SoundPlayer(iphone);

            if (lblMarka.Text == "Nokia")
            {
                pbPhones.Image = Properties.Resources.Nokia_3310;
                soundNokia.Play();               
            }
            else if (lblMarka.Text == "Iphone")
            {
                pbPhones.Image = Properties.Resources.iphone_13;
                soundIphone.Play();
            }

        }

        private void TelefonlariListele_Load(object sender, EventArgs e)
        {

        }
    }
}

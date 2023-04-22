using CrudPhones.Models;
using System;
using System.Windows.Forms;

namespace CrudPhones
{
    public partial class TelefonlariDuzenle : Form
    {
        public TelefonlariDuzenle()
        {
            InitializeComponent();
        }



        private void btnEkle_Click(object sender, EventArgs e)
        {
            Telefon telefon = new Telefon();
            TelefonOzellikleriVer(telefon);
            Telefon.telefonlarList.Add(telefon);
            lstTelefonlar.Items.Add(telefon);
        }
        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            Telefon telefon = new Telefon();
            TelefonOzellikleriVer(telefon);
            try
            {
                int selectedIndex = lstTelefonlar.SelectedIndex;
                Telefon.telefonlarList.RemoveAt(selectedIndex);
                Telefon.telefonlarList.Insert(selectedIndex, telefon);
                lstTelefonlar.Items.RemoveAt(selectedIndex);
                lstTelefonlar.Items.Insert(selectedIndex, telefon);
            }
            catch
            {
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            Telefon.telefonlarList.Remove((Telefon)lstTelefonlar.SelectedItem);
            lstTelefonlar.Items.Remove(lstTelefonlar.SelectedItem);
        }
        private void TelefonOzellikleriVer(Telefon telefon)
        {
            telefon.Marka = txtMarka.Text;
            telefon.Model = txtModel.Text;
            telefon.Yil = int.Parse(txtYil.Text);
            if (rbtnHurda.Checked)
            {
                telefon.Durumu = "Hurda";
            }
            else if (rbtnKullanimda.Checked)
            {
                telefon.Durumu = "Kullanimda";
            }
            else if (rbtnSatista.Checked)
            {
                telefon.Durumu = "Satista";
            }
        }
    }
}

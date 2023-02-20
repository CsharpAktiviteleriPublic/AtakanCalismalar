using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA_RandomFutbolTakim.Models;

namespace WFA_RandomFutbolTakim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnCreateTeam_Click(object sender, EventArgs e)
        {
           
            Kaleciler kaleci = new Kaleciler();
            Defanslar defans1 = new Defanslar();

            Defanslar defans2 = new Defanslar();
            Defanslar defans3 = new Defanslar();

            OrtaSahalar ortaSaha1 = new OrtaSahalar();
            OrtaSahalar ortaSaha2 = new OrtaSahalar();
            OrtaSahalar ortaSaha3 = new OrtaSahalar();
            OrtaSahalar ortaSaha4 = new OrtaSahalar();
            OrtaSahalar ortaSaha5 = new OrtaSahalar();

            Forvetler forvet1 = new Forvetler();
            Forvetler forvet2 = new Forvetler();


            label1.Text = kaleci.AdVer();
            label2.Text = defans1.AdVer();
            label3.Text = defans2.AdVer();
            label4.Text = defans3.AdVer();
            label5.Text = ortaSaha1.AdVer();
            label6.Text = ortaSaha2.AdVer();
            label7.Text = ortaSaha3.AdVer();
            label8.Text = ortaSaha4.AdVer();
            label9.Text = ortaSaha5.AdVer();
            label10.Text = forvet1.AdVer();
            label11.Text = forvet2.AdVer();






        }


    }
}

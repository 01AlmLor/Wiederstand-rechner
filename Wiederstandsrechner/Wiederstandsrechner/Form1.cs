using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int r1;
        int r2;
        double ergebnis;
        bool reihe;
        WiederstandBerchnung berechnen = new WiederstandBerchnung();

        private void txtR1_TextChanged(object sender, EventArgs e)
        {

        }      


        private void txtAusgabe_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReihe_Click(object sender, EventArgs e)
        {
            reihe = true;
        }

        private void btnParallel_Click(object sender, EventArgs e)
        {
            reihe = false;
        }

        private void btnBerechnen_Click(object sender, EventArgs e)
        {
            berechnen.setR1(Convert.ToInt16(txtR1.Text));
            berechnen.setR2(Convert.ToInt16(txtR2.Text));
            berechnen.Reihe(reihe);
            ergebnis=berechnen.berechnen();
            txtAusgabe.Text = Convert.ToString(ergebnis);
        }
    }
}

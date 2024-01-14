using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratorioDeFisiscav3
{
    public partial class ENERGIAMECANICA : Form
    {
        public ENERGIAMECANICA()
        {
            InitializeComponent();
        }


        public double velEC = 0;

        public double masEC = 0;

        public double masEP = 0;

        public double gravEP = 0;

        public double distEP = 0;






        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            velEC = Convert.ToDouble(TxtVelocidadEC.Text);
            masEC = Convert.ToDouble(TxtMasaEC.Text);
            masEP = Convert.ToDouble(TxtMasaEP.Text);
            gravEP = Convert.ToDouble(TxtGravedadEP.Text);
            distEP = Convert.ToDouble(TxtGravedadEP.Text);

            TxtRpta.Text = Convert.ToString(Math.Round((masEC * Math.Pow(velEC, 2) / 2) + (masEP * gravEP * distEP)));




        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            TRABAJOMECANICO ventanaENERGIAMECANICA = new TRABAJOMECANICO();
            ventanaENERGIAMECANICA.Show();
            this.Hide();



        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class MRU : Form
    {
        public MRU()
        {
            InitializeComponent();
        }

        public double kilh = 0;

        public double mets = 0;

        public double vel = 0;

        public double tie = 0;



        //calculando convertir de KM A M
        private void TxtConvertir_Click(object sender, EventArgs e)
        {

            kilh = Convert.ToDouble(TxtKm.Text);

            TxtM.Text = Convert.ToString(kilh * 5 / 18);

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {

            vel = Convert.ToDouble(TxtVelocidad.Text);

            tie = Convert.ToDouble(TxtTiempo.Text);

            TxtRpta.Text = Convert.ToString(Math.Round(vel * tie));








        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            ANALISISVECTORIALII ventanaMRU = new ANALISISVECTORIALII();
            ventanaMRU.Show();
            this.Hide();
        }
    }
}

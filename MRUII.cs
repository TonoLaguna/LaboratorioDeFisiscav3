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
    public partial class MRUII : Form
    {
        public MRUII()
        {
            InitializeComponent();
        }

        public double velM = 0;

        public double velm = 0;

        public double dist = 0;

        public double tiem = 0;

        private void BtnCalcularT_Click(object sender, EventArgs e)
        {
            velM = Convert.ToDouble(TxtVelocidadM.Text);
            velm = Convert.ToDouble(TxtVelocidadme.Text);
            dist = Convert.ToDouble(TxtDistancia.Text);

            TxtRptaT.Text = Convert.ToString(dist / (velM - velm));
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            tiem = Convert.ToDouble(TxtTiempo.Text);

            TxtRpta.Text = Convert.ToString(velm * tiem);
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            MRU ventanaMRUII = new MRU();
            ventanaMRUII.Show();
            this.Hide();
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {

            MRUV ventanaMRUII = new MRUV();
            ventanaMRUII.Show();
            this.Hide();
        }
    }
}

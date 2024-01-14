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
    public partial class MVCL : Form
    {
        public MVCL()
        {
            InitializeComponent();
        }


        public double veli = 0;

        public double grai = 0;


        public double velii = 0;

        public double velfii = 0;

        public double tiemii = 0;


        public double veliii = 0;

        public double graviii = 0;

        public double distiii = 0;


        private void BtnCalcularT_Click(object sender, EventArgs e)
        {
            veli = Convert.ToDouble(TxtVelocidadi.Text);
            grai = Convert.ToDouble(TxtGravedadi.Text);
            TxtRptaT.Text = Convert.ToString(veli / grai);
        }

        private void BtnCalcularh_Click(object sender, EventArgs e)
        {
            velii = Convert.ToDouble(TxtVelocidadii.Text);

            velfii = Convert.ToDouble(TxtVelocidadf.Text);

            tiemii = Convert.ToDouble(TxtTiempo.Text);

            TxtRptah.Text = Convert.ToString(((velii + velfii) / 2) * tiemii);


        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {

            veliii = Convert.ToDouble(TxtVelocidadiii.Text);

            graviii = Convert.ToDouble(TxtGravedadiii.Text);

            TxtRpta.Text = Convert.ToString(Math.Sqrt(Math.Pow(veliii, 2) + 2 * graviii * distiii));


        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            MRUVII ventanaMCVL = new MRUVII();
            ventanaMCVL.Show();
            this.Hide();
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            MVCLII ventanaMCVL = new MVCLII();
            ventanaMCVL.Show();
            this.Hide();
        }
    }
}

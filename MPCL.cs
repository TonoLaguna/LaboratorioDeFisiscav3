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
    public partial class MPCL : Form
    {
        public MPCL()
        {
            InitializeComponent();
        }



        public double dist = 0;

        public double velh = 0;


        public double tiem = 0;


        public double grav = 0;



        private void BtnCalcularT_Click(object sender, EventArgs e)
        {


            velh = Convert.ToDouble(TxtVelocidadh.Text);
            dist = Convert.ToDouble(TxtDistancia.Text);

            TxtRptaT.Text = Convert.ToString(dist / velh);
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {


            tiem = Convert.ToDouble(TxtTiempo.Text);

            grav = Convert.ToDouble(TxtGravedad.Text);

            TxtRpta.Text = Convert.ToString(tiem * grav);




        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            MVCLII ventanaMPCL = new MVCLII();
            ventanaMPCL.Show();
            this.Hide();
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {

        }
    }
}

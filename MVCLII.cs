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
    public partial class MVCLII : Form
    {
        public MVCLII()
        {
            InitializeComponent();
        }


        public double velA = 0;


        public double velB = 0;



        public double dist = 0;

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            velA = Convert.ToDouble(TxtVelocidadA.Text);

            velB = Convert.ToDouble(TxtVelocidadB.Text);

            dist = Convert.ToDouble(TxtDistancia.Text);

            TxtRpta.Text = Convert.ToString(dist / (velA + velB));


        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            MVCL ventanaMVCLII = new MVCL();
            ventanaMVCLII.Show();
            this.Hide();
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            MPCL ventanaMVCLII = new MPCL();
            ventanaMVCLII.Show();
            this.Hide();
        }
    }
}

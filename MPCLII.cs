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
    public partial class MPCLII : Form
    {
        public MPCLII()
        {
            InitializeComponent();
        }



        public double veli = 0;


        public double dist = 0;

        public double grav = 0;



        public double disti = 0;

        public double tiem = 0;









        private void BtnCalcularT_Click(object sender, EventArgs e)
        {

            veli = Convert.ToDouble(TxtVelocidad.Text);

            grav = Convert.ToDouble(TxtGravedad.Text);

            dist = Convert.ToDouble(TxtDistancia.Text);


            TxtRptaT.Text = Convert.ToString(Math.Round(Math.Sqrt((dist / grav) * 2)));


        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {


            disti = Convert.ToDouble(TxtDistanciai.Text);

            tiem = Convert.ToDouble(TxtTiempoi.Text);

            TxtRpta.Text = Convert.ToString(Math.Round(Math.Sqrt((dist / tiem) * 2)));



        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            MPCL ventanaMPCLII = new MPCL();
            ventanaMPCLII.Show();
            this.Hide();
        }
    }
}

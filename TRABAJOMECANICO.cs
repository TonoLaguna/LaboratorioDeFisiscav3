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
    public partial class TRABAJOMECANICO : Form
    {
        public TRABAJOMECANICO()
        {
            InitializeComponent();
        }


        public double fzaD = 0;

        public double fzaI = 0;

        public double distD = 0;

        public double distI = 0;



        private void BtnCalcular_Click(object sender, EventArgs e)
        {

            fzaD = Convert.ToDouble(TxtFuerzaD.Text);

            fzaI = Convert.ToDouble(TxtFuerzaI.Text);

            distD = Convert.ToDouble(TxtDistanciaD.Text);
            

            distI = Convert.ToDouble(TxtDistanciaI.Text);

            TxtRpta.Text = Convert.ToString(Math.Round((fzaD * distD) - (fzaI * distI)));

        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            ROZAMIENTO ventanaTRABAJOMECANICO = new ROZAMIENTO();
            ventanaTRABAJOMECANICO.Show();
            this.Hide();
        }

        private void TxtSiguiente_Click(object sender, EventArgs e)
        {
            ENERGIAMECANICA ventanaTRABAJOMECANICO = new ENERGIAMECANICA();
            ventanaTRABAJOMECANICO.Show();
            this.Hide();
        }
    }
}

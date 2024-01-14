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
    public partial class FUERZA : Form
    {
        public FUERZA()
        {
            InitializeComponent();
        }






       

        private void BtnAtras_Click(object sender, EventArgs e)
        {

            MCUV ventanaFUERZA = new MCUV();
            ventanaFUERZA.Show();
            this.Hide();





        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            ESTATICA ventanaFUERZA = new ESTATICA();
            ventanaFUERZA.Show();
            this.Hide();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (RdBTN1.Checked == true)
                TxtRPTA.Text = "Incorrecto";

            if (RdBTN2.Checked == true)
                TxtRPTA.Text = "Incorrecto";

            if (RdBTN1.Checked == true)
                TxtRPTA.Text = "Correcto";

        }
    }
}

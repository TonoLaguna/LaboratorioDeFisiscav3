using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratorioDeFisiscav3
{
    public partial class MCUV : Form
    {
        public MCUV()
        {
            InitializeComponent();
        }

        private void MCUV_Load(object sender, EventArgs e)
        {

        }


        public double vangA = 0;
        public double vangB = 0;
        public double radA = 0;
        public double radB = 0;



        private void BtnCalcular_Click(object sender, EventArgs e)
        {

            vangA = Convert.ToDouble(TxtVangularA.Text);
            radA = Convert.ToDouble(TxtRadioA.Text);
            radB = Convert.ToDouble(TxtRadioB.Text);

            TxtRpta.Text = Convert.ToString((vangA / radA) * radB);





        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            MCU ventanaMCUV = new MCU();
            ventanaMCUV.Show();
            this.Hide();


        }

        private void TxtSiguiente_Click(object sender, EventArgs e)
        {
           // FUERZA ventanaMCUV = new FUERZA();
            //ventanaMCUV.Show();
            this.Hide();
        }
    }
}

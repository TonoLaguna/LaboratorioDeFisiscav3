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
    public partial class MCU : Form
    {
        public MCU()
        {
            InitializeComponent();
        }


        public double tiem = 0;

        public double vuel = 0;






        private void BtnCalcular_Click(object sender, EventArgs e)
        {


            vuel = Convert.ToDouble(TxtNvueltas.Text);
            tiem = Convert.ToDouble(TxtTiempo.Text);

            TxtRpta.Text = Convert.ToString(Math.Round(vuel / tiem));




        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            MPCLII ventanaMCU = new MPCLII();
            ventanaMCU.Show();
            this.Hide();

        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {


           // MCUII ventanaMCU = new MCUII();
          //  ventanaMCU.Show();
            this.Hide();
        }
    }
}

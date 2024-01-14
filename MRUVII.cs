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
    public partial class MRUVII : Form
    {
        public MRUVII()
        {
            InitializeComponent();
        }

        public double velf = 0;

        public double veli = 0;

        public double acel = 0;

       
        
        
        private void BtnConvertir_Click(object sender, EventArgs e)
        {

         

        }




        private void BtnCalcular_Click(object sender, EventArgs e)
        {

            velf = Convert.ToDouble(TxtVelocidadF.Text);
            veli = Convert.ToDouble(TxtVelocidadI.Text);
            acel = Convert.ToDouble(TxtAceleracion.Text);

            TxtRpta.Text = Convert.ToString((veli - velf) / acel);



        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            MRUV ventanaMRUVII = new MRUV();
            ventanaMRUVII.Show();
            this.Hide();
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            MVCL ventanaMRUVII = new MVCL();
            ventanaMRUVII.Show();
            this.Hide();
        }
    }
}

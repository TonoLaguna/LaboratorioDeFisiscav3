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
    public partial class ANALISISVECTORIAL : Form
    {
        public ANALISISVECTORIAL()
        {
            InitializeComponent();
        }


        public double vectorD = 0;

        public double vectorI = 0;

        public double vectorCX = 0;

        public double vectorA = 0;

        public double vectorB = 0;

        public double vectorCY = 0;

        public double vectorX = 0;

        public double vectorY = 0;






        //calculando vector resultante eje x

        private void BtnCalcularX_Click(object sender, EventArgs e)
        {

         vectorD = Convert.ToDouble(TxtCOS37.Text);
         vectorCX = Convert.ToDouble(TxtVectorD.Text);
         vectorI = Convert.ToDouble(TxtVectorI.Text);

         TxtRptaX.Text = Convert.ToString((vectorCX * vectorD) - vectorI);


        }
        //calculando vector resultante eje y
        private void BtnCalcularY_Click(object sender, EventArgs e)
        {

         vectorA = Convert.ToDouble(TxtSEN37.Text);

         vectorCY = Convert.ToDouble(TxtVectorA.Text);

         vectorB = Convert.ToDouble(TxtVectorB.Text);

         TxtRptaY.Text = Convert.ToString((vectorCY * vectorA) - vectorB);
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            ANALISISDIMENSIONALII ventanaAV = new ANALISISDIMENSIONALII();
            ventanaAV.Show();
            this.Close();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            vectorX = Convert.ToDouble(TxtRptaX1.Text);
            vectorY = Convert.ToDouble(TxtRptaY1.Text);

            TxtRpta.Text = Convert.ToString(Math.Round(Math.Sqrt((Math.Pow(vectorX, 2) + Math.Pow(vectorY, 2)))));
         


        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            ANALISISVECTORIALII ventanaAV = new ANALISISVECTORIALII();
            ventanaAV.Show();
            this.Hide();
            
        
        }
    }
}

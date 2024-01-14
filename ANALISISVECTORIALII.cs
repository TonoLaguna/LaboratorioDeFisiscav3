using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratorioDeFisiscav3
{
    public partial class ANALISISVECTORIALII : Form
    {
        public ANALISISVECTORIALII()
        {
            InitializeComponent();
        }

        public double vectorA = 0;

        public double vectorB = 0;

        public double vectorA1 = 0;

        public double vectorB1 = 0;

        public double cosAng = 0;




        //Calculando el vector resultante R

        private void BtnCalcular_Click(object sender, EventArgs e)
        {

            vectorA = Convert.ToDouble(TxtVectorA.Text);

            vectorB = Convert.ToDouble(TxtVectorB.Text);

            vectorA1 = Convert.ToDouble(TxtVectorA1.Text);

            vectorB1 = Convert.ToDouble(TxtVectorB1.Text);

            cosAng = Convert.ToDouble(TxtCOS60.Text);

            TxtRpta.Text = Convert.ToString(Math.Round((Math.Sqrt((Math.Pow(vectorA, 2) + Math.Pow(vectorB, 2)) + (2 * vectorA1 * vectorB1 * cosAng)))));



        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            ANALISISVECTORIAL ventanaAVII = new ANALISISVECTORIAL();
            ventanaAVII.Show();
            this.Hide();
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            MRU ventanaAVII = new MRU();
            ventanaAVII.Show();
            this.Hide();
        }
    }
}

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
    public partial class ROZAMIENTO : Form
    {
        public ROZAMIENTO()
        {
            InitializeComponent();
        }

        public double fzasF = 0;

        public double fzasK = 0;
        public double masaN = 0;
        public double grav = 0;
        public double coefk = 0;
        public double masa = 0;




        private void BtnCalcularFN_Click(object sender, EventArgs e)
        {
            // fzasN = Convert.ToDouble(TxtFuerzaF.Text);
            masaN = Convert.ToDouble(TxtGravedadN.Text);
            grav = Convert.ToDouble(TxtMasaN.Text);
            TxtRptaFN.Text = Convert.ToString(masa * grav);




        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {

            fzasF = Convert.ToDouble(TxtFuerzaF.Text);
            fzasK = Convert.ToDouble(TxtFuerzaK.Text);
            coefk = Convert.ToDouble(TxtCoefK.Text);
            masa = Convert.ToDouble(TxtMasa.Text);


            TxtRpta.Text = Convert.ToString(Math.Round((fzasF - (fzasK * coefk)) / masa));

        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            DINAMICALINEAL ventanaROZAMIENTO = new DINAMICALINEAL();
            ventanaROZAMIENTO.Show();
            this.Hide();

        }

        
        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            TRABAJOMECANICO ventanaROZAMIENTO = new TRABAJOMECANICO();
            ventanaROZAMIENTO.Show();
            this.Hide();



        }
    }
}

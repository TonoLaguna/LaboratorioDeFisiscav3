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
    public partial class ESTATICAII : Form
    {
        public ESTATICAII()
        {
            InitializeComponent();
        }



        public double angCosI = 0;

        public double angCosD = 0;

        public double masa = 0;

        public double grave = 0;

        public double  fzasD= 0;



        private void BtnCalcular_Click(object sender, EventArgs e)
        {
         
         masa = Convert.ToDouble(TxtMasa.Text);

         grave = Convert.ToDouble(TxtGravedad.Text);

         fzasD = Convert.ToDouble(TxtFuerzaD.Text);

         angCosD = Convert.ToDouble(TxtCosANGD.Text);

         angCosI = Convert.ToDouble(TxtCosANGI.Text);


         TxtRpta.Text = Convert.ToString(Math.Round((masa * grave * fzasD * angCosD) / angCosI)); ;

        }









    }
}

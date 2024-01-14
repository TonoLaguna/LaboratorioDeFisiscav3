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
    public partial class MF : Form
    {
        public MF()
        {
            InitializeComponent();
        }


        public double fzasA = 0;
        public double dist = 0;




        private void BtnCalcular_Click(object sender, EventArgs e)
        {

            fzasA = Convert.ToDouble(TxtFuerzaA.Text);
            dist = Convert.ToDouble(TxtDistancia.Text);

            TxtRpta.Text = Convert.ToString(Math.Round(fzasA * dist));





        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            ESTATICAII ventanaMF = new ESTATICAII();
            ventanaMF.Show();
            this.Hide();
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
           ESTATICAIII ventanaMF = new ESTATICAIII();
           ventanaMF.Show();
            this.Hide();
        }
    }
}

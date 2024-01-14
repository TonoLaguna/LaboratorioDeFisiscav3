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
    public partial class DINAMICALINEAL : Form
    {
        public DINAMICALINEAL()
        {
            InitializeComponent();
        }


        public double fzasD = 0;


        public double fzasI = 0;


        public double masa = 0;








        private void BtnCalcular_Click(object sender, EventArgs e)
        {

            fzasD = Convert.ToDouble(TxtFuerzaD.Text);


            fzasI = Convert.ToDouble(TxtFuerzaI.Text);


            masa = Convert.ToDouble(TxtMasa.Text);


            TxtRpta.Text = Convert.ToString(Math.Round((fzasD - fzasI) / masa));
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            ESTATICAIII ventanaDL = new ESTATICAIII();
            ventanaDL.Show();
            this.Hide();
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            ROZAMIENTO ventanaDL = new ROZAMIENTO();
            ventanaDL.Show();
            this.Hide();
        }
    }
}

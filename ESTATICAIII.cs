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
    public partial class ESTATICAIII : Form
    {
        public ESTATICAIII()
        {
            InitializeComponent();
        }


        public double fzasD = 0;
        public double distA = 0;
        public double distH = 0;




        private void BtnCalcular_Click(object sender, EventArgs e)
        {

            fzasD = Convert.ToDouble(TxtFuerzaA.Text);
            distA = Convert.ToDouble(TxtDistanciaA.Text);
            distH = Convert.ToDouble(TxtDistanciaH.Text);

            TxtRpta.Text = Convert.ToString(Math.Round((fzasD * distA) / distH));




        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            MF ventanaESTATICAIII = new MF();
            ventanaESTATICAIII.Show();
            this.Hide();
        }
    }
}

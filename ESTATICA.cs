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
    public partial class ESTATICA : Form
    {
        public ESTATICA()
        {
            InitializeComponent();
        }


        public double fzasI = 0;
        public double masa = 0;
        public double grav = 0;
        public double fzasT = 0;
        public double fzasF = 0;



        private void BtnCalcularF_Click(object sender, EventArgs e)
        {
            fzasI = Convert.ToDouble(TxtRptaF.Text);
            TxtRptaF.Text = Convert.ToString(fzasI);

        }

        private void BtnCalcularT_Click(object sender, EventArgs e)
        {
            masa = Convert.ToDouble(TxtMasa.Text);

            grav = Convert.ToDouble(TxtGravedad.Text);

            TxtRptaT.Text = Convert.ToString(Math.Round(masa * grav));





        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            fzasT = Convert.ToDouble(TxtRptaTT.Text);
            fzasF = Convert.ToDouble(TxtRptaFF.Text);

            TxtRpta.Text = Convert.ToString(Math.Round(fzasT + fzasF));

        }







    }
}

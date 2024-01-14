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
    public partial class MRUV : Form
    {
        public MRUV()
        {
            InitializeComponent();
        }

        public double veli = 0;
        public double velf = 0;
        public double tiem = 0;
        public double dist = 0;
        public double cons = 0;

        private void BtnCalcular_Click(object sender, EventArgs e)
        {


            veli = Convert.ToDouble(TxtVelocidadi.Text);
            velf = Convert.ToDouble(TxtVelocidadf.Text);
            tiem = Convert.ToDouble(TxtTiempo.Text);
            dist = Convert.ToDouble(TxtDistancia.Text);
            cons = Convert.ToDouble(TxtConstante.Text);
            TxtRpta.Text = Convert.ToString(((dist * cons) / tiem) - veli);




        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            MRUII ventanaMRUV = new MRUII();
            ventanaMRUV.Show();
            this.Hide();
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            MRUVII ventanaMRUV = new MRUVII();
            ventanaMRUV.Show();
            this.Hide();
        }
    }
}

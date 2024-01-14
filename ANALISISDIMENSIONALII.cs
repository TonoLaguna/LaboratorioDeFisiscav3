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
    public partial class ANALISISDIMENSIONALII : Form
    {
        public ANALISISDIMENSIONALII()
        {
            InitializeComponent();
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            ANALISISDIMENSIONAL ventanaAD = new ANALISISDIMENSIONAL();
            ventanaAD.Show();
            this.Hide();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (TxtRdbI.Checked == true)
                TxtRpta.Text = "INCORRECTO";


            if (TxtRdbII.Checked == true)
                TxtRpta.Text = "INCORRECTO";


            if (TxtRdbIII.Checked == true)
                TxtRpta.Text = "INCORRECTO";


            if (TxtRdbIIII.Checked == true)
                TxtRpta.Text = "CORRECTO";


            if (TxtRdbIIIII.Checked == true)
                TxtRpta.Text = "INCORRECTO";

        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            ANALISISVECTORIAL ventanaAV = new ANALISISVECTORIAL();
            ventanaAV.Show();
            this.Hide();
        }
    }
}

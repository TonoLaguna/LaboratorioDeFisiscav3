using System.Runtime.Intrinsics.Arm;

namespace LaboratorioDeFisiscav3
{
    public partial class ANALISISDIMENSIONAL : Form
    {
        public ANALISISDIMENSIONAL()
        {
            InitializeComponent();
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
          if (RdnFuerza.Checked == true)
                TxtRpta.Text = "correcto";
          if (RdnDensidad.Checked == true)
                TxtRpta.Text = "incorrecto";
          if (RdnRadio.Checked == true)
                TxtRpta.Text = "incorrecto";
          if (RdnVelocidad.Checked == true)
                TxtRpta.Text = "incorrecto";
          if (RdnPresion.Checked == true)
                TxtRpta.Text = "incorrecto";
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            ANALISISDIMENSIONALII ventanaAD = new ANALISISDIMENSIONALII();
            ventanaAD.Show();
            this.Hide();
                
                }
    }
}

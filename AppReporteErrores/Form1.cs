using System;
using System.Windows.Forms;
//using System.Data;

namespace AppReporteErrores
{
    public partial class frmNominal : Form
    {
        private cNominal aNominal;
        public frmNominal()
        {
            InitializeComponent();
            aNominal = new cNominal();
            //CargarGrid();
        }

        public void CargarGrid()
        {
            dgvNominalErrores.DataSource = aNominal.DevolverTabla("sp_Reporte_Errores").Tables[0];
        }

        private void frmNominal_Load(object sender, EventArgs e)
        {

        }

        private void btnCargarTramas_Click(object sender, EventArgs e)
        {
            frmCargarTramas frm2 = new frmCargarTramas();
            frm2.ShowDialog();
        }

        private void btnMostrarErrores_Click(object sender, EventArgs e)
        {
            CargarGrid();
            txtCantidadFilas.Text = dgvNominalErrores.RowCount.ToString();
        }
    }
}

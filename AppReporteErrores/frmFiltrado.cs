using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AppReporteErrores
{
    public partial class frmFiltrado : Form
    {
        cNominal aNominal = new cNominal();
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dt3 = new DataTable();
        //string s = "select * from vista_procesos\r\nwhere MicroRed = 'urubamba' and Establecimiento = 'chillca' and Fecha_Atencion = '3-2-2023' and Codigo_Item = '93784'";
        public frmFiltrado()
        {
            InitializeComponent();
            CargarCboMicro();
            //CargarCboRangoEdades();
            //txtDescripcionItem.Text = s;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtCodigoItem_Enter(object sender, EventArgs e)
        {
            // If the TextBox contains text, change its foreground and background colors.
            //if (string.IsNullOrEmpty(txtCodigoItem.Text))
            //{
            //    txtCodigoItem.ForeColor = Color.Red;
            //    txtCodigoItem.BackColor = Color.Blue;
            //    txtCodigoItem.Select(txtCodigoItem.Text.Length,500);
            //}
        }

        private void txtCodigoItem_Leave(object sender, EventArgs e)
        {
            //txtCodigoItem.ForeColor = Color.Black;
            //txtCodigoItem.BackColor = Color.Coral; 
            //txtCodigoItem.Select(0, 0);
        }

        public void CargarCboMicro()
        {
            dt = aNominal.CargarMicrored().Tables[0];
            DataRow fila = dt.NewRow();
            fila["MicroRed"] = "";
            dt.Rows.InsertAt(fila, 0);

            cboMicrored.ValueMember = "Codigo_MicroRed";
            cboMicrored.DisplayMember = "MicroRed";
            cboMicrored.DataSource = dt;
        }

        public void CargarCboEstablecimiento(string MicroRed)
        {
            dt2 = aNominal.CargarEstablecimiento(MicroRed).Tables[0];
            DataRow fila1 = dt2.NewRow();
            fila1["Establecimiento"] = "";
            dt2.Rows.InsertAt(fila1, 0);

            cboEstablecimiento.ValueMember = "Id_Establecimiento";
            cboEstablecimiento.DisplayMember = "Establecimiento";
            cboEstablecimiento.DataSource = dt2;

        }

        public void CargarCboRangoEdades()
        {
            dt3 = aNominal.CargarRangoEdades().Tables[0];
            DataRow fila2 = dt3.NewRow();
            fila2["GRUPO_EDAD"] = "";
            dt3.Rows.InsertAt(fila2, 0);

            //cboMicrored.ValueMember = "Codigo_MicroRed";
            cboMicrored.DisplayMember = "GRUPO_EDAD";
            cboMicrored.DataSource = dt3;
        }

        public void CargarValoresVacios()
        {
            //DataRow fil = cboTipoDx.Items();
        }

        private void cboMicrored_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMicrored.SelectedValue.ToString() != null | cboMicrored.SelectedValue.ToString() != "")
            {
                string microred = cboMicrored.SelectedValue.ToString();
                CargarCboEstablecimiento(microred);
            }
        }

        private void cboMicrored_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //if (cboMicrored.SelectedValue.ToString() != null | cboMicrored.SelectedValue.ToString() != "")
            //{
            //    string microred = cboMicrored.SelectedValue.ToString();
            //    CargarCboEstablecimiento(microred);
            //}
        }

        public void FiltrarDatos()
        {
            string Microred = cboMicrored.Text;
            string Establecimiento = cboEstablecimiento.Text;
            string FechaInicio = dteDesde.Value.ToShortDateString();
            string FechaFin = dteHasta.Value.ToShortDateString();
            string CodigoItem = txtCodigoItem.Text;
            string TipoDx = cboTipoDx.Text;
            string ValorLab = txtValorLab.Text;
            string DNIPaciente = txtDNIPaciente.Text;
            string DNIPersonalSalud = txtDNIPersonal.Text;
            string RangoEdades = cboRandoEdades.Text;
            string APP = txtApp.Text;
            string Edad = txtEdad.Text;
            string TipoEdad = cboTipoEdad.Text;
            string Sexo = cboSexo.Text;

            dgvFiltro.DataSource = aNominal.Filtro("sp_Filtro", Microred, Establecimiento, FechaInicio, FechaFin, CodigoItem, TipoDx, ValorLab, DNIPaciente, DNIPersonalSalud, RangoEdades, APP, Edad, TipoEdad, Sexo).Tables[0];
            aNominal.MostrarMensajeOK("Filtro Realizado", "ALERTA!");
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            FiltrarDatos();
            aNominal.GenerarNumeracionDGV(dgvFiltro);
            //GenerarNumeracionData();
            txtNroRegistros.Text = dgvFiltro.RowCount.ToString();
        }
        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            //txtDescripcionItem.Text = dteDesde.Value.ToString();
            //txtDescripcionItem.Text = dteHasta.Value.ToShortDateString();
            txtDescripcionItem.Text = cboMicrored.Text;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvFiltro_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //for (int i = 0;i<dgvFiltro.Rows.Count;i++)
            //{
            //    this.dgvFiltro.Rows[i].HeaderCell.Value = (i+1).ToString();
            //}
            
        }

        public void GenerarNumeracionData()
        {
            for (int i = 0; i < dgvFiltro.Rows.Count; i++)
            {
                this.dgvFiltro.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
        }
    }
}

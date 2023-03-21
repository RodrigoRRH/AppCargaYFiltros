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
        string s = "select * from vista_procesos\r\nwhere MicroRed = 'urubamba' and Establecimiento = 'chillca' and Fecha_Atencion = '3-2-2023' and Codigo_Item = '93784'";
        public frmFiltrado()
        {
            InitializeComponent();
            CargarCboMicro();
            txtDescripcionItem.Text = s;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtCodigoItem_Enter(object sender, EventArgs e)
        {
            // If the TextBox contains text, change its foreground and background colors.
            if (string.IsNullOrEmpty(txtCodigoItem.Text))
            {
                txtCodigoItem.ForeColor = Color.Red;
                txtCodigoItem.BackColor = Color.Blue;
                txtCodigoItem.Select(txtCodigoItem.Text.Length,500);
            }
        }

        private void txtCodigoItem_Leave(object sender, EventArgs e)
        {
            txtCodigoItem.ForeColor = Color.Black;
            txtCodigoItem.BackColor = Color.Coral; 
            txtCodigoItem.Select(0, 0);
        }

        public void CargarCboMicro()
        {
            dt = aNominal.CargarMicrored().Tables[0];
            DataRow fila = dt.NewRow();
            fila["MicroRed"] = "";
            dt.Rows.InsertAt(fila, 0);

            cboMicrored.DisplayMember = "MicroRed";
            cboMicrored.DataSource = dt;
        }

        public void CargaCboEstablecimiento(string MicroRed)
        {
            dt2 = aNominal.CargarEstablecimiento(MicroRed).Tables[0];
            DataRow fila1 = dt2.NewRow();
            fila1["Establecimiento"] = "";
            dt2.Rows.InsertAt(fila1, 0);

            //cboEstablecimiento.ValueMember = "MicroRed";
            cboEstablecimiento.DisplayMember = "Establecimiento";
            cboEstablecimiento.DataSource = dt2;

        }

        private void cboMicrored_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMicrored.SelectedValue.ToString() != null | cboMicrored.SelectedValue.ToString() != "")
            {
                string microred = cboMicrored.SelectedValue.ToString();
                CargaCboEstablecimiento(microred);
            }
        }
    }
}

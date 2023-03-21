using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppReporteErrores
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void itemCargaCSV_Click(object sender, EventArgs e)
        {
            frmCargarTramas tramas = new frmCargarTramas();
            tramas.ShowDialog();
        }

        private void itemMostrarErrores_Click(object sender, EventArgs e)
        {
            frmNominal nominal = new frmNominal();
            nominal.ShowDialog();
        }

        private void itemBarraProgreso_Click(object sender, EventArgs e)
        {
            frmBarraProgreso barra = new frmBarraProgreso();
            barra.ShowDialog();
        }

        private void mostrarFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBarraProgreso barraProgreso = new frmBarraProgreso();
            barraProgreso.TopLevel = false;
            panel1.Controls.Add(barraProgreso);
            barraProgreso.Show();
        }

        private void itemFiltroNominal_Click(object sender, EventArgs e)
        {
            frmFiltrado filtro = new frmFiltrado();
            filtro.ShowDialog();
        }
    }
}

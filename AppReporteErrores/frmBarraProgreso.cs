using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace AppReporteErrores
{
    public partial class frmBarraProgreso : Form
    {
        cNominal aNominal = new cNominal();
        int tiempo = 0;
        DataTable datos = new DataTable();
        public frmBarraProgreso()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            /*
            for (int i = 0;i<=100;i++)
            {
                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    DemoSleep();
                    backgroundWorker1.ReportProgress(i);
                }
            }*/

            if (backgroundWorker1.CancellationPending)
            {
                e.Cancel = true;
                datos.Clear();
            }
            else
            {
                tiempo++;
                datos = aNominal.Tabla().Tables[0];
                //backgroundWorker1.ReportProgress(dgvTabla.DataSource);
                
            }
   
            //txtCantidad.Text = dgvTabla.RowCount.ToString();

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //progressBar1.Value = e.ProgressPercentage;
            //lblPorcentaje.Text = e.ProgressPercentage.ToString() + " %";
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                backgroundWorker1.CancelAsync();
                timer1.Stop();
                lblTiempo.Text = "Proceso cancelado..." + tiempo.ToString() + " seg.";
                timer1.Enabled = false;
                tiempo = 0;
                display("Proceso cancelado");
                dgvTabla.Columns.Clear();
                txtNroRegistros.Text = dgvTabla.RowCount.ToString();
            }
            else
            {
                //dgvTabla.DataSource = aNominal.Tabla().Tables[0];
                dgvTabla.DataSource = datos;
                txtNroRegistros.Text = dgvTabla.RowCount.ToString();
                lblTiempo.Text = "Termino la carga.." + tiempo.ToString() + " seg.";
                tiempo = 0;
                timer1.Enabled = false;
                display("Proceso completado exitosamente...");
            }
            
        }
        private void DemoSleep()
        {
            Thread.Sleep(100);
        }

        public void display(string text)
        {
            MessageBox.Show(text);
        }

        private void btnEmpezar_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            {
                dgvTabla.Columns.Clear();
                backgroundWorker1.RunWorkerAsync();
                timer1.Start();
            }
            else
            {
                display("No se puede ejecutar backgroundWorker1 2 veces ");
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Seguro de cancelar el proceso?", "ALERTA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            
            if (result == DialogResult.OK)
            {
                
                backgroundWorker1.CancelAsync();
                timer1.Stop();
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tiempo++;
            lblTiempo.Text = "Cargando... " + tiempo.ToString() + " seg.";
        }

        private void btnLimpiarTabla_Click(object sender, EventArgs e)
        {
            dgvTabla.Columns.Clear();
            txtNroRegistros.Text = string.Empty;
            lblTiempo.Text = string.Empty;
        }
    }
}

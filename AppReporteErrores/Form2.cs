using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace AppReporteErrores
{
    public partial class frmCargarTramas : Form
    {
        private cNominal aNominal = new cNominal();
        public frmCargarTramas()
        {
            InitializeComponent();
            CargarResumenes();
            //BorrarDatos();
        }

        private void btnAbrirArchivo_Click(object sender, EventArgs e)
        {
            string rutaArchivo = string.Empty;
            OpenFileDialog openFile = new OpenFileDialog();
            
            if(openFile.ShowDialog() == DialogResult.OK)
            {
                rutaArchivo = openFile.FileName;
            }

            txtRutaArchivo.Text = rutaArchivo;
        }

        public void CargarResumenes()
        {
            dgvResumenPersonas.DataSource = aNominal.SP_Datos("sp_ResumenTablas").Tables[0];
            dgvResumenTramas.DataSource = aNominal.SP_Datos("sp_ResumenTramas").Tables[0];
        }

        private void frmCargarTramas_Load(object sender, EventArgs e)
        {

        }

        private void btnBorrarTablas_Click(object sender, EventArgs e)
        {

            string mensaje = "Seguro de borrar las tablas!";
            string titulo = "¡ALERTA!";
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult resultado;

            resultado = MessageBox.Show(this, mensaje, titulo,botones, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if(resultado == DialogResult.Yes)
            {
                BorrarDatos();
            }

        }

        private void BorrarDatos()
        {
            string mensaje = aNominal.SP_Mensaje("sp_limpiar_datos"); ;
            aNominal.MostrarMensajeOK(mensaje,  "RED NORTE");
            CargarResumenes();


        }
        

        private void btnCargarArchivo_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtRutaArchivo.Text is null)
                {
                    MessageBox.Show("No hay ruta");
                }
                else
                {
                    if (rdbTrama.Checked)
                    {
                        cboAnio.Enabled = true;
                        cboMes.Enabled = true;

                        int mes = Convert.ToInt32(cboMes.SelectedItem);
                        int anio = Convert.ToInt32(cboAnio.SelectedItem);
                        string ruta = txtRutaArchivo.Text;

                        string mensaje = aNominal.SP_CargarTrama("sp_tramanuevo_csv", ruta, mes, anio);
                        aNominal.MostrarMensajeOK(mensaje, "RED NORTE");
                        CargarResumenes();
                    }
                    if (rdbPersonal.Checked)
                    {
                        cboAnio.Enabled = false;
                        cboMes.Enabled = false;

                        string ruta = txtRutaArchivo.Text;
                        string mensaje = aNominal.SP_CargarTablasPersonas("sp_personal_csv", ruta);
                        aNominal.MostrarMensajeOK(mensaje, "RED NORTE");
                        CargarResumenes();
                    }
                    if (rdbPaciente.Checked)
                    {
                        cboAnio.Enabled = false;
                        cboMes.Enabled = false;

                        string ruta = txtRutaArchivo.Text;
                        string mensaje = aNominal.SP_CargarTablasPersonas("sp_paciente_csv", ruta);
                        aNominal.MostrarMensajeOK(mensaje, "RED NORTE");
                        CargarResumenes();
                    }
                    if (rdbRegistrador.Checked)
                    {
                        cboAnio.Enabled = false;
                        cboMes.Enabled = false;

                        string ruta = txtRutaArchivo.Text;
                        string mensaje = aNominal.SP_CargarTablasPersonas("sp_registrador_csv", ruta);
                        aNominal.MostrarMensajeOK(mensaje, "RED NORTE");
                        CargarResumenes();
                    }
                }


            }
            catch (Exception)
            {
                throw;
            }

        }

        private void btnCargarMensaje_Click(object sender, EventArgs e)
        {
            int mes = Convert.ToInt32(cboMes.SelectedItem);
            
            int anio = Convert.ToInt32(cboAnio.SelectedItem);
            string ruta = txtRutaArchivo.Text;
            txtMensaje.Text = "sp_tramanuevo_csv" + " '" + ruta + "'," + mes + ", " + anio;
        }

        private void rdbTrama_CheckedChanged(object sender, EventArgs e)
        {
            txtRutaArchivo.Text = "";
            if (rdbTrama.Checked)
            {
                cboAnio.Enabled=true; cboMes.Enabled=true;
            }
            else 
            {
                cboAnio.Enabled=false; cboMes.Enabled=false;
                cboAnio.SelectedIndex=-1; cboMes.SelectedIndex = -1;
            }

        }

        private void rdbPersonal_CheckedChanged(object sender, EventArgs e)
        {
            txtRutaArchivo.Text = "";
        }

        private void rdbPaciente_CheckedChanged(object sender, EventArgs e)
        {
            txtRutaArchivo.Text = "";
        }

        private void rdbRegistrador_CheckedChanged(object sender, EventArgs e)
        {
            txtRutaArchivo.Text = "";
        }

        // BACKGROUNDWORKER
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }
    }
}

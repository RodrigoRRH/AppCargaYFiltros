using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AppReporteErrores
{
    internal class cNominal
    {
        private SqlConnection aConexion;
        private SqlDataAdapter aAdaptador;
        private DataSet aDatos;
        private bool aNuevo;

        public cNominal()
        { 
            aNuevo = true;
            aDatos = new DataSet();
            aAdaptador = new SqlDataAdapter();
            
            //conexion
            string CadenaConexion = "Data Source=localhost; Initial Catalog = RedNorte; Integrated Security = SSPI; ";

            aConexion = new SqlConnection(CadenaConexion);
        }

        // ---------- propiedades --------------------------
        public bool Nuevo
        {
            get { return aNuevo; }
            set { aNuevo = value; }
        }

        // Metodos
        public DataSet DevolverTabla(string sp)
        {
            //string CadenaConsulta = "sp_Reporte_Errores";
            // Ejecutar la consulta
            aAdaptador.SelectCommand = new SqlCommand(sp, aConexion)
            {
                CommandType = CommandType.StoredProcedure
            };
            aDatos = new DataSet();
            aAdaptador.Fill(aDatos);
            return aDatos;
        }
        // ---------------------------------------------------------------------
        public Object ValorAtributo(string pNombreCampo)
        { // Recupera el valor de un atributo del dataset
            return aDatos.Tables[0].Rows[0][pNombreCampo];
        }

        public DataSet SP_Datos(string sp)
        {
            // Ejecutar la consulta
            aAdaptador.SelectCommand = new SqlCommand(sp, aConexion)
            {
                CommandType = CommandType.StoredProcedure
            };
            aDatos = new DataSet();
            aAdaptador.SelectCommand.CommandTimeout = 1000;
            aAdaptador.Fill(aDatos);
            return aDatos;
        }

        public string SP_Mensaje(string sp)
        {
            string resultado;
            // Ejecutar la consulta
            aAdaptador.SelectCommand = new SqlCommand(sp, aConexion)
            {
                CommandType = CommandType.StoredProcedure
            };
            aConexion.Open();
            SqlDataReader registro = aAdaptador.SelectCommand.ExecuteReader();
            if (registro.Read())
            {
                resultado = registro["Mensaje"].ToString();
            }
            else
            {
                resultado = registro["Mensaje"].ToString();
            }
            aConexion.Close();

            return resultado;
        }

        public void MostrarMensajeOK(string mensaje, string titulo)
        {
            MessageBoxButtons botones = MessageBoxButtons.OK;
            DialogResult resultado;
            resultado = MessageBox.Show(mensaje, titulo, botones, MessageBoxIcon.Information);

        }

        public string SP_CargarTrama(string sp, string ruta, int mes, int anio)
        {
            string resultado;
            //string cadena = sp+" '"+ ruta+"',"+mes+", "+ anio;
            // Ejecutar la consulta
            aAdaptador.SelectCommand = new SqlCommand(sp, aConexion)
            {
                CommandType = CommandType.StoredProcedure
            };
            aAdaptador.SelectCommand.CommandTimeout = 1000;
            aAdaptador.SelectCommand.Parameters.Add("@Ruta", SqlDbType.VarChar).Value = ruta;
            aAdaptador.SelectCommand.Parameters.Add("@mes", SqlDbType.Int).Value = mes;
            aAdaptador.SelectCommand.Parameters.Add("@anio", SqlDbType.Int).Value = anio;
            aConexion.Open();
            SqlDataReader registro = aAdaptador.SelectCommand.ExecuteReader();
            if (registro.Read())
            {
                resultado = registro["Mensaje"].ToString();
            }
            else
            {
                resultado = registro["Mensaje"].ToString();
            }
            aConexion.Close();

            return resultado;
        }

        public string SP_CargarTablasPersonas(string sp, string ruta)
        {
            string resultado;
            //string cadena = sp+" '"+ ruta+"',"+mes+", "+ anio;
            // Ejecutar la consulta
            aAdaptador.SelectCommand = new SqlCommand(sp, aConexion)
            {
                CommandType = CommandType.StoredProcedure
            };
            aAdaptador.SelectCommand.CommandTimeout = 1000;
            aAdaptador.SelectCommand.Parameters.Add("@Ruta", SqlDbType.VarChar).Value = ruta;

            aConexion.Open();
            SqlDataReader registro = aAdaptador.SelectCommand.ExecuteReader();
            if (registro.Read())
            {
                resultado = registro["Mensaje"].ToString();
            }
            else
            {
                resultado = registro["Mensaje"].ToString();
            }
            aConexion.Close();

            return resultado;
        }

        public DataSet Tabla()
        { // recupera la lista de libros
            string CadenaConsulta = "select * from NOMINAL_TRAMA_NUEVO";
            // Ejecutar la consulta
            aAdaptador.SelectCommand = new SqlCommand(CadenaConsulta, aConexion);
            aAdaptador.SelectCommand.CommandTimeout = 1000;
            aDatos = new DataSet();
            aAdaptador.Fill(aDatos);
            return aDatos;
        }

        public DataSet CargarMicrored()
        {
            string CadenaConsulta = "select distinct Codigo_MicroRed, MicroRed from MAESTRO_HIS_ESTABLECIMIENTO where Red = 'CUSCO NORTE'";
            // Ejecutar la consulta
            aAdaptador.SelectCommand = new SqlCommand(CadenaConsulta, aConexion);
            aAdaptador.SelectCommand.CommandTimeout = 1000;
            aDatos = new DataSet();
            aAdaptador.Fill(aDatos);
            return aDatos;
        }

        public DataSet CargarEstablecimiento(string MicroRed)
        {
            string CadenaConsulta = "select Id_Establecimiento, Nombre_Establecimiento as Establecimiento, Codigo_MicroRed from MAESTRO_HIS_ESTABLECIMIENTO where Red = 'CUSCO NORTE' and Codigo_MicroRed = '"+MicroRed+"' order by MicroRed";
            // Ejecutar la consulta
            aAdaptador.SelectCommand = new SqlCommand(CadenaConsulta, aConexion);
            //aAdaptador.SelectCommand.Parameters.AddWithValue("MicroRed", SqlDbType.VarChar).Value = MicroRed;
            aAdaptador.SelectCommand.CommandTimeout = 1000;
            aDatos = new DataSet();
            aAdaptador.Fill(aDatos);
            return aDatos;
        }

    }
}

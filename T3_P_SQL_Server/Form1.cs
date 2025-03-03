using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T3_P_SQL_Server
{
    public partial class Form1 : Form
    {

        SqlConnection conexion;


        public Form1()
        {
            InitializeComponent();



        }

        private void btnBDConnection_Click(object sender, EventArgs e)
        {
            // Conexión a localhost
            conexion = new SqlConnection("server=localhost; database=tienda; integrated security = true; TrustServerCertificate=true");

            // Conexión a usuario concreto
            //conexion = new SqlConnection("server=localhost; database=tienda; user=someUser; password=somePassword; TrustServerCertificate=true");

            // Conexión mediante configuración (origen de datos)
            //string conexionByConfiguration = ConfigurationManager.ConnectionStrings["T3_P_SQL_Server.Properties.Settings.tiendaConnectionString"].ConnectionString;
            //conexion = new SqlConnection(conexionByConfiguration);


            conexion.Open();


        }

        private void btnBDDisconnection_Click(object sender, EventArgs e)
        {
            conexion.Close();
        }

        private void btnInsertarRegistros_Click(object sender, EventArgs e)
        {
            if (conexion?.State == System.Data.ConnectionState.Open)
            {
                // InsertSinParametros();

                InsertConParametros();
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (conexion?.State == System.Data.ConnectionState.Open)
            {
                string query = "SELECT * FROM fabricante";

                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader registros = comando.ExecuteReader();

                textResultadoConsulta.Text = "";
                while (registros.Read())
                {
                    textResultadoConsulta.Text += registros["codigo"] + " ";
                    textResultadoConsulta.Text += registros["nombre"];
                    textResultadoConsulta.Text += Environment.NewLine;
                }

                registros.Close();
            }
        }

        private void InsertSinParametros()
        {
            string inputFabricanteCodigo = txtFabricanteCodigo.Text;
            string inputFabricanteNombre = txtFabricanteNombre.Text;

            // Se construye la consulta
            string query = "INSERT INTO fabricante values (" + inputFabricanteCodigo + ", '" + inputFabricanteNombre + "')";

            // Constructor del SqlCommand, quien laneja la query
            SqlCommand comando = new SqlCommand(query, conexion);

            // ExecuteNonQuery se utiliza para INSERT, UPDATE, DELETE
            int registrosAfectados = comando.ExecuteNonQuery();

            if (registrosAfectados > 0)
            {
                MessageBox.Show("Realizado con éxito");
            }
        }

        private void InsertConParametros()
        {
            int inputFabricanteCodigo;

            int.TryParse(txtFabricanteCodigo.Text, out inputFabricanteCodigo);

            string inputFabricanteNombre = txtFabricanteNombre.Text;

            // Se construye la consulta
            string query = "INSERT INTO fabricante values (@inputFabricanteCodigo, @inputFabricanteNombre)";

            SqlCommand comando = new SqlCommand(query, conexion);

            //comando.Parameters.Add("@inputFabricanteCodigo", SqlDbType.Int);
            //comando.Parameters.Add("@inputFabricanteNombre", SqlDbType.VarChar);

            //comando.Parameters["@inputFabricanteCodigo"].Value = inputFabricanteCodigo;
            //comando.Parameters["@inputFabricanteNombre"].Value = inputFabricanteNombre;

            // Manera alternativa sin tener que especificar tipos
            comando.Parameters.AddWithValue("@inputFabricanteCodigo", inputFabricanteCodigo);
            comando.Parameters.AddWithValue("@inputFabricanteNombre", inputFabricanteNombre);


            comando.ExecuteNonQuery();
        }

        // SqlDataAdapter
        private void btnConsultarConDataAdapter_Click(object sender, EventArgs e)
        {
            if (conexion?.State == System.Data.ConnectionState.Open)
            {
                string query = "SELECT * FROM fabricante";

                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataAdapter miDataAdapter = new SqlDataAdapter(comando);

                using (miDataAdapter)
                {
                    DataTable DTAFabricantes = new DataTable();
                    miDataAdapter.Fill(DTAFabricantes);

                    ListBoxFabricantes.ValueMember = "codigo";
                    ListBoxFabricantes.DisplayMember = "nombre";
                    ListBoxFabricantes.DataSource = DTAFabricantes.DefaultView;
                }

            }
        }
    }
}

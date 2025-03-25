using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using Dapper;
using Dapper.Contrib.Extensions;

namespace T4_P_Dapper
{
    public partial class Form1 : Form
    {
        //const string _connectionString = "Initial Catalog=Futbol; Data Source=localhost; Integrated Security=SSPI";
        const string _connectionString = "server=localhost; database=Futbol; integrated security = true; TrustServerCertificate=true";

        public Form1()
        {
            InitializeComponent();
            CargarComboEquipo();
        }

        private SqlConnection IniciarConexion()
        {
            SqlConnection conexion = new SqlConnection(_connectionString);
            conexion.Open();
            return conexion;
        }

        #region DB
        private List<Equipo> GetEquipos()
        {
            using (SqlConnection conexion = IniciarConexion())
            {
                return (List<Equipo>)conexion.GetAll<Equipo>();
            }
        }

        private Equipo GetEquipoById(string codigoEquipo)
        {
            using (SqlConnection conexion = IniciarConexion())
            {
                return conexion.Get<Equipo>(codigoEquipo);
            }
        }

        private List<Futbolista> GetJugadoresByEquipo(string codigoEquipo)
        {
            string consulta = $"SELECT * FROM Futbolistas WHERE CodigoEquipo = '{codigoEquipo}'";

            using (SqlConnection conexion = IniciarConexion())
            {
                List<Futbolista> listaFutbolistas = (List<Futbolista>)conexion.Query<Futbolista>(consulta);

                return listaFutbolistas;
            }
        }

        private void InsertEquipo(Equipo equipo)
        {
            using (SqlConnection conexion = IniciarConexion())
            {
                conexion.Insert(equipo);
            }
        }

        private void InsertJugador(Futbolista futbolista)
        {
            using (SqlConnection conexion = IniciarConexion())
            {
                conexion.Insert(futbolista);
            }
        }

        private void UpdateJugador(Futbolista futbolista)
        {
            using (SqlConnection conexion = IniciarConexion())
            {
                conexion.Update(futbolista);
            }
        }

        private void DeleteJugador(Futbolista futbolista)
        {
            using (SqlConnection conexion = IniciarConexion())
            {
                conexion.Delete(futbolista);
            }
        }

        private void DeleteAllJugadores()
        {
            using (SqlConnection conexion = IniciarConexion())
            {
                conexion.DeleteAll<Futbolista>();
            }
        }

        #endregion

        private void CargarComboEquipo()
        {
            comboFEquipo.DataSource = GetEquipos();
            comboFEquipo.DisplayMember = "Nombre";
            comboFEquipo.ValueMember = "Codigo";
            comboFEquipoDetail.DataSource = GetEquipos();
            comboFEquipoDetail.DisplayMember = "Nombre";
            comboFEquipoDetail.ValueMember = "Codigo";
        }

        #region Listeners
        private void btnBuscarEquipos_Click(object sender, EventArgs e)
        {
            lstbxEquipos.DataSource = GetEquipos();
        }


        private void btnConsultarJugadores_Click(object sender, EventArgs e)
        {
            if (lstbxEquipos.SelectedItems.Count > 0)
            {
                Equipo equipo = (Equipo)lstbxEquipos.SelectedItem;
                lstbxJugadoresEquipo.DataSource = GetJugadoresByEquipo(equipo.Codigo);
            }

        }

        private void btnInsertarEquipo_Click(object sender, EventArgs e)
        {
            Equipo equipo = new Equipo();
            equipo.Codigo = txtECodigoEquipo.Text;
            equipo.Nombre = txtENombreEquipo.Text;
            InsertEquipo(equipo);

            txtECodigoEquipo.Clear();
            txtENombreEquipo.Clear();
        }

        private void btnInsertarJugador_Click(object sender, EventArgs e)
        {
            Futbolista futbolista = new Futbolista();
            futbolista.Codigo = txtFCodigo.Text;
            futbolista.Nombre = txtFNombre.Text;
            Equipo equipoSeleccionado = comboFEquipo.SelectedItem as Equipo;
            futbolista.CodigoEquipo = equipoSeleccionado.Codigo;
            InsertJugador(futbolista);

            txtFCodigo.Clear();
            txtFNombre.Clear();
        }

        private void btnUpdateJugador_Click(object sender, EventArgs e)
        {
            Futbolista futbolista = lstbxJugadoresEquipo.SelectedItem as Futbolista;
            if (futbolista != null)
            {
                futbolista.Nombre = txtFNombreDetail.Text;
                Equipo equipoSeleccionado = comboFEquipoDetail.SelectedItem as Equipo;
                futbolista.CodigoEquipo = equipoSeleccionado.Codigo;

                UpdateJugador(futbolista);
            }
        }

        private void btnEliminarJugador_Click(object sender, EventArgs e)
        {
            Futbolista jugadorSeleccionado = lstbxJugadoresEquipo.SelectedItem as Futbolista;

            DeleteJugador(jugadorSeleccionado);
            pnlJugadorDetail.Visible = false;
        }

        private void lstbxJugadoresEquipo_DoubleClick(object sender, EventArgs e)
        {
            pnlJugadorDetail.Visible = true;
            Futbolista jugadorSeleccionado = lstbxJugadoresEquipo.SelectedItem as Futbolista;
            txtFNombreDetail.Text = jugadorSeleccionado.Nombre;

            comboFEquipoDetail.SelectedValue = jugadorSeleccionado.CodigoEquipo;
        }

        #endregion
    }
}

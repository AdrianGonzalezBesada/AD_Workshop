using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using Dapper.Contrib.Extensions;

namespace T4_P_Dapper
{
    public partial class Form1 : Form
    {
        const string _stringConnection = "Initial Catalog=Futbol; Data Source=localhost; Integrated Security=SSPI";
        SqlConnection _conexion;

        public Form1()
        {
            InitializeComponent();
            CargarComboEquipo();
        }

        private SqlConnection IniciarConexion()
        {
            _conexion = new SqlConnection(_stringConnection);
            _conexion.Open();
            return _conexion;
        }

        #region DB
        private List<Equipo> GetEquipos()
        {
            using (IniciarConexion())
            {
                return (List<Equipo>)_conexion.GetAll<Equipo>();
            }
        }

        private Equipo GetEquipoById(string codigoEquipo)
        {
            using (IniciarConexion())
            {
                return _conexion.Get<Equipo>(codigoEquipo);
            }
        }

        private List<Futbolista> GetJugadoresByEquipo(string codigoEquipo)
        {
            string consulta = $"SELECT * FROM Futbolistas WHERE CodigoEquipo = '{codigoEquipo}'";

            using (IniciarConexion())
            {
                List<Futbolista> listaFutbolistas = (List<Futbolista>)_conexion.Query<Futbolista>(consulta);

                return listaFutbolistas;
            }
        }

        private void InsertEquipo(Equipo equipo)
        {
            using (IniciarConexion())
            {
                _conexion.Insert(equipo);
            }
        }

        private void InsertJugador(Futbolista futbolista)
        {
            using (IniciarConexion())
            {
                _conexion.Insert(futbolista);
            }
        }

        private void UpdateJugador(Futbolista futbolista)
        {
            using (IniciarConexion())
            {
                _conexion.Update(futbolista);
            }
        }

        private void DeleteJugador(Futbolista futbolista)
        {
            using (IniciarConexion())
            {
                _conexion.Delete(futbolista);
            }
        }

        private void DeleteAllJugadores()
        {
            using (IniciarConexion())
            {
                _conexion.DeleteAll<Futbolista>();
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

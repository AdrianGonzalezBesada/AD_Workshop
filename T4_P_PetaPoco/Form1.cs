using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetaPoco;

namespace T4_P_PetaPoco
{
    public partial class Form1 : Form
    {
        const string _stringConnection = "Initial Catalog=Futbol; Data Source=localhost; Integrated Security=SSPI";
        Database _conexion;

        public Form1()
        {
            InitializeComponent();
            CargarComboEquipo();
        }

        private Database IniciarConexion()
        {
            _conexion = new PetaPoco.Database(_stringConnection);
            return _conexion;
        }

        #region DB
        private List<Equipo> GetEquipos()
        {
            using (IniciarConexion())
            {
                return _conexion.Fetch<Equipo>();
            }
        }

        private Equipo GetEquipoById(string codigoEquipo)
        {
            using (IniciarConexion())
            {
                return _conexion.Single<Equipo>(codigoEquipo);
            }
        }

        private List<Futbolista> GetJugadoresByEquipo(string codigoEquipo)
        {
            string consulta = $"SELECT * FROM Futbolistas WHERE CodigoEquipo = '{codigoEquipo}'";

            using (IniciarConexion())
            {
                List<Futbolista> listaFutbolistas;

                return listaFutbolistas = _conexion.Fetch<Futbolista>(consulta);
            }
        }

        private void InsertEquipo(Equipo equipo)
        {
            using (IniciarConexion())
            {
                try
                {
                    _conexion.BeginTransaction();

                    _conexion.Insert(equipo);

                    _conexion.CompleteTransaction();

                }
                catch (Exception ex)
                {
                    _conexion.AbortTransaction();
                    Console.WriteLine(ex.ToString());
                }
            }
        }

        private void InsertJugador(Futbolista futbolista)
        {
            using (IniciarConexion())
            {
                _conexion.Insert("Futbolistas", "Codigo", false, futbolista);
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
                _conexion.Delete<Futbolista>("");
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

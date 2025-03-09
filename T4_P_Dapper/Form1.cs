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

        public Form1()
        {
            InitializeComponent();
            CargarComboEquipo();
        }

        #region DB
        private List<Equipo> GetEquipos()
        {
            using (SqlConnection db = new SqlConnection(_stringConnection))
            {
                return (List<Equipo>)db.GetAll<Equipo>();
            }
        }

        private Equipo GetEquipoById(string codigoEquipo)
        {
            using (SqlConnection db = new SqlConnection(_stringConnection))
            {
                return db.Get<Equipo>(codigoEquipo);
            }
        }

        private List<Futbolista> GetJugadoresByEquipo(string codigoEquipo)
        {
            string consulta = $"SELECT * FROM Futbolistas WHERE CodigoEquipo = '{codigoEquipo}'";

            using (SqlConnection db = new SqlConnection(_stringConnection))
            {
                List<Futbolista> listaFutbolistas = (List<Futbolista>)db.Query<Futbolista>(consulta);

                return listaFutbolistas;
            }
        }

        private void InsertEquipo(Equipo equipo)
        {
            using (SqlConnection db = new SqlConnection(_stringConnection))
            {
                db.Insert(equipo);
            }
        }

        private void InsertJugador(Futbolista futbolista)
        {
            using (SqlConnection db = new SqlConnection(_stringConnection))
            {
                db.Insert(futbolista);
            }
        }

        private void UpdateJugador(Futbolista futbolista)
        {
            using (SqlConnection db = new SqlConnection(_stringConnection))
            {
                db.Update(futbolista);
            }
        }

        private void DeleteJugador(Futbolista futbolista)
        {
            using (SqlConnection db = new SqlConnection(_stringConnection))
            {
                db.Delete(futbolista);
            }
        }

        private void DeleteAllJugadores()
        {
            using (SqlConnection db = new SqlConnection(_stringConnection))
            {
                db.DeleteAll<Futbolista>();
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

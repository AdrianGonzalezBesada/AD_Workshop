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

        private List<Equipo> GetEquipos()
        {
            string consulta = "SELECT * FROM Equipos";

            using (SqlConnection db = new SqlConnection(_stringConnection))
            {
                List<Equipo> listaEquipos = (List<Equipo>)db.Query<Equipo>(consulta);

                return listaEquipos;
            }
        }

        private Equipo GetEquipoById(string codigoEquipo)
        {
            string consulta = $"SELECT TOP 1 * FROM Equipos WHERE Codigo = '{codigoEquipo}'";

            using (SqlConnection db = new SqlConnection(_stringConnection))
            {
                Equipo equipo = (Equipo)db.Query<Equipo>(consulta).FirstOrDefault();

                return equipo;
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
            string consulta = $"INSERT INTO Equipos VALUES (" +
                $"'{equipo.Codigo}'," +
                $"'{equipo.Nombre}'," +
                $"'{equipo.Pais}'," +
                $"{equipo.Goles}," +
                $"{equipo.Puntos}," +
                $"'{equipo.PJ}'," +
                $"{equipo.PG}," +
                $"{equipo.PE}," +
                $"{equipo.PP}," +
                $"'{equipo.Estadio}'," +
                $"'{equipo.Ciudad}'" +
                $")";

            using (SqlConnection db = new SqlConnection(_stringConnection))
            {
                db.Execute(consulta);
            }
        }

        private void InsertJugador(Futbolista futbolista)
        {
            string consulta = "INSERT INTO Futbolistas (Codigo,Nombre,CodigoEquipo,Posicion,Edad,Goles,TA,TR,Minutos,PrecioMercado,Dorsal,Peso) VALUES (" +
                $"'{futbolista.Codigo}'," +
                $"'{futbolista.Nombre}'," +
                $"'{futbolista.CodigoEquipo}'," +
                $"'{futbolista.Posicion}'," +
                $"{futbolista.Edad}," +
                $"{futbolista.Goles}," +
                $"{futbolista.TA}," +
                $"{futbolista.TR}," +
                $"{futbolista.Minutos}," +
                $"'{futbolista.PrecioMercado}'," +
                $"{futbolista.Dorsal}," +
                $"{futbolista.Peso}" +
                ")";

            using (SqlConnection db = new SqlConnection(_stringConnection))
            {
                db.Execute(consulta);
            }
        }

        private void UpdateJugador(Futbolista futbolista)
        {
            if (!string.IsNullOrEmpty(futbolista.Codigo))
            {
                string sufijo = ", ";

                string consulta = "UPDATE Futbolistas SET ";

                if (!string.IsNullOrEmpty(futbolista.Nombre))
                    consulta += $"Nombre = '{futbolista.Nombre}', ";

                if (!string.IsNullOrEmpty(futbolista.CodigoEquipo))
                    consulta += $"CodigoEquipo = '{futbolista.CodigoEquipo}', ";

                if (consulta.EndsWith(sufijo))
                    consulta = consulta.Substring(0, consulta.Length - sufijo.Length);

                consulta += $" WHERE Codigo = '{futbolista.Codigo}'";

                if (!consulta.Contains("UPDATE Futbolistas SET WHERE"))
                {

                    using (SqlConnection db = new SqlConnection(_stringConnection))
                    {
                        db.Execute(consulta);
                    }

                }
            }
        }

        private void DeleteJugador(Futbolista futbolista)
        {
            string consulta = $"DELETE FROM Futbolistas WHERE Codigo = @Codigo";

            if (!string.IsNullOrEmpty(futbolista.Codigo))
            {

                using (SqlConnection db = new SqlConnection(_stringConnection))
                {
                    db.Execute(consulta, futbolista);
                }
            }
        }

        private void CargarComboEquipo()
        {
            comboFEquipo.DataSource = GetEquipos();
            comboFEquipo.DisplayMember = "Nombre";
            comboFEquipo.ValueMember = "Codigo";
            comboFEquipoDetail.DataSource = GetEquipos();
            comboFEquipoDetail.DisplayMember = "Nombre";
            comboFEquipoDetail.ValueMember = "Codigo";
        }

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

            //foreach (Equipo equipo in comboFEquipoDetail.Items)
            //{
            //    if(equipo.Codigo == jugadorSeleccionado.CodigoEquipo)
            //        comboFEquipoDetail.SelectedItem = equipo;
            //}
        }
    }
}

using Dapper;
using Dapper.Contrib;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace PruebasExamen
{
    public partial class Form1 : Form
    {
        private const string _connectionString = "Server=localhost;Database=Futbol;Integrated Security=True;TrustServerCertificate=True;";

        public Form1()
        {
            InitializeComponent();
        }

        #region Dapper
        private SqlConnection ObtenerConexion()
        {
            SqlConnection conexion = new SqlConnection(_connectionString);
            conexion.Open();
            return conexion;
        }

        private List<Futbolista> GetAllFutbolistas()
        {
            using (SqlConnection conexion = ObtenerConexion())
            {
                return (List<Futbolista>)conexion.GetAll<Futbolista>();
            }
        }

        private Futbolista GetFutbolistaById(string pcodigo)
        {
            using (SqlConnection conexion = ObtenerConexion())
            {
                return conexion.Get<Futbolista>(pcodigo);
            }
        }

        private void DeleteFutbolista(Futbolista pFutbolista)
        {
            using (SqlConnection conexion = ObtenerConexion())
            {
                conexion.Delete(pFutbolista);
            }
        }

        private Equipo GetEquipoWithJugadores()
        {
            Equipo newEquipo = null;

            string query = "SELECT e.*, '||' as Split, f.* from Equipos as e INNER JOIN Futbolistas as f ON f.CodigoEquipo = e.Codigo";

            using (SqlConnection conexion = ObtenerConexion())
            {
                conexion.Query<Equipo, Futbolista, Equipo>(query, (equipo, futbolista) =>
                {
                    if (newEquipo == null)
                    {
                        newEquipo = equipo;
                        newEquipo.Futbolistas = new List<Futbolista>();
                    }

                    newEquipo.Futbolistas.Add(futbolista);
                    return null;
                }, splitOn: "Split");

                return newEquipo;
            }
        }


        private List<Equipo> GetEquiposWithJugadores()
        {
            List<Equipo> lstEquipos = new List<Equipo>();

            string query = "SELECT e.*, '||' as Split, f.* from Equipos as e INNER JOIN Futbolistas as f ON f.CodigoEquipo = e.Codigo";

            using (SqlConnection conexion = ObtenerConexion())
            {
                conexion.Query<Equipo, Futbolista, Equipo>(query, (equipo, futbolista) =>
                {
                    int indexEquipo = lstEquipos.FindIndex(e => e.Codigo == equipo.Codigo);
                    if(indexEquipo == -1)
                    {
                        lstEquipos.Add(equipo);
                        indexEquipo = lstEquipos.FindIndex(e => e.Codigo == equipo.Codigo);

                    }

                    if (futbolista.Codigo != null)
                    {
                        if (lstEquipos[indexEquipo].Futbolistas == null)
                            lstEquipos[indexEquipo].Futbolistas = new List<Futbolista>();

                        lstEquipos[indexEquipo].Futbolistas.Add(futbolista);
                    }

                    return null;
                }, splitOn: "Split");

                return lstEquipos;
            }
        }

        #endregion

        #region Ficheros

        private void EscribirFichero(string ruta, string texto, bool isSobreescribir)
        {
            StreamWriter fichero = null;

            if (isSobreescribir)
            {
                fichero = File.CreateText(ruta);
            }
            else
            {
                fichero = File.AppendText(ruta);
            }

            fichero.WriteLine(texto);

            fichero.Close();
        }

        private string LeerFichero(string ruta)
        {

            if (File.Exists(ruta))
            {
                using (StreamReader fichero = new StreamReader(ruta))
                {
                    return fichero.ReadToEnd();
                }
            }
            else
            {
                MessageBox.Show("asdsad");
                return null;
            }
        }

        #endregion



        private void btnGetFutbolistas_Click(object sender, EventArgs e)
        {
            lstbxFutbolistas.DataSource = GetAllFutbolistas();
            lstbxFutbolistas.DisplayMember = "Nombre";
            lstbxFutbolistas.ValueMember = "Codigo";
        }

        private void btnGetFutbolistasLstvw_Click(object sender, EventArgs e)
        {
            List<Futbolista> lstFutbolistas = GetAllFutbolistas();

            if (lstvwFutbolistas != null)
            {
                var propiedades = typeof(Futbolista).GetProperties();

                foreach (var propiedad in propiedades)
                {
                    lstvwFutbolistas.Columns.Add(propiedad.Name, 130, HorizontalAlignment.Left);
                }

                lstvwFutbolistas.Items.Clear();
                foreach (Futbolista futbolista in lstFutbolistas)
                {
                    ListViewItem item = new ListViewItem(propiedades[0].GetValue(futbolista).ToString());

                    for (int i = 1; i < propiedades.Length; i++)
                    {
                        item.SubItems.Add(propiedades[i].GetValue(futbolista)?.ToString());

                    }
                    item.Tag = futbolista.Codigo; // Permite guardar el objeto entero
                    lstvwFutbolistas.Items.Add(item);
                }
            }
        }

        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            string selectedFutbolistaCodigo = lstvwFutbolistas.SelectedItems[0].Tag.ToString();
            Futbolista futbolistaSeleccionado = GetFutbolistaById(selectedFutbolistaCodigo);

            DeleteFutbolista(futbolistaSeleccionado);

        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string textoAEscribir = tbFicheroAEscribir.Text;

            EscribirFichero("Prueba.txt", textoAEscribir, false);

            tbFicheroAEscribir.Text = LeerFichero("Prueba.txt");

        }

        private void btnGetJugadoresByEquipo_Click(object sender, EventArgs e)
        {
            GetEquipoWithJugadores();

            GetEquiposWithJugadores();
        }
    }
}

using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GonzalezBesadaAdrianTarea2
{
    public partial class Form1 : Form
    {

        string _connectionString = "server=localhost; database=tienda; integrated security = true; TrustServerCertificate=true";
        SqlConnection _conexion = null;

        public Form1()
        {
            InitializeComponent();
            CargarComboConsultas();
        }

        private SqlConnection IniciarConexion()
        {
            _conexion = new SqlConnection(_connectionString);
            _conexion.Open();
            return _conexion;
        }

        private void btnSelectListaProductos_Click(object sender, EventArgs e)
        {

            string query = "SELECT nombre, precio, codigo FROM producto";

            using (IniciarConexion())
            {
                if (_conexion.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand comando = new SqlCommand(query, _conexion);

                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(comando))
                    {
                        DataTable dt = new DataTable();
                        dataAdapter.Fill(dt);

                        lstvwProductos.Clear();

                        if (!lstvwProductos.Columns.ContainsKey("Nombre"))
                            lstvwProductos.Columns.Add("Nombre", 150, HorizontalAlignment.Left);

                        if (!lstvwProductos.Columns.ContainsKey("Precio"))
                            lstvwProductos.Columns.Add("Precio", 50, HorizontalAlignment.Left);

                        foreach (DataRow row in dt.Rows)
                        {
                            ListViewItem item = new ListViewItem(row["nombre"].ToString());

                            item.SubItems.Add(row["precio"].ToString());
                            item.Tag = row["codigo"].ToString();
                            lstvwProductos.Items.Add(item);
                        }
                    }

                }
            }
        }

        private void btnSelectListaFabricantes_Click(object sender, EventArgs e)
        {

            string query = "SELECT nombre, codigo FROM fabricante";

            using (IniciarConexion())
            {
                if (_conexion.State == ConnectionState.Open)
                {
                    SqlCommand comando = new SqlCommand(query, _conexion);

                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(comando))
                    {
                        DataTable dt = new DataTable();
                        dataAdapter.Fill(dt);

                        lstvwFabricantes.Clear();

                        if (!lstvwFabricantes.Columns.ContainsKey("Nombre"))
                            lstvwFabricantes.Columns.Add("Nombre", 150, HorizontalAlignment.Left);

                        foreach (DataRow row in dt.Rows)
                        {
                            ListViewItem item = new ListViewItem(row["nombre"].ToString());

                            item.Tag = row["codigo"].ToString();
                            lstvwFabricantes.Items.Add(item);
                        }
                    }
                }
            }
        }

        private void btnBuscarConRadio_Click(object sender, EventArgs e)
        {
            bool isSelected = false;
            string query = string.Empty;

            if (rbProducto.Checked)
            {
                isSelected = true;
                query = "SELECT * FROM fabricante " +
                    $"WHERE codigo = (SELECT codigo_fabricante FROM producto WHERE nombre = '{txtBusquedaRB.Text}')";
            }
            else if (rbFabricante.Checked)
            {
                isSelected = true;
                query = "SELECT * FROM producto " +
                    $"WHERE codigo_fabricante = (SELECT codigo from fabricante WHERE nombre = '{txtBusquedaRB.Text}')";
            }

            if (isSelected)
            {
                using (IniciarConexion())
                {

                    SqlCommand comando = new SqlCommand(query, _conexion);

                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(comando))
                    {
                        DataTable dt = new DataTable();
                        dataAdapter.Fill(dt);

                        lstvwResultadosBusqueda.Items.Clear();
                        lstvwResultadosBusqueda.Columns.Clear();

                        if (rbProducto.Checked)
                        {
                            lstvwResultadosBusqueda.Columns.Add("Nombre", 150, HorizontalAlignment.Left);
                            lstvwResultadosBusqueda.Columns.Add("Código", 50, HorizontalAlignment.Left);

                            foreach (DataRow row in dt.Rows)
                            {
                                ListViewItem item = new ListViewItem(row["nombre"].ToString());

                                item.SubItems.Add(row["codigo"].ToString());
                                lstvwResultadosBusqueda.Items.Add(item);
                            }

                        }
                        else if (rbFabricante.Checked)
                        {
                            lstvwResultadosBusqueda.Columns.Add("Nombre", 150, HorizontalAlignment.Left);
                            lstvwResultadosBusqueda.Columns.Add("Precio", 50, HorizontalAlignment.Left);
                            lstvwResultadosBusqueda.Columns.Add("Código", 50, HorizontalAlignment.Left);
                            lstvwResultadosBusqueda.Columns.Add("Código fabricante", 100, HorizontalAlignment.Left);

                            foreach (DataRow row in dt.Rows)
                            {
                                ListViewItem item = new ListViewItem(row["nombre"].ToString());

                                item.SubItems.Add(row["precio"].ToString());
                                item.SubItems.Add(row["codigo"].ToString());
                                item.SubItems.Add(row["codigo_fabricante"].ToString());
                                lstvwResultadosBusqueda.Items.Add(item);
                            }

                        }

                    }
                }

            }
        }

        private void btnEliminarSeleccionado_Click(object sender, EventArgs e)
        {
            string elementoSeleccionado = string.Empty;
            string slectedList = string.Empty;

            if (lstvwProductos.SelectedItems.Count > 0)
            {
                slectedList = "producto";
                elementoSeleccionado = lstvwProductos.SelectedItems[0].Tag.ToString();
            }
            else if (lstvwFabricantes.SelectedItems.Count > 0)
            {
                slectedList = "fabricante";
                elementoSeleccionado = lstvwFabricantes.SelectedItems[0].Text;
            }

            if (!string.IsNullOrEmpty(elementoSeleccionado))
            {
                using (IniciarConexion())
                {
                    string query = $"DELETE FROM {slectedList} WHERE codigo = {elementoSeleccionado}";

                    SqlCommand comando = new SqlCommand(query, _conexion);

                    comando.ExecuteNonQuery();
                }
            }
        }

        private void CargarComboConsultas()
        {
            Dictionary<string, string> consultas = new Dictionary<string, string>
            {
                { "Productos ordenados por nombre y precio ascendentemente", "SELECT nombre from producto ORDER BY nombre ASC, precio ASC" },
                { "Productos de entre 60€ y 200€", "SELECT * from producto WHERE precio BETWEEN 60 AND 200" },
                { "Fabricantes de 4 letras", "SELECT nombre FROM fabricante WHERE LEN(nombre) = 4" },
                { "Nombre de producto, precio, y fabricante de toda la base de datos", "SELECT p.nombre as NombreProducto, p.precio, f.nombre as nombreFabricante from producto as p INNER JOIN fabricante as f ON f.codigo = p.codigo_fabricante" },
                { "Productos de Asus, Hewlett-Packard y Seagate", "SELECT p.nombre as NombreProducto, p.precio, f.nombre as nombreFabricante from producto as p INNER JOIN fabricante as f ON f.codigo = p.codigo_fabricante WHERE f.nombre IN ('Asus', 'Hewlett-Packard', 'Seagate')" },
                { "Nombres de los fabricantes ascendentemente", "SELECT nombre FROM fabricante ORDER BY nombre ASC" },
                { "Total de productos", "SELECT COUNT(*) as NumeroDeProductos FROM producto" },
                { "Fabricantes con productos por valor de más de 1000€ en conjunto", "SELECT f.nombre FROM fabricante as f INNER JOIN producto as p ON p.codigo_fabricante = f.codigo GROUP BY f.nombre HAVING SUM(p.precio) > 1000" },
                { "Fabricantes sin productos", "SELECT f.codigo, f.nombre FROM fabricante as f LEFT JOIN producto as p ON p.codigo_fabricante = f.codigo WHERE p.codigo_fabricante IS NULL" },
                { "Recuento de fabricantes con productos cuyo precio es igual o mayor a 220€", "SELECT f.nombre, COUNT(*) AS NumeroProductos FROM fabricante AS f LEFT JOIN producto AS p ON f.codigo = p.codigo_fabricante AND p.precio >= 220 GROUP BY f.nombre;" }
            };

            comboConsultas.DataSource = new BindingSource(consultas, null);
            comboConsultas.DisplayMember = "Key";
            comboConsultas.ValueMember = "Value";
        }

        private void btnEjecutarConsulta_Click(object sender, EventArgs e)
        {
            string consultaSeleccionada = string.Empty;

            if (comboConsultas.SelectedItem != null)
            {
                consultaSeleccionada = comboConsultas.SelectedValue.ToString();
            }

            if (!string.IsNullOrEmpty(consultaSeleccionada))
            {
                using (IniciarConexion())
                {
                    SqlCommand comando = new SqlCommand(consultaSeleccionada, _conexion);

                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(comando))
                    {
                        DataTable dt = new DataTable();
                        dataAdapter.Fill(dt);

                        lstvwResultadoConsulta.Items.Clear();
                        lstvwResultadoConsulta.Columns.Clear();

                        List<string> nombresColumnas = new List<string>();

                        foreach (DataColumn col in dt.Columns)
                        {
                            if (!lstvwResultadoConsulta.Columns.ContainsKey(col.ColumnName))
                                lstvwResultadoConsulta.Columns.Add(col.ColumnName, 100, HorizontalAlignment.Left);

                            nombresColumnas.Add(col.ColumnName);
                        }

                        foreach (DataRow row in dt.Rows)
                        {
                            ListViewItem item = new ListViewItem(row[nombresColumnas[0]].ToString());

                            foreach (string nombreColumna in nombresColumnas)
                            {
                                if(nombreColumna != nombresColumnas[0])
                                    item.SubItems.Add(row[nombreColumna].ToString());
                            }

                            lstvwResultadoConsulta.Items.Add(item);
                        }
                    }

                }
            }

        }
    }
}

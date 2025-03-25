using T6_P_EntityFrameworkCore.Data;

namespace T6_P_EntityFrameworkCore
{
    public partial class Form1 : Form
    {
        private readonly PanaderiaContext _context;

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(PanaderiaContext context)
        {
            _context = context;
            InitializeComponent();
        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            Producto newProducto = new Producto()
            {
                Nombre = tbNombre.Text,
                Precio = float.Parse(tbPrecio.Text),
                Stock = int.Parse(tbStock.Text)
            };

            _context.Productos.Add(newProducto);
            _context.SaveChanges();
            MessageBox.Show("Producto guardado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            tbNombre.Clear();
            tbPrecio.Clear();
            tbStock.Clear();
        }

        private void btnVisualizarProductos_Click(object sender, EventArgs e)
        {
            dgvProductos.DataSource = _context.Productos.ToList();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6_P_EntityFrameworkCore_DB_Frist.Models
{
    public class PanaderiaProducto
    {
        public int PanaderiaId { get; set; }
        public Panaderia Panaderia { get; set; }
        public int ProductoId { get; set; }
        public Producto Producto { get; set; }
        public float Precio { get; set; }
        public string Stock { get; set; }
    }
}

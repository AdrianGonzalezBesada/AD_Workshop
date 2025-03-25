using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6_P_EntityFrameworkCore.Data
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public float Precio { get; set; }
        public int Stock { get; set; }
    }
}

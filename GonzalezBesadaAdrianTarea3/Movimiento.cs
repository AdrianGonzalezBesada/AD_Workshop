using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GonzalezBesadaAdrianTarea3
{
    [Table("Movimiento")]
    internal class Movimiento
    {
        [Key]
        public int id_movimiento { get; set; }
        public string nombre { get; set; }
        public int potencia { get; set; }
        public int precision_mov { get; set; }
        public string descripcion { get; set; }
        public int pp { get; set; }
        public int id_tipo { get; set; }
        public int prioridad { get; set; }
            
            
            
            
            
            
            
            




    }
}

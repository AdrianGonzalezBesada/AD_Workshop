using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GonzalezBesadaAdrianTarea3
{
    [Table("tipo")]
    internal class Tipo
    {
        [Key]
        public int id_tipo { get; set; }
        public string nombre { get; set; }
        public int id_tipo_ataque { get; set; }
    }
}

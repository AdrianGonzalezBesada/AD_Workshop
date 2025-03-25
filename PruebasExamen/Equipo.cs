using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib;
using Dapper.Contrib.Extensions;

namespace PruebasExamen
{
    [Table("Equipos")]
    public class Equipo
    {
        [ExplicitKey]
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Pais { get; set; }
        public int Goles { get; set; }
        public int Puntos { get; set; }
        public string PJ { get; set; }
        public int PG { get; set; }
        public int PE { get; set; }
        public int PP { get; set; }
        public string Estadio { get; set; }
        public string Ciudad { get; set; }
        public List<Futbolista> Futbolistas { get; set; }

    }
}

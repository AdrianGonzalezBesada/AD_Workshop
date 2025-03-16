using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4_P_PetaPoco
{
    [TableName("Equipos")]
    [PrimaryKey("Codigo", AutoIncrement = false)]
    internal class Equipo
    {
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

        public override string ToString()
        {
            return this.Nombre;
        }
    }
}
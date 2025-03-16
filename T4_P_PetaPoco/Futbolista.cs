using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4_P_PetaPoco
{
    [TableName("Futbolistas")]
    [PrimaryKey("Codigo", AutoIncrement = false)]
    internal class Futbolista
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string CodigoEquipo { get; set; }
        public string Posicion { get; set; }
        public int Edad { get; set; }
        public int Goles { get; set; }
        public int TA { get; set; }
        public int TR { get; set; }
        public int Minutos { get; set; }
        public string PrecioMercado { get; set; }
        public int Dorsal { get; set; }
        public int Peso { get; set; }


        public override string ToString()
        {
            return this.Nombre;
        }
    }
}

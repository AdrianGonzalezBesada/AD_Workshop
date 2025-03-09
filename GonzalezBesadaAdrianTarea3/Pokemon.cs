using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GonzalezBesadaAdrianTarea3
{
    [Table("pokemon")]
    internal class Pokemon
    {
        [Key]
        public int PokemonId { get; set; }
        public string nombre { get; set; }
        public float peso { get; set; }
        public float altura { get; set; }
        public int ps { get; set; }
        public int defensa { get; set; }
        public int especial { get; set; }
        public int velocidad { get; set; }
        public List<Tipo> tipos { get; set; }
        public List<Movimiento> Movimientos { get; set; }
        public List<Pokemon> Involuciones { get; set; }
        public List<Pokemon> Evoluciones { get; set; }

        //public int MyProperty { get; set; }
        //public int MyProperty { get; set; }
        //public int MyProperty { get; set; }
        //public int MyProperty { get; set; }
        //public int MyProperty { get; set; }
        //public int MyProperty { get; set; }
        //public int MyProperty { get; set; }
        //public int MyProperty { get; set; }
        //public int MyProperty { get; set; }
        //public int MyProperty { get; set; }


    }
}

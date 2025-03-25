using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Mapping.Attributes;

namespace T5_P_NHibernate.Entities
{
    [Serializable]
    [Class( Schema = "dbo", Table = "Estudiantes", NameType = typeof(Estudiante))]
    public class Estudiante
    {
        [Id(Name = "IdEstudiante", Column = "IdEstudiante", Type = "int"), Generator(1, Class = "identity")]
        public virtual int IdEstudiante { get; set; }
        [Property(Column = "NombreEstudiante", Type = "string", NotNull = false)]
        public virtual string NombreEstudiante { get; set; }
        [Property(Column = "DescripcionEstudiante", Type = "string", NotNull = false)]
        public virtual string DescripcionEstudiante { get; set; }
        public virtual List<Instituto> ListaEstudiantes { get; set; }
    }
}

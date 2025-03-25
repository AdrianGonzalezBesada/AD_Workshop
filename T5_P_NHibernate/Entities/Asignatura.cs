using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Mapping.Attributes;

namespace T5_P_NHibernate.Entities
{
    [Serializable]
    [Class(Schema = "dbo", Table = "Asignatura", NameType = typeof(Asignatura))]
    public class Asignatura
    {
        [Id(Name = "IdAsignatura", Column = "IdAsignatura", Type = "int"), Generator(1, Class = "identity")]
        public virtual int IdAsignatura { get; set; }
        [Property(Column = "NombreAsignatura", Type = "string", NotNull = false)]
        public virtual string NombreAsignatura { get; set; }
        [Property(Column = "DescripcionAsignatura", Type = "string", NotNull = false)]
        public virtual string DescripcionAsignatura { get; set; }
        public virtual List<Estudiante> ListaAsignaturas { get; set; }
    }
}

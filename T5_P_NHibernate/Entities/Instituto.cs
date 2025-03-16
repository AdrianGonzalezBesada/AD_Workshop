using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Mapping.Attributes;
using T5_P_NHibernate.Entities;


namespace T5_P_NHibernate.Entities
{
    [Serializable]
    [Class(Schema = "dbo", Table = "Instituto", NameType = typeof(Instituto))]
    public class Instituto
    {
        [Id(Name = "IdInstituto", Column = "IdInstituto", Type = "int"), Generator(1, Class = "identity")]
        public virtual int IdInstituto { get; set; }
        [Property(Column = "NombreAsignatura", Type = "string", NotNull = false)]
        public virtual string NombreAsignatura { get; set; }
        [Property(Column = "DescripcionInstituto", Type = "string", NotNull = false)]
        public virtual string DescripcionInstituto { get; set; }
        public virtual List<Instituto> ListaInstitutos { get; set; }
    }
}

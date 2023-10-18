using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core.Entities
{
    public class PermisosGenericos : BaseEntity
    {
        public string NombrePermiso { get; set; }
        public ICollection<GenericosvsSubModulos> GenericosvsSubModulos {get; set;}
    }
}
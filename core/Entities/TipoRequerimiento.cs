using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core.Entities
{
    public class TipoRequerimiento : BaseEntity
    {
        public string Nombre { get; set; }
        public ICollection<ModuloNoficaciones> ModuloNoficaciones {get; set;}
    }
}
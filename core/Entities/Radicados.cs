using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core.Entities
{
    public class Radicados : BaseEntity
    {
        public ICollection<ModuloNoficaciones> ModuloNoficaciones {get; set;}
    }
}
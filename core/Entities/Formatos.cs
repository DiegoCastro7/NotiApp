using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace core.Entities
{
    public class Formatos : BaseEntity
    {
        [Required]
        public string NombreFormato { get; set; }
        public ICollection<ModuloNoficaciones> ModuloNoficaciones {get; set;}
    }
}
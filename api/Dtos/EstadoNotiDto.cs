using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.Entities;

namespace api.Dtos
{
    public class EstadoNotiDto
    {
        public int Id { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public string NombreEstado { get; set; }
        public ICollection<ModuloNoficaciones> ModuloNoficaciones {get; set;}
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.Entities;

namespace api.Dtos
{
    public class SubmodulosDto
    {
        public int Id { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public string NombreSubmodulo { get; set; }
        public ICollection<MaestrosvsSubModulos> MaestrosvsSubModulos {get; set;}
    }
}
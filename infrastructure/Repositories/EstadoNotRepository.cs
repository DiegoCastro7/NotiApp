using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.Entities;
using core.Interfaces;
using infrastructure.Data;

namespace infrastructure.Repositories
{
    public class EstadoNotRepository : GenericRepository<EstadoNotificacion>, IEstadoNotificacion
    {
        private readonly NotiAppContext _context;
        public EstadoNotRepository(NotiAppContext context) : base(context)
        {
            _context = context;
        }
    }
}
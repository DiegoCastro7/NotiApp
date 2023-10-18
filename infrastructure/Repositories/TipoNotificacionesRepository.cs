using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.Entities;
using core.Interfaces;
using infrastructure.Data;

namespace infrastructure.Repositories
{
    public class TipoNotificacionesRepository : GenericRepository<TipoNotificaciones>, ITipoNotificaciones
    {
        private readonly NotiAppContext _context;
        public TipoNotificacionesRepository(NotiAppContext context) : base(context)
        {
            _context = context;
        }
    }
}
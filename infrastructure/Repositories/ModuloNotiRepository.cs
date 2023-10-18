using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.Entities;
using core.Interfaces;
using infrastructure.Data;

namespace infrastructure.Repositories
{
    public class ModuloNotiRepository : GenericRepository<ModuloNoficaciones>, IModuloNotificaciones
    {
        private readonly NotiAppContext _context;
        public ModuloNotiRepository(NotiAppContext context) : base(context)
        {
            _context = context;
        }
    }
}
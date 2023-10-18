using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.Entities;
using core.Interfaces;
using infrastructure.Data;

namespace infrastructure.Repositories
{
    public class PermisosGenericosRepository : GenericRepository<PermisosGenericos>, IPermisosGenericos
    {
        private readonly NotiAppContext _context;
        public PermisosGenericosRepository(NotiAppContext context) : base(context)
        {
            _context = context;
        }
    }
}
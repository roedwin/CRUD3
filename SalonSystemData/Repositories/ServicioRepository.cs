using EscuelaSystemData.Interface;
using EscuelaSystemModules;
using System;
using System.Collections.Generic;
using System.Text;

namespace EscuelaSystemData.Repositories
{
    public class ServicioRepository : Repository<Servicio>, IServicioRepository
    {
        private readonly ApplicationDbContext _db;
        public ServicioRepository(ApplicationDbContext db): base(db)
        {
        }
    }
}

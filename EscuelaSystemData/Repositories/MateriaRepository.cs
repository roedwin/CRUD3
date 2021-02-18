using EscuelaSystemData.Interface;
using EscuelaSystemModules;
using System;
using System.Collections.Generic;
using System.Text;

namespace EscuelaSystemData.Repositories
{
    public class MateriaRepository : Repository<Materia>, IMateriaRepository
    {
        private readonly ApplicationDbContext _db;
        public MateriaRepository(ApplicationDbContext db): base(db)
        {
        }
    }
}

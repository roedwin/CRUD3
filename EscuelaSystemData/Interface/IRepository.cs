using EscuelaSystemModules;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace EscuelaSystemData.Interface
{
    public interface IRepository<T> where T : EntityBase
    {
        T GetByID(int id);
        IEnumerable<T> List();
        IEnumerable<T> List(Expression<Func<T, bool>> predicate);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}

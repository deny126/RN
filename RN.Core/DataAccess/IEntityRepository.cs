using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using RN.Core.Entities;

namespace RN.Core.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntityBase, new()
    {
        T Get(Expression<Func<T, bool>> filter = null);

        List<T> GetList(Expression<Func<T, bool>> filter = null);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}

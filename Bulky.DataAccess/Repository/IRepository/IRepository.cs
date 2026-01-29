using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Bulky.DataAccess.Repository.IRepository
{
    internal interface IRepository <T> where T : class
    {
        //T - Category
        IEnumerable<T> GetAll();
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);

    }
}

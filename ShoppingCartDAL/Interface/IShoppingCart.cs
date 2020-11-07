using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCartDAL.Interface
{
    public interface IShoppingCart<T>
    {
        IEnumerable<T> GetAll();

        T Get(Guid id);
        void Add(T entity);
        void Update(T entity);
        void Delete(Guid id);
        void Commit();
    }
}

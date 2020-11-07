using ShoppingCartDAL.Interface;
using ShoppingInfra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCartDAL.Repositories
{
    public class ShoppingCart<T> : IShoppingCart<T> where T: class
    {
        public AppDbContext DbContext { get; }
        public ShoppingCart(AppDbContext dbContext)
        {
            DbContext = dbContext;
        }       

        public IEnumerable<T> GetAll()
        {
            return DbContext.Set<T>().ToList();
        }

        public T Get(Guid id)
        {
            if (id == null)
                return null;

            return DbContext.Set<T>().Find(id);
        }

        public void Add(T entity)
        {
            if (entity == null)
                return;

            DbContext.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            if (entity == null)
                return;

            DbContext.Set<T>().Update(entity);
        }

        public void Delete(Guid id)
        {
            if (id == null)
                return;

            T _entity = DbContext.Set<T>().Find(id);

            DbContext.Set<T>().Remove(_entity);
        }

        public void Commit()
        {
            DbContext.SaveChanges();
        }
    }
}

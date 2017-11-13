using App.Core.DomainEntitity;
using System.Linq;

namespace App.Core
{
    public class Repository<T> : IRepository<T> where T : BaseEntity

    {
        public void Insert(T entity)
        {
            throw new System.NotImplementedException();
        }

        public T Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public IQueryable<T> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public IQueryable<T> GetQueryable(long id)
        {
            throw new System.NotImplementedException();
        }

        public IQueryable<T> GetQueryable()
        {
            throw new System.NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new System.NotImplementedException();
        }
        public void Delete(T entity)
        {
            throw new System.NotImplementedException();
        }
    }
}

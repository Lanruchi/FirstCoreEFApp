
using App.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace App.Repo
{
    public class Repository<T> : IRepository<T> where T : BaseEntity

    {
        private readonly ApplicationContext context;
        private DbSet<T> entities;
        string errorMessage = string.Empty;

        public Repository(ApplicationContext context)
        {
            this.context = context;
            entities = context.Set<T>();
        }

        public void Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentException("entity insert");
            }
            entities.Add(entity);
            SaveChanges();

        }

        public T Get(long id)
        {
            return entities.Find(id);

        }

        public IQueryable<T> GetAll()
        {
            return entities.AsQueryable();
        }

        public IQueryable<T> GetQueryable()
        {
            return entities.AsQueryable();
        }
        public IQueryable<T> GetQueryable(long id)
        {
            return entities.Where(x => x.Id == id).AsQueryable();
        }

        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity update");
            }
            SaveChanges();
        }

        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity delete");
            }
            entities.Remove(entity);
            SaveChanges();
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}

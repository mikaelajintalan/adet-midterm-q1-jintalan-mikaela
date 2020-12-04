using app.domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace app.repository
{
    public class GenericRepository<T> : IRepository<T> where T : BaseEntity
    {

        private readonly MvcMovieContext context;
        private DbSet<T> entities;

        public GenericRepository(MvcMovieContext context)
        {

            this.context = context;
            entities = context.Set<T>();

        }
        public void Create(T entity)
        {
            entities.Add(entity);
        }

        public T Get(Guid id) => entities.Find(id);
        public IQueryable<T> GetAll() => entities;


        public void SaveChanges() => context.SaveChanges();

    }
}

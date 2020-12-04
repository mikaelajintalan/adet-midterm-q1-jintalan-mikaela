using app.domain;
using System;
using System.Linq;

namespace app.repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Get(Guid id);
        IQueryable<T> GetAll();
        void Create(T entity);
        void SaveChanges();
    }
}

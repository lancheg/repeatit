using System;
using System.Linq;
using Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace Core.Data.Ef
{
    public class Repository<TEntity>: IRepository<TEntity> where TEntity : class, IEntity
    {
        private readonly DbContext _context;

        public Repository(DbContext context)
        {
            _context = context;
        }
        

        public TEntity Add(TEntity entity)
        {
            return _context.Set<TEntity>().Add(entity).Entity;
        }

        public void Delete(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
        }

        public TEntity Get(int id)
        {
            return _context.Set<TEntity>().Single(x => x.Id == id);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}

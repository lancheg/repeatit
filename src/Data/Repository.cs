using System;
using Core.Domain;

namespace Core.Data.Ef
{
    public class Repository<T>: IRepository<T> where T:IEntity
    {
        public Repository()
        {
        }

        public T Add(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public T Get(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}

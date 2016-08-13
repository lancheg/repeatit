using System;
using Core.Domain;

namespace Core.Data.Ef
{
    public class Repository<T>: IRepository<IEntity>
    {
        public Repository()
        {
        }

        public IEntity Add(IEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEntity Get(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}

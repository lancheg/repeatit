namespace Core.Domain
{
    public interface IRepository<T> where T:IEntity
    {
        T Add(T entity);
        T Get(int id);
        void Delete(int id);
        void SaveChanges();

    }
}

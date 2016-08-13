namespace Core.Domain
{
    public interface IRepository<TEntity> where TEntity : IEntity
    {
        TEntity Add(TEntity entity);
        TEntity Get(int id);
        void Delete(TEntity entity);
        void SaveChanges();

    }
}

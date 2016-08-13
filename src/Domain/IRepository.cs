namespace Core.Domain
{
    public interface IRepository<IEntity>
    {
        IEntity Add(IEntity entity);
        IEntity Get(int id);
        void Delete(int id);
        void SaveChanges();

    }
}

namespace Core.Domain
{
    public interface IUnitOfWork
    {
        void SaveChanges();
    }
}

using Core.Domain;

namespace Core.Data.Ef
{
    public interface IEfUnitOfWorkFactory
    {
        IUnitOfWork GetUoW();
    }
}

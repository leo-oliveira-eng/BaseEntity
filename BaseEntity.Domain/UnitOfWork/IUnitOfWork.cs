using System.Threading.Tasks;

namespace BaseEntity.Domain.UnitOfWork
{
    public interface IUnitOfWork
    {
        Task<bool> CommitAsync();
    }
}

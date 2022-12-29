using Stefanini_CRUD.Domain.Aggregate;
using Stefanini_CRUD.Domain.SeedOfWork.Repository;

namespace Stefanini_CRUD.Infra.Data.Repository
{
    public interface IUserRepository : IBaseRepository<User>
    {
        
    }
}
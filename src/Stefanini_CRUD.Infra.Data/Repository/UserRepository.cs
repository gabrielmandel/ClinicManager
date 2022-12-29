using Stefanini_CRUD.Domain.Aggregate;

namespace Stefanini_CRUD.Infra.Data.Repository
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(AppDbContext context) : base(context)
        {
        }
    }
}
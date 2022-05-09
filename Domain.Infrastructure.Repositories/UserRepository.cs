using Diplom.Domain.Entities;
using Diplom.Domain.Repositories.Abstracts;
using Diplom.Persistence.Contexts;
using Domain.Infrastructure.Repositories.GenericRepository;

namespace Domain.Infrastructure.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(DiplomContext context) : base(context)
        {
        }
    }
}
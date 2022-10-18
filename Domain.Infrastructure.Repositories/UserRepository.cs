using Diplom.Domain.Entities;
using Diplom.Domain.Repositories.Abstracts;
using Diplom.Infrastructure.Repositories.GenericRepository;
using Diplom.Persistence.Contexts;

namespace Diplom.Infrastructure.Repositories;

/// <summary>
/// Репозиторий пользователя.
/// </summary>
public class UserRepository : GenericRepository<User>, IUserRepository
{
    public UserRepository(DiplomContext context) : base(context)
    {
    }
}
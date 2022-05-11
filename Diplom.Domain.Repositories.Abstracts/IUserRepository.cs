using Diplom.Domain.Entities;
using Diplom.Domain.Repositories.Abstracts.IGenericRepository;

namespace Diplom.Domain.Repositories.Abstracts
{
    /// <summary>
    /// Интерфейс репозитория пользователя.
    /// </summary>
    public interface IUserRepository : IGenericRepository<User>
    {
    }
}

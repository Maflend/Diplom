using Diplom.Domain.Entities;
using Diplom.Domain.Repositories.Abstracts.IGenericRepository;

namespace Diplom.Domain.Repositories.Abstracts
{
    /// <summary>
    /// Интерфейс репозитория категорий.
    /// </summary>
    public interface ICategoryRepository : IGenericRepository<Category>
    {
    }
}

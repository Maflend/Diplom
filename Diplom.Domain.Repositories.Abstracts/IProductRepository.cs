using Diplom.Domain.Entities;
using Diplom.Domain.Repositories.Abstracts.IGenericRepository;

namespace Diplom.Domain.Repositories.Abstracts
{
    /// <summary>
    /// Интерфейс репозитория продукта.
    /// </summary>
    public interface IProductRepository : IGenericRepository<Product>
    {
    }
}

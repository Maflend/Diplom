using Diplom.Domain.Entities;
using Diplom.Domain.Repositories.Abstracts;
using Diplom.Persistence.Contexts;
using Diplom.Infrastructure.Repositories.GenericRepository;

namespace Diplom.Infrastructure.Repositories
{
    /// <summary>
    /// Репозиторий продукта.
    /// </summary>
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(DiplomContext context) : base(context)
        {
        }
    }
}

using Diplom.Domain.Entities;
using Diplom.Domain.Repositories.Abstracts;
using Diplom.Infrastructure.Repositories.GenericRepository;
using Diplom.Persistence.Contexts;

namespace Diplom.Infrastructure.Repositories;

/// <summary>
/// Репозиторий продукта.
/// </summary>
public class ProductRepository : GenericRepository<Product>, IProductRepository
{
    public ProductRepository(DiplomContext context) : base(context)
    {
    }
}

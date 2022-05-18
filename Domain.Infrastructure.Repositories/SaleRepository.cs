using Diplom.Domain.Entities;
using Diplom.Domain.Repositories.Abstracts;
using Diplom.Persistence.Contexts;
using Diplom.Infrastructure.Repositories.GenericRepository;

namespace Diplom.Infrastructure.Repositories
{
    /// <summary>
    /// Репозиторий продажи.
    /// </summary>
    public class SaleRepository : GenericRepository<Sale>, ISaleRepository
    {
        public SaleRepository(DiplomContext context) : base(context)
        {
        }
    }
}

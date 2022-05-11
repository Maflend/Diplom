using Diplom.Domain.Entities;
using Diplom.Domain.Repositories.Abstracts;
using Diplom.Persistence.Contexts;
using Domain.Infrastructure.Repositories.GenericRepository;

namespace Domain.Infrastructure.Repositories
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

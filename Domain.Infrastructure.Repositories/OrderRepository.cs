using Diplom.Domain.Entities;
using Diplom.Domain.Repositories.Abstracts;
using Diplom.Persistence.Contexts;
using Domain.Infrastructure.Repositories.GenericRepository;

namespace Domain.Infrastructure.Repositories
{
    /// <summary>
    /// Репозиторий заказа.
    /// </summary>
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(DiplomContext context) : base(context)
        {
        }
    }
}

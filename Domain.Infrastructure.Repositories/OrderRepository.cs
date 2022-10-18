using Diplom.Domain.Entities;
using Diplom.Domain.Repositories.Abstracts;
using Diplom.Infrastructure.Repositories.GenericRepository;
using Diplom.Persistence.Contexts;

namespace Diplom.Infrastructure.Repositories;

/// <summary>
/// Репозиторий заказа.
/// </summary>
public class OrderRepository : GenericRepository<Order>, IOrderRepository
{
    public OrderRepository(DiplomContext context) : base(context)
    {
    }
}

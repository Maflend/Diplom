using Diplom.Domain.Entities;
using Diplom.Domain.Repositories.Abstracts.IGenericRepository;

namespace Diplom.Domain.Repositories.Abstracts;

/// <summary>
/// Интерфейс репозитория заказа.
/// </summary>
public interface IOrderRepository : IGenericRepository<Order>
{
}

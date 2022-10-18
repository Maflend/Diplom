using Diplom.Domain.Entities;
using Diplom.Domain.Repositories.Abstracts.IGenericRepository;

namespace Diplom.Domain.Repositories.Abstracts;

/// <summary>
/// Интерфейс репозитория продажи.
/// </summary>
public interface ISaleRepository : IGenericRepository<Sale>
{
}

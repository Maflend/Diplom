using Ardalis.Specification;
using System.Linq.Expressions;

namespace Diplom.Domain.Repositories.Abstracts.IGenericRepository
{
    public interface IGenericRepository<TEntity>
    {
        Task<TEntity> GetByIdAsync(Guid id, CancellationToken cancellationToken);
        Task<List<TEntity>> GetAllBySpecAsync(Specification<TEntity> specification, CancellationToken cancellationToken);
        Task<List<TEntity>> GetAllAsync(CancellationToken cancellationToken);
        Task<TEntity> GetBySpecAsync(Specification<TEntity> specification, CancellationToken cancellationToken);
        Task AddAndSaveAsync(TEntity entity, CancellationToken cancellationToken);
        Task<TEntity> UpdateAndSaveAsync(TEntity entity, CancellationToken cancellationToken);
        Task DeleteAndSaveAsync(TEntity entity, CancellationToken cancellationToken);
        Task<bool> AnyAsync(Expression<Func<TEntity, bool>> func, CancellationToken cancellationToken);


    }
}
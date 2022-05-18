using Ardalis.Specification;
using Ardalis.Specification.EntityFrameworkCore;
using Diplom.Domain.Repositories.Abstracts.IGenericRepository;
using Diplom.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Diplom.Infrastructure.Repositories.GenericRepository
{
    /// <summary>
    /// Общий репозиторий.
    /// <inheritdoc cref="IGenericRepository"/>
    /// </summary>
    /// <typeparam name="TEntity">Тип сущности.</typeparam>
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly DiplomContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public GenericRepository(DiplomContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        /// <summary>
        /// Добавить сущность и сохранить изменения.
        /// </summary>
        /// <param name="entity">Сущность.</param>
        /// <param name="cancellationToken"></param>
        /// <returns><see cref="Task"/></returns>
        public async Task AddAndSaveAsync(TEntity entity, CancellationToken cancellationToken)
        {
            await _dbSet.AddAsync(entity, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
        }

        /// <summary>
        /// Изменить сущность и сохранить изменения.
        /// </summary>
        /// <param name="entity">Сущность.</param>
        /// <param name="cancellationToken"></param>
        /// <returns><see cref="Task"/> с измененной сущность.</returns>
        public async Task<TEntity> UpdateAndSaveAsync(TEntity entity, CancellationToken cancellationToken)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return entity;
        }

        /// <summary>
        /// Удалить и сохранить изменения.
        /// </summary>
        /// <param name="entity">Сущность.</param>
        /// <param name="cancellationToken"></param>
        /// <returns><see cref="Task"/></returns>
        public async Task DeleteAndSaveAsync(TEntity entity, CancellationToken cancellationToken)
        {
            _context.Remove(entity);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Получить <see cref="List{T}"/> сущностей.
        /// </summary>
        /// <param name="specification">Спецификация.</param>
        /// <param name="cancellationToken"></param>
        /// <returns><see cref="Task"/> с <see cref="List{T}"/> T-тип сущности.</returns>
        public async Task<List<TEntity>> GetAllBySpecAsync(Specification<TEntity> specification, CancellationToken cancellationToken)
        {
            var result = SpecificationEvaluator.Default
             .GetQuery(
             query: _dbSet.AsQueryable(),
             specification: specification);

            return result.ToList();
        }

        /// <summary>
        /// Получить сущность по идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор.</param>
        /// <param name="cancellationToken"></param>
        /// <returns><see cref="Task{TEntity}"/></returns>
        public async Task<TEntity> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            var result = await _dbSet.FindAsync(id);

            return result;
        }

        /// <summary>
        /// Получить сущность по спецификации.
        /// </summary>
        /// <param name="specification">Спецификация.</param>
        /// <param name="cancellationToken"></param>
        /// <returns><see cref="Task{TEntity}"/></returns>
        public async Task<TEntity> GetBySpecAsync(Specification<TEntity> specification, CancellationToken cancellationToken)
        {
            var result = await _dbSet.WithSpecification(specification).FirstOrDefaultAsync();

            return result;
        }

        /// <summary>
        /// Проверить вхождение сущности.
        /// </summary>
        /// <param name="func"><see cref="Expression"/></param>
        /// <param name="cancellationToken"></param>
        /// <returns><see cref="Task{bool}"/></returns>
        public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> func, CancellationToken cancellationToken)
        {
            bool result = await _dbSet.AnyAsync(func, cancellationToken);

            return result;
        }

        /// <summary>
        /// Получить все сущности из бд.
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns><see cref="Task{TResult}"/></returns>
        public async Task<List<TEntity>> GetAllAsync(CancellationToken cancellationToken)
        {
            return await _dbSet.ToListAsync(cancellationToken);
        }
    }
}

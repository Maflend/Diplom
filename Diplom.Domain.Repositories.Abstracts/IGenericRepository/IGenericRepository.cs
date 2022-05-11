using Ardalis.Specification;
using System.Linq.Expressions;

namespace Diplom.Domain.Repositories.Abstracts.IGenericRepository
{
    /// <summary>
    /// Интрефейс общего репозитория.
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IGenericRepository<TEntity>
    {
        /// <summary>
        /// Получить сущность по идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор.</param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<TEntity> GetByIdAsync(Guid id, CancellationToken cancellationToken);

        /// <summary>
        /// Получить <see cref="List{T}"/> сущностей по спецификации.
        /// </summary>
        /// <param name="specification">Спецификация.</param>
        /// <param name="cancellationToken"></param>
        /// <returns><see cref="Task"/> с <see cref="List{T}"/> T-тип сущности.</returns>
        Task<List<TEntity>> GetAllBySpecAsync(Specification<TEntity> specification, CancellationToken cancellationToken);

        /// <summary>
        /// Получить все сущности из бд.
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns><see cref="Task{TResult}"/></returns>
        Task<List<TEntity>> GetAllAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Получить сущность по спецификации.
        /// </summary>
        /// <param name="specification">Спецификация.</param>
        /// <param name="cancellationToken"></param>
        /// <returns><see cref="Task{TEntity}"/></returns>
        Task<TEntity> GetBySpecAsync(Specification<TEntity> specification, CancellationToken cancellationToken);

        /// <summary>
        /// Добавить сущность и сохранить изменения.
        /// </summary>
        /// <param name="entity">Сущность.</param>
        /// <param name="cancellationToken"></param>
        /// <returns><see cref="Task"/></returns>
        Task AddAndSaveAsync(TEntity entity, CancellationToken cancellationToken);

        /// <summary>
        /// Изменить сущность и сохранить изменения.
        /// </summary>
        /// <param name="entity">Сущность.</param>
        /// <param name="cancellationToken"></param>
        /// <returns><see cref="Task"/> с измененной сущность.</returns>
        Task<TEntity> UpdateAndSaveAsync(TEntity entity, CancellationToken cancellationToken);

        /// <summary>
        /// Удалить и сохранить изменения.
        /// </summary>
        /// <param name="entity">Сущность.</param>
        /// <param name="cancellationToken"></param>
        /// <returns><see cref="Task"/></returns>
        Task DeleteAndSaveAsync(TEntity entity, CancellationToken cancellationToken);

        /// <summary>
        /// Проверить вхождение сущности.
        /// </summary>
        /// <param name="func"><see cref="Expression"/></param>
        /// <param name="cancellationToken"></param>
        /// <returns><see cref="Task{bool}"/></returns>
        Task<bool> AnyAsync(Expression<Func<TEntity, bool>> func, CancellationToken cancellationToken);
    }
}
using Ardalis.Specification;
using Ardalis.Specification.EntityFrameworkCore;
using Diplom.Domain.Repositories.Abstracts.IGenericRepository;
using Diplom.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Domain.Infrastructure.Repositories.GenericRepository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly DiplomContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public GenericRepository(DiplomContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public async Task AddAndSaveAsync(TEntity entity, CancellationToken cancellationToken)
        {
            await _dbSet.AddAsync(entity, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task<TEntity> UpdateAndSaveAsync(TEntity entity, CancellationToken cancellationToken)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAndSaveAsync(TEntity entity, CancellationToken cancellationToken)
        {
            _context.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<List<TEntity>> GetAllBySpecAsync(Specification<TEntity> specification, CancellationToken cancellationToken)
        {
            var result = SpecificationEvaluator.Default
             .GetQuery(
             query: _dbSet.AsQueryable(),
             specification: specification);

            return result.ToList();
        }

        public async Task<TEntity> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            var result = await _dbSet.FindAsync(id);
            return result;
        }

        public async Task<TEntity> GetBySpecAsync(Specification<TEntity> specification, CancellationToken cancellationToken)
        {
            var result = await _dbSet.WithSpecification(specification).FirstOrDefaultAsync();

            return result;
        }

        public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> func, CancellationToken cancellationToken)
        {
            bool result = await _dbSet.AnyAsync(func, cancellationToken);
            return result;
        }

        public async Task<List<TEntity>> GetAllAsync(CancellationToken cancellationToken)
        {
            return await _dbSet.ToListAsync(cancellationToken);
        }
    }
}

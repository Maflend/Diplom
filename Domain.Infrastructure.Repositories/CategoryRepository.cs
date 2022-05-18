using Diplom.Domain.Entities;
using Diplom.Domain.Repositories.Abstracts;
using Diplom.Persistence.Contexts;
using Diplom.Infrastructure.Repositories.GenericRepository;

namespace Diplom.Infrastructure.Repositories
{
    /// <summary>
    /// Репозиторий категорий.
    /// </summary>
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(DiplomContext context) : base(context)
        {
        }
    }
}

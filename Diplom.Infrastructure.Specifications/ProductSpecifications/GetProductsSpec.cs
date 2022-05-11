using Ardalis.Specification;
using Diplom.Domain.Entities;

namespace Diplom.Infrastructure.Specifications.ProductSpecifications
{
    public class GetProductsSpec : Specification<Product>
    {
        /// <summary>
        /// Спецификация получения продуктов по Id категории.
        /// </summary>
        /// <param name="categoryId"></param>
        public GetProductsSpec(Guid categoryId)
        {
            Query.Where(p => p.CategoryId == categoryId);
        }
    }
}

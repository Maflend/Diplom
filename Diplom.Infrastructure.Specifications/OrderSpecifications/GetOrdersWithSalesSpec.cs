using Ardalis.Specification;
using Diplom.Domain.Entities;

namespace Diplom.Domain.Specifications.OrderSpecifications
{
    /// <summary>
    /// Спецификация получения заказов с продажами.
    /// </summary>
    public class GetOrdersWithSalesSpec : Specification<Order>
    {
        /// <inheritdoc cref="GetOrdersWithSalesSpec"/>=
        public GetOrdersWithSalesSpec()
        {
            Query.Include(o => o.Sales);
        }
    }
}

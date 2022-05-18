using Diplom.Domain.Entities.Base;

namespace Diplom.Domain.Entities
{
    /// <summary>
    /// Продажа.
    /// </summary>
    public class Sale : BaseEntity
    {
        /// <summary>
        /// Количество.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Идентификатор продукта.
        /// </summary>
        public Guid ProductId { get; set; }

        /// <summary>
        /// Продукт.
        /// </summary>
        public Product Product { get; set; }

        /// <summary>
        /// Заказ.
        /// </summary>
        public Order Order { get; set; }
    }
}

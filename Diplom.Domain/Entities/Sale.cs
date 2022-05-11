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
        /// Продукт.
        /// </summary>
        public Product Product { get; set; }

        /// <summary>
        /// Заказ.
        /// </summary>
        public Order Order { get; set; }
    }
}

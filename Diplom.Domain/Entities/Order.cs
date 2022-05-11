namespace Diplom.Domain.Entities
{
    /// <summary>
    /// Заказ.
    /// </summary>
    public class Order : BaseEntity
    {
        /// <summary>
        /// Дата оформления.
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// Перечень продаж.
        /// </summary>
        public List<Sale> Sales { get; set; }

        /// <summary>
        /// Пользователь.
        /// </summary>
        public User User { get; set; }

    }
}

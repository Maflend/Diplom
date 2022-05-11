namespace Diplom.Domain.Entities
{
    public class Category : BaseEntity
    {
        /// <summary>
        /// Наименование.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Продукты.
        /// </summary>
        public List<Product> Products { get; set; }
    }
}

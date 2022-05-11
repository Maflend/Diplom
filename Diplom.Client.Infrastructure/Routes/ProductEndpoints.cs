namespace Diplom.Client.Infrastructure.Routes
{
    /// <summary>
    /// Конечные точки для контроллера продукта.
    /// </summary>
    public class ProductEndpoints
    {
        /// <summary>
        /// Конечная точка для получения всех продуктов.
        /// </summary>
        public static string GetAll = "api/product/getAll";

        /// <summary>
        /// Конечная точка для получения продукта по Id.
        /// </summary>
        public static string GetById = "api/product";

        /// <summary>
        /// Конечная точка для получения продуктов по Id категории.
        /// </summary>
        public static string GetByCategoryId = "api/product/category";
    }
}

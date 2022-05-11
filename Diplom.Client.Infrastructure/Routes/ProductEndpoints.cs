namespace Diplom.Client.Infrastructure.Routes
{
    public class ProductEndpoints
    {
        public static string GetAll = "api/product/getAll";
        public static string GetById = "api/product";

        /// <summary>
        /// Endpoint для получения продуктов по Id категории.
        /// </summary>
        public static string GetByCategoryId = "api/product/category";

    }
}

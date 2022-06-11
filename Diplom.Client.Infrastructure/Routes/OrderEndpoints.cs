namespace Diplom.Client.Infrastructure.Routes
{
    /// <summary>
    /// Конечные точки для контроллера заказов.
    /// </summary>
    public class OrderEndpoints
    {
        /// <summary>
        /// Конечная точка создания заказа.
        /// </summary>
        public readonly static string CreateOrder = "api/order/create";

        /// <summary>
        /// Конечная точка получения заказов.
        /// </summary>
        public readonly static string GetOrders = "api/order";
    }
}

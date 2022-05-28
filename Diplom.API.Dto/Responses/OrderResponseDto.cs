namespace Diplom.API.Dto.Responses
{
    /// <summary>
    /// Дто ответа сервера о создании заказа.
    /// </summary>
    public class OrderResponseDto
    {
        /// <summary>
        /// Идентификатор заказа.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Дата создания заказа.
        /// </summary>
        public DateTime CreateDate { get; set; }
    }
}

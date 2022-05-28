using Diplom.API.Dto.Dtos;

namespace Diplom.Client.Infrastructure.Services.Cart
{
    /// <summary>
    /// Интерфейс сервиса для взаимодействия с корзиной.
    /// </summary>
    public interface ICartService
    {
        /// <summary>
        /// Получить все продажи.
        /// </summary>
        Task<List<CartDto>> GetSalesAsync();

        /// <summary>
        /// Получить продажу по идентификатору продукта.
        /// </summary>
        /// <param name="productId">Идентификатор продукта.</param>
        Task<CartDto> GetSaleAsync(Guid productId);

        /// <summary>
        /// Добавить продажу в корзину.
        /// </summary>
        /// <param name="sale"><see cref="CartDto"/></param>
        Task AddSaleAsync(CartDto sale);

        /// <summary>
        /// Сохранить продажу в корзине.
        /// </summary>
        /// <param name="sale"><see cref="CartDto"/></param>
        Task UpdateSaleAsync(CartDto sale);

        /// <summary>
        /// Удалить продажу из корзины.
        /// </summary>
        /// <param name="productId">Идентификатор продукта.</param>
        Task DeleteSaleAsync(Guid productId);

        /// <summary>
        /// Очистить корзину.
        /// </summary>
        Task Clear();
    }
}

using Blazored.LocalStorage;
using Diplom.API.Dto.Dtos;

namespace Diplom.Client.Infrastructure.Services.Cart
{
    /// <summary>
    /// Сервис взаимодействия с карзиной.
    /// </summary>
    public class CartService : ICartService
    {
        private readonly ILocalStorageService _localStorageService;

        public CartService(ILocalStorageService localStorageService)
        {
            _localStorageService = localStorageService;
        }

        /// <summary>
        /// Добавить продажу в карзину.
        /// </summary>
        /// <param name="cartItem"></param>
        /// <returns></returns>
        public async Task AddSaleAsync(CartDto cartItem)
        {
            var cart = await GetSalesAsync();

            if (cart is null)
            {
                cart = new();
            }

            var currentSale = cart.FirstOrDefault(s => s.Product.Id == cartItem.Product.Id);

            if (currentSale != null)
            {
                cart.First(s => s.Product.Id == cartItem.Product.Id).Quantity += cartItem.Quantity;
            }
            else
            {
                cart.Add(cartItem);
            }

            await _localStorageService.SetItemAsync("cart", cart);
        }

        /// <summary>
        /// Очистить карзину.
        /// </summary>
        /// <returns></returns>
        public async Task Clear()
        {
            await _localStorageService.RemoveItemAsync("cart");
        }

        /// <summary>
        /// Удалить продажу из карзины.
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public async Task DeleteSaleAsync(Guid productId)
        {
            var cart = await GetSalesAsync();
            cart.Remove(cart.First(s => s.Product.Id == productId));
            await _localStorageService.SetItemAsync("cart", cart);
        }

        /// <summary>
        /// Получить продажу из карзины по идентификатору.
        /// </summary>
        /// <param name="productId">Идентификатор продажи.</param>
        /// <returns></returns>
        public async Task<CartDto> GetSaleAsync(Guid productId)
        {
            var cart = await GetSalesAsync();
            return cart.FirstOrDefault(c => c.Product.Id == productId);
        }

        /// <summary>
        /// Получить все продажи.
        /// </summary>
        /// <returns></returns>
        public async Task<List<CartDto>> GetSalesAsync()
        {
            return await _localStorageService.GetItemAsync<List<CartDto>>("cart") ?? new();
        }

        /// <summary>
        /// Сохранить изменения продажи.
        /// </summary>
        /// <param name="sale"></param>
        /// <returns></returns>
        public async Task UpdateSaleAsync(CartDto sale)
        {
            var cart = await GetSalesAsync();
            cart.First(c => c.Product.Id == sale.Product.Id).Quantity = sale.Quantity;
            await _localStorageService.SetItemAsync("cart", cart);
        }
    }
}

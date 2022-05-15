using Blazored.LocalStorage;
using Diplom.API.Dto.Dtos;

namespace Diplom.Client.Infrastructure.Services.Cart
{
    public class CartService : ICartService
    {
        private readonly ILocalStorageService _localStorageService;

        public CartService(ILocalStorageService localStorageService)
        {
            _localStorageService = localStorageService;
        }
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

        public async Task Clear()
        {
            await _localStorageService.RemoveItemAsync("cart");
        }

        public async Task DeleteSaleAsync(Guid productId)
        {
            var cart = await GetSalesAsync();
            cart.Remove(cart.First(s => s.Product.Id == productId));
            await _localStorageService.SetItemAsync("cart", cart);
        }

        public async Task<CartDto> GetSaleAsync(Guid productId)
        {
            var cart = await GetSalesAsync();
            return cart.FirstOrDefault(c => c.Product.Id == productId);
        }

        public async Task<List<CartDto>> GetSalesAsync()
        {
            return await _localStorageService.GetItemAsync<List<CartDto>>("cart") ?? new();
        }

        public async Task UpdateSaleAsync(CartDto sale)
        {
            var cart = await GetSalesAsync();
            cart.First(c => c.Product.Id == sale.Product.Id).Quantity = sale.Quantity;
            await _localStorageService.SetItemAsync("cart", cart);
        }
    }
}

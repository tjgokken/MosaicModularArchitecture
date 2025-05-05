using QuickCart.Features.CartItem.Models;

namespace QuickCart.Features.CartItem;

public interface ICartItemService
{
    Task AddToCartAsync(int productId, int quantity);
    Task<List<CartItemModel>> GetCartItemsAsync();
}
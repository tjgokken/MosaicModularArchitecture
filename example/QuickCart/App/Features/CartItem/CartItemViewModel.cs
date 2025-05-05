using QuickCart.Features.CartItem.Models;

namespace QuickCart.Features.CartItem;

public class CartItemViewModel
{
    private readonly ICartItemService _cartItemService;
    public CartItemViewModel(ICartItemService cartItemService) => _cartItemService = cartItemService;

    public async Task AddItem(int productId, int quantity)
    {
        await _cartItemService.AddToCartAsync(productId, quantity);
    }

    public async Task<List<CartItemModel>> LoadCart()
    {
        return await _cartItemService.GetCartItemsAsync();
    }
}
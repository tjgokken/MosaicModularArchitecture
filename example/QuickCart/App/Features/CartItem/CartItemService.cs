using Microsoft.EntityFrameworkCore;
using QuickCart.Features.CartItem.Models;
using QuickCart.Infrastructure.Db;

namespace QuickCart.Features.CartItem;

public class CartItemService : ICartItemService
{
    private readonly AppDbContext _db;

    public CartItemService(AppDbContext db)
    {
        _db = db;
    }

    public async Task AddToCartAsync(int productId, int quantity)
    {
        var item = new CartItemModel { ProductId = productId, Quantity = quantity };
        _db.CartItems.Add(item);
        await _db.SaveChangesAsync();
    }

    public async Task<List<CartItemModel>> GetCartItemsAsync()
    {
        return await _db.CartItems.ToListAsync();
    }
}
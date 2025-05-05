namespace QuickCart.Features.CartItem.Models;

public class CartItemModel
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }

    // Optional — if you want to cache product info in the cart
    public string? ProductName { get; set; }
    public decimal? Price { get; set; }
}
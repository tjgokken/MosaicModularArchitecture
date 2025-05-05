namespace QuickCart.Features.Order.Models;

public class OrderModel
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public List<int> CartItemIds { get; set; } = new(); // references to CartItems
    public decimal Total { get; set; }
    public string Status { get; set; } = "Pending";
}
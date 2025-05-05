namespace QuickCart.Features.Shipping.Models;

public class ShippingModel
{
    public int Id { get; set; }
    public int OrderId { get; set; }
    public string Address { get; set; } = default!;
    public string Status { get; set; } = "Not Shipped";
    public DateTime? ShippedAt { get; set; }
}
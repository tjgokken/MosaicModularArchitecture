using QuickCart.Features.Shipping.Models;
using QuickCart.Infrastructure.Db;

namespace QuickCart.Features.Shipping;

public class ShippingService : IShippingService
{
    private readonly AppDbContext _db;
    public ShippingService(AppDbContext db) => _db = db;

    public async Task<bool> ShipOrderAsync(int orderId, string address)
    {
        var shipping = new ShippingModel
        {
            OrderId = orderId,
            Address = address,
            Status = "Shipped",
            ShippedAt = DateTime.UtcNow
        };

        _db.Shippings.Add(shipping);
        await _db.SaveChangesAsync();
        return true;
    }
}
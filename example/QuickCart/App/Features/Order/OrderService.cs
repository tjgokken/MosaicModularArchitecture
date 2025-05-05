using QuickCart.Features.Order.Models;
using QuickCart.Infrastructure.Db;

namespace QuickCart.Features.Order;

public class OrderService : IOrderService
{
    private readonly AppDbContext _db;

    public OrderService(AppDbContext db)
    {
        _db = db;
    }

    public async Task<int> PlaceOrderAsync(List<int> cartItemIds)
    {
        var order = new OrderModel
        {
            CartItemIds = cartItemIds,
            CreatedAt = DateTime.UtcNow,
            Total = 0, // you can compute this based on cartItems later
            Status = "Pending"
        };

        _db.Orders.Add(order);
        await _db.SaveChangesAsync();
        return order.Id;
    }
}
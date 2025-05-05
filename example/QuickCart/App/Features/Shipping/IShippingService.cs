namespace QuickCart.Features.Shipping;

public interface IShippingService
{
    Task<bool> ShipOrderAsync(int orderId, string address);
}
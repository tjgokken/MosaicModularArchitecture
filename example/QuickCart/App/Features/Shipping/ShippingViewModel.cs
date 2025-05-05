namespace QuickCart.Features.Shipping;

public class ShippingViewModel
{
    private readonly IShippingService _shippingService;
    public ShippingViewModel(IShippingService shippingService) => _shippingService = shippingService;

    public async Task<bool> Ship(int orderId, string address)
    {
        return await _shippingService.ShipOrderAsync(orderId, address);
    }
}
namespace QuickCart.Features.Order;

public class OrderViewModel
{
    private readonly IOrderService _orderService;
    public OrderViewModel(IOrderService orderService) => _orderService = orderService;

    public async Task<int> PlaceOrder(List<int> cartItemIds)
    {
        return await _orderService.PlaceOrderAsync(cartItemIds);
    }
}
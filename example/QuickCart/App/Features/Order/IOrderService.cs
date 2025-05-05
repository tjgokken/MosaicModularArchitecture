namespace QuickCart.Features.Order;

public interface IOrderService
{
    Task<int> PlaceOrderAsync(List<int> cartItemIds);
}
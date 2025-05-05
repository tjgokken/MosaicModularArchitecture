namespace QuickCart.Features.Payment;

public interface IPaymentService
{
    Task<bool> ProcessPaymentAsync(int orderId, string provider);
}
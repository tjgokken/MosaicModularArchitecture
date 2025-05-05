namespace QuickCart.Features.Payment;

public class PaymentViewModel
{
    private readonly IPaymentService _paymentService;
    public PaymentViewModel(IPaymentService paymentService) => _paymentService = paymentService;

    public async Task<bool> Pay(int orderId, string provider)
    {
        return await _paymentService.ProcessPaymentAsync(orderId, provider);
    }
}
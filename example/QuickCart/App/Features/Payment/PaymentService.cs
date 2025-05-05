using QuickCart.Features.Payment.Models;
using QuickCart.Infrastructure.Db;

namespace QuickCart.Features.Payment;

public class PaymentService : IPaymentService
{
    private readonly AppDbContext _db;
    public PaymentService(AppDbContext db) => _db = db;

    public async Task<bool> ProcessPaymentAsync(int orderId, string provider)
    {
        var payment = new PaymentModel
        {
            OrderId = orderId,
            Provider = provider,
            Status = "Paid",
            PaidAt = DateTime.UtcNow
        };

        _db.Payments.Add(payment);
        await _db.SaveChangesAsync();
        return true;
    }
}
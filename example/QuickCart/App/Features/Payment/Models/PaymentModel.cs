namespace QuickCart.Features.Payment.Models;

public class PaymentModel
{
    public int Id { get; set; }
    public int OrderId { get; set; }
    public string Provider { get; set; } = "MockPay";
    public string Status { get; set; } = "Unpaid";
    public DateTime PaidAt { get; set; }
}
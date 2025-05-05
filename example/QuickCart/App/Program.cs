using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using QuickCart.Infrastructure.Db;
using QuickCart.Features.CartItem;
using QuickCart.Features.Order;
using QuickCart.Features.Payment;
using QuickCart.Features.Shipping;

var builder = Host.CreateApplicationBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=quickcart.db"));

builder.Services.AddScoped<ICartItemService, CartItemService>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IPaymentService, PaymentService>();
builder.Services.AddScoped<IShippingService, ShippingService>();

var app = builder.Build();


// Apply migrations or create DB if not exists
using var scope = app.Services.CreateScope();
var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
db.Database.EnsureCreated();
var services = scope.ServiceProvider;

// 1. Add item to cart
var cartService = services.GetRequiredService<ICartItemService>();
await cartService.AddToCartAsync(1, 2);
var cartItems = await cartService.GetCartItemsAsync();

// 2. Place order
var orderService = services.GetRequiredService<IOrderService>();
var orderId = await orderService.PlaceOrderAsync(cartItems.Select(ci => ci.Id).ToList());

// 3. Pay for order
var paymentService = services.GetRequiredService<IPaymentService>();
await paymentService.ProcessPaymentAsync(orderId, "MockPay");

// 4. Ship order
var shippingService = services.GetRequiredService<IShippingService>();
await shippingService.ShipOrderAsync(orderId, "123 MMA Lane");

Console.WriteLine($"✅ Order #{orderId} placed, paid, and shipped.");
await app.RunAsync();
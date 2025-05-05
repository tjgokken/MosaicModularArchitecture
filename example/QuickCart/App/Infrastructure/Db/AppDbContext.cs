using Microsoft.EntityFrameworkCore;
using QuickCart.Features.CartItem.Models;
using QuickCart.Features.Order.Models;
using QuickCart.Features.Payment.Models;
using QuickCart.Features.Shipping.Models;
using ProductModel = QuickCart.Features.Product.Models.ProductModel;

namespace QuickCart.Infrastructure.Db;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<ProductModel> Products { get; set; } = default!;
    public DbSet<CartItemModel> CartItems { get; set; } = default!;
    public DbSet<OrderModel> Orders { get; set; } = default!;
    public DbSet<PaymentModel> Payments { get; set; } = default!;
    public DbSet<ShippingModel> Shippings { get; set; } = default!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ProductModel>().ToTable("Products");
        modelBuilder.Entity<CartItemModel>().ToTable("CartItems");
        modelBuilder.Entity<OrderModel>().ToTable("Orders");
        modelBuilder.Entity<PaymentModel>().ToTable("Payments");
        modelBuilder.Entity<ShippingModel>().ToTable("Shippings");
    }
}
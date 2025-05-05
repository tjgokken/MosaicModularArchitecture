# QuickCart Sample App (MMA Example)

This is a sample project built with the Mosaic Modular Architecture (MMA) template. It demonstrates how to structure and build an MVP-grade modular backend.

## 🧠 What It Shows
- Modular feature folders
- Clean DI-based service wiring
- Minimal orchestration via ViewModels
- EF Core with SQLite (local DB)
- MMA-style bootstrap with `App/` isolation

## 🛠 Features
- `Product`: holds product catalog
- `Cart`: add items to cart
- `Order`: place an order from cart
- `Payment`: process payment for an order
- `Shipping`: mark the order as shipped

## 🚀 Running the App
```bash
cd example/QuickCart/App

dotnet run
```

You should see something like:
```
✅ Order #1 placed, paid, and shipped.
```

## ⚙️ Project Setup
- App folder was created using MMA template:
  ```bash
  dotnet new mma -n QuickCart
  ```
- EF Core and SQLite added via:
  ```bash
  dotnet add package Microsoft.EntityFrameworkCore.Sqlite
  ```
- Project created via:
  ```bash
  dotnet new console -n QuickCart -o .
  ```

## 📂 Folder Structure
```
App/
├── Features/
│   ├── Product
│   ├── Cart
│   ├── Order
│   ├── Payment
│   └── Shipping
├── Infrastructure/Db/
├── Program.cs
└── QuickCart.csproj
```

## 🧪 Test Flow
Inside `Program.cs`, we:
1. Add a product to cart
2. Place an order
3. Process payment
4. Ship the order

Everything is done via service + ViewModel glue.

## ✨ Want to Add More?
Use the feature scaffolding script:
```bash
./scripts/create-feature.ps1 Wishlist
```

Then fill in your model, service, and viewmodel.
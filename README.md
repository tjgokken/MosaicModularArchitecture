# Mosaic Modular Architecture (MMA)

A pragmatic, modular-first architecture for MVPs and beyond. Built with simplicity in mind and scalable by design.

## ✨ What is MMA?
Mosaic Modular Architecture (MMA) is a feature-first structure designed to help teams ship working software fast — without falling into spaghetti code hell.

It draws inspiration from:
- 🧱 Clean & Onion architecture (but less ceremony)
- 🧩 Modular folder-by-feature structure
- 🧠 Domain-Driven Design (only where it matters)

## 🧰 Key Principles
- Features live in isolation: `App/Features/X`
- Use ViewModels as glue
- Focus on clarity over purity
- Fully DI-compatible
- CLI-friendly: scaffold new features in seconds

## 📂 Folder Structure 
```
/your-app/
├── App/
│   ├── Features/
│   │   ├── Order/
│   │   ├── Product/
│   │   └── Cart/
│   └── Infrastructure/
├── Program.cs
├── scripts/
└── README.md
```

## 🚀 Quick Start
```bash
dotnet new install ./src/MMA_Template

cd your-folder
dotnet new mma -n YourApp
```

Use the scaffold script:
```bash
./scripts/create-feature.ps1 Wishlist
```

## 🧪 Sample Included: QuickCart
Check out the `/example/QuickCart` project for a complete MVP.

## 📚 Docs
See `/docs` for full documentation and reasoning behind MMA.
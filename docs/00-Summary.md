# MMA: A Practical Architecture for MVPs and Mid-Scale Apps

## TL;DR
Mosaic Modular Architecture (MMA) is a pragmatic, modular-first software architecture that balances simplicity and scalability. It helps teams move fast, build cleanly, and avoid the over-engineering trap.

## 🧠 Why MMA?
- Most architecture docs are either too abstract or too bloated
- Clean Architecture is great, but overkill for MVPs
- Onion is solid, but often splits up cohesive features
- We wanted:
  - A folder-by-feature design
  - Easy-to-understand structure
  - Real-world practicality

## 🔍 How MMA Compares
| Feature                  | Clean Architecture | Onion Architecture | MMA              |
|-------------------------|--------------------|--------------------|------------------|
| MVP-Readiness           | 🚫 Too Heavy       | ⚠️ Midweight        | ✅ Lightweight    |
| Modular Features        | ⚠️ Not Native      | 🚫 Split by Layer   | ✅ Yes            |
| DI-Ready                | ✅ Yes             | ✅ Yes             | ✅ Yes           |
| Eventing/DDD Support    | ✅ Complex Ready   | ✅ With Work        | ✅ Just Enough   |
| UI Framework Tied       | 🚫 No              | 🚫 No              | 🚫 No            |
| CLI/Script Friendly     | ⚠️ Manual          | ⚠️ Manual          | ✅ Scaffoldable  |

## 🛠 Built For
- Bootstrapped startups
- Solo builders
- Mid-sized enterprise apps
- MVPs you may need to scale

## 👨‍💻 Developer Experience
- App lives in `/App` to keep root clean
- ViewModels used to coordinate
- CLI/PowerShell scripts to scaffold new features fast
- Drop-in EF Core + DI + SQLite compatible

## ✅ Try It
```bash
dotnet new install ./src/MMA_Template
dotnet new mma -n YourApp
```

See `example/QuickCart` for a working app.
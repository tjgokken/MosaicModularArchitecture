### Suggested Folder Layout

```
/App
├── Features
│   ├── Orders
│   │   ├── OrderViewModel.cs
│   │   ├── IOrderService.cs
│   │   ├── OrderService.cs
│   │   └── Models/
│   ├── Users
│   │   └── ...
│   └── Payments
│       └── ...
├── Shared
│   ├── Interfaces/
│   ├── Models/
│   └── Utils/
└── Infrastructure
    ├── Api/
    ├── Repositories/
    └── Services/
```

### Guidelines
- **Features/**: One folder per feature with its own mini-stack
- **Shared/**: Only shared contracts, models, or helpers — avoid dumping all code here
- **Infrastructure/**: Things like persistence, HTTP clients, and platform-specific services

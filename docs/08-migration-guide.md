### Migration Guide

#### From Traditional Layered
1. Start organizing existing services, models, and views by feature
2. Move them into `Features/<Name>` folders
3. Create interface boundaries between cross-cutting logic
4. Shift shared dependencies into `/Shared` or `/Infrastructure`

#### From Monolith or God Classes
1. Identify functional boundaries (e.g., Users, Orders, Payments)
2. Extract features into their own folders
3. Replace static helpers or direct service calls with interfaces
4. Begin adding ViewModels and injecting services

#### From Clean or Onion
- Simply collapse layers into feature modules
- Keep domain models and events intact
- Push use cases and services into feature folders for modularity

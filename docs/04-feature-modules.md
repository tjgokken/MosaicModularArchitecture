### Feature Modules
Each feature module includes everything needed for that domain area:
- ViewModels (presentation logic)
- Service interfaces + implementations
- Models and validation logic
- Optional: domain events, value objects

**Benefits:**
- Self-contained
- Easier onboarding for new devs
- Smaller cognitive load

**Rules of Thumb:**
- Use dependency injection
- Avoid reaching into other features' internals
- If communication is needed, do it via shared interfaces or events

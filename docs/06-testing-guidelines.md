### Testing Strategy

#### Unit Testing
- Services: Mock dependencies, test business logic in isolation
- ViewModels: Use dependency injection, mock services

#### Integration Testing
- Cross-feature interactions through interface contracts
- Feature-to-infrastructure boundary (e.g., repository integration)

#### UI Testing (optional)
- If using Blazor, WPF, or MAUI, test ViewModel behaviors instead of UI components

**Goal:**
- Keep tests fast and isolated
- Don't test internals — test behavior
- Every feature should be testable without the entire app

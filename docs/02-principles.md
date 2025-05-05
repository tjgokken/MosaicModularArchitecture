### Core Principles

- **Feature Modularity**: Group by feature, not by technical layer. Each feature is a "vertical slice" of the app.
- **Interface Boundaries**: Features talk to each other only via interfaces, minimizing tight coupling.
- **MVVM Coordination**: ViewModels coordinate feature-level workflows. Services and domain logic stay behind interfaces.
- **Explicit Boundaries**: Each feature owns its own models, services, and ViewModels. Cross-feature access is discouraged.
- **Testability First**: Structure favors writing unit and integration tests from the start.
- **No Ceremony**: Avoid premature abstractions. Only introduce complexity when it's earned.

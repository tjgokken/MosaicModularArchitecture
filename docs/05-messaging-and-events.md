### Messaging & Domain Events
While not required at MVP stage, MMA encourages adding messaging gradually as complexity grows.

#### MVP-Ready Setup:
- Define `IEventPublisher` interface
- Use an in-memory bus or MediatR
- Create domain events like `OrderPlacedEvent`

#### When to Add More:
- Background processing (e.g., send confirmation email after checkout)
- Cross-feature workflows
- Audit logging or outbox pattern

#### Future Options:
- Swap in RabbitMQ, Azure Service Bus, or Kafka
- Add support for sagas or event sourcing if needed

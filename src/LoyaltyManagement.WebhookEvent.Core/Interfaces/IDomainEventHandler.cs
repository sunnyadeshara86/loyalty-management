namespace LoyaltyManagement.WebhookEvent.Core.Interfaces
{
    public interface IDomainEventHandler<in TEvent> where TEvent : IDomainEvent
    {
        Task Handle(TEvent domainEvent);
    }
}

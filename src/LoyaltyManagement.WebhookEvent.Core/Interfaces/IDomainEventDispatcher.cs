namespace LoyaltyManagement.WebhookEvent.Core.Interfaces
{
    public interface IDomainEventDispatcher
    {
        Task Dispatch(IDomainEvent domainEvent);
        Task DispatchAll(IEnumerable<IDomainEvent> domainEvents);
    }
}

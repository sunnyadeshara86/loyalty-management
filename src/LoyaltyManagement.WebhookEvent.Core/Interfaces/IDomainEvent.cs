namespace LoyaltyManagement.WebhookEvent.Core.Interfaces
{
    public interface IDomainEvent
    {
        DateTime OccurredOn { get; }
    }
}

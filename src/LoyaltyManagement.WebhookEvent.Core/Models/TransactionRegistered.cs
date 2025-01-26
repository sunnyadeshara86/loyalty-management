using LoyaltyManagement.WebhookEvent.Core.Interfaces;

namespace LoyaltyManagement.WebhookEvent.Core.Models
{
    public class TransactionRegistered : IDomainEvent
    {
        public DateTime OccurredOn { get; private set; }

        public TransactionRegistered()
        {
            OccurredOn = DateTime.UtcNow;
        }
    }
}

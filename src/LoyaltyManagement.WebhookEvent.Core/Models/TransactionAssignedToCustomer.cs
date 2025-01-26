using LoyaltyManagement.WebhookEvent.Core.Interfaces;

namespace LoyaltyManagement.WebhookEvent.Core.Models
{
    public class TransactionAssignedToCustomer : IDomainEvent
    {
        public DateTime OccurredOn { get; private set; }

        public TransactionAssignedToCustomer()
        {
            OccurredOn = DateTime.UtcNow;
        }
    }
}

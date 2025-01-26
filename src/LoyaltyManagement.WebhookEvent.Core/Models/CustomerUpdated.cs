using LoyaltyManagement.WebhookEvent.Core.Interfaces;

namespace LoyaltyManagement.WebhookEvent.Core.Models
{
    public class CustomerUpdated : IDomainEvent
    {
        public DateTime OccurredOn { get; private set; }

        public CustomerUpdated()
        {
            OccurredOn = DateTime.UtcNow;
        }
    }
}

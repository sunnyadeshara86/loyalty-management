using LoyaltyManagement.WebhookEvent.Core.Interfaces;

namespace LoyaltyManagement.WebhookEvent.Core.Models
{
    public class CustomerDeactivated : IDomainEvent
    {
        public DateTime OccurredOn { get; private set; }

        public CustomerDeactivated()
        {
            OccurredOn = DateTime.UtcNow;
        }
    }
}

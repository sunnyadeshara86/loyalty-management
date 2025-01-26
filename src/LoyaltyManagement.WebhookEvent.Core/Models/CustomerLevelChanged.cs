using LoyaltyManagement.WebhookEvent.Core.Interfaces;

namespace LoyaltyManagement.WebhookEvent.Core.Models
{
    public class CustomerLevelChanged : IDomainEvent
    {
        public DateTime OccurredOn { get; private set; }

        public CustomerLevelChanged()
        {
            OccurredOn = DateTime.UtcNow;
        }
    }
}

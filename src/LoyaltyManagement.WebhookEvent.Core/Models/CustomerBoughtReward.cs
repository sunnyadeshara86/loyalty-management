using LoyaltyManagement.WebhookEvent.Core.Interfaces;

namespace LoyaltyManagement.WebhookEvent.Core.Models
{
    public class CustomerBoughtReward : IDomainEvent
    {
        public DateTime OccurredOn { get; private set; }

        public CustomerBoughtReward()
        {
            OccurredOn = DateTime.UtcNow;
        }
    }
}

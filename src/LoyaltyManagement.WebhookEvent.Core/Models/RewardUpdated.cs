using LoyaltyManagement.WebhookEvent.Core.Interfaces;

namespace LoyaltyManagement.WebhookEvent.Core.Models
{
    public class RewardUpdated : IDomainEvent
    {
        public DateTime OccurredOn { get; private set; }

        public RewardUpdated()
        {
            OccurredOn = DateTime.UtcNow;
        }
    }
}

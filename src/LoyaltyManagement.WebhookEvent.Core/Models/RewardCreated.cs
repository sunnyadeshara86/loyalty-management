using LoyaltyManagement.WebhookEvent.Core.Interfaces;

namespace LoyaltyManagement.WebhookEvent.Core.Models
{
    public class RewardCreated : IDomainEvent
    {
        public DateTime OccurredOn { get; private set; }

        public RewardCreated()
        {
            OccurredOn = DateTime.UtcNow;
        }
    }
}

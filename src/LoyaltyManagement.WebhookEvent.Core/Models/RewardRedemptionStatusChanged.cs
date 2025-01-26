using LoyaltyManagement.WebhookEvent.Core.Interfaces;

namespace LoyaltyManagement.WebhookEvent.Core.Models
{
    public class RewardRedemptionStatusChanged : IDomainEvent
    {
        public DateTime OccurredOn { get; private set; }

        public RewardRedemptionStatusChanged()
        {
            OccurredOn = DateTime.UtcNow;
        }
    }
}

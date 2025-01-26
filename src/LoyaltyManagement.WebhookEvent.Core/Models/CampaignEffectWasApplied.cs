using LoyaltyManagement.WebhookEvent.Core.Interfaces;

namespace LoyaltyManagement.WebhookEvent.Core.Models
{
    public class CampaignEffectWasApplied : IDomainEvent
    {
        public DateTime OccurredOn { get; private set; }

        public CampaignEffectWasApplied()
        {
            OccurredOn = DateTime.UtcNow;
        }
    }
}

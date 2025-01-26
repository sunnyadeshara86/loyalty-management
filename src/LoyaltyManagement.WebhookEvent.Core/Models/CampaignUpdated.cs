using LoyaltyManagement.WebhookEvent.Core.Interfaces;

namespace LoyaltyManagement.WebhookEvent.Core.Models
{
    public class CampaignUpdated : IDomainEvent
    {
        public DateTime OccurredOn { get; private set; }

        public CampaignUpdated()
        {
            OccurredOn = DateTime.UtcNow;
        }
    }
}

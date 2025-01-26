using LoyaltyManagement.WebhookEvent.Core.Interfaces;

namespace LoyaltyManagement.WebhookEvent.Core.Models
{
    public class CampaignCreated : IDomainEvent
    {
        public DateTime OccurredOn { get; private set; }

        public CampaignCreated()
        {
            OccurredOn = DateTime.UtcNow;
        }
    }
}

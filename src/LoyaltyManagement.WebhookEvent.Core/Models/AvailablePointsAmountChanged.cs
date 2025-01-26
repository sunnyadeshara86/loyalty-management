using LoyaltyManagement.WebhookEvent.Core.Interfaces;

namespace LoyaltyManagement.WebhookEvent.Core.Models
{
    public class AvailablePointsAmountChanged : IDomainEvent
    {
        public DateTime OccurredOn { get; private set; }

        public AvailablePointsAmountChanged()
        {
            OccurredOn = DateTime.UtcNow;
        }
    }
}

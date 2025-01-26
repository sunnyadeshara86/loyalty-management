using LoyaltyManagement.WebhookEvent.Core.Interfaces;

namespace LoyaltyManagement.WebhookEvent.Core.Models
{
    public class PointsWillExpire : IDomainEvent
    {
        public DateTime OccurredOn { get; private set; }

        public PointsWillExpire()
        {
            OccurredOn = DateTime.UtcNow;
        }
    }
}

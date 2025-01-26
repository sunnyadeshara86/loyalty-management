using LoyaltyManagement.WebhookEvent.Core.Interfaces;

namespace LoyaltyManagement.WebhookEvent.Core.Models
{
    public class CouponWillExpire : IDomainEvent
    {
        public DateTime OccurredOn { get; private set; }

        public CouponWillExpire()
        {
            OccurredOn = DateTime.UtcNow;
        }
    }
}

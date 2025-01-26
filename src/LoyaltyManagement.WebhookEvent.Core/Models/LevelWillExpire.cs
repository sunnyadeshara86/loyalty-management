using LoyaltyManagement.WebhookEvent.Core.Interfaces;

namespace LoyaltyManagement.WebhookEvent.Core.Models
{
    public class LevelWillExpire : IDomainEvent
    {
        public DateTime OccurredOn { get; private set; }

        public LevelWillExpire()
        {
            OccurredOn = DateTime.UtcNow;
        }
    }
}

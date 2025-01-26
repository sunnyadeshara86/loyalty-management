using LoyaltyManagement.WebhookEvent.Core.Interfaces;

namespace LoyaltyManagement.WebhookEvent.Core.Models
{
    public class AchievementUpdated : IDomainEvent
    {
        public DateTime OccurredOn { get; private set; }

        public AchievementUpdated()
        {
            OccurredOn = DateTime.UtcNow;
        }
    }
}

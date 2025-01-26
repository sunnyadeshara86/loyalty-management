using LoyaltyManagement.WebhookEvent.Core.Interfaces;

namespace LoyaltyManagement.WebhookEvent.Core.Models
{
    public class AchievementCreated : IDomainEvent
    {
        public DateTime OccurredOn { get; private set; }

        public AchievementCreated()
        {
            OccurredOn = DateTime.UtcNow;
        }
    }
}

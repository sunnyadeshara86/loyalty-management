using LoyaltyManagement.WebhookEvent.Core.Interfaces;

namespace LoyaltyManagement.WebhookEvent.Core.Models
{
    public class MemberAchievementProgressWasChanged : IDomainEvent
    {
        public DateTime OccurredOn { get; private set; }

        public MemberAchievementProgressWasChanged()
        {
            OccurredOn = DateTime.UtcNow;
        }
    }
}

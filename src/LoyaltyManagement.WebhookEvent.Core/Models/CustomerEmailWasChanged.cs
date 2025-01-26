using LoyaltyManagement.WebhookEvent.Core.Interfaces;

namespace LoyaltyManagement.WebhookEvent.Core.Models
{
    public class CustomerEmailWasChanged : IDomainEvent
    {
        public DateTime OccurredOn { get; private set; }

        public CustomerEmailWasChanged()
        {
            OccurredOn = DateTime.UtcNow;
        }
    }
}

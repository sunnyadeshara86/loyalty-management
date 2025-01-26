using LoyaltyManagement.WebhookEvent.Core.Interfaces;

namespace LoyaltyManagement.WebhookEvent.Core.Models
{
    public class CustomerPhoneNumberWasChanged : IDomainEvent
    {
        public DateTime OccurredOn { get; private set; }

        public CustomerPhoneNumberWasChanged()
        {
            OccurredOn = DateTime.UtcNow;
        }
    }
}

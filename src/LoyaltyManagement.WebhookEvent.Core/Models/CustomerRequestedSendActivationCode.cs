using LoyaltyManagement.WebhookEvent.Core.Interfaces;

namespace LoyaltyManagement.WebhookEvent.Core.Models
{
    public class CustomerRequestedSendActivationCode : IDomainEvent
    {
        public DateTime OccurredOn { get; private set; }

        public CustomerRequestedSendActivationCode()
        {
            OccurredOn = DateTime.UtcNow;
        }
    }
}

using LoyaltyManagement.WebhookEvent.Core.Interfaces;

namespace LoyaltyManagement.WebhookEvent.Core.Models
{
    public class CustomerRequestedPasswordReset : IDomainEvent
    {
        public DateTime OccurredOn { get; private set; }

        public CustomerRequestedPasswordReset()
        {
            OccurredOn = DateTime.UtcNow;
        }
    }
}

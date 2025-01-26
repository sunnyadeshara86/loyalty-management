using LoyaltyManagement.WebhookEvent.Core.Interfaces;

namespace LoyaltyManagement.WebhookEvent.Core.Models
{
    public class UnitsTransferWasAdded : IDomainEvent
    {
        public DateTime OccurredOn { get; private set; }

        public UnitsTransferWasAdded()
        {
            OccurredOn = DateTime.UtcNow;
        }
    }
}

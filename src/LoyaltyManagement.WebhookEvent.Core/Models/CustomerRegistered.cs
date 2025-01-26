using LoyaltyManagement.WebhookEvent.Core.Interfaces;

namespace LoyaltyManagement.WebhookEvent.Core.Models
{
    public class CustomerRegistered : IDomainEvent
    {
        public DateTime OccurredOn { get; private set; }

        public CustomerRegistered(string name)
        {
            Name = name;
            OccurredOn = DateTime.UtcNow;
        }

        public string Name { get; private set; }
    }
}

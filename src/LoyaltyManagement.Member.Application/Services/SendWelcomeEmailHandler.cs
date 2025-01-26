using LoyaltyManagement.WebhookEvent.Core.Interfaces;
using LoyaltyManagement.WebhookEvent.Core.Models;

namespace LoyaltyManagement.Member.Application.Services
{
    public class SendWelcomeEmailHandler : IDomainEventHandler<CustomerRegistered>
    {
        public Task Handle(CustomerRegistered domainEvent)
        {
            return Task.CompletedTask;
        }
    }
}

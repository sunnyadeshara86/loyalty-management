using LoyaltyManagement.WebhookEvent.Core.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace LoyaltyManagement.WebhookEvent.Core.Services
{
    public class DomainEventDispatcher : IDomainEventDispatcher
    {
        private readonly IServiceProvider _serviceProvider;

        public DomainEventDispatcher(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task Dispatch(IDomainEvent domainEvent)
        {
            var handlers = _serviceProvider.GetServices(typeof(IDomainEventHandler<>).MakeGenericType(domainEvent.GetType()));

            if (handlers != null)
            {
                foreach (var handler in handlers)
                {
                    await ((dynamic)handler).Handle((dynamic)domainEvent);
                }
            }
        }

        public async Task DispatchAll(IEnumerable<IDomainEvent> domainEvents)
        {
            foreach (var domainEvent in domainEvents)
            {
                await Dispatch(domainEvent);
            }
        }
    }
}

using LoyaltyManagement.Member.Core.Repositories;
using LoyaltyManagement.WebhookEvent.Core.Interfaces;
using MediatR;

namespace LoyaltyManagement.Member.Application.Commands
{
    public class CreateMemberHandler : IRequestHandler<CreateMemberCommand>
    {
        private readonly IMemberRepository _repository;
        private readonly IDomainEventDispatcher _eventDispatcher;

        public CreateMemberHandler(IMemberRepository repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(CreateMemberCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(request.Member);

            // Dispatch domain events
            var domainEvents = request.Member.DomainEvents.ToList();
            request.Member.ClearDomainEvents();

            await _eventDispatcher.DispatchAll(domainEvents);

            return Unit.Value;
        }
    }
}

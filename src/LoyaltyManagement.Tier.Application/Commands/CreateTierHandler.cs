using LoyaltyManagement.Tier.Core.Repositories;
using MediatR;

namespace LoyaltyManagement.Store.Application.Commands
{
    public class CreateTierHandler : IRequestHandler<CreateTierCommand>
    {
        private readonly ITierRepository _repository;

        public CreateTierHandler(ITierRepository repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(CreateTierCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(request.Tier);
            return Unit.Value;
        }
    }
}

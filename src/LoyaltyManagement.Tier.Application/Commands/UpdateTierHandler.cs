using LoyaltyManagement.Tier.Core.Repositories;
using MediatR;

namespace LoyaltyManagement.Store.Application.Commands
{
    public class UpdateTierHandler : IRequestHandler<UpdateTierCommand>
    {
        private readonly ITierRepository _repository;

        public UpdateTierHandler(ITierRepository repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(UpdateTierCommand request, CancellationToken cancellationToken)
        {
            await _repository.UpdateAsync(request.Tier);
            return Unit.Value;
        }
    }
}

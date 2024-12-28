using LoyaltyManagement.Tier.Core.Repositories;
using MediatR;

namespace LoyaltyManagement.Store.Application.Commands
{
    public class DeleteTierHandler : IRequestHandler<DeleteTierCommand>
    {
        private readonly ITierRepository _repository;

        public DeleteTierHandler(ITierRepository repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(DeleteTierCommand request, CancellationToken cancellationToken)
        {
            await _repository.DeleteAsync(request.Id);
            return Unit.Value;
        }
    }
}

using LoyaltyManagement.Tier.Application.Queries;
using LoyaltyManagement.Tier.Core.Models;
using LoyaltyManagement.Tier.Core.Repositories;
using MediatR;

namespace LoyaltyManagement.Store.Application.Queries
{
    public class GetTierByIdHandler : IRequestHandler<GetTierByIdQuery, TierModel>
    {
        private readonly ITierRepository _repository;

        public GetTierByIdHandler(ITierRepository repository)
        {
            _repository = repository;
        }

        public async Task<TierModel> Handle(GetTierByIdQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetByIdAsync(request.Id);
        }
    }
}

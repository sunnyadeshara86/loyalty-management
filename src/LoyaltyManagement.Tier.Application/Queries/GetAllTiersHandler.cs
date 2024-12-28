using LoyaltyManagement.Tier.Application.Queries;
using LoyaltyManagement.Tier.Core.Models;
using LoyaltyManagement.Tier.Core.Repositories;
using MediatR;

namespace LoyaltyManagement.Store.Application.Queries
{
    public class GetAllTiersHandler : IRequestHandler<GetAllTiersQuery, IEnumerable<TierModel>>
    {
        private readonly ITierRepository _repository;

        public GetAllTiersHandler(ITierRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<TierModel>> Handle(GetAllTiersQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetAllAsync();
        }
    }
}

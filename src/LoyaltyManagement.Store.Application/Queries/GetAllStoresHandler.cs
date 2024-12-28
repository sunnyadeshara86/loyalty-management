using LoyaltyManagement.Store.Core.Models;
using LoyaltyManagement.Store.Core.Repositories;
using MediatR;

namespace LoyaltyManagement.Store.Application.Queries
{
    public class GetAllStoresHandler : IRequestHandler<GetAllStoresQuery, IEnumerable<StoreModel>>
    {
        private readonly IStoreRepository _repository;

        public GetAllStoresHandler(IStoreRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<StoreModel>> Handle(GetAllStoresQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetAllAsync();
        }
    }
}

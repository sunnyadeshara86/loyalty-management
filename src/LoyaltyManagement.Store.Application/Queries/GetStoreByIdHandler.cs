using LoyaltyManagement.Store.Core.Models;
using LoyaltyManagement.Store.Core.Repositories;
using MediatR;

namespace LoyaltyManagement.Store.Application.Queries
{
    public class GetStoreByIdHandler : IRequestHandler<GetStoreByIdQuery, StoreModel>
    {
        private readonly IStoreRepository _repository;

        public GetStoreByIdHandler(IStoreRepository repository)
        {
            _repository = repository;
        }

        public async Task<StoreModel> Handle(GetStoreByIdQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetByIdAsync(request.Id);
        }
    }
}

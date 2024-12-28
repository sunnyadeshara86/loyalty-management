using LoyaltyManagement.Store.Core.Repositories;
using MediatR;

namespace LoyaltyManagement.Store.Application.Commands
{
    public class UpdateStoreHandler : IRequestHandler<UpdateStoreCommand>
    {
        private readonly IStoreRepository _repository;

        public UpdateStoreHandler(IStoreRepository repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(UpdateStoreCommand request, CancellationToken cancellationToken)
        {
            await _repository.UpdateAsync(request.Store);
            return Unit.Value;
        }
    }
}

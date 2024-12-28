using LoyaltyManagement.Store.Core.Repositories;
using MediatR;

namespace LoyaltyManagement.Store.Application.Commands
{
    public class CreateStoreHandler : IRequestHandler<CreateStoreCommand>
    {
        private readonly IStoreRepository _repository;

        public CreateStoreHandler(IStoreRepository repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(CreateStoreCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(request.Store);
            return Unit.Value;
        }
    }
}

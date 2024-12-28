using LoyaltyManagement.Store.Core.Repositories;
using MediatR;

namespace LoyaltyManagement.Store.Application.Commands
{
    public class DeleteStoreHandler : IRequestHandler<DeleteStoreCommand>
    {
        private readonly IStoreRepository _repository;

        public DeleteStoreHandler(IStoreRepository repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(DeleteStoreCommand request, CancellationToken cancellationToken)
        {
            await _repository.DeleteAsync(request.Id);
            return Unit.Value;
        }
    }
}

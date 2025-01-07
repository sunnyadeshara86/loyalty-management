using LoyaltyManagement.Channel.Core.Repositories;
using MediatR;

namespace LoyaltyManagement.Channel.Application.Commands
{
    public class DeleteChannelHandler : IRequestHandler<DeleteChannelCommand>
    {
        private readonly IChannelRepository _repository;

        public DeleteChannelHandler(IChannelRepository repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(DeleteChannelCommand request, CancellationToken cancellationToken)
        {
            await _repository.DeleteAsync(request.Id);
            return Unit.Value;
        }
    }
}

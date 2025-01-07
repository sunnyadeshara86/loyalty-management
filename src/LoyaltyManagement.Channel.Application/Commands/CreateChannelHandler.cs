using LoyaltyManagement.Channel.Core.Repositories;
using MediatR;

namespace LoyaltyManagement.Channel.Application.Commands
{
    public class CreateChannelHandler : IRequestHandler<CreateChannelCommand>
    {
        private readonly IChannelRepository _repository;

        public CreateChannelHandler(IChannelRepository repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(CreateChannelCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(request.Channel);
            return Unit.Value;
        }
    }
}

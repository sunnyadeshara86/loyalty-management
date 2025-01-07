using LoyaltyManagement.Channel.Core.Repositories;
using MediatR;

namespace LoyaltyManagement.Channel.Application.Commands
{
    public class UpdateChannelHandler : IRequestHandler<UpdateChannelCommand>
    {
        private readonly IChannelRepository _repository;

        public UpdateChannelHandler(IChannelRepository repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(UpdateChannelCommand request, CancellationToken cancellationToken)
        {
            await _repository.UpdateAsync(request.Channel);
            return Unit.Value;
        }
    }
}
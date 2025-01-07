using LoyaltyManagement.Channel.Core.Models;
using LoyaltyManagement.Channel.Core.Repositories;
using MediatR;

namespace LoyaltyManagement.Channel.Application.Queries
{
    public class GetAllChannelsHandler : IRequestHandler<GetAllChannelsQuery, IEnumerable<ChannelModel>>
    {
        private readonly IChannelRepository _repository;

        public GetAllChannelsHandler(IChannelRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<ChannelModel>> Handle(GetAllChannelsQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetAllAsync();
        }
    }
}

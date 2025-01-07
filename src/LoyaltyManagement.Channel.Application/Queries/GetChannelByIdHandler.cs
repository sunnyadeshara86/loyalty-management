using LoyaltyManagement.Channel.Core.Models;
using LoyaltyManagement.Channel.Core.Repositories;
using MediatR;

namespace LoyaltyManagement.Channel.Application.Queries
{
    public class GetChannelByIdHandler : IRequestHandler<GetChannelByIdQuery, ChannelModel>
    {
        private readonly IChannelRepository _repository;

        public GetChannelByIdHandler(IChannelRepository repository)
        {
            _repository = repository;
        }

        public async Task<ChannelModel> Handle(GetChannelByIdQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetByIdAsync(request.Id);
        }
    }
}

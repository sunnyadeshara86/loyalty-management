using LoyaltyManagement.Channel.Core.Models;
using MediatR;

namespace LoyaltyManagement.Channel.Application.Queries
{
    public record GetAllChannelsQuery : IRequest<IEnumerable<ChannelModel>>;
    public record GetChannelByIdQuery(int Id) : IRequest<ChannelModel>;
}

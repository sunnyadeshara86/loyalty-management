using LoyaltyManagement.Channel.Core.Models;
using MediatR;

namespace LoyaltyManagement.Channel.Application.Commands
{
    public record CreateChannelCommand(ChannelModel Channel) : IRequest;
    public record UpdateChannelCommand(ChannelModel Channel) : IRequest;
    public record DeleteChannelCommand(int Id) : IRequest;
}

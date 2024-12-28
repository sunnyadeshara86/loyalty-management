using LoyaltyManagement.Tier.Core.Models;
using MediatR;

namespace LoyaltyManagement.Store.Application.Commands
{
    public record CreateTierCommand(TierModel Tier) : IRequest;
    public record UpdateTierCommand(TierModel Tier) : IRequest;
    public record DeleteTierCommand(int Id) : IRequest;
}

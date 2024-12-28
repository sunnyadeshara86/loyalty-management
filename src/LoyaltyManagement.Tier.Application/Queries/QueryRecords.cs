using LoyaltyManagement.Tier.Core.Models;
using MediatR;

namespace LoyaltyManagement.Tier.Application.Queries
{
    public record GetAllTiersQuery : IRequest<IEnumerable<TierModel>>;
    public record GetTierByIdQuery(int Id) : IRequest<TierModel>;
}

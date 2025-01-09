using LoyaltyManagement.Campaign.Core.Models;
using MediatR;

namespace LoyaltyManagement.Campaign.Application.Queries
{
    public record GetAllCampaignsQuery : IRequest<IEnumerable<CampaignModel>>;
    public record GetCampaignByIdQuery(int Id) : IRequest<CampaignModel>;
}

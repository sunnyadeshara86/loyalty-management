using LoyaltyManagement.Campaign.Core.Models;
using MediatR;

namespace LoyaltyManagement.Campaign.Application.Commands
{
    public record CreateCampaignCommand(CampaignModel Campaign) : IRequest;
    public record UpdateCampaignCommand(CampaignModel Campaign) : IRequest;
    public record DeleteCampaignCommand(int Id) : IRequest;
}

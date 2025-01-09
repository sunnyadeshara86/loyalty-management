using LoyaltyManagement.Campaign.Application.Queries;
using LoyaltyManagement.Campaign.Core.Models;
using LoyaltyManagement.Campaign.Core.Repositories;
using MediatR;

namespace LoyaltyManagement.Campaign.Application;

public class GetAllCampaignsHandler : IRequestHandler<GetAllCampaignsQuery, IEnumerable<CampaignModel>>
{
    private readonly ICampaignRepository _repository;

    public GetAllCampaignsHandler(ICampaignRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<CampaignModel>> Handle(GetAllCampaignsQuery request, CancellationToken cancellationToken)
    {
        return await _repository.GetAllAsync();
    }
}

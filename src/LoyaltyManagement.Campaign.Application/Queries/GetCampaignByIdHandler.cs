using LoyaltyManagement.Campaign.Application.Queries;
using LoyaltyManagement.Campaign.Core.Models;
using LoyaltyManagement.Campaign.Core.Repositories;
using MediatR;

namespace LoyaltyManagement.Campaign.Application;

public class GetAllCampaignByIdHandler : IRequestHandler<GetCampaignByIdQuery, CampaignModel>
{
    private readonly ICampaignRepository _repository;

    public GetAllCampaignByIdHandler(ICampaignRepository repository)
    {
        _repository = repository;
    }

    public async Task<CampaignModel> Handle(GetCampaignByIdQuery request, CancellationToken cancellationToken)
    {
        return await _repository.GetByIdAsync(request.Id);
    }
}

using LoyaltyManagement.Campaign.Application.Commands;
using LoyaltyManagement.Campaign.Core.Repositories;
using MediatR;

namespace LoyaltyManagement.Campaign.Application;

public class UpdateCampaignHandler : IRequestHandler<UpdateCampaignCommand>
{
    private readonly ICampaignRepository _repository;

    public UpdateCampaignHandler(ICampaignRepository repository)
    {
        _repository = repository;
    }

    public async Task<Unit> Handle(UpdateCampaignCommand request, CancellationToken cancellationToken)
    {
        await _repository.UpdateAsync(request.Campaign);
        return Unit.Value;
    }
}

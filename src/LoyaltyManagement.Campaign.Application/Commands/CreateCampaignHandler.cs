using LoyaltyManagement.Campaign.Application.Commands;
using LoyaltyManagement.Campaign.Core.Repositories;
using MediatR;

namespace LoyaltyManagement.Campaign.Application;

public class CreateCampaignHandler : IRequestHandler<CreateCampaignCommand>
{
    private readonly ICampaignRepository _repository;

    public CreateCampaignHandler(ICampaignRepository repository)
    {
        _repository = repository;
    }

    public async Task<Unit> Handle(CreateCampaignCommand request, CancellationToken cancellationToken)
    {
        await _repository.CreateAsync(request.Campaign);
        return Unit.Value;
    }
}

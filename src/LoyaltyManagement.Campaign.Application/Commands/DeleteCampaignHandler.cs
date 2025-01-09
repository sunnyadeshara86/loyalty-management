using LoyaltyManagement.Campaign.Application.Commands;
using LoyaltyManagement.Campaign.Core.Repositories;
using MediatR;

namespace LoyaltyManagement.Campaign.Application;

public class DeleteCampaignHandler : IRequestHandler<DeleteCampaignCommand>
{
    private readonly ICampaignRepository _repository;

    public DeleteCampaignHandler(ICampaignRepository repository)
    {
        _repository = repository;
    }

    public async Task<Unit> Handle(DeleteCampaignCommand request, CancellationToken cancellationToken)
    {
        await _repository.DeleteAsync(request.Id);
        return Unit.Value;
    }
}

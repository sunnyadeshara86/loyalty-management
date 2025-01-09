using LoyaltyManagement.Reward.Application.Commands;
using LoyaltyManagement.Reward.Core.Repositories;
using MediatR;

namespace LoyaltyManagement.Reward.Application;

public class UpdateRewardCategoryHandler : IRequestHandler<UpdateRewardCategoryCommand>
{
    private readonly IRewardCategoryRepository _repository;

    public UpdateRewardCategoryHandler(IRewardCategoryRepository repository)
    {
        _repository = repository;
    }

    public async Task<Unit> Handle(UpdateRewardCategoryCommand request, CancellationToken cancellationToken)
    {
        await _repository.UpdateAsync(request.RewardCategory);
        return Unit.Value;
    }
}

using LoyaltyManagement.Reward.Application.Commands;
using LoyaltyManagement.Reward.Core.Repositories;
using MediatR;

namespace LoyaltyManagement.Reward.Application;

public class CreateRewardCategoryHandler : IRequestHandler<CreateRewardCategoryCommand>
{
    private readonly IRewardCategoryRepository _repository;

    public CreateRewardCategoryHandler(IRewardCategoryRepository repository)
    {
        _repository = repository;
    }

    public async Task<Unit> Handle(CreateRewardCategoryCommand request, CancellationToken cancellationToken)
    {
        await _repository.CreateAsync(request.RewardCategory);
        return Unit.Value;
    }
}

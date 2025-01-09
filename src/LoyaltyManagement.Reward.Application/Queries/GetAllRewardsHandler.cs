using LoyaltyManagement.Reward.Application.Queries;
using LoyaltyManagement.Reward.Core.Models;
using LoyaltyManagement.Reward.Core.Repositories;
using MediatR;

namespace LoyaltyManagement.Reward.Application;

public class GetAllRewardsHandler : IRequestHandler<GetAllRewardsQuery, IEnumerable<RewardModel>>
{
    private readonly IRewardRepository _repository;

    public GetAllRewardsHandler(IRewardRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<RewardModel>> Handle(GetAllRewardsQuery request, CancellationToken cancellationToken)
    {
        return await _repository.GetAllAsync();
    }
}

using LoyaltyManagement.Reward.Application.Queries;
using LoyaltyManagement.Reward.Core.Models;
using LoyaltyManagement.Reward.Core.Repositories;
using MediatR;

namespace LoyaltyManagement.Reward.Application;

public class GetAllRewardCategoriesHandler : IRequestHandler<GetAllRewardCategoriesQuery, IEnumerable<RewardCategoryModel>>
{
    private readonly IRewardCategoryRepository _repository;

    public GetAllRewardCategoriesHandler(IRewardCategoryRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<RewardCategoryModel>> Handle(GetAllRewardCategoriesQuery request, CancellationToken cancellationToken)
    {
        return await _repository.GetAllAsync();
    }
}

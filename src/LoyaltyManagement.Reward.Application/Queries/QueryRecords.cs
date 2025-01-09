using LoyaltyManagement.Reward.Core.Models;
using MediatR;

namespace LoyaltyManagement.Reward.Application.Queries
{
    public record GetAllRewardCategoriesQuery : IRequest<IEnumerable<RewardCategoryModel>>;
    public record GetRewardCategoryByIdQuery(int Id) : IRequest<RewardCategoryModel>;

    public record GetAllRewardsQuery : IRequest<IEnumerable<RewardModel>>;
    public record GetRewardByIdQuery(int Id) : IRequest<RewardModel>;
}

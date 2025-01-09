using LoyaltyManagement.Reward.Core.Models;
using MediatR;

namespace LoyaltyManagement.Reward.Application.Commands
{
    public record CreateRewardCategoryCommand(RewardCategoryModel RewardCategory) : IRequest;
    public record UpdateRewardCategoryCommand(RewardCategoryModel RewardCategory) : IRequest;
    public record DeleteRewardCategoryCommand(int Id) : IRequest;

    public record CreateRewardCommand(RewardModel Reward) : IRequest;
    public record UpdateRewardCommand(RewardModel Reward) : IRequest;
    public record DeleteRewardCommand(int Id) : IRequest;
}

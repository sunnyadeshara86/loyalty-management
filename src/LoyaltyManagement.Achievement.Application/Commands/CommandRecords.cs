using LoyaltyManagement.Achievement.Core.Models;
using MediatR;

namespace LoyaltyManagement.Achievement.Application.Commands
{
    public record CreateAchievementCommand(AchievementModel Achievement) : IRequest;
    public record UpdateAchievementCommand(AchievementModel Achievement) : IRequest;
    public record DeleteAchievementCommand(int Id) : IRequest;
}

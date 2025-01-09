using LoyaltyManagement.Achievement.Core.Models;
using MediatR;

namespace LoyaltyManagement.Achievement.Application.Queries
{
    public class QueryRecords
    {
        public record GetAllAchievementsQuery : IRequest<IEnumerable<AchievementModel>>;
        public record GetAchievementByIdQuery(int Id) : IRequest<AchievementModel>;
    }
}

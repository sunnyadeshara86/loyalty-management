using LoyaltyManagement.Achievement.Core.Models;
using LoyaltyManagement.Store.Core.Repositories;
using MediatR;
using static LoyaltyManagement.Achievement.Application.Queries.QueryRecords;

namespace LoyaltyManagement.Achievement.Application;

public class GetAllAchievementsHandler : IRequestHandler<GetAllAchievementsQuery, IEnumerable<AchievementModel>>
{
    private readonly IAchievementRepository _repository;

    public GetAllAchievementsHandler(IAchievementRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<AchievementModel>> Handle(GetAllAchievementsQuery request, CancellationToken cancellationToken)
    {
        return await _repository.GetAllAsync();
    }
}

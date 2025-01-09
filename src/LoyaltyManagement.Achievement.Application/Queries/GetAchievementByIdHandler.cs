using LoyaltyManagement.Achievement.Core.Models;
using LoyaltyManagement.Store.Core.Repositories;
using MediatR;
using static LoyaltyManagement.Achievement.Application.Queries.QueryRecords;

namespace LoyaltyManagement.Achievement.Application;

public class GetAchievementByIdHandler : IRequestHandler<GetAchievementByIdQuery, AchievementModel>
{
    private readonly IAchievementRepository _repository;

    public GetAchievementByIdHandler(IAchievementRepository repository)
    {
        _repository = repository;
    }

    public async Task<AchievementModel> Handle(GetAchievementByIdQuery request, CancellationToken cancellationToken)
    {
        return await _repository.GetByIdAsync(request.Id);
    }
}

using LoyaltyManagement.Achievement.Application.Commands;
using LoyaltyManagement.Store.Core.Repositories;
using MediatR;

namespace LoyaltyManagement.Achievement.Application;

public class UpdateAchievementHandler : IRequestHandler<UpdateAchievementCommand>
{
    private readonly IAchievementRepository _repository;

    public UpdateAchievementHandler(IAchievementRepository repository)
    {
        _repository = repository;
    }

    public async Task<Unit> Handle(UpdateAchievementCommand request, CancellationToken cancellationToken)
    {
        await _repository.UpdateAsync(request.Achievement);
        return Unit.Value;
    }
}

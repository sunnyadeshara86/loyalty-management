using LoyaltyManagement.Achievement.Application.Commands;
using LoyaltyManagement.Store.Core.Repositories;
using MediatR;

namespace LoyaltyManagement.Achievement.Application;

public class DeleteAchievementHandler : IRequestHandler<DeleteAchievementCommand>
{
    private readonly IAchievementRepository _repository;

    public DeleteAchievementHandler(IAchievementRepository repository)
    {
        _repository = repository;
    }

    public async Task<Unit> Handle(DeleteAchievementCommand request, CancellationToken cancellationToken)
    {
        await _repository.DeleteAsync(request.Id);
        return Unit.Value;
    }
}

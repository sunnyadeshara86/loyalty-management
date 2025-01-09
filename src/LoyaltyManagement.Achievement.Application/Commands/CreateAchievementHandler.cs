using LoyaltyManagement.Achievement.Application.Commands;
using LoyaltyManagement.Store.Core.Repositories;
using MediatR;

namespace LoyaltyManagement.Achievement.Application;

public class CreateAchievementHandler : IRequestHandler<CreateAchievementCommand>
{
    private readonly IAchievementRepository _repository;

    public CreateAchievementHandler(IAchievementRepository repository)
    {
        _repository = repository;
    }

    public async Task<Unit> Handle(CreateAchievementCommand request, CancellationToken cancellationToken)
    {
        await _repository.CreateAsync(request.Achievement);
        return Unit.Value;
    }
}
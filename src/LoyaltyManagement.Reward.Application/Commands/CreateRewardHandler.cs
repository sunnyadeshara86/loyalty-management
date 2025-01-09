using LoyaltyManagement.Reward.Application.Commands;
using LoyaltyManagement.Reward.Core.Repositories;
using MediatR;

namespace LoyaltyManagement.Reward.Application;

public class CreateRewardHandler : IRequestHandler<CreateRewardCommand>
{
    private readonly IRewardRepository _repository;

    public CreateRewardHandler(IRewardRepository repository)
    {
        _repository = repository;
    }

    public async Task<Unit> Handle(CreateRewardCommand request, CancellationToken cancellationToken)
    {
        await _repository.CreateAsync(request.Reward);
        return Unit.Value;
    }
}

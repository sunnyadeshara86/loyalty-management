using LoyaltyManagement.Reward.Application.Commands;
using LoyaltyManagement.Reward.Core.Repositories;
using MediatR;

namespace LoyaltyManagement.Reward.Application;

public class UpdateRewardHandler : IRequestHandler<UpdateRewardCommand>
{
    private readonly IRewardRepository _repository;

    public UpdateRewardHandler(IRewardRepository repository)
    {
        _repository = repository;
    }

    public async Task<Unit> Handle(UpdateRewardCommand request, CancellationToken cancellationToken)
    {
        await _repository.UpdateAsync(request.Reward);
        return Unit.Value;
    }
}

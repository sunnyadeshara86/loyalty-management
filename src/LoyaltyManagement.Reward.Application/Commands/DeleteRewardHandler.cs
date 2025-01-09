using LoyaltyManagement.Reward.Application.Commands;
using LoyaltyManagement.Reward.Core.Repositories;
using MediatR;

namespace LoyaltyManagement.Reward.Application;

public class DeleteRewardHandler : IRequestHandler<DeleteRewardCommand>
{
    private readonly IRewardRepository _repository;

    public DeleteRewardHandler(IRewardRepository repository)
    {
        _repository = repository;
    }

    public async Task<Unit> Handle(DeleteRewardCommand request, CancellationToken cancellationToken)
    {
        await _repository.DeleteAsync(request.Id);
        return Unit.Value;
    }
}

using LoyaltyManagement.Reward.Application.Commands;
using LoyaltyManagement.Reward.Core.Repositories;
using MediatR;

namespace LoyaltyManagement.Reward.Application;

public class DeleteRewardCategoryHandler : IRequestHandler<DeleteRewardCategoryCommand>
{
    private readonly IRewardCategoryRepository _repository;

    public DeleteRewardCategoryHandler(IRewardCategoryRepository repository)
    {
        _repository = repository;
    }

    public async Task<Unit> Handle(DeleteRewardCategoryCommand request, CancellationToken cancellationToken)
    {
        await _repository.DeleteAsync(request.Id);
        return Unit.Value;
    }
}

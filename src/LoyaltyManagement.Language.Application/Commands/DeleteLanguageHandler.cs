using LoyaltyManagement.Language.Core.Repositories;
using MediatR;

namespace LoyaltyManagement.Language.Application.Commands;

public class DeleteLanguageHandler : IRequestHandler<DeleteLanguageCommand>
{
    private readonly ILanguageRepository _repository;

    public DeleteLanguageHandler(ILanguageRepository repository)
    {
        _repository = repository;
    }

    public async Task<Unit> Handle(DeleteLanguageCommand request, CancellationToken cancellationToken)
    {
        await _repository.DeleteAsync(request.Id);
        return Unit.Value;
    }
}

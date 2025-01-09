using LoyaltyManagement.Language.Core.Repositories;
using MediatR;

namespace LoyaltyManagement.Language.Application.Commands;

public class UpdateLanguageHandler : IRequestHandler<UpdateLanguageCommand>
{
    private readonly ILanguageRepository _repository;

    public UpdateLanguageHandler(ILanguageRepository repository)
    {
        _repository = repository;
    }

    public async Task<Unit> Handle(UpdateLanguageCommand request, CancellationToken cancellationToken)
    {
        await _repository.UpdateAsync(request.Language);
        return Unit.Value;
    }
}

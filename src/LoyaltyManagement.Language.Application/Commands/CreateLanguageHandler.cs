using LoyaltyManagement.Language.Core.Repositories;
using MediatR;

namespace LoyaltyManagement.Language.Application.Commands;

public class CreateLanguageHandler : IRequestHandler<CreateLanguageCommand>
{
    private readonly ILanguageRepository _repository;

    public CreateLanguageHandler(ILanguageRepository repository)
    {
        _repository = repository;
    }

    public async Task<Unit> Handle(CreateLanguageCommand request, CancellationToken cancellationToken)
    {
        await _repository.CreateAsync(request.Language);
        return Unit.Value;
    }
}

using LoyaltyManagement.Language.Core.Models;
using LoyaltyManagement.Language.Core.Repositories;
using MediatR;

namespace LoyaltyManagement.Language.Application.Queries;

public class GetAllLanguagesHandler : IRequestHandler<GetAllLanguagesQuery, IEnumerable<LanguageModel>>
{
    private readonly ILanguageRepository _repository;

    public GetAllLanguagesHandler(ILanguageRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<LanguageModel>> Handle(GetAllLanguagesQuery request, CancellationToken cancellationToken)
    {
        return await _repository.GetAllAsync();
    }
}

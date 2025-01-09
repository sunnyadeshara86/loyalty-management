using LoyaltyManagement.Language.Core.Models;
using LoyaltyManagement.Language.Core.Repositories;
using MediatR;

namespace LoyaltyManagement.Language.Application.Queries;

public class GetLanguageByIdHandler : IRequestHandler<GetLanguageByIdQuery, LanguageModel>
{
    private readonly ILanguageRepository _repository;

    public GetLanguageByIdHandler(ILanguageRepository repository)
    {
        _repository = repository;
    }

    public async Task<LanguageModel> Handle(GetLanguageByIdQuery request, CancellationToken cancellationToken)
    {
        return await _repository.GetByIdAsync(request.Id);
    }
}

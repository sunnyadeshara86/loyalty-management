using LoyaltyManagement.Language.Core.Models;
using MediatR;

namespace LoyaltyManagement.Language.Application.Queries
{
    public record GetAllLanguagesQuery : IRequest<IEnumerable<LanguageModel>>;
    public record GetLanguageByIdQuery(int Id) : IRequest<LanguageModel>;
}

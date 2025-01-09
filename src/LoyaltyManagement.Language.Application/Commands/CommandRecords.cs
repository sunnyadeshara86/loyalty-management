using LoyaltyManagement.Language.Core.Models;
using MediatR;

namespace LoyaltyManagement.Language.Application.Commands
{
    public record CreateLanguageCommand(LanguageModel Language) : IRequest;
    public record UpdateLanguageCommand(LanguageModel Language) : IRequest;
    public record DeleteLanguageCommand(int Id) : IRequest;
}

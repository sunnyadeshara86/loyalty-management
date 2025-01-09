using FluentValidation;
using LoyaltyManagement.Language.Application.Commands;

namespace LoyaltyManagement.Language.Application.Validations
{
    public class CreateLanguageCommandValidator : AbstractValidator<CreateLanguageCommand>
    {
        public CreateLanguageCommandValidator()
        {
            RuleFor(x => x.Language).SetValidator(new LanguageValidator());
        }
    }
}

using FluentValidation;
using LoyaltyManagement.Language.Core.Models;

namespace LoyaltyManagement.Language.Application.Validations
{
    public class LanguageValidator : AbstractValidator<LanguageModel>
    {
        public LanguageValidator()
        {
            RuleFor(x => x.LocaleCode)
                .NotEmpty().WithMessage("Code is required.")
                .MaximumLength(50).WithMessage("Code must not exceed 50 characters.");

            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Name is required.")
                .MaximumLength(100).WithMessage("Name must not exceed 100 characters.");

            RuleFor(x => x.CreatedAt)
                .LessThanOrEqualTo(DateTime.UtcNow).WithMessage("CreatedAt cannot be in the future.");
        }
    }
}

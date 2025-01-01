using FluentValidation;
using LoyaltyManagement.Store.Application.Commands;
using LoyaltyManagement.Tier.Application.Validations;

namespace LoyaltyManagement.Store.Application.Validations
{
    public class CreateTierCommandValidator : AbstractValidator<CreateTierCommand>
    {
        public CreateTierCommandValidator()
        {
            RuleFor(x => x.Tier).SetValidator(new TierValidator());
        }
    }
}

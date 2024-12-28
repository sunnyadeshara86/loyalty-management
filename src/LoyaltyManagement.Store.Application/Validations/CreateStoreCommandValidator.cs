using FluentValidation;
using LoyaltyManagement.Store.Application.Commands;

namespace LoyaltyManagement.Store.Application.Validations
{
    public class CreateStoreCommandValidator : AbstractValidator<CreateStoreCommand>
    {
        public CreateStoreCommandValidator()
        {
            RuleFor(x => x.Store).SetValidator(new StoreValidator());
        }
    }
}

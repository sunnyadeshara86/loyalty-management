using FluentValidation;
using LoyaltyManagement.Reward.Core.Models;

namespace LoyaltyManagement.Store.Application.Validations
{
    public class RewardValidator : AbstractValidator<RewardModel>
    {
        public RewardValidator()
        {
            RuleFor(x => x.Code)
                .NotEmpty().WithMessage("Code is required.")
                .MaximumLength(50).WithMessage("Code must not exceed 50 characters.");

            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Name is required.")
                .MaximumLength(100).WithMessage("Name must not exceed 100 characters.");
        }
    }
}

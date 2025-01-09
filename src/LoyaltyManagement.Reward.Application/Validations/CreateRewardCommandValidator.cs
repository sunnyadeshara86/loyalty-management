using FluentValidation;
using LoyaltyManagement.Reward.Application.Commands;
using LoyaltyManagement.Store.Application.Validations;

namespace LoyaltyManagement.Reward.Application.Validations
{
    public class CreateRewardCommandValidator : AbstractValidator<CreateRewardCommand>
    {
        public CreateRewardCommandValidator()
        {
            RuleFor(x => x.Reward).SetValidator(new RewardValidator());
        }
    }
}

using FluentValidation;
using LoyaltyManagement.Channel.Application.Commands;

namespace LoyaltyManagement.Channel.Application.Validations
{
    public class CreateChannelCommandValidator : AbstractValidator<CreateChannelCommand>
    {
        public CreateChannelCommandValidator()
        {
            RuleFor(x => x.Channel).SetValidator(new ChannelValidator());
        }
    }
}

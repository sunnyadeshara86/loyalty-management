using FluentValidation;
using LoyaltyManagement.Member.Application.Commands;

namespace LoyaltyManagement.Member.Application.Validations
{
    public class CreateMemberCommandValidator : AbstractValidator<CreateMemberCommand>
    {
        public CreateMemberCommandValidator()
        {
            RuleFor(x => x.Member).SetValidator(new MemberValidator());
        }
    }
}

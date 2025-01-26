using FluentValidation;
using LoyaltyManagement.Campaign.Application.Commands;

namespace LoyaltyManagement.Campaign.Application.Validations
{
    public class CreateMemberCommandValidator : AbstractValidator<CreateCampaignCommand>
    {
        public CreateMemberCommandValidator()
        {
            RuleFor(x => x.Campaign).SetValidator(new CampaignValidator());
        }
    }
}

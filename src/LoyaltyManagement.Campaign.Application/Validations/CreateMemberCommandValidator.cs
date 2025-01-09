using FluentValidation;
using LoyaltyManagement.Campaign.Application.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

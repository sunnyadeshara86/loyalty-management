using FluentValidation;
using LoyaltyManagement.Campaign.Core.Models;

namespace LoyaltyManagement.Campaign.Application.Validations
{
    public class CampaignValidator : AbstractValidator<CampaignModel>
    {
        public CampaignValidator()
        {
            RuleFor(x => x.Code)
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

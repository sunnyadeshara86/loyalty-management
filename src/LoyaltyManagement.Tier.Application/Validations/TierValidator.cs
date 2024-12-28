using FluentValidation;
using LoyaltyManagement.Tier.Core.Models;

namespace LoyaltyManagement.Tier.Application.Validations
{
    public class TierValidator : AbstractValidator<TierModel>
    {
        public TierValidator()
        {
            RuleFor(t => t.Code).NotEmpty().WithMessage("Code is required.");
            RuleFor(t => t.Name).NotEmpty().WithMessage("Name is required.");
            RuleFor(t => t.Description).MaximumLength(500).WithMessage("Description cannot exceed 500 characters.");
            RuleFor(t => t.StoreId).GreaterThan(0).WithMessage("StoreId must be greater than zero.");
            RuleFor(t => t.SortOrder).GreaterThanOrEqualTo(0).WithMessage("SortOrder must be non-negative.");
        }
    }
}

using FluentValidation;
using LoyaltyManagement.Segment.Core.Models;

namespace LoyaltyManagement.Store.Application.Validations
{
    public class SegmentValidator : AbstractValidator<SegmentModel>
    {
        public SegmentValidator()
        {
            RuleFor(x => x.Code)
                .NotEmpty().WithMessage("Code is required.")
                .MaximumLength(50).WithMessage("Code must not exceed 50 characters.");

            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Name is required.")
                .MaximumLength(100).WithMessage("Name must not exceed 100 characters.");

            RuleFor(x => x.Currency)
                .NotEmpty().WithMessage("Currency is required.")
                .Matches("^[A-Z]{3}$").WithMessage("Currency must be a valid 3-letter ISO code.");

            RuleFor(x => x.CreatedBy)
                .NotEmpty().WithMessage("CreatedBy is required.");

            RuleFor(x => x.CreatedAt)
                .LessThanOrEqualTo(DateTime.UtcNow).WithMessage("CreatedAt cannot be in the future.");
        }
    }
}

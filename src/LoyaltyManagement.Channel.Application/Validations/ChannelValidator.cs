using FluentValidation;
using LoyaltyManagement.Channel.Core.Models;

namespace LoyaltyManagement.Channel.Application.Validations
{
    public class ChannelValidator : AbstractValidator<ChannelModel>
    {
        public ChannelValidator()
        {
            RuleFor(x => x.Code)
                .NotEmpty().WithMessage("Code is required.")
                .MaximumLength(50).WithMessage("Code must not exceed 50 characters.");

            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Name is required.")
                .MaximumLength(100).WithMessage("Name must not exceed 100 characters.");

            RuleFor(x => x.CreatedBy)
                .NotEmpty().WithMessage("CreatedBy is required.");

            RuleFor(x => x.CreatedAt)
                .LessThanOrEqualTo(DateTime.UtcNow).WithMessage("CreatedAt cannot be in the future.");
        }
    }
}

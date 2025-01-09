using FluentValidation;
using LoyaltyManagement.Segment.Application.Commands;
using LoyaltyManagement.Store.Application.Validations;

namespace LoyaltyManagement.Segment.Application.Validations
{
    public class CreateSegmentCommandValidator : AbstractValidator<CreateSegmentCommand>
    {
        public CreateSegmentCommandValidator()
        {
            RuleFor(x => x.Segment).SetValidator(new SegmentValidator());
        }
    }
}

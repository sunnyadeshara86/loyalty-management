using LoyaltyManagement.Segment.Core.Models;
using MediatR;

namespace LoyaltyManagement.Segment.Application.Commands
{
    public record CreateSegmentCommand(SegmentModel Segment) : IRequest;
    public record UpdateSegmentCommand(SegmentModel Segment) : IRequest;
    public record DeleteSegmentCommand(int Id) : IRequest;
}

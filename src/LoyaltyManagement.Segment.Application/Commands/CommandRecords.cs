using LoyaltyManagement.Segment.Core.Models;
using MediatR;

namespace LoyaltyManagement.Segment.Application.Commands
{
    public class CommandRecords
    {
        public record CreateSegmentCommand(SegmentModel Channel) : IRequest;
        public record UpdateSegmentCommand(SegmentModel Channel) : IRequest;
        public record DeleteSegmentCommand(int Id) : IRequest;
    }
}

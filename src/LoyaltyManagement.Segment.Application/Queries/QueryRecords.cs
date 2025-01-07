using LoyaltyManagement.Segment.Core.Models;
using MediatR;

namespace LoyaltyManagement.Segment.Application.Queries
{
    public class QueryRecords
    {
        public record GetAllSegmentsQuery : IRequest<IEnumerable<SegmentModel>>;
        public record GetSegmentByIdQuery(int Id) : IRequest<SegmentModel>;
    }
}

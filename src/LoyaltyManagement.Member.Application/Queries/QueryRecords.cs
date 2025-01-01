using LoyaltyManagement.Member.Core.Models;
using MediatR;

namespace LoyaltyManagement.Member.Application.Queries
{
    public record GetAllMembersQuery : IRequest<IEnumerable<MemberModel>>;
    public record GetMemberByIdQuery(int Id) : IRequest<MemberModel>;
}

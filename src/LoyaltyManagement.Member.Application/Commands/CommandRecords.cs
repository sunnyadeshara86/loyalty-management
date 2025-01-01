using LoyaltyManagement.Member.Core.Models;
using MediatR;

namespace LoyaltyManagement.Member.Application.Commands
{
    public record CreateMemberCommand(MemberModel Member) : IRequest;
    public record UpdateMemberCommand(MemberModel Member) : IRequest;
    public record DeleteMemberCommand(int Id) : IRequest;
}

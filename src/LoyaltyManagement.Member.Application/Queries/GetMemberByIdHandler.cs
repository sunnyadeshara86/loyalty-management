using LoyaltyManagement.Member.Application.Queries;
using LoyaltyManagement.Member.Core.Models;
using LoyaltyManagement.Member.Core.Repositories;
using MediatR;

namespace LoyaltyManagement.Member.Application;

public class GetMemberByIdHandler : IRequestHandler<GetMemberByIdQuery, MemberModel>
{
    private readonly IMemberRepository _repository;

    public GetMemberByIdHandler(IMemberRepository repository)
    {
        _repository = repository;
    }

    public async Task<MemberModel> Handle(GetMemberByIdQuery request, CancellationToken cancellationToken)
    {
        return await _repository.GetByIdAsync(request.Id);
    }
}

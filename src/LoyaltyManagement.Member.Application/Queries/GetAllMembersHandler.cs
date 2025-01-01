using LoyaltyManagement.Member.Core.Models;
using LoyaltyManagement.Member.Core.Repositories;
using MediatR;

namespace LoyaltyManagement.Member.Application.Queries
{
    public class GetAllMembersHandler : IRequestHandler<GetAllMembersQuery, IEnumerable<MemberModel>>
    {
        private readonly IMemberRepository _repository;

        public GetAllMembersHandler(IMemberRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<MemberModel>> Handle(GetAllMembersQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetAllAsync();
        }
    }
}

using LoyaltyManagement.Member.Core.Repositories;
using MediatR;

namespace LoyaltyManagement.Member.Application.Commands
{
    public class UpdateMemberHandler : IRequestHandler<UpdateMemberCommand>
    {
        private readonly IMemberRepository _repository;

        public UpdateMemberHandler(IMemberRepository repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(UpdateMemberCommand request, CancellationToken cancellationToken)
        {
            await _repository.UpdateAsync(request.Member);
            return Unit.Value;
        }
    }
}

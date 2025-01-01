using LoyaltyManagement.Member.Core.Repositories;
using MediatR;

namespace LoyaltyManagement.Member.Application.Commands
{
    public class DeleteMemberHandler : IRequestHandler<DeleteMemberCommand>
    {
        private readonly IMemberRepository _repository;

        public DeleteMemberHandler(IMemberRepository repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(DeleteMemberCommand request, CancellationToken cancellationToken)
        {
            await _repository.DeleteAsync(request.Id);
            return Unit.Value;
        }
    }
}

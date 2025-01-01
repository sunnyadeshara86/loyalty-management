using LoyaltyManagement.Member.Core.Repositories;
using MediatR;

namespace LoyaltyManagement.Member.Application.Commands
{
    public class CreateMemberHandler : IRequestHandler<CreateMemberCommand>
    {
        private readonly IMemberRepository _repository;

        public CreateMemberHandler(IMemberRepository repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(CreateMemberCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(request.Member);
            return Unit.Value;
        }
    }
}

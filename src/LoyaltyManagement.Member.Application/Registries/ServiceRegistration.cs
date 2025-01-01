using FluentValidation;
using LoyaltyManagement.Member.Application.Queries;
using LoyaltyManagement.Member.Application.Validations;
using LoyaltyManagement.Member.Core.Repositories;
using LoyaltyManagement.Member.Persistence.Repositories;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace LoyaltyManagement.Member.Application.Registries
{
    public static class ServiceRegistration
    {
        public static void RegisterApplicationServices(this IServiceCollection services)
        {
            services.AddMediatR(typeof(GetAllMembersHandler).Assembly);

            services.AddScoped<IMemberRepository, MemberRepository>();

            services.AddValidatorsFromAssemblyContaining<CreateMemberCommandValidator>();

            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
        }
    }
}

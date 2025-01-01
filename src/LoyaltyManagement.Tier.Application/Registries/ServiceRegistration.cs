using FluentValidation;
using LoyaltyManagement.Store.Application.Queries;
using LoyaltyManagement.Store.Application.Validations;
using LoyaltyManagement.Tier.Core.Repositories;
using LoyaltyManagement.Tier.Persistence.Repositories;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace LoyaltyManagement.Tier.Application.Registries
{
    public static class ServiceRegistration
    {
        public static void RegisterApplicationServices(this IServiceCollection services)
        {
            services.AddMediatR(typeof(GetAllTiersHandler).Assembly);

            services.AddScoped<ITierRepository, TierRepository>();

            services.AddValidatorsFromAssemblyContaining<CreateTierCommandValidator>();

            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
        }
    }
}

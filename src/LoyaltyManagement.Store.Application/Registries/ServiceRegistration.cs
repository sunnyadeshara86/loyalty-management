using FluentValidation;
using LoyaltyManagement.Store.Application.Queries;
using LoyaltyManagement.Store.Application.Validations;
using LoyaltyManagement.Store.Core.Repositories;
using LoyaltyManagement.Store.Persistence.Repositories;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace LoyaltyManagement.Store.Application.Registries
{
    public static class ServiceRegistration
    {
        public static void RegisterApplicationServices(this IServiceCollection services)
        {
            services.AddMediatR(typeof(GetAllStoresHandler).Assembly);

            services.AddScoped<IStoreRepository, StoreRepository>();

            services.AddValidatorsFromAssemblyContaining<CreateStoreCommandValidator>();

            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
        }
    }
}

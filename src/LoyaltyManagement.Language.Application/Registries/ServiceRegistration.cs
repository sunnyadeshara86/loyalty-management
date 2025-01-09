using FluentValidation;
using LoyaltyManagement.Language.Application.Queries;
using LoyaltyManagement.Language.Application.Validations;
using LoyaltyManagement.Language.Core.Repositories;
using LoyaltyManagement.Language.Persistence.Repositories;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace LoyaltyManagement.Language.Application.Registries
{
    public static class ServiceRegistration
    {
        public static void RegisterApplicationServices(this IServiceCollection services)
        {
            services.AddMediatR(typeof(GetAllLanguagesHandler).Assembly);

            services.AddScoped<ILanguageRepository, LanguageRepository>();

            services.AddValidatorsFromAssemblyContaining<CreateLanguageCommandValidator>();

            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
        }
    }
}

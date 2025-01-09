using FluentValidation;
using LoyaltyManagement.Campaign.Application.Validations;
using LoyaltyManagement.Campaign.Core.Repositories;
using LoyaltyManagement.Campaign.Persistence.Repositories;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace LoyaltyManagement.Campaign.Application.Registries
{
    public static class ServiceRegistration
    {
        public static void RegisterApplicationServices(this IServiceCollection services)
        {
            services.AddMediatR(typeof(GetAllCampaignsHandler).Assembly);

            services.AddScoped<ICampaignRepository, CampaignRepository>();

            services.AddValidatorsFromAssemblyContaining<CreateMemberCommandValidator>();

            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
        }
    }
}

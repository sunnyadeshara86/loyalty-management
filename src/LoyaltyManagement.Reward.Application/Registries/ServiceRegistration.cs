using FluentValidation;
using LoyaltyManagement.Reward.Application.Validations;
using LoyaltyManagement.Reward.Core.Repositories;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace LoyaltyManagement.Reward.Application.Registries
{
    public static class ServiceRegistration
    {
        public static void RegisterApplicationServices(this IServiceCollection services)
        {
            services.AddMediatR(typeof(GetAllRewardsHandler).Assembly);

            services.AddScoped<IRewardCategoryRepository, IRewardCategoryRepository>();

            services.AddScoped<IRewardRepository, IRewardRepository>();

            services.AddValidatorsFromAssemblyContaining<CreateRewardCommandValidator>();

            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
        }
    }
}

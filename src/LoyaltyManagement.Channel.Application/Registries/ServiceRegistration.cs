using FluentValidation;
using LoyaltyManagement.Channel.Application.Queries;
using LoyaltyManagement.Channel.Application.Validations;
using LoyaltyManagement.Channel.Core.Repositories;
using LoyaltyManagement.Channel.Persistence.Repositories;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace LoyaltyManagement.Channel.Application.Registries
{
    public static class ServiceRegistration
    {
        public static void RegisterApplicationServices(this IServiceCollection services)
        {
            services.AddMediatR(typeof(GetAllChannelsQuery).Assembly);

            services.AddScoped<IChannelRepository, ChannelRepository>();

            services.AddValidatorsFromAssemblyContaining<CreateChannelCommandValidator>();

            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
        }
    }
}

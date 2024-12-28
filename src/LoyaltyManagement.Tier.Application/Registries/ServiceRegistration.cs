using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoyaltyManagement.Tier.Application.Registries
{
    public static class ServiceRegistration
    {
        public static void RegisterApplicationServices(this IServiceCollection services)
        {
            //services.AddMediatR(typeof(GetAllStoresQuery).Assembly);

            //services.AddScoped<IStoreRepository, StoreRepository>();

            //services.AddValidatorsFromAssemblyContaining<CreateStoreCommandValidator>();

            //services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
        }
    }
}

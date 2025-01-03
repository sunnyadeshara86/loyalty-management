using FluentValidation;
using LoyaltyManagement.Store.Api.Middlewares;
using LoyaltyManagement.Store.Application.Queries;
using LoyaltyManagement.Store.Application.Registries;
using LoyaltyManagement.Store.Core.Repositories;
using LoyaltyManagement.Store.Persistence.Repositories;
using MediatR;
using MongoDB.Driver;
using System.Reflection;

namespace LoyaltyManagement.Store.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllers();

            builder.Services.AddSingleton<IMongoClient>(sp =>
            {
                var connectionString = builder.Configuration["MongoDbSettings:ConnectionString"];
                return new MongoClient(connectionString);
            });

            builder.Services.AddSingleton(sp =>
            {
                var client = sp.GetRequiredService<IMongoClient>();
                var databaseName = builder.Configuration["MongoDbSettings:DatabaseName"];
                return client.GetDatabase(databaseName);
            });

            builder.Services.AddScoped<IStoreRepository, StoreRepository>();

            builder.Services.RegisterApplicationServices();
            
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();
            app.UseMiddleware<ValidationExceptionMiddleware>();

            app.Run();
        }
    }
}

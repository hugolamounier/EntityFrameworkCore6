using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using UnitOfWork;

namespace DependencyInjection;

public static class InfrastructureServiceCollection
{
    public static IServiceCollection AddMySQlServer(this IServiceCollection services, IConfiguration configuration, IWebHostEnvironment environment)
    {
        var connectionString = configuration["DefaultConnection"];

        if (environment.IsDevelopment() || environment.IsStaging())
        {
            services.AddDbContext<ApplicationDbContext>();
        }
        else
        {
            services.AddDbContext<ApplicationDbContext>();
        }

        return services;
    }
    public static IServiceCollection AddInfrastructureServiceCollection(this IServiceCollection services)
    {
        return services;
    }
}
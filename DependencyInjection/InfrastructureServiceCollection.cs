using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using UnitOfWork;

namespace DependencyInjection;

public static class InfrastructureServiceCollection
{
    public static IServiceCollection AddMySqlServer(this IServiceCollection services, IConfiguration configuration, IWebHostEnvironment environment)
    {
        var connectionString = configuration["DefaultConnection"];

        if (environment.IsDevelopment() || environment.IsStaging())
        {
            services.AddDbContext<ApplicationDbContext>(option => option
                .UseMySql(connectionString, ServerVersion.AutoDetect(connectionString))
                .LogTo(Console.WriteLine, LogLevel.Trace)
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors());
        }
        else
        {
            services.AddDbContext<ApplicationDbContext>(option => option
                .UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));
        }

        return services;
    }
    public static IServiceCollection AddInfrastructureServiceCollection(this IServiceCollection services)
    {
        return services;
    }
}
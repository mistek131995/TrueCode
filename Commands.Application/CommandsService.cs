using Commands.Infrastructure.Contexts;
using Commands.Infrastructure.Interfaces;
using Commands.Infrastructure.Providers;
using Commands.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Commands.Application;

public static class CommandsService
{
    public static IServiceCollection AddCommands(this IServiceCollection services, string connectionString)
    {
        services.AddScoped<IRepositoryProvider, RepositoryProvider>();
        services.AddScoped<IFileStorageService, FileStorageService>(service =>
            new FileStorageService(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads")));
        services.AddDbContext<SQLContext>(option => option.UseSqlServer(connectionString));
        services.AddMediatR(cfg => 
        {
            cfg.RegisterServicesFromAssembly(typeof(CommandsService).Assembly);
        });
        
        return services;
    }
}
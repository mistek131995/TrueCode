using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace Commands.Application;

public static class CommandsService
{
    public static IServiceCollection AddCommands(this IServiceCollection services)
    {
        services.AddMediatR(cfg => 
        {
            cfg.RegisterServicesFromAssembly(typeof(CommandsService).Assembly);
        });
        
        return services;
    }
}
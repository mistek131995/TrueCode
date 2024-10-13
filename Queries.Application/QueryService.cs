using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.DependencyInjection;

namespace Queries.Application;

public static class QueryService
{
    public static IServiceCollection AddQueries(this IServiceCollection services, string connectionString)
    {
        services.AddScoped<IDbConnection>(sp => new SqlConnection(connectionString));
        services.AddMediatR(cfg => 
        {
            cfg.RegisterServicesFromAssembly(typeof(QueryService).Assembly);
        });
        services.AddMemoryCache();
        
        return services;
    }
}
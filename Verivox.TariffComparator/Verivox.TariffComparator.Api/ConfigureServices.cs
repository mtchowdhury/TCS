using Verivox.TariffComparator.Api.Middlewares;
using Verivox.TariffComparator.Service.Contracts;

namespace Verivox.TariffComparator.Api;

    public static class ConfigureServices
    {
    public static IServiceCollection AddApiServices(this IServiceCollection services, IConfiguration configuration)
    {
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        _ = services.AddEndpointsApiExplorer();
        _ = services.AddSwaggerGen();
        _ = services.AddSingleton<ExceptionHandlingMiddleware>();
        _ = services.AddHealthChecks();
        return services;
    }
}


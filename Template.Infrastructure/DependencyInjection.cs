using Microsoft.Extensions.DependencyInjection;

namespace Template.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        //services.AddScoped<IAuthService, AuthService>();
        return services;
    }
}

using Sample.Application;
using Sample.Application.Commands;
using Sample.Application.Handlers;
using Sample.Core.Interfaces;

namespace Product.Service.Api.Configurations;
public static class ApplicationServiceConfiguration
{
    public static IServiceCollection AddApplicationServiceConfiguration(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddTransient<ICommandHandler<AddProductCommand, AddProductCommandResponse>, AddProductHandler>();
        services.AddTransient(typeof(ICommandHandlerExecuter<,>), typeof(CommandHandlerExecuter<,>));

        return services;
    }
}

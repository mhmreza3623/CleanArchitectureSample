using Sample.Application;
using Sample.Application.Commands;
using Sample.Application.Handlers;
using Sample.Core.Interfaces;

namespace Ordre.Service.Api.Configurations;
public static class ApplicationServiceConfiguration
{
    public static IServiceCollection AddApplicationServiceConfiguration(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddTransient<ICommandHandler<AddOrderCommand, AddOrderCommandResponse>, AddOrderHandler>();
        services.AddTransient(typeof(ICommandHandlerExecuter<,>), typeof(CommandHandlerExecuter<,>));

        return services;
    }
}

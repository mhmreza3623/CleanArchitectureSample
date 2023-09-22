using RabbitMQ.Client;
using Sample.Core.Shared.RabbitMQ;

namespace Product.Service.Api.Configurations;

public static class RabbitMQConfiguration
{
    public static IServiceCollection AddRabbitMQConfiguration(this IServiceCollection services, IConfiguration configuration)
    {
        //services.Configure<RabbitMQConfigModel>(configuration.GetSection("RabbitMQConfig"));
        //var factory = new ConnectionFactory()
        //{
        //    Uri = new Uri(configuration.GetSection("RabbitMQConfig")["Host"]),
        //};
        //services.AddSingleton(factory);
        //using var connection = factory.CreateConnection();
        //using var channel = connection.CreateModel();
        //channel.QueueDeclare("produt-queue", true, false, false, null);


        return services;
    }
}

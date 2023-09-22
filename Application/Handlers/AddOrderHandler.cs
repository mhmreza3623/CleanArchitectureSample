using Ordre.Service.Api.Controllers;
using Sample.Application.Commands;
using Sample.Core.Interfaces;

namespace Sample.Application.Handlers
{
    public class AddOrderHandler : ICommandHandler<AddOrderCommand, AddOrderCommandResponse>
    {
        static List<Order> Orders = new();
        public async Task<AddOrderCommandResponse> Execute(AddOrderCommand command)
        {
            Orders.Add(command.Order);

            var response = new AddOrderCommandResponse()
            {
                Orders = Orders
            };

            return response;
        }
    }
}

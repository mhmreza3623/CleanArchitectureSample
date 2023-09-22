using Ordre.Service.Api.Controllers;
using Sample.Core.Models;
using Sample.Core.Shared.CommandModels;

namespace Sample.Application.Commands
{
    public class AddOrderCommand : CommandBase
    {
        public Order Order { get; set; }
    }

    public class AddOrderCommandResponse : CommandResponseBase
    {
        public AddOrderCommandResponse()
        {
            if (Orders == null)
            {
                Orders = new List<Order>();
            }
        }

        public List<Order> Orders = new();
    }
}

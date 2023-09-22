
using Sample.Application.Commands;
using Sample.Core.Interfaces;
using Sample.Core.Models;

namespace Sample.Application.Handlers
{
    public class AddProductHandler : ICommandHandler<AddProductCommand, AddProductCommandResponse>
    {
        static List<Product> Products = new();
        public async Task<AddProductCommandResponse> Execute(AddProductCommand command)
        {
            Products.Add(command.Product);

            var response = new AddProductCommandResponse()
            {
                Products = Products
            };



            return response;
        }
    }
}

using Sample.Core.Models;
using Sample.Core.Shared.CommandModels;

namespace Sample.Application.Commands
{
    public class AddProductCommand : CommandBase
    {
        public Product Product { get; set; }
    }

    public class AddProductCommandResponse : CommandResponseBase
    {
        public List<Product> Products = new();
        public AddProductCommandResponse()
        {
            if (Products == null)
            {
                Products = new List<Product>();
            }
        }
    }
}

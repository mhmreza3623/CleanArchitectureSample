using Sample.Core.Models;
using Sample.Core.Shared.Messages;
using System.Text.Json;

namespace Sample.Core.Events
{
    public class AddProductEvent : Event
    {
        public AddProductEvent(Product product)
        {
            this.Product = product;
            this.Content = JsonSerializer.Serialize(product);
        }

        public Product Product { get; set; }
    }
}

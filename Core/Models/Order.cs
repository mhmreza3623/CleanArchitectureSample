using Sample.Core.Models;

namespace Ordre.Service.Api.Controllers
{
    public class Order :Entity
    {
        public string ProductId { get; set; }
        public int Count { get; set; }
    }
}
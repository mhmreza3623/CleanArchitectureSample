namespace Gateway.Service.Api.Controllers
{
    public class CreateOrderRequest
    {
        public string ProductId { get; set; }
        public int Count { get; set; }
    }
}
using Microsoft.AspNetCore.Mvc;
using Sample.Application.Commands;
using Sample.Core.Interfaces;

namespace Ordre.Service.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly ILogger<OrderController> _logger;
        private readonly ICommandHandlerExecuter<AddOrderCommand, AddOrderCommandResponse> _orderExecuter;

        public OrderController(ILogger<OrderController> logger,
            ICommandHandlerExecuter<AddOrderCommand, AddOrderCommandResponse> orderExecuter)
        {
            _logger = logger;
            this._orderExecuter = orderExecuter;
        }

        [HttpPost("createOrder")]
        public async Task<IActionResult> Post([FromBody] OrderRequest request)
        {
            var response = await _orderExecuter.Execute(new AddOrderCommand()
            {
                Order = new Order
                {
                    ProductId = request.ProductId,
                    Count = request.Count
                }
            });

            return Ok(response.Orders);
        }
    }
}
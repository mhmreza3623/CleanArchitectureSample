using Microsoft.AspNetCore.Mvc;
using Sample.Application.Commands;
using Sample.Core.Interfaces;

namespace Product.Service.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly ICommandHandlerExecuter<AddProductCommand, AddProductCommandResponse> _productExecuter;
        static int counter = 0;

        public ProductController(ILogger<ProductController> logger, 
            ICommandHandlerExecuter<AddProductCommand, AddProductCommandResponse> productExecuter)
        {
            _logger = logger;
            this._productExecuter = productExecuter;
        }

        [HttpPost("createproduct")]
        public async Task<IActionResult> Post()
        {
            var response = await _productExecuter.Execute(new AddProductCommand()
            {
                Product = new Sample.Core.Models.Product
                {
                    CreateDate = DateTime.Now,
                    Name = $"Product_{Guid.NewGuid().ToString("N")}",
                    Count = ++counter
                }
            });

            return Ok(response.Products);
        }
    }
}
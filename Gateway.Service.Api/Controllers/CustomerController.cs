using Microsoft.AspNetCore.Mvc;
using Sample.Core.Models;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using static System.Net.Mime.MediaTypeNames;

namespace Gateway.Service.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public CustomerController(IHttpClientFactory httpClientFactory)
        {
            this._httpClientFactory = httpClientFactory;
        }
        [HttpPost("product/createProduct")]
        public async Task<IActionResult> CreateNewProduct()
        {
            try
            {


                using var response = await _httpClientFactory.CreateClient("product_service")
                    .PostAsync("/Product/createproduct", new StringContent(""));
                var responseString = await response.Content.ReadAsStringAsync();

                return Ok(JsonSerializer.Deserialize<List<Product>>(responseString, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                }));
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        [HttpPost("order/createOrder")]
        public async Task<IActionResult> CreateOrder([FromBody] CreateOrderRequest request)
        {
            var requestModel = new StringContent(
                  JsonSerializer.Serialize(new
                  {
                      productId = request.ProductId,
                      count = request.Count
                  }),
                  Encoding.UTF8,
                  Application.Json);

            using var response = await _httpClientFactory.CreateClient("order_service")
                .PostAsync("/order/createOrder", requestModel);

            return Ok(await response.Content.ReadAsStringAsync());
        }
    }
}
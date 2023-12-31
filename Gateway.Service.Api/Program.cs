using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
});

builder.Services.AddHttpClient("product_service", httpclient =>
{
    httpclient.BaseAddress = new Uri("http://host.docker.internal:15887");
});

builder.Services.AddHttpClient("order_service", httpclient =>
{
    httpclient.BaseAddress = new Uri("http://host.docker.internal:51898");
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();

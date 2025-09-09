using AZ_AI_Vision_Caption.Interfaces;
using AZ_AI_Vision_Caption.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddHttpClient<IVisionService, VisionService>(client =>
{
    client.BaseAddress = new Uri(builder.Configuration["AzureVision:Endpoint"]);
});
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

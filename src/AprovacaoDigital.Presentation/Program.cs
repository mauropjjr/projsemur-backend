using AprovacaoDigital.Infrastructure.Persistence.Context;
using AprovacaoDigital.Infrastructure;
using AprovacaoDigital.Application;
using AprovacaoDigital.Presentation.Extensions;
using AprovacaoDigital.Presentation.Middlewares;
using Microsoft.OpenApi.Models;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.ConfigurePersistence(builder.Configuration);
builder.Services.ConfigureApplication();
builder.Services.ConfigureApiBehavior();
builder.Services.ConfigureCorsPolicy();
builder.Services.AddHttpContextAccessor();


builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles;
    options.JsonSerializerOptions.WriteIndented = true;
});
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Aprovação Digital", Version = "v1" });
});

var app = builder.Build();

var serviceScope = app.Services.CreateScope();
var dataContext = serviceScope.ServiceProvider.GetService<DataContext>();
dataContext?.Database.EnsureCreated();


// Configure the HTTP request pipeline.

//app.UseAuthorization();
//app.UseMiddleware<RequestLoggingMiddleware>();
app.UseSwagger();

app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Aprovação Digital");
    c.RoutePrefix = string.Empty; // Define a raiz da aplicação como o Swagger
});
app.UseCors();

app.MapControllers();

app.Run();
public partial class Program { }

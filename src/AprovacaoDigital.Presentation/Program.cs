using AprovacaoDigital.Application;
using AprovacaoDigital.Infrastructure;
using AprovacaoDigital.Infrastructure.Persistence.Context;
using AprovacaoDigital.Presentation.Extensions;
using Keycloak.AuthServices.Authentication;
using Keycloak.AuthServices.Authorization;
using Microsoft.OpenApi.Models;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.ConfigurePersistence(builder.Configuration);
builder.Services.ConfigureApplication();
builder.Services.ConfigureApiBehavior();
builder.Services.ConfigureCorsPolicy();




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
#region Autenticacao
var authenticationOptions = builder
                            .Configuration
                            .GetSection(KeycloakAuthenticationOptions.Section)
                            .Get<KeycloakAuthenticationOptions>();

builder.Services.AddKeycloakAuthentication(authenticationOptions);
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("AnalystPolicy", builder =>
    {
        builder
            .RequireRealmRoles("ANALISTA");
    });
})
    .AddKeycloakAuthorization(builder.Configuration);


builder.Services.AddHttpContextAccessor();




#endregion
#region Swagger
builder.Services.AddSwaggerGen(c =>
{

    var securityScheme = new OpenApiSecurityScheme
    {
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        Scheme = "bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "JWT Authorization header using the Bearer scheme. Example: \"Authorization: Bearer {token}\"",

        Reference = new OpenApiReference
        {
            Type = ReferenceType.SecurityScheme,
            Id = "Bearer"
        }
    };

    c.AddSecurityDefinition("Bearer", securityScheme);

    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            securityScheme,
            new string[] {}
        }
    });
});
#endregion
var app = builder.Build();

var serviceScope = app.Services.CreateScope();
var dataContext = serviceScope.ServiceProvider.GetService<DbprojsemurContext>();
dataContext?.Database.EnsureCreated();




// Configure the HTTP request pipeline.
app.UseAuthentication();
app.UseAuthorization();
//app.UseMiddleware<RequestLoggingMiddleware>();
app.UseSwagger();
//app.UseMiddleware<LogClaimsMiddleware>();

app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Aprovação Digital");
    c.RoutePrefix = string.Empty; // Define a raiz da aplicação como o Swagger
});
app.UseCors();

app.MapControllers();

app.Run();
public partial class Program { }

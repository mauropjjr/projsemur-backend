using System.Security.Claims;

namespace AprovacaoDigital.Presentation.Middlewares;

public partial class LogClaimsMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<LogClaimsMiddleware> _logger;

    public LogClaimsMiddleware(RequestDelegate next, ILogger<LogClaimsMiddleware> logger)
    {
        _next = next;
        _logger = logger;
    }

    public async Task Invoke(HttpContext context)
    {
        if (context.User.Identity is ClaimsIdentity identity)
        {
            var claims = identity.Claims.Select(c => new { c.Type, c.Value }).ToList();
            _logger.LogInformation("User Claims: {@Claims}", claims);
        }

        await _next(context);
    }
}

using AprovacaoDigital.Presentation.Filters;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AprovacaoDigital.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiExceptionFilter]
    public class ApiControllerBase : ControllerBase
    {
        private ISender? _mediator;
        private IHttpContextAccessor? _httpContextAccessor;
        protected IHttpContextAccessor HttpContextAccessor => _httpContextAccessor ??= HttpContext.RequestServices.GetRequiredService<IHttpContextAccessor>();
        protected ISender Mediator => _mediator ??= HttpContext.RequestServices.GetRequiredService<ISender>();
        protected ILogger Logger => HttpContext.RequestServices.GetRequiredService<ILogger>();

    }
}

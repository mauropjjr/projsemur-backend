using AprovacaoDigital.Presentation.Filters;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace AprovacaoDigital.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiExceptionFilter]

  //  [Authorize]
    public class ApiControllerBase : ControllerBase
    {
        private ISender? _mediator;
        private IHttpContextAccessor? _httpContextAccessor;
        protected IHttpContextAccessor HttpContextAccessor => _httpContextAccessor ??= HttpContext.RequestServices.GetRequiredService<IHttpContextAccessor>();
        protected ISender Mediator => _mediator ??= HttpContext.RequestServices.GetRequiredService<ISender>();
        protected ILogger Logger => HttpContext.RequestServices.GetRequiredService<ILogger>();

        protected bool UserHasRole(string role)
        {
            return User.IsInRole(role);
        }
        // Método para logar as roles do usuário
        protected void LogUserRoles()
        {
            var roles = User.Claims.Where(c => c.Type == ClaimTypes.Role).Select(c => c.Value).ToList();
            Logger.LogInformation("User Roles: {Roles}", roles);
        }

        //public ApiControllerBase()
        //{
        //    LogUserRoles();
        //}
    }
}

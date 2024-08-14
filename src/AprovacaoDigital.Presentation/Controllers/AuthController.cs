using AprovacaoDigital.Application.Common.Models;
using AprovacaoDigital.Application.Features.AreaReceptora.GetAll;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System.Collections.Concurrent;

namespace AprovacaoDigital.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class AuthController : ApiControllerBase
    {
   

        [HttpGet]
        public async Task<ActionResult<object>> GetAll([FromQuery] string access_token)
        {

            return Ok(access_token);

        }
    }
}

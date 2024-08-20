using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AprovacaoDigital.Presentation.Controllers
{
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

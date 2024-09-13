
using AprovacaoDigital.Application.Features.Encaminhar;
using Microsoft.AspNetCore.Mvc;

namespace AprovacaoDigital.Presentation.Controllers;


public class EncaminharController :  ApiControllerBase
{

    [HttpPost]
    public async Task<IActionResult> Create(EncaminharRequest request, CancellationToken cancellationToken)
    {
        await Mediator.Send(request, cancellationToken);
        return Ok();
    }
}

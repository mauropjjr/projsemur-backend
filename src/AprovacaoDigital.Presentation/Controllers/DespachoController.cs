
using AprovacaoDigital.Application.Features.Despachar.Update;
using Microsoft.AspNetCore.Mvc;

namespace AprovacaoDigital.Presentation.Controllers;


public class DespachoController :  ApiControllerBase
{

    [HttpPost]
    public async Task<IActionResult> Create(UpdateDespacharRequest request, CancellationToken cancellationToken)
    {
        await Mediator.Send(request, cancellationToken);
        return Ok();
    }
}

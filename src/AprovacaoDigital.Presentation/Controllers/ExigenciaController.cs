using AprovacaoDigital.Application.Common.Models;
using AprovacaoDigital.Application.Features.Exigencia.Create;
using AprovacaoDigital.Application.Features.Exigencia.Get;
using AprovacaoDigital.Application.Features.Exigencia.GetAll;
using Microsoft.AspNetCore.Mvc;

namespace AprovacaoDigital.Presentation.Controllers;

public class ExigenciaController : ApiControllerBase
{

    [HttpGet]
    public async Task<ActionResult<PaginatedList<GetAllResponse>>> GetAll([FromQuery] GetAllRequest request, CancellationToken cancellationToken)
    {
        var response = await Mediator.Send(request, cancellationToken);
        return Ok(response);
    }
    [HttpGet("{id}")]

    public async Task<IActionResult> Get(int id, CancellationToken cancellationToken)
    {
        var response = await Mediator.Send(new GetRequest(id), cancellationToken);
        return Ok(response);
    }
    [HttpPost]
    public async Task<IActionResult> Create(CreateExigenciaRequest request,
        CancellationToken cancellationToken)
    {
        var response = await Mediator.Send(request, cancellationToken);
        return Ok(response);
    }
}

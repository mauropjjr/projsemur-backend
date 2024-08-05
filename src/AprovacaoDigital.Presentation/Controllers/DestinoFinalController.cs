using AprovacaoDigital.Application.Common.Models;
using AprovacaoDigital.Application.Features.DestinoFinal.Create;
using AprovacaoDigital.Application.Features.DestinoFinal.Delete;
using AprovacaoDigital.Application.Features.DestinoFinal.Get;
using AprovacaoDigital.Application.Features.DestinoFinal.GetAll;
using AprovacaoDigital.Application.Features.DestinoFinal.Update;
using Microsoft.AspNetCore.Mvc;

namespace AprovacaoDigital.Presentation.Controllers;

public class DestinoFinalController : ApiControllerBase
{

    [HttpGet]
    public async Task<ActionResult<PaginatedList<GetAllDestinoFinalResponse>>> GetAll([FromQuery] GetAllRequest request, CancellationToken cancellationToken)
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
    public async Task<IActionResult> Create(CreateDestinoFinalRequest request,
        CancellationToken cancellationToken)
    {
        var response = await Mediator.Send(request, cancellationToken);
        return Ok(response);
    }
    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, UpdateDestinoFinalRequest request)
    {
        if (request.Id != id)
        {
            return BadRequest(new { Message = "O ID fornecido na URL não corresponde ao ID no corpo da solicitação." });
        }
        var response = await Mediator.Send(request);
        return Ok(response);

    }
    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {

        await Mediator.Send(new DeleteRequest(id));
        return Ok();

    }
}

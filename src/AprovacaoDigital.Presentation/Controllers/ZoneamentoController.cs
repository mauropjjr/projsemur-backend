using AprovacaoDigital.Application.Common.Models;
using AprovacaoDigital.Application.Features.Zoneamento.Create;
using AprovacaoDigital.Application.Features.Zoneamento.Delete;
using AprovacaoDigital.Application.Features.Zoneamento.Get;
using AprovacaoDigital.Application.Features.Zoneamento.GetAll;
using AprovacaoDigital.Application.Features.Zoneamento.Update;
using Microsoft.AspNetCore.Mvc;

namespace AprovacaoDigital.Presentation.Controllers;

public class ZoneamentoController : ApiControllerBase
{

    [HttpGet]
    public async Task<ActionResult<PaginatedList<GetAllZoneamentoResponse>>> GetAll([FromQuery] GetAllRequest request, CancellationToken cancellationToken)
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
    public async Task<IActionResult> Create(CreateZoneamentoRequest request,
        CancellationToken cancellationToken)
    {
        var response = await Mediator.Send(request, cancellationToken);
        return Ok(response);
    }
    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, UpdateZoneamentoRequest request)
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

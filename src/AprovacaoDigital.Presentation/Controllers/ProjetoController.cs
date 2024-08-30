using AprovacaoDigital.Application.Common.Models;
using AprovacaoDigital.Application.Features.AlterarStatusAlvara;
using AprovacaoDigital.Application.Features.AreaReceptora.Update;
using AprovacaoDigital.Application.Features.Projeto.Create;
using AprovacaoDigital.Application.Features.Projeto.Delete;
using AprovacaoDigital.Application.Features.Projeto.Get;
using AprovacaoDigital.Application.Features.Projeto.GetAll;
using AprovacaoDigital.Application.Features.Projeto.Update;
using Microsoft.AspNetCore.Mvc;

namespace AprovacaoDigital.Presentation.Controllers;

public class ProjetoController : ApiControllerBase
{

    [HttpGet]
    public async Task<ActionResult<PaginatedList<GetAllProjetoResponse>>> GetAll([FromQuery] GetAllRequest request, CancellationToken cancellationToken)
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
    public async Task<IActionResult> Create(CreateProjetoRequest request,
        CancellationToken cancellationToken)
    {
        var response = await Mediator.Send(request, cancellationToken);
        return Ok(response);
    }
    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, UpdateProjetoRequest request)
    {
        if (request.Id != id)
        {
            return BadRequest(new { Message = "O ID fornecido na URL não corresponde ao ID no corpo da solicitação." });
        }
        var response = await Mediator.Send(request);
        return Ok(response);

    }
    [HttpPut]
    //[ActionName("AlterarStatusAlvara")]
    public async Task<IActionResult> AlterarStatusAlvara(AlterarStatusAlvaraRequest request)
    {
 
        await Mediator.Send(request);
        return Ok();

    }
    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {

        await Mediator.Send(new DeleteRequest(id));
        return Ok();

    }
}

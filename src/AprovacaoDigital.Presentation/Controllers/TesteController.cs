
using AprovacaoDigital.Application.Common.Models;
using AprovacaoDigital.Application.Features.Teste.Create;
using AprovacaoDigital.Application.Features.Teste.GetAll;
using Microsoft.AspNetCore.Mvc;

namespace AprovacaoDigital.Presentation.Controllers;

public class TesteController :  ApiControllerBase
{
    //[HttpGet]
    //public async Task<ActionResult<PaginatedList<GetAllResponse>>> GetAll([FromQuery] GetAllRequest request, CancellationToken cancellationToken)
    //{
    //    var response = await Mediator.Send(request, cancellationToken);
    //    return Ok(response);
    //}
    //[HttpGet("{id}")]
    //public async Task<ActionResult<CategoriaComiteResponse>> GetId(int id, CancellationToken cancellationToken)
    //{

    //    var response = await Mediator.Send(new GetCategoriaComiteRequest() { Id = id }, cancellationToken);
    //    return Ok(response);
    //}

    //[HttpPost]
    //public async Task<ActionResult<int>> Create(CreateTesteRequest request,
    //    CancellationToken cancellationToken)
    //{
    //    var response = await Mediator.Send(request, cancellationToken);
    //    return Ok(response);
    //}
    //[HttpPut("{id}")]
    //[ProducesResponseType(StatusCodes.Status204NoContent)]
    //[ProducesResponseType(StatusCodes.Status400BadRequest)]
    //[ProducesDefaultResponseType]
    //public async Task<ActionResult<CategoriaComiteResponse>> Update(int id, CategoriaComiteRequest request)
    //{
    //    if (request.Id != id)
    //    {
    //        return BadRequest();
    //    }
    //    request.UsuarioId = Convert.ToInt32(HttpContextAccessor.HttpContext.User.FindFirst("userId")?.Value);
    //    var response = await Mediator.Send(request);
    //    return Ok(response);

    //}
    //[HttpDelete("{id}")]
    //[ProducesResponseType(StatusCodes.Status204NoContent)]
    //[ProducesResponseType(StatusCodes.Status400BadRequest)]
    //[ProducesDefaultResponseType]
    //public async Task<ActionResult<CategoriaComiteResponse>> Delete(int id)
    //{
    //    var request = new DeleteCategoriaComiteRequest { Id = id };

    //    await Mediator.Send(request);
    //    return Ok();

    //}

}


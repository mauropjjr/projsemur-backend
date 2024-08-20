using AprovacaoDigital.Application.Common.Models;
using AprovacaoDigital.Application.Features.Assunto.Create;
using AprovacaoDigital.Application.Features.Assunto.Delete;
using AprovacaoDigital.Application.Features.Assunto.Get;
using AprovacaoDigital.Application.Features.Assunto.GetAll;
using AprovacaoDigital.Application.Features.Assunto.Update;
using Microsoft.AspNetCore.Mvc;

namespace AprovacaoDigital.Presentation.Controllers;
public class AssuntoController : ApiControllerBase
{
    /*
     * "0 - Configuracao - nao aparece em lugar nenuhm\r\n=================== TRIAGEM ================\r\n1 - Não analisado - Triagem(Primeira remessa enviada)	\r\n2 -  Ja analisei e retornei para o Profissional - Triagem (A remessa é analisada e retornada pela triagem.)\r\n3 - Voltou do Profissional corrigido - Triagem (A remessa é respondida pelo profissional (criação de uma nova remessa))\r\n==================== ANALISTA =================\r\n4 - Não analisado - Analista (Primeira remessa enviada)\r\n5 -  Ja analisei e retornei para o Profissional - Analista (A remessa é analisada e retornada pelo analista.)\r\n6 - Voltou do Profissional corrigido - Analista (A remessa é respondida pelo profissional (criação de uma nova remessa))\r\n=================== ADMINISTRADOR ===============\r\n7 - De acordo (Quando o analista gera a remessa final e envia arquivos para análise. Gera assinatura digital também. Profissional não pode ver a Remessa Final.)\r\n===================== DIRETOR ==================\r\n8 - Encaminhado ao Diretor (Quando o administrador confere os dados da remessa final e clica no botao encaminhar para diretor)\r\n9 - Aprovado (Quando o projeto foi efetivamente concluído e aceito. Profissional só visualizará a Remessa Final.)\r\n10 - Negado (Diretor retorna o projeto ao analista para corrigir os arquivos da Remessa Final
     * */

    [HttpGet]
    public async Task<ActionResult<PaginatedList<GetAllAssuntoResponse>>> GetAll([FromQuery] GetAllAssuntoRequest request, CancellationToken cancellationToken)
    {
        var response = await Mediator.Send(request, cancellationToken);
        return Ok(response);
    }
    [HttpGet("{id}")]

    public async Task<IActionResult> Get(int id, CancellationToken cancellationToken)
    {
        var response = await Mediator.Send(new GetAssuntoRequest(id), cancellationToken);
        return Ok(response);
    }
    [HttpPost]
    public async Task<IActionResult> Create(CreateAssuntoRequest request,
        CancellationToken cancellationToken)
    {
        var response = await Mediator.Send(request, cancellationToken);
        return Ok(response);
    }
    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, UpdateAssuntoRequest request)
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
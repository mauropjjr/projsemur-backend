using AprovacaoDigital.Application.Interfaces.Services;
using AprovacaoDigital.Application.Repositories;
using AprovacaoDigital.Common.Exceptions;
using AutoMapper;
using MediatR;


namespace AprovacaoDigital.Application.Features.Encaminhar;
/* Teste
 * 
{
   "AnalistaId":341,
   "ProjetoId":77183,
   "Enc":3,
   "Classificacao":"NOR",
   "Especial":1,
   "CodificacaoId":1
}
 * 
 * */
public sealed record EncaminharRequest : IRequest
{
    public int ProjetoId { get; set; }
    public int AnalistaId { get; set; }
    public int? Enc { get; set; }
    public int? Enc2 { get; set; }
    public string? Classificacao { get; set; }
    public int? Version { get; set; }
    public int? Especial { get; set; }
    public int CodificacaoId{ get; set; }


}

public sealed class EncaminharHandler : IRequestHandler<EncaminharRequest>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IProjetoRepository _repository;
    private readonly IMapper _mapper;
    private readonly IHistoricoServices _historicoServices;
    public EncaminharHandler(IUnitOfWork unitOfWork, IProjetoRepository repository, IMapper mapper, IHistoricoServices historicoServices)
    {
        _unitOfWork = unitOfWork;
        _repository = repository;
        _mapper = mapper;
        _historicoServices = historicoServices;
    }
    public async Task Handle(EncaminharRequest request, CancellationToken cancellationToken)
    {
        
        var objeto = await _repository.FindId(x => x.Projetoid == request.ProjetoId, "AtividadeNavigation,Historicos,Remessas.Documentos.ArquivoNavigation,Remessas.Remessaexigencia.ExigenciaNavigation", cancellationToken);
        
        if (objeto == null)
        {
            throw new NotFoundException(nameof(objeto), request.ProjetoId);
        }

        await Update(objeto, request, cancellationToken);
       
        await _unitOfWork.Save(cancellationToken);
    }

    private async Task Update(Domain.Entities.Projeto obj, EncaminharRequest encaminhar, CancellationToken cancellationToken)
    {

        int GrupoId = 31;
        if ((new List<int> { 32, 97, 14 }).Any(a => a == GrupoId) && obj.Status == 14)
        {
            decimal areaexcedente = obj.Areaexcedente ?? 0;
            if (areaexcedente > 0)
            {
                decimal valorcontrapartida = (decimal)(obj.Valormetroquadrado * areaexcedente);
                string valorcontrapartidaextenso = CurrencyConverter.ToExtenso(valorcontrapartida);
                string valormetroquadradoextenso = CurrencyConverter.ToExtenso((decimal)obj.Valormetroquadrado);

                obj.Areaexcedente = areaexcedente;
                obj.Valorcontrapartida = valorcontrapartida;
                obj.Valorcontrapartidaextenso = valorcontrapartidaextenso;
                obj.Valormetroquadradoextenso = valormetroquadradoextenso;
                obj.Datalaudoavaliacao = DateOnly.FromDateTime(DateTime.Now);
            }
        }
        else
        {
            int tptram = 4;
            // Lógica de encaminhamento e geração de trâmites
            if (encaminhar.Enc != null && encaminhar.Enc == 3 && encaminhar.Especial != null && encaminhar.Especial == 1)
            {
                encaminhar.Enc = 1;
            }

            if (encaminhar.Enc != null &&  encaminhar.Enc == 3 && encaminhar.Enc2 == null)
            {
                tptram = 19;
            }

            if ((encaminhar.Enc != null && encaminhar.Enc == 3) && (encaminhar.Enc2 != null && encaminhar.Enc2 == 2))
            {
                if (obj.Status == 17)
                {
                    tptram = 19;
                }
            }

            if ((encaminhar.Enc != null && encaminhar.Enc == 1) || (encaminhar.Enc2 != null && encaminhar.Enc2 == 2) || (encaminhar.Enc != null && encaminhar.Enc == 3))
            {
                // Gera um tramite toda vez que o supervisor encaminhar projeto a um analista
                obj.Exportado = null;
                obj.Dataexportado = null;

                string s;
                if ((encaminhar.Enc2 != null && encaminhar.Enc2 == 2) && (obj.Status == 1 || obj.Status == 2 || obj.Status == 3))
                {
                    // ...
                }
                else if (obj.Status == 9)
                {
                    await _historicoServices.GerarTramiteProcesso(false, obj, tptram, cancellationToken);
                }
                else
                {
                    await _historicoServices.GerarTramiteProcesso(true, obj, tptram, cancellationToken);
                }

                if ((encaminhar.Enc != null && encaminhar.Enc == 1) && (encaminhar.Enc2 == null))
                {
                    obj.Dataencaminhamento = DateTime.Now;
                }
            }

            // Avaliacao
            if (GrupoId != null && obj.Status == 13 && (GrupoId == 32 || GrupoId == 214) && obj.Valormetroquadrado != null)
            {
                obj.Datalaudoavaliacao = DateOnly.FromDateTime(DateTime.Now); 
                obj.Status = 14;
            }

            // Avaliação
            //if (GrupoId != null && obj.Status == 13 && GrupoId != null && GrupoId == 97)
            //{
            //    // Colocar arqui para qndo o avaliador salvar, talvez o grupoid consiga alguma copisa
            //    Usuario usuaval = _projetoRepository.GetUsuarioById(GrupoId);
            //    obj.Usuaval = usuaval.Nome;
            //}

            // Endereço do requerente (profissional logado)
            if (obj.Rua == null)
            {
                string rua = obj.ProfissionalNavigation.Tipprf + " " + obj.ProfissionalNavigation.Nlcprf;
                obj.Rua = rua;
                obj.Numero = obj.ProfissionalNavigation.Numprf;
            }

          
        }
        _repository.Update(obj);


    }

}



public static class CurrencyConverter
{
    private static readonly string[] Unidades = { "", "um", "dois", "três", "quatro", "cinco", "seis", "sete", "oito", "nove", "dez", "onze", "doze", "treze", "quatorze", "quinze", "dezesseis", "dezessete", "dezoito", "dezenove" };
    private static readonly string[] Dezenas = { "", "dez", "vinte", "trinta", "quarenta", "cinquenta", "sessenta", "setenta", "oitenta", "noventa" };
    private static readonly string[] Centenas = { "", "cento", "duzentos", "trezentos", "quatrocentos", "quinhentos", "seiscentos", "setecentos", "oitocentos", "novecentos" };

    public static string ToExtenso(decimal valor)
    {
        if (valor == 0)
        {
            return "zero reais";
        }

        string resultado = "";
        int inteiro = (int)valor;
        int decimalParte = (int)Math.Round((valor - inteiro) * 100);

        // Convertendo a parte inteira
        resultado += ConverteInteiro(inteiro) + " real";
        if (inteiro > 1)
        {
            resultado += "s";
        }

        // Convertendo a parte decimal
        if (decimalParte > 0)
        {
            resultado += " e " + ConverteInteiro(decimalParte) + " centavo";
            if (decimalParte > 1)
            {
                resultado += "s";
            }
        }

        return resultado;
    }

    private static string ConverteInteiro(int numero)
    {
        if (numero == 0)
        {
            return "";
        }

        if (numero < 20)
        {
            return Unidades[numero];
        }

        if (numero < 100)
        {
            return Dezenas[numero / 10] + (numero % 10 != 0 ? " e " + Unidades[numero % 10] : "");
        }

        if (numero == 100)
        {
            return "cem";
        }

        if (numero < 1000)
        {
            return Centenas[numero / 100] + (numero % 100 != 0 ? " e " + ConverteInteiro(numero % 100) : "");
        }

        if (numero == 1000)
        {
            return "mil";
        }

        if (numero < 1000000)
        {
            return ConverteInteiro(numero / 1000) + " mil" + (numero % 1000 != 0 ? " e " + ConverteInteiro(numero % 1000) : "");
        }

        if (numero == 1000000)
        {
            return "um milhão";
        }

        if (numero < 1000000000)
        {
            return ConverteInteiro(numero / 1000000) + " milhões" + (numero % 1000000 != 0 ? " e " + ConverteInteiro(numero % 1000000) : "");
        }

        if (numero == 1000000000)
        {
            return "um bilhão";
        }

        return ConverteInteiro(numero / 1000000000) + " bilhões" + (numero % 1000000000 != 0 ? " e " + ConverteInteiro(numero % 1000000000) : "");
    }
}
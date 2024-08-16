using AutoMapper;

namespace AprovacaoDigital.Application.Features.Codificacao.Create;

public sealed class CreateCodificacaoMapper : Profile
{
    public CreateCodificacaoMapper()
    {
        CreateMap<CreateCodificacaoRequest, Domain.Entities.Codificacao>();
    }

}

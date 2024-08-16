using AutoMapper;

namespace AprovacaoDigital.Application.Features.Codificacao.Get;

public sealed class GetCodificacaoMapper : Profile
{
    public GetCodificacaoMapper()
    {
        CreateMap<Domain.Entities.Codificacao, GetResponse>();

    }
}


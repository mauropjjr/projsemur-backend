using AutoMapper;

namespace AprovacaoDigital.Application.Features.Codificacao.GetAll;

public sealed class GetAllCodificacaoMapper : Profile
{
    public GetAllCodificacaoMapper()
    {
        CreateMap<Domain.Entities.Codificacao, GetAllCodificacaoResponse>();

    }
}


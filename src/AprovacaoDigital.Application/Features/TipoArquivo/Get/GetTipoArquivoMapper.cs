using AutoMapper;

namespace AprovacaoDigital.Application.Features.TipoArquivo.Get;

public sealed class GetTipoArquivoMapper : Profile
{
    public GetTipoArquivoMapper()
    {
        CreateMap<Domain.Entities.TipoArquivoAgenda, GetResponse>();

    }
}


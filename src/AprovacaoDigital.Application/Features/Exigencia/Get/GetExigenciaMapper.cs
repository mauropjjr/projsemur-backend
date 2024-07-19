using AutoMapper;

namespace AprovacaoDigital.Application.Features.Exigencia.Get;

public sealed class GetExigenciaMapper : Profile
{
    public GetExigenciaMapper()
    {
        CreateMap<Domain.Entities.Exigencia, GetResponse>();

    }
}


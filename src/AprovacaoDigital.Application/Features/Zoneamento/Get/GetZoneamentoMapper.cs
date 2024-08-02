using AutoMapper;

namespace AprovacaoDigital.Application.Features.Zoneamento.Get;

public sealed class GetZoneamentoMapper : Profile
{
    public GetZoneamentoMapper()
    {
        CreateMap<Domain.Entities.Zoneamento, GetResponse>();

    }
}


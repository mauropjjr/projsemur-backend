using AutoMapper;

namespace AprovacaoDigital.Application.Features.Zoneamento.GetAll;

public sealed class GetAllZoneamentoMapper : Profile
{
    public GetAllZoneamentoMapper()
    {
        CreateMap<Domain.Entities.Zoneamento, GetAllZoneamentoResponse>();

    }
}


using AutoMapper;

namespace AprovacaoDigital.Application.Features.Zoneamento.Create;

public sealed class CreateZoneamentoMapper : Profile
{
    public CreateZoneamentoMapper()
    {
        CreateMap<CreateZoneamentoRequest, Domain.Entities.Zoneamento>();
    }

}

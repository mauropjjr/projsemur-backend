using AutoMapper;

namespace AprovacaoDigital.Application.Features.Zoneamento.Update;

public sealed class UpdateZoneamentoMapper : Profile
{
    public UpdateZoneamentoMapper()
    {
        CreateMap<UpdateZoneamentoRequest, Domain.Entities.Zoneamento>()
            .ForMember(dest => dest.Zoneamentoid, opt => opt.MapFrom(src => src.Id));
    }

}

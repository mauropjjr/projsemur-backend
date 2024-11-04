using AutoMapper;

namespace AprovacaoDigital.Application.Features.Analista.Update;

public sealed class UpdateAnalistaMapper : Profile
{
    public UpdateAnalistaMapper()
    {
        CreateMap<UpdateAnalistaRequest, Domain.Entities.Analistum>()
            .ForMember(dest => dest.Analistaid, opt => opt.MapFrom(src => src.Id));
    }

}

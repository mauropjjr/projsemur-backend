using AutoMapper;

namespace AprovacaoDigital.Application.Features.DestinoFinal.Update;

public sealed class UpdateDestinoFinalMapper : Profile
{
    public UpdateDestinoFinalMapper()
    {
        CreateMap<UpdateDestinoFinalRequest, Domain.Entities.DestinoFinal>()
            .ForMember(dest => dest.Destinofinalid, opt => opt.MapFrom(src => src.Id));
    }

}

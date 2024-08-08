using AutoMapper;

namespace AprovacaoDigital.Application.Features.Exigencia.Update;

public sealed class UpdateExigenciaMapper : Profile
{
    public UpdateExigenciaMapper()
    {
        CreateMap<UpdateExigenciaRequest, Domain.Entities.Exigencia>()
            .ForMember(dest => dest.Exigenciaid, opt => opt.MapFrom(src => src.Id));
    }

}

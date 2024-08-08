using AutoMapper;

namespace AprovacaoDigital.Application.Features.AreaReceptora.Update;

public sealed class UpdateAreaReceptoraMapper : Profile
{
    public UpdateAreaReceptoraMapper()
    {
        CreateMap<UpdateAreaReceptoraRequest, Domain.Entities.AreaReceptora>()
            .ForMember(dest => dest.Areareceptoraid, opt => opt.MapFrom(src => src.Id));
    }

}

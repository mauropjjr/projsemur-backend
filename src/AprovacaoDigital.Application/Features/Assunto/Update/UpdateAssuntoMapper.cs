using AutoMapper;

namespace AprovacaoDigital.Application.Features.Assunto.Update;

public sealed class UpdateAssuntoMapper : Profile
{
    public UpdateAssuntoMapper()
    {
        CreateMap<UpdateAssuntoRequest, Domain.Entities.Assunto1>()
            .ForMember(dest => dest.Assuntoid, opt => opt.MapFrom(src => src.Id));
    }

}


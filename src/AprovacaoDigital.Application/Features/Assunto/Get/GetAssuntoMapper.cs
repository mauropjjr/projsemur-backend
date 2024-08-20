using AutoMapper;

namespace AprovacaoDigital.Application.Features.Assunto.Get;

public sealed class GetAssuntoMapper : Profile
{
    public GetAssuntoMapper()
    {
        CreateMap<Domain.Entities.Assunto1, GetAssuntoResponse>().ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Assuntoid)); ;

    }
}


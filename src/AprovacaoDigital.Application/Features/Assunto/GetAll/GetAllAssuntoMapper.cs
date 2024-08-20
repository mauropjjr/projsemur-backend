using AutoMapper;

namespace AprovacaoDigital.Application.Features.Assunto.GetAll;

public sealed class GetAllAssuntoMapper : Profile
{
    public GetAllAssuntoMapper()
    {
        CreateMap<Domain.Entities.Assunto1, GetAllAssuntoResponse>().ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Assuntoid)); ;

    }
}


using AprovacaoDigital.Domain.Entities;
using AutoMapper;

namespace AprovacaoDigital.Application.Features.Exigencia.GetAll;

public sealed class GetAllExigenciaMapper : Profile
{
    public GetAllExigenciaMapper()
    {
        CreateMap<Domain.Entities.Exigencia, GetAllResponse>().ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Exigenciaid)); ;

    }
}


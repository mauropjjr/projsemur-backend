using AutoMapper;

namespace AprovacaoDigital.Application.Features.Analista.GetAll;

public sealed class GetAllAnalistaMapper : Profile
{
    public GetAllAnalistaMapper()
    {
        CreateMap<Domain.Entities.Analistum, GetAllAnalistaResponse>().ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Analistaid)); 

    }
}


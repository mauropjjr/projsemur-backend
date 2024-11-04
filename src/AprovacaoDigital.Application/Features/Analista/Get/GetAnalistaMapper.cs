using AprovacaoDigital.Application.Common.DTOs;
using AprovacaoDigital.Application.Features.Projeto.Get;
using AutoMapper;

namespace AprovacaoDigital.Application.Features.Analista.Get;

public sealed class GetAnalistaMapper : Profile
{
    public GetAnalistaMapper()
    {
        CreateMap<Domain.Entities.Analistum, GetResponse>().ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Analistaid));
        CreateMap<Domain.Entities.Projeto, GetProjetoResponse>().ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Projetoid));
        CreateMap<Domain.Entities.Remessa, GetRemessaRequest>().ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Remessaid));

    }
}


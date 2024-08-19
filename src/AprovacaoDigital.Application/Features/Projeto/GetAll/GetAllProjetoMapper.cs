using AprovacaoDigital.Application.Common.DTOs;
using AutoMapper;

namespace AprovacaoDigital.Application.Features.Projeto.GetAll;

public sealed class GetAllProjetoMapper : Profile
{
    public GetAllProjetoMapper()
    {
        CreateMap<Domain.Entities.Projeto, GetAllProjetoResponse>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Projetoid))
            .ForMember(dest => dest.DataUltimoTramite,  opt => opt.MapFrom(src => src.Dataulttram));
        CreateMap<Domain.Entities.Prfage, GetPrfageRequest>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Codprf))
            .ForMember(dest => dest.Nome, opt => opt.MapFrom(src => src.Nomprf));
        CreateMap<Domain.Entities.Analistum, GetAnalistaRequest>().ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Analistaid));
        CreateMap<Domain.Entities.Assunto1, GetAssuntoRequest>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Assuntoid));


    }
}


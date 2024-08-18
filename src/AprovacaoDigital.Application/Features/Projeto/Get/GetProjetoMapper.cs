using AprovacaoDigital.Application.Common.DTOs;
using AutoMapper;

namespace AprovacaoDigital.Application.Features.Projeto.Get;

public sealed class GetProjetoMapper : Profile
{
    public GetProjetoMapper()
    {
        CreateMap<Domain.Entities.Projeto, GetProjetoResponse>().ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Projetoid));
        CreateMap<Domain.Entities.Atividade, Atividade.Get.GetRequest>().ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Atividadeid));
        CreateMap<Domain.Entities.Analistum, GetAnalistaRequest>().ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Analistaid));
        CreateMap<Domain.Entities.Assunto, GetAssuntoRequest>().ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Assuntoid));
        CreateMap<Domain.Entities.Codificacao, Codificacao.Get.GetRequest>().ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Codificacaoid));
        CreateMap<Domain.Entities.Natureza, GetNaturezaRequest>().ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Naturezaid));
        CreateMap<Domain.Entities.Prfage, GetPrfageRequest>().ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Codprf));
        CreateMap<Domain.Entities.Regiao, GetRegiaoRequest>().ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Regiaoid));
        CreateMap<Domain.Entities.Zoneamento, Zoneamento.Get.GetRequest>().ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Zoneamentoid));
 
    }
}


using AutoMapper;

namespace AprovacaoDigital.Application.Features.Codificacao.Update;

public sealed class UpdateCodificacaoMapper : Profile
{
    public UpdateCodificacaoMapper()
    {
        CreateMap<UpdateCodificacaoRequest, Domain.Entities.Codificacao>()
            .ForMember(dest => dest.Codificacaoid, opt => opt.MapFrom(src => src.Id));
    }

}

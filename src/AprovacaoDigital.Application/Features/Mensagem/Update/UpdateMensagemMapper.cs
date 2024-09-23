using AutoMapper;

namespace AprovacaoDigital.Application.Features.Mensagem.Update;

public sealed class UpdateMensagemMapper : Profile
{
    public UpdateMensagemMapper()
    {
        CreateMap<UpdateMensagemRequest, Domain.Entities.Mensagem>()
            .ForMember(dest => dest.Mensagemid, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.Grupo, opt => opt.MapFrom(src => src.Grupo));
    }

}


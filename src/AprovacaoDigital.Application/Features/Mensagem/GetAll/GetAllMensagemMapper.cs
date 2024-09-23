using AutoMapper;

namespace AprovacaoDigital.Application.Features.Mensagem.GetAll;

public sealed class GetAllMensagemMapper : Profile
{
    public GetAllMensagemMapper()
    {
        CreateMap<Domain.Entities.Mensagem, GetAllMensagemResponse>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Mensagemid))
            .ForMember(dest => dest.Grupo, opt => opt.MapFrom(src => src.Grupo));

    }
}


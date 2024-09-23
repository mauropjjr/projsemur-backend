using AprovacaoDigital.Application.Features.Mensagem.GetAll;
using AutoMapper;

namespace AprovacaoDigital.Application.Features.Mensagem.Get;

public sealed class GetMensagemMapper : Profile
{
    public GetMensagemMapper()
    {
        CreateMap<Domain.Entities.Mensagem, GetMensagemResponse>()
          .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Mensagemid))
          .ForMember(dest => dest.Grupo, opt => opt.MapFrom(src => src.Grupo));

    }
}


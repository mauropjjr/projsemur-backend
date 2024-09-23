using AutoMapper;

namespace AprovacaoDigital.Application.Features.Mensagem.Create;

public sealed class CreateMensagemMapper : Profile
{
    public CreateMensagemMapper()
    {
        CreateMap<CreateMensagemRequest, Domain.Entities.Mensagem>()
            .ForMember(dest => dest.Projeto, opt => opt.MapFrom(src => src.ProjetoId))
            .ForMember(dest => dest.Grupo, opt => opt.MapFrom(src => src.GrupoId)); ;
    }

}

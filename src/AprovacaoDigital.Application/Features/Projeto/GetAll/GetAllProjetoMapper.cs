using AutoMapper;

namespace AprovacaoDigital.Application.Features.Projeto.GetAll;

public sealed class GetAllProjetoMapper : Profile
{
    public GetAllProjetoMapper()
    {
        CreateMap<Domain.Entities.Projeto, GetAllProjetoResponse>().ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Projetoid)); ;

    }
}


using AutoMapper;

namespace AprovacaoDigital.Application.Features.Projeto.Update;

public sealed class UpdateProjetoMapper : Profile
{
    public UpdateProjetoMapper()
    {
        CreateMap<UpdateProjetoRequest, Domain.Entities.Projeto>()
            .ForMember(dest => dest.Projetoid, opt => opt.MapFrom(src => src.Id));
    }

}

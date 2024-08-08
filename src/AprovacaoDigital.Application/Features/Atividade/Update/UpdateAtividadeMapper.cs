using AutoMapper;

namespace AprovacaoDigital.Application.Features.Atividade.Update;

public sealed class UpdateAtividadeMapper : Profile
{
    public UpdateAtividadeMapper()
    {
        CreateMap<UpdateAtividadeRequest, Domain.Entities.Atividade>()
            .ForMember(dest => dest.Atividadeid, opt => opt.MapFrom(src => src.Id));
    }

}

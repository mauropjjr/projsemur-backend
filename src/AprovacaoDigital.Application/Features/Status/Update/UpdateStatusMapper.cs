using AutoMapper;

namespace AprovacaoDigital.Application.Features.Status.Update;

public sealed class UpdateStatusMapper : Profile
{
    public UpdateStatusMapper()
    {
        CreateMap<UpdateStatusRequest, Domain.Entities.Status1>()
            .ForMember(dest => dest.Statusid, opt => opt.MapFrom(src => src.Id));
    }

}


using AutoMapper;

namespace AprovacaoDigital.Application.Features.Status.GetAll;

public sealed class GetAllStatusMapper : Profile
{
    public GetAllStatusMapper()
    {
        CreateMap<Domain.Entities.Status1, GetAllStatusResponse>().ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Statusid)); ;

    }
}


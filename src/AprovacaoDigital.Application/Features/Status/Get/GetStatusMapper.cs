using AutoMapper;

namespace AprovacaoDigital.Application.Features.Status.Get;

public sealed class GetStatusMapper : Profile
{
    public GetStatusMapper()
    {
        CreateMap<Domain.Entities.Status1, GetStatusResponse>().ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Statusid)); ;

    }
}


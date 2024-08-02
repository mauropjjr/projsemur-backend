using AutoMapper;

namespace AprovacaoDigital.Application.Features.AreaReceptora.Get;

public sealed class GetAreaReceptoraMapper : Profile
{
    public GetAreaReceptoraMapper()
    {
        CreateMap<Domain.Entities.AreaReceptora, GetResponse>();

    }
}


using AutoMapper;

namespace AprovacaoDigital.Application.Features.AreaReceptora.GetAll;

public sealed class GetAllAreaReceptoraMapper : Profile
{
    public GetAllAreaReceptoraMapper()
    {
        CreateMap<Domain.Entities.AreaReceptora, GetAllAreaReceptoraResponse>();

    }
}


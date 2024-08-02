using AutoMapper;

namespace AprovacaoDigital.Application.Features.AreaReceptora.Create;

public sealed class CreateAreaReceptoraMapper : Profile
{
    public CreateAreaReceptoraMapper()
    {
        CreateMap<CreateAreaReceptoraRequest, Domain.Entities.AreaReceptora>();
    }

}

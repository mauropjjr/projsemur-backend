using AutoMapper;

namespace AprovacaoDigital.Application.Features.Analista.Create;

public sealed class CreateAnalistaMapper : Profile
{
    public CreateAnalistaMapper()
    {
        CreateMap<CreateAnalistaRequest, Domain.Entities.Analistum>();
    }

}

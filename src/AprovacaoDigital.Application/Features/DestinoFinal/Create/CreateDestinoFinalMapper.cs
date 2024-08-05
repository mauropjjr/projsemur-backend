using AutoMapper;

namespace AprovacaoDigital.Application.Features.DestinoFinal.Create;

public sealed class CreateDestinoFinalMapper : Profile
{
    public CreateDestinoFinalMapper()
    {
        CreateMap<CreateDestinoFinalRequest, Domain.Entities.DestinoFinal>();
    }

}

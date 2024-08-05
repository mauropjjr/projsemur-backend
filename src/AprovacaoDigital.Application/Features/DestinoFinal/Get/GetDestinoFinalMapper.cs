using AutoMapper;

namespace AprovacaoDigital.Application.Features.DestinoFinal.Get;

public sealed class GetDestinoFinalMapper : Profile
{
    public GetDestinoFinalMapper()
    {
        CreateMap<Domain.Entities.DestinoFinal, GetResponse>();

    }
}


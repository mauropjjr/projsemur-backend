using AprovacaoDigital.Domain.Entities;
using AutoMapper;

namespace AprovacaoDigital.Application.Features.DestinoFinal.GetAll;

public sealed class GetAllDestinoFinalMapper : Profile
{
    public GetAllDestinoFinalMapper()
    {
        CreateMap<Domain.Entities.DestinoFinal, GetAllDestinoFinalResponse>();

    }
}


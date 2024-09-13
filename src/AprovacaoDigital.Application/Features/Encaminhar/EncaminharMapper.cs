using AutoMapper;

namespace AprovacaoDigital.Application.Features.Encaminhar;

public sealed class EncaminharMapper : Profile
{
    public EncaminharMapper()
    {
        CreateMap<EncaminharRequest, Domain.Entities.Projeto>();
    }

}

using AutoMapper;

namespace AprovacaoDigital.Application.Features.Teste.GetAll;

public sealed class GetAllTesteMapper : Profile
{
    public GetAllTesteMapper()
    {
        CreateMap<Domain.Entities.Teste, GetAllResponse>();

    }
}


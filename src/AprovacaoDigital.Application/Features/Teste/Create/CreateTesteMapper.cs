using AutoMapper;

namespace AprovacaoDigital.Application.Features.Teste.Create;

public sealed class CreateTesteMapper : Profile
{
    public CreateTesteMapper()
    {
        CreateMap<CreateTesteRequest, Domain.Entities.TesteOld>();
    }

}

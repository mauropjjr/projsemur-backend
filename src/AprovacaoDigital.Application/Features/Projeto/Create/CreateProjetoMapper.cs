using AutoMapper;

namespace AprovacaoDigital.Application.Features.Projeto.Create;

public sealed class CreateProjetoMapper : Profile
{
    public CreateProjetoMapper()
    {
        CreateMap<CreateProjetoRequest, Domain.Entities.Projeto>();
    }

}

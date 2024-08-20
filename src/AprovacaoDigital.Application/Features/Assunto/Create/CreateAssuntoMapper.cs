using AutoMapper;

namespace AprovacaoDigital.Application.Features.Assunto.Create;

public sealed class CreateAssuntoMapper : Profile
{
    public CreateAssuntoMapper()
    {
        CreateMap<CreateAssuntoRequest, Domain.Entities.Assunto1>();
    }

}

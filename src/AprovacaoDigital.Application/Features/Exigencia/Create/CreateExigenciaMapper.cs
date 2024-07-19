using AutoMapper;

namespace AprovacaoDigital.Application.Features.Exigencia.Create;

public sealed class CreateExigenciaMapper : Profile
{
    public CreateExigenciaMapper()
    {
        CreateMap<CreateExigenciaRequest, Domain.Entities.Exigencia>();
    }

}

using AutoMapper;

namespace AprovacaoDigital.Application.Features.TipoArquivo.Create;

public sealed class CreateTipoArquivoMapper : Profile
{
    public CreateTipoArquivoMapper()
    {
        CreateMap<CreateTipoArquivoRequest, Domain.Entities.TipoArquivoAgenda>();
    }

}

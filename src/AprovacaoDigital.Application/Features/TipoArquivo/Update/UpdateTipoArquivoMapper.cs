using AprovacaoDigital.Domain.Entities;
using AutoMapper;

namespace AprovacaoDigital.Application.Features.TipoArquivo.Update;

public sealed class UpdateTipoArquivoMapper : Profile
{
    public UpdateTipoArquivoMapper()
    {
        CreateMap<UpdateTipoArquivoAgendaRequest, Domain.Entities.TipoArquivoAgenda>()
            .ForMember(dest => dest.Tipoarquivoid, opt => opt.MapFrom(src => src.Id));
    }

}

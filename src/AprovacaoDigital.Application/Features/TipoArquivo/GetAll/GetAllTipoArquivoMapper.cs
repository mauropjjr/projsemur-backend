using AutoMapper;

namespace AprovacaoDigital.Application.Features.TipoArquivo.GetAll;

public sealed class GetAllTipoArquivoMapper : Profile
{
    public GetAllTipoArquivoMapper()
    {
        CreateMap<Domain.Entities.TipoArquivoAgenda, GetAllTipoArquivoAgendaResponse>().ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Tipoarquivoid)); 

    }
}


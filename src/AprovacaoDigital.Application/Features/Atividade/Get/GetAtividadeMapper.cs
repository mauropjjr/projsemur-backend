using AutoMapper;

namespace AprovacaoDigital.Application.Features.Atividade.Get;

public sealed class GetAtividadeMapper : Profile
{
    public GetAtividadeMapper()
    {
        CreateMap<Domain.Entities.Atividade, GetResponse>();

    }
}


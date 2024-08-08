using AutoMapper;

namespace AprovacaoDigital.Application.Features.Atividade.GetAll;

public sealed class GetAllAtividadeMapper : Profile
{
    public GetAllAtividadeMapper()
    {
        CreateMap<Domain.Entities.Atividade, GetAllAtividadeResponse>();

    }
}


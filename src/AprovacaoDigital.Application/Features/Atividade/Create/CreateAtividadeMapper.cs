using AutoMapper;

namespace AprovacaoDigital.Application.Features.Atividade.Create;

public sealed class CreateAtividadeMapper : Profile
{
    public CreateAtividadeMapper()
    {
        CreateMap<CreateAtividadeRequest, Domain.Entities.Atividade>();
    }

}

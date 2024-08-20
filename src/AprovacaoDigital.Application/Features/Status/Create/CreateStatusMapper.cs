using AutoMapper;

namespace AprovacaoDigital.Application.Features.Status.Create;

public sealed class CreateStatusMapper : Profile
{
    public CreateStatusMapper()
    {
        CreateMap<CreateStatusRequest, Domain.Entities.Status1>();
    }

}


using MediatR;

namespace AprovacaoDigital.Application.Features.Despachar.Update;

public sealed record UpdateDespacharRequest : IRequest<int>
{

    public int RemessaId { get; set; }
    public string? Despacho { get; set; }


 

}


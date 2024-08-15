using AprovacaoDigital.Application.Common.Models;
using AprovacaoDigital.Application.Repositories;
using AutoMapper;
using MediatR;
using System.Linq.Expressions;


namespace AprovacaoDigital.Application.Features.TipoArquivo.GetAll
{
    public sealed record GetAllTipoArquivoAgendaResponse
    {
        public int Id { get; set; }

        public string? Nome { get; set; }

        public int? Version { get; set; }

        public string? Extension { get; set; }

        public string? Contenttype { get; set; }

        public int? Ativo { get; set; }

    }

    public sealed record GetAllRequest : BaseRequest, IRequest<PaginatedList<GetAllTipoArquivoAgendaResponse>>
    {
        public string? Nome { get; set; }
        public int? Ativo { get; set; }

    }

    public sealed class GetAllTipoArquivoAgendaHandler : IRequestHandler<GetAllRequest, PaginatedList<GetAllTipoArquivoAgendaResponse>>
    {
        private readonly ITipoArquivoAgendaRepository _repository;
        private readonly IMapper _mapper;

        public GetAllTipoArquivoAgendaHandler(ITipoArquivoAgendaRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<PaginatedList<GetAllTipoArquivoAgendaResponse>> Handle(GetAllRequest request, CancellationToken cancellationToken)
        {
            Expression<Func<Domain.Entities.TipoArquivoAgenda, bool>> filter = null;

            if (!string.IsNullOrEmpty(request.Nome))
            {
                filter = x => x.Nome.Contains(request.Nome);
            }
            if (request.Ativo != null)
            {
                filter = x => x.Ativo == request.Ativo;
            }


            var orderByExpression = request.CampoOrdem != null ?
                    ExpressionExtensions.CreateOrderByExpression<Domain.Entities.TipoArquivoAgenda>(request.CampoOrdem) : null;

            var lista = await _repository.FindAllAsync(filter, null, orderByExpression, request.OrderBy, cancellationToken);
            var total = lista.Count();

            var data = lista.Skip((request.PageNumber - 1) * request.PageSize).Take(request.PageSize).ToList();


            var dto = _mapper.Map<ICollection<GetAllTipoArquivoAgendaResponse>>(data);
            var paginate = new PaginatedList<GetAllTipoArquivoAgendaResponse>(dto, total, request.PageNumber, request.PageSize);

            return paginate;
        }


    }
}

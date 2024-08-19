using AprovacaoDigital.Application.Common.DTOs;
using AprovacaoDigital.Application.Common.Models;
using AprovacaoDigital.Application.Repositories;
using AutoMapper;
using MediatR;
using Microsoft.Extensions.Primitives;
using System.Linq.Expressions;


namespace AprovacaoDigital.Application.Features.Projeto.GetAll
{
    public class GetAllProjetoResponse
    {
        public int Id { get; set; }
        public DateTime? Datacriacao { get; set; }

        public DateTime? Datahomologacao { get; set; }

        public int? Profissional { get; set; }

        public int? Analista { get; set; }

        public DateTime? Dataencaminhamento { get; set; }
        public DateTime? DataUltimoTramite { get; set; }

        public int? Finalizado { get; set; }

        public string Processo { get; set; } = null!;

        public string? Proprietario { get; set; }

        public string? Inscricao { get; set; }
        public int? Assunto { get; set; }

        public int Status { get; set; }
        public virtual GetAssuntoRequest? AssuntoNavigation { get; set; }
        public virtual GetAnalistaRequest? AnalistaNavigation { get; set; }
        public virtual GetPrfageRequest? ProfissionalNavigation { get; set; }

    }

    public sealed record GetAllRequest : BaseRequest, IRequest<PaginatedList<GetAllProjetoResponse>>
    {
        public int? Status { get; set; }
        public int? Assunto { get; set; }
        public string? Proprietario { get; set; }
        public string? Processo { get; set; }
        public DateTime? Datacriacao { get; set; }
        public DateTime? Datahomologacao { get; set; }
        public DateTime? DataUltimoTramite { get; set; }

    }

    public sealed class GetAllProjetoHandler : IRequestHandler<GetAllRequest, PaginatedList<GetAllProjetoResponse>>
    {
        private readonly IProjetoRepository _repository;
        private readonly IMapper _mapper;

        public GetAllProjetoHandler(IProjetoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<PaginatedList<GetAllProjetoResponse>> Handle(GetAllRequest request, CancellationToken cancellationToken)
        {
            Expression<Func<Domain.Entities.Projeto, bool>> filter = null;

            if (request.Status != null && request.Status > 0)
            {
                filter = x => x.Status == request.Status;
            }
            if (request.Assunto != null && request.Assunto > 0)
            {
                filter = filter == null
                    ? (x => x.Assunto == request.Assunto)
                    : filter.And(x => x.Assunto == request.Assunto);
            }

            if (!string.IsNullOrEmpty(request.Proprietario))
            {
                filter = filter == null
                    ? (x => x.Proprietario.Contains(request.Proprietario))
                    : filter.And(x => x.Proprietario.Contains(request.Proprietario));
            }

            if (!string.IsNullOrEmpty(request.Processo))
            {
                filter = filter == null
                    ? (x => x.Processo.Contains(request.Processo))
                    : filter.And(x => x.Processo.Contains(request.Processo));
            }

            if (request.Datacriacao != null)
            {
                filter = filter == null
                    ? (x => x.Datacriacao.Value.Date == request.Datacriacao.Value.Date)
                    : filter.And(x => x.Datacriacao.Value.Date == request.Datacriacao.Value.Date);
            }

            if (request.Datahomologacao != null)
            {
                filter = filter == null
                    ? (x => x.Datahomologacao.Value.Date == request.Datahomologacao.Value.Date)
                    : filter.And(x => x.Datahomologacao.Value.Date == request.Datahomologacao.Value.Date);
            }

            if (request.DataUltimoTramite != null)
            {
                filter = filter == null
                    ? (x => x.Dataulttram.Value.Date == request.DataUltimoTramite.Value.Date)
                    : filter.And(x => x.Dataulttram.Value.Date == request.DataUltimoTramite.Value.Date);
            }

            if (request.CampoOrdem == null)
            {
                request.CampoOrdem = "dataulttram";
                request.OrderBy = "desc";
            }
            var orderByExpression = ExpressionExtensions.CreateOrderByExpression<Domain.Entities.Projeto>(request.CampoOrdem);

            var lista = await _repository.FindAllAsync(filter, "AssuntoNavigation,AnalistaNavigation,ProfissionalNavigation", orderByExpression, request.OrderBy, cancellationToken);
            var total = lista.Count();

            var data = lista.Skip((request.PageNumber - 1) * request.PageSize).Take(request.PageSize).ToList();


            var dto = _mapper.Map<ICollection<GetAllProjetoResponse>>(data);
            var paginate = new PaginatedList<GetAllProjetoResponse>(dto, total, request.PageNumber, request.PageSize);

            return paginate;
        }


    }
}

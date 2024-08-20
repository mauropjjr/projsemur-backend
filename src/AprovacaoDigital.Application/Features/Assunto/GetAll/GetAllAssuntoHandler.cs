using AprovacaoDigital.Application.Common.Models;
using AprovacaoDigital.Application.Repositories;
using AutoMapper;
using MediatR;
using System.Linq.Expressions;


namespace AprovacaoDigital.Application.Features.Assunto.GetAll
{
    public sealed record GetAllAssuntoResponse
    {
        public int Id { get; set; }

        public string? Nome { get; set; }



    }

    public sealed record GetAllAssuntoRequest : BaseRequest, IRequest<PaginatedList<GetAllAssuntoResponse>>
    {
        public string? Nome { get; set; }
    }

    public sealed class GetAllAssuntoHandler : IRequestHandler<GetAllAssuntoRequest, PaginatedList<GetAllAssuntoResponse>>
    {
        private readonly IAssuntoRepository _repository;
        private readonly IMapper _mapper;

        public GetAllAssuntoHandler(IAssuntoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<PaginatedList<GetAllAssuntoResponse>> Handle(GetAllAssuntoRequest request, CancellationToken cancellationToken)
        {
            Expression<Func<Domain.Entities.Assunto1, bool>> filter = null;

            if (!string.IsNullOrEmpty(request.Nome))
            {
                filter = x => x.Nome.Contains(request.Nome);
            }


            var orderByExpression = request.CampoOrdem != null ?
                    ExpressionExtensions.CreateOrderByExpression<Domain.Entities.Assunto1>(request.CampoOrdem) : null;

            var lista = await _repository.FindAllAsync(filter, null, orderByExpression, request.OrderBy, cancellationToken);
            var total = lista.Count();

            var data = lista.Skip((request.PageNumber - 1) * request.PageSize).Take(request.PageSize).ToList();


            var dto = _mapper.Map<ICollection<GetAllAssuntoResponse>>(data);
            var paginate = new PaginatedList<GetAllAssuntoResponse>(dto, total, request.PageNumber, request.PageSize);

            return paginate;
        }


    }
}

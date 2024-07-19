using AprovacaoDigital.Application.Common.Models;
using AprovacaoDigital.Application.Repositories;
using AutoMapper;
using MediatR;
using System.Linq.Expressions;


namespace AprovacaoDigital.Application.Features.Teste.GetAll
{
    public sealed record GetAllResponse
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

    }

    public sealed record GetAllRequest : BaseRequest, IRequest<PaginatedList<GetAllResponse>>
    {
        public string Descricao { get; set; }
    }

    public sealed class GetAllTesteHandler : IRequestHandler<GetAllRequest, PaginatedList<GetAllResponse>>
    {
        private readonly ITesteRepository _repository;
        private readonly IMapper _mapper;

        public GetAllTesteHandler(ITesteRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<PaginatedList<GetAllResponse>> Handle(GetAllRequest request, CancellationToken cancellationToken)
        {
            Expression<Func<Domain.Entities.TesteOld, bool>> filter = null;

            if (!string.IsNullOrEmpty(request.Descricao))
            {
                filter = x => x.Descricao.Contains(request.Descricao);
            }
            

            var orderByExpression = request.CampoOrdem != null ?
                    ExpressionExtensions.CreateOrderByExpression<Domain.Entities.TesteOld>(request.CampoOrdem) : null;

            var lista = await _repository.FindAllAsync(filter, null, orderByExpression, request.OrderBy, cancellationToken);
            var total = lista.Count();

            var data = lista.Skip((request.PageNumber - 1) * request.PageSize).Take(request.PageSize).ToList();


            var dto = _mapper.Map<ICollection<GetAllResponse>>(data);
            var paginate = new PaginatedList<GetAllResponse>(dto, total, request.PageNumber, request.PageSize);

            return paginate;
        }


    }
}

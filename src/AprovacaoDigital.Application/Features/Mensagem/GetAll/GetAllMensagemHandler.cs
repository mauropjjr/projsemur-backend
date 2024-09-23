using AprovacaoDigital.Application.Common.Models;
using AprovacaoDigital.Application.Repositories;
using AutoMapper;
using MediatR;
using System.Linq.Expressions;


namespace AprovacaoDigital.Application.Features.Mensagem.GetAll
{
    public sealed record GetAllMensagemResponse
    {
        public int Id { get; set; }

        public int ProjetoId { get; set; }

        public DateTime Datahora { get; set; }

        public string Usuario { get; set; } = null!; //Pegar

        public string Texto { get; set; } = null!;

        public int Lida { get; set; }
        public int Grupo { get; set; }




    }

    public sealed record GetAllMensagemRequest : BaseRequest, IRequest<ICollection<GetAllMensagemResponse>>
    {
        public int? ProjetoId { get; set; }
    }

    public sealed class GetAllMensagemHandler : IRequestHandler<GetAllMensagemRequest, ICollection<GetAllMensagemResponse>>
    {
        private readonly IMensagemRepository _repository;
        private readonly IMapper _mapper;

        public GetAllMensagemHandler(IMensagemRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<ICollection<GetAllMensagemResponse>> Handle(GetAllMensagemRequest request, CancellationToken cancellationToken)
        {
            Expression<Func<Domain.Entities.Mensagem, bool>> filter = x => x.Projeto == request.ProjetoId ;

     

            var orderByExpression = ExpressionExtensions.CreateOrderByExpression<Domain.Entities.Mensagem>("Datahora");

            var lista = await _repository.FindAllAsync(filter, null, orderByExpression, "Desc", cancellationToken);
          

            var dto = _mapper.Map<ICollection<GetAllMensagemResponse>>(lista);
           

            return dto;
        }


    }
}

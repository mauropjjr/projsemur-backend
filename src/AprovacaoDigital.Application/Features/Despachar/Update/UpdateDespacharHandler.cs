using AprovacaoDigital.Application.Repositories;
using AprovacaoDigital.Common.Exceptions;
using AutoMapper;
using MediatR;

namespace AprovacaoDigital.Application.Features.Despachar.Update;


public sealed class UpdateDespacharHandler : IRequestHandler<UpdateDespacharRequest, int>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IProjetoRepository _repository;
    private readonly IMapper _mapper;
    public UpdateDespacharHandler(IUnitOfWork unitOfWork, IProjetoRepository repository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _repository = repository;
        _mapper = mapper;
    }
    public async Task<int> Handle(UpdateDespacharRequest request, CancellationToken cancellationToken)
    {
        //var objeto = await _repository.GetAsync(x => x.Rem == request.RemessaId, cancellationToken);
        //if (objeto == null)
        //{
        //    throw new NotFoundException(nameof(objeto), request.Id);
        //}

        //var updateRequest = _mapper.Map<Domain.Entities.Projeto>(request);
        //_repository.Update(updateRequest);
        //await _unitOfWork.Save(cancellationToken);
        //return updateRequest.Projetoid;
        throw new Exception("TODO: Implementar logica");
    }


}

using FluentValidation;

namespace AprovacaoDigital.Application.Features.Codificacao.Get
{
    public sealed class GetCodificacaoValidator : AbstractValidator<GetRequest>
    {
        public GetCodificacaoValidator()
        {
            RuleFor(x => x.Id)
            .NotNull().WithMessage("O ID não pode ser nulo.")
            .GreaterThan(0).WithMessage("O ID deve ser maior que 0.");
        }

    }
}

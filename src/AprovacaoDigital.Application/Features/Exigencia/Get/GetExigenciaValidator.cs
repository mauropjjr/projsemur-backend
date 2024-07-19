using FluentValidation;

namespace AprovacaoDigital.Application.Features.Exigencia.Get
{
    public sealed class GetExigenciaValidator : AbstractValidator<GetRequest>
    {
        public GetExigenciaValidator()
        {
            RuleFor(x => x.Id)
            .NotNull().WithMessage("O ID não pode ser nulo.")
            .GreaterThan(0).WithMessage("O ID deve ser maior que 0.");
        }

    }
}

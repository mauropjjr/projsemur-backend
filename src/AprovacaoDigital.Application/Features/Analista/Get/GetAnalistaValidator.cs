using FluentValidation;

namespace AprovacaoDigital.Application.Features.Analista.Get
{
    public sealed class GetAnalistaValidator : AbstractValidator<GetRequest>
    {
        public GetAnalistaValidator()
        {
            RuleFor(x => x.Id)
            .NotNull().WithMessage("O ID não pode ser nulo.")
            .GreaterThan(0).WithMessage("O ID deve ser maior que 0.");
        }

    }
}

using FluentValidation;

namespace AprovacaoDigital.Application.Features.Zoneamento.Get
{
    public sealed class GetZoneamentoValidator : AbstractValidator<GetRequest>
    {
        public GetZoneamentoValidator()
        {
            RuleFor(x => x.Id)
            .NotNull().WithMessage("O ID não pode ser nulo.")
            .GreaterThan(0).WithMessage("O ID deve ser maior que 0.");
        }

    }
}

using FluentValidation;

namespace AprovacaoDigital.Application.Features.Status.Get
{
    public sealed class GetStatusValidator : AbstractValidator<GetStatusRequest>
    {
        public GetStatusValidator()
        {
            RuleFor(x => x.Id)
            .NotNull().WithMessage("O ID não pode ser nulo.")
            .GreaterThan(0).WithMessage("O ID deve ser maior que 0.");
        }

    }
}

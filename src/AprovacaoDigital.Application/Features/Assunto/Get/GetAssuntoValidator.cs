using FluentValidation;

namespace AprovacaoDigital.Application.Features.Assunto.Get
{
    public sealed class GetAssuntoValidator : AbstractValidator<GetAssuntoRequest>
    {
        public GetAssuntoValidator()
        {
            RuleFor(x => x.Id)
            .NotNull().WithMessage("O ID não pode ser nulo.")
            .GreaterThan(0).WithMessage("O ID deve ser maior que 0.");
        }

    }
}

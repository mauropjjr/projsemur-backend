using FluentValidation;

namespace AprovacaoDigital.Application.Features.Projeto.Get
{
    public sealed class GetProjetoValidator : AbstractValidator<GetRequest>
    {
        public GetProjetoValidator()
        {
            RuleFor(x => x.Id)
            .NotNull().WithMessage("O ID não pode ser nulo.")
            .GreaterThan(0).WithMessage("O ID deve ser maior que 0.");
        }

    }
}

using FluentValidation;

namespace AprovacaoDigital.Application.Features.Atividade.Get
{
    public sealed class GetAtividadeValidator : AbstractValidator<GetRequest>
    {
        public GetAtividadeValidator()
        {
            RuleFor(x => x.Id)
            .NotNull().WithMessage("O ID não pode ser nulo.")
            .GreaterThan(0).WithMessage("O ID deve ser maior que 0.");
        }

    }
}

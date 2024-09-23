using FluentValidation;

namespace AprovacaoDigital.Application.Features.Mensagem.Get
{
    public sealed class GetMensagemValidator : AbstractValidator<GetMensagemRequest>
    {
        public GetMensagemValidator()
        {
            RuleFor(x => x.Id)
            .NotNull().WithMessage("O ID não pode ser nulo.")
            .GreaterThan(0).WithMessage("O ID deve ser maior que 0.");
        }

    }
}

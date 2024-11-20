using FluentValidation;

namespace AprovacaoDigital.Application.Features.Codificacao.Update
{
    public sealed class UpdateCodificacaoValidator : AbstractValidator<UpdateCodificacaoRequest>
    {
        public UpdateCodificacaoValidator()
        {
            RuleFor(x => x.Codificacaoid)
            .NotNull().WithMessage("O ID não pode ser nulo.")
            .GreaterThan(0).WithMessage("O ID deve ser maior que 0.");
            RuleFor(x => x.Nome).NotEmpty().WithMessage("Obrigatório").MaximumLength(255).WithMessage("Campo suporta apenas 255 caracteres");
        }

    }
}

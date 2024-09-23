using FluentValidation;

namespace AprovacaoDigital.Application.Features.Mensagem.Create
{
    public sealed class CreateMensagemValidator : AbstractValidator<CreateMensagemRequest>
    {
        public CreateMensagemValidator()
        {
            RuleFor(x => x.Texto).NotEmpty().WithMessage("Obrigatório").MaximumLength(255).WithMessage("Campo suporta apenas 255 caracteres");
            RuleFor(x => x.ProjetoId)
                .NotNull().WithMessage("O ProjetoId não pode ser nulo.")
                .GreaterThan(0).WithMessage("O ProjetoId deve ser maior que 0.");
            RuleFor(x => x.GrupoId)
                .NotNull().WithMessage("O GrupoId não pode ser nulo.")
                .GreaterThan(0).WithMessage("O GrupoId deve ser maior que 0.");
        }

    }
}

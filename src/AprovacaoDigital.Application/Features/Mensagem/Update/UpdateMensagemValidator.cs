using FluentValidation;

namespace AprovacaoDigital.Application.Features.Mensagem.Update
{
    public sealed class UpdateMensagemValidator : AbstractValidator<UpdateMensagemRequest>
    {
        public UpdateMensagemValidator()
        {
            RuleFor(x => x.Id)
            .NotNull().WithMessage("O ID não pode ser nulo.")
            .GreaterThan(0).WithMessage("O ID deve ser maior que 0.");
            RuleFor(x => x.Texto).NotEmpty().WithMessage("Obrigatório").MaximumLength(255).WithMessage("Campo suporta apenas 255 caracteres");
            RuleFor(x => x.ProjetoId)
                .NotNull().WithMessage("O ProjetoId não pode ser nulo.")
                .GreaterThan(0).WithMessage("O ProjetoId deve ser maior que 0.");
                        RuleFor(x => x.Grupo)
                            .NotNull().WithMessage("O Grupo não pode ser nulo.")
                            .GreaterThan(0).WithMessage("O Grupo deve ser maior que 0.");
        }

    }
}

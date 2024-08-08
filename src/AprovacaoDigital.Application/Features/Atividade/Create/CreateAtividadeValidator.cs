using FluentValidation;

namespace AprovacaoDigital.Application.Features.Atividade.Create
{
    public sealed class CreateAtividadeValidator : AbstractValidator<CreateAtividadeRequest>
    {
        public CreateAtividadeValidator()
        {
            RuleFor(x => x.Nome).NotEmpty().WithMessage("Obrigatório").MaximumLength(255).WithMessage("Campo suporta apenas 255 caracteres");
        }

    }
}

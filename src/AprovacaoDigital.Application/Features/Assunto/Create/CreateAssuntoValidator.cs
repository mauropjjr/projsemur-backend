using FluentValidation;

namespace AprovacaoDigital.Application.Features.Assunto.Create
{
    public sealed class CreateAssuntoValidator : AbstractValidator<CreateAssuntoRequest>
    {
        public CreateAssuntoValidator()
        {
            RuleFor(x => x.Nome).NotEmpty().WithMessage("Obrigatório").MaximumLength(255).WithMessage("Campo suporta apenas 255 caracteres");
        }

    }
}

using FluentValidation;

namespace AprovacaoDigital.Application.Features.Exigencia.Create
{
    public sealed class CreateExigenciaValidator : AbstractValidator<CreateExigenciaRequest>
    {
        public CreateExigenciaValidator()
        {
            RuleFor(x => x.Nome).NotEmpty().WithMessage("Obrigatório").MaximumLength(255).WithMessage("Campo suporta apenas 255 caracteres");
        }

    }
}

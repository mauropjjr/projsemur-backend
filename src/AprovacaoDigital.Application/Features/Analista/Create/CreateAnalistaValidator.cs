using FluentValidation;

namespace AprovacaoDigital.Application.Features.Analista.Create
{
    public sealed class CreateAnalistaValidator : AbstractValidator<CreateAnalistaRequest>
    {
        public CreateAnalistaValidator()
        {
            RuleFor(x => x.Nome).NotEmpty().WithMessage("Obrigatório").MaximumLength(255).WithMessage("Campo suporta apenas 255 caracteres");
        }

    }
}

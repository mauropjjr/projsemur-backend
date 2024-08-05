using FluentValidation;

namespace AprovacaoDigital.Application.Features.DestinoFinal.Create
{
    public sealed class CreateDestinoFinalValidator : AbstractValidator<CreateDestinoFinalRequest>
    {
        public CreateDestinoFinalValidator()
        {
            RuleFor(x => x.Nome).NotEmpty().WithMessage("Obrigatório").MaximumLength(255).WithMessage("Campo suporta apenas 255 caracteres") ;
        }

    }
}

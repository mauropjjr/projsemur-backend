using FluentValidation;

namespace AprovacaoDigital.Application.Features.AreaReceptora.Create
{
    public sealed class CreateAreaReceptoraValidator : AbstractValidator<CreateAreaReceptoraRequest>
    {
        public CreateAreaReceptoraValidator()
        {
            RuleFor(x => x.Nome).NotEmpty().WithMessage("Obrigatório").MaximumLength(255).WithMessage("Campo suporta apenas 255 caracteres") ;
        }

    }
}

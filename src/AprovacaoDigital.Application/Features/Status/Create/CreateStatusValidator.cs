using FluentValidation;

namespace AprovacaoDigital.Application.Features.Status.Create
{
    public sealed class CreateStatusValidator : AbstractValidator<CreateStatusRequest>
    {
        public CreateStatusValidator()
        {
            RuleFor(x => x.Descricao).NotEmpty().WithMessage("Obrigatório").MaximumLength(255).WithMessage("Campo suporta apenas 255 caracteres");
        }

    }
}

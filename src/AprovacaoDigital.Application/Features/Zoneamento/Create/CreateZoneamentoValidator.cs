using FluentValidation;

namespace AprovacaoDigital.Application.Features.Zoneamento.Create
{
    public sealed class CreateZoneamentoValidator : AbstractValidator<CreateZoneamentoRequest>
    {
        public CreateZoneamentoValidator()
        {
            RuleFor(x => x.Nome).NotEmpty().WithMessage("Obrigatório").MaximumLength(255).WithMessage("Campo suporta apenas 255 caracteres");
        }

    }
}

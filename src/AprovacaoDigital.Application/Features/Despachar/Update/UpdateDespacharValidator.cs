
using FluentValidation;

namespace AprovacaoDigital.Application.Features.Despachar.Update
{
    public sealed class UpdateDespacharValidator : AbstractValidator<UpdateDespacharRequest>
    {
        public UpdateDespacharValidator()
        {
            RuleFor(x => x.RemessaId)
            .NotNull().WithMessage("O RemessaId não pode ser nulo.")
            .GreaterThan(0).WithMessage("O RemessaId deve ser maior que 0.");
            //  RuleFor(x => x.Nome).NotEmpty().WithMessage("Obrigatório").MaximumLength(255).WithMessage("Campo suporta apenas 255 caracteres");
        }

    }
}

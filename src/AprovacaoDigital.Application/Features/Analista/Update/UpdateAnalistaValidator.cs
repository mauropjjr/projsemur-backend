using FluentValidation;

namespace AprovacaoDigital.Application.Features.Analista.Update
{
    public sealed class UpdateAnalistaValidator : AbstractValidator<UpdateAnalistaRequest>
    {
        public UpdateAnalistaValidator()
        {
            RuleFor(x => x.Id)
            .NotNull().WithMessage("O ID não pode ser nulo.")
            .GreaterThan(0).WithMessage("O ID deve ser maior que 0.");
            RuleFor(x => x.Nome).NotEmpty().WithMessage("Obrigatório").MaximumLength(255).WithMessage("Campo suporta apenas 255 caracteres");
        }

    }
}

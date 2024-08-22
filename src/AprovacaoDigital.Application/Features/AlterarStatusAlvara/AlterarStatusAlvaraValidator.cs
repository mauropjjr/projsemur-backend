using AprovacaoDigital.Application.Features.AreaReceptora.Update;
using FluentValidation;

namespace AprovacaoDigital.Application.Features.AlterarStatusAlvara
{
    public sealed class AlterarStatusAlvaraValidator : AbstractValidator<AlterarStatusAlvaraRequest>
    {
        public AlterarStatusAlvaraValidator()
        {
            RuleFor(x => x.ProjetoId)
            .NotNull().WithMessage("O Projeto não pode ser nulo.")
            .GreaterThan(0).WithMessage("O Projeto deve ser maior que 0.");
            RuleFor(x => x.StatusId)
            .NotNull().WithMessage("O Status não pode ser nulo.")
            .GreaterThan(0).WithMessage("O Status deve ser maior que 0.");

        }

    }
}

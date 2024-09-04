using AprovacaoDigital.Domain.Enums;
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
            .GreaterThan(0).WithMessage("O Status deve ser maior que 0.").When(w => w.Tipo != RequestTipoProjetoEnum.CancelarProjeto);
            RuleFor(x => x.Tipo)
            .NotNull().WithMessage("O Tipo não pode ser nulo.")
             .IsInEnum().WithMessage("Tipo Inválido.")
             .Must(i => Enum.IsDefined(typeof(RequestTipoProjetoEnum), i)).WithMessage("Tipo inválido, utilize:  AlterarStatusEAlvara =0, NegarProjeto=1,  CancelarProjeto=2");


        }

    }
}

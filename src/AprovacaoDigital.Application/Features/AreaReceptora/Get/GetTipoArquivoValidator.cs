using FluentValidation;

namespace AprovacaoDigital.Application.Features.AreaReceptora.Get
{
    public sealed class GetAreaReceptoraValidator : AbstractValidator<GetRequest>
    {
        public GetAreaReceptoraValidator()
        {
            RuleFor(x => x.Id)
            .NotNull().WithMessage("O ID não pode ser nulo.")
            .GreaterThan(0).WithMessage("O ID deve ser maior que 0.");
        }

    }
}

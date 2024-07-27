using FluentValidation;

namespace AprovacaoDigital.Application.Features.TipoArquivo.Get
{
    public sealed class GetTipoArquivoValidator : AbstractValidator<GetRequest>
    {
        public GetTipoArquivoValidator()
        {
            RuleFor(x => x.Id)
            .NotNull().WithMessage("O ID não pode ser nulo.")
            .GreaterThan(0).WithMessage("O ID deve ser maior que 0.");
        }

    }
}

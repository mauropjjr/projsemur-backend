using FluentValidation;

namespace AprovacaoDigital.Application.Features.Codificacao.Create
{
    public sealed class CreateCodificacaoValidator : AbstractValidator<CreateCodificacaoRequest>
    {
        public CreateCodificacaoValidator()
        {
            RuleFor(x => x.Nome).NotEmpty().WithMessage("Obrigatório").MaximumLength(255).WithMessage("Campo suporta apenas 255 caracteres");
        }

    }
}

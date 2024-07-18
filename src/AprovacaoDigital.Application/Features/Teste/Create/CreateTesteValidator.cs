using FluentValidation;

namespace AprovacaoDigital.Application.Features.Teste.Create
{
    public sealed class CreateTesteValidator : AbstractValidator<CreateTesteRequest>
    {
        public CreateTesteValidator()
        {
            RuleFor(x => x.Descricao).NotEmpty().MaximumLength(255);
        }

    }
}

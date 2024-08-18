using FluentValidation;

namespace AprovacaoDigital.Application.Features.Projeto.Create
{
    public sealed class CreateProjetoValidator : AbstractValidator<CreateProjetoRequest>
    {

        //TODO: Verificar se vai ter essa tela de cadastro
        public CreateProjetoValidator()
        {
         //   RuleFor(x => x.Nome).NotEmpty().WithMessage("Obrigatório").MaximumLength(255).WithMessage("Campo suporta apenas 255 caracteres");
        }

    }
}

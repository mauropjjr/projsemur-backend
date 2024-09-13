using FluentValidation;

namespace AprovacaoDigital.Application.Features.Encaminhar;

public sealed class EncaminharValidator : AbstractValidator<EncaminharRequest>
{
    public EncaminharValidator()
    {
        RuleFor(x => x.AnalistaId)
        .NotNull().WithMessage("O Analista  não pode ser nulo.")
        .GreaterThan(0).WithMessage("O AnalistaId deve ser maior que 0.");
        RuleFor(x => x.ProjetoId)
        .NotNull().WithMessage("O Projeto não pode ser nulo.")
        .GreaterThan(0).WithMessage("O Projeto deve ser maior que 0.");
        //  RuleFor(x => x.Nome).NotEmpty().WithMessage("Obrigatório").MaximumLength(255).WithMessage("Campo suporta apenas 255 caracteres");
    }

}
//"AnalistaId": 341
//"ProjetoId": 77183
//"Enc": 3
//"Classificacao": NOR
//"Especial": 1
//"CodificacaoId": 1
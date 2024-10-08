﻿using FluentValidation;

namespace AprovacaoDigital.Application.Features.TipoArquivo.Create
{
    public sealed class CreateTipoArquivoValidator : AbstractValidator<CreateTipoArquivoRequest>
    {
        public CreateTipoArquivoValidator()
        {
            RuleFor(x => x.Nome).NotEmpty().WithMessage("Obrigatório").MaximumLength(255).WithMessage("Campo suporta apenas 255 caracteres");
            RuleFor(x => x.Extension).MaximumLength(4).WithMessage("Campo suporta apenas 4 caracteres");
        }

    }
}

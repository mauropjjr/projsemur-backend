using AprovacaoDigital.Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace AprovacaoDigital.Infrastructure.Persistence.Seeds;

public static class Status1Seeds
{
    public static void Configure(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Status1>().HasData(
            new Status1 { Statusid = 1, Descricao = "1-Não analisado (Triagem)" },
            new Status1 { Statusid= 2, Descricao = "2-Negado. Encaminhado para o Profissional (Com o Profissional)" },
            new Status1 { Statusid= 3, Descricao = "3-Voltou do Profissional corrigido (Triagem)" },
            new Status1 { Statusid= 4, Descricao = "4-Não analisado (Analista)" },
            new Status1 { Statusid= 5, Descricao = "5-Re-encaminhado para o Profissional (Com o Profissional)" },
            new Status1 { Statusid= 6, Descricao = "6-Voltou do Profissional corrigido (Analista)" },
            new Status1 { Statusid= 7, Descricao = "7-De acordo - Encaminhado para o Administrador" },
            new Status1 { Statusid= 8, Descricao = "8-Encaminhado para o Chefe de Divisão" },
            new Status1 { Statusid= 9, Descricao = "9-Aprovado" },
            new Status1 { Statusid= 10, Descricao = "10-Re-encaminhado para nova análise" },
            new Status1 { Statusid= 11, Descricao = "11-Indeferido/Cancelado" },
            new Status1 { Statusid= 12, Descricao = "12-Indeferido (60 Dias)" },
            new Status1 { Statusid= 13, Descricao = "13-Projeto encaminhado para Avaliação" },
            new Status1 { Statusid= 14, Descricao = "14-Projeto Avaliado (com Analista)" },
            new Status1 { Statusid= 15, Descricao = "15-Imprimir Termo (com Profissional)" },
            new Status1 { Statusid= 16, Descricao = "16-Projeto Cancelado/Substituido" },
            new Status1 { Statusid= 17, Descricao = "17-Encaminhado para vistoria (com Fiscal)" },
            new Status1 { Statusid= 18, Descricao = "18-Projeto vistoriado (com Fiscal)" },
            new Status1 { Statusid= 22, Descricao = "22-Indeferido (180 dias)" }
        );
    }
}

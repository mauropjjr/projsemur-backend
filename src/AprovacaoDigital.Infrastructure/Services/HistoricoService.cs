using AprovacaoDigital.Application.Repositories;
using AprovacaoDigital.Domain.Entities;


namespace AprovacaoDigital.Infrastructure.Services;

public class HistoricoService
{

    private readonly IUnitOfWork _unitOfWork;
    private readonly IProjetoRepository _repository;
 //   private readonly IMapper _mapper;
    public HistoricoService(IUnitOfWork unitOfWork, IProjetoRepository repository)
    {
        _unitOfWork = unitOfWork;
        _repository = repository;
     //   _mapper = mapper;
    }
    public object GerarTramiteProcesso(bool alteraStatus,Historico historico, int tipoTramite)
    {
        if (historico.Projeto >0  && historico.Autor != null)
        {
            string autor = historico.Autor;
            string email = string.Empty; //pegar de uma forma inteligente esse email

               // Busca o Projeto
            var projeto = historico.ProjetoNavigation;

            // Se for para alterar o status, salva o projeto; se não, apenas cria um tramite
            if (alteraStatus)
            {
                // Altera o status do projeto correspondente ao tramite
                if (tipoTramite == 13 || tipoTramite == 20 || tipoTramite == 21)
                    projeto.Status = 11; // Status INDEFERIDO
                else if (tipoTramite == 16)
                    projeto.Status = 13; // Status AVALIAÇÃO
                else if (tipoTramite == 17)
                    projeto.Status = 14; // Status AVALIADO (COM O ANALISTA)
                else if (tipoTramite == 18)
                    projeto.Status = 16; // Status CANCELADO OU SUBSTITUIDO
                else if (tipoTramite == 19)
                    projeto.Status = 17; // STATUS ENCAMINHADO AO FISCAL
                else if (tipoTramite == 22)
                    projeto.Status = 22; // Status Indeferido 180 dias
                else
                    projeto.Status = tipoTramite; // Seta com o mesmo tipo do tramite

                // Salva o projeto
                var projetoLogic = new Projeto();
                if (tipoTramite == 11 || tipoTramite == 12 || tipoTramite == 20 || tipoTramite == 22)
                {
                   // projetoLogic.Dao.Permited = true;
                }
                // Altera a data do ultimo tramite do projeto
                else
                {
                   // projeto.Dataulttram = new DateTime(GetToday().Ticks);
                }

               // projetoLogic.SetEntity(projeto);
               // projeto = (Projeto)projetoLogic.SaveOrUpdate();
            }

            string despacho = string.Empty, despachoemail = string.Empty, despachopropemail = string.Empty, despachoprop = string.Empty;

            if (projeto != null)
            {
                string ps = string.Empty;
                if (projeto.Procsubstituto != null && !projeto.Procsubstituto.Equals(string.Empty))
                {
                    ps = "PROCESSO SUBSTITUIDO POR: " + projeto.Procsubstituto;
                }
                despacho = CriarDespacho(projeto) + " " + ps;
                despachoemail = "<b>" + despacho.ToUpper() + "</b>";
                // DESPACHO QUE VAI PARA O PROPRIETARIO
                despachoprop = CriarDespachoProprietario(projeto) + " " + ps;
                despachopropemail = "<b>" + despachoprop.ToUpper() + "</b>";
            }

            if (tipoTramite.Equals(9))
            {
                despachoemail = "Data: " + FormatarData(DateTime.Now) + ", ";
                despachoemail += "O Processo (<b>" + projeto.Processo + "</b>) foi aprovado.";
                despachoemail += "\nPlotar 4 jogos do Projeto e Memorial Descritivo com as devidas assinaturas e encaminhar ao CAT (Central de Atendimento Técnico - 3º andar) para anexar ao Processo. O Álvara de Construção e os Projetos Aprovados serão retirados na SEMRE (Pav.Térreo).";
                despachoemail += "Obs: Esse procedimento será alterado após a implantação da 'CERTIFICAÇÃO DIGITAL'.";
            }
            else if (tipoTramite == 13 || tipoTramite == 11 || tipoTramite == 12 || tipoTramite == 20 || tipoTramite == 22)
            {
                despachoemail = "<b>" + despacho.ToUpper() + "</b>";
            }

            bool valida = new HistoricoHibernateDAO().GerarHistoricoTramiteProcesso(projeto, despacho, autor, tipoTramite);

            if (valida)
            {
                // COMENTADO TEMPORARIAMENTE, POR PROBLEMAS NO ENVIO DE EMAILS
                // SendNotificacaoTramite(projeto, despacho, autor, email);

                string email2 = projeto.Profissional.Emlprf;
                string emailprop = projeto.Emailproprietario;

                string localPath = Environment.CurrentDirectory;
                if (localPath.Contains("C:")) // LOCAL
                {
                    // SendNotificacaoTramite(projeto, despachoemail, projeto.Profissional.Nomprf, "yamaura@gmail.com");
                }
                else
                {
                    if (tipoTramite != 5) // TAL TRAMITE NAO ENVIA
                    {
                        // Foi adicionado para enviar ao proprietário um email de tramitação do projeto.
                        // if (email2 != null && !email2.Equals(string.Empty))
                        //     SendNotificacaoTramite(projeto, despachoemail, projeto.Profissional.Nomprf, email2.ToLower());
                        // if (emailprop != null && !emailprop.Equals(string.Empty))
                        //     SendNotificacaoTramite(projeto, despachopropemail, projeto.Profissional.Nomprf, emailprop.ToLower());
                    }
                }

                return new { msg = "Trâmite gerado com Sucesso!" };
            }
            else
            {
                return new { msg = "Ocorreu algum erro ao gerar o trâmite!" };
            }
        }
        else
        {
            return new { msg = "Projeto não encontrado!" };
        }
    }

    private string FormatarData(DateTime data)
    {
        return data.ToString("yyyy-MM-dd");
    }
    public async Task<string> CriarDespacho(Projeto projeto, int tipoTramite, CancellationToken cancellationToken)
    {
        string despacho = "Data: " + FormatarData(DateTime.Now) + ", ";
        var listaRemessa = projeto.Remessas;
        // DESPACHO 1 - Criação de remessa
        if (tipoTramite.Equals(1))
        {
            despacho += "Processo protocolado";
           
            if (listaRemessa.Count > 0)
            {
                despacho += " e enviado arquivo(s):\n\n";
                var listaArquivo = listaRemessa.FirstOrDefault()?.Documentos;
                if (listaArquivo != null && listaArquivo.Count > 0)
                {
                    foreach (var a in listaArquivo)
                    {
                        despacho += a.ArquivoNavigation.TipoarquivoNavigation.Nome + ";\n";
                    }
                    despacho += "\nTotal de " + listaArquivo.Count + " arquivo(s)";
                }
            }
            despacho += " para aceite.";
        }
        // DESPACHO 2 - Supervisor Nega algum documento na pré-triagem
        else if (tipoTramite.Equals(2))
        {
            despacho += "Processo analisado. \"Negado\". Verificar condições para aceite de Documentos/Arquivos.";
        }
        // DESPACHO 3 - Profissional Encaminha o projeto corrigido para pré-triagem
        else if (tipoTramite.Equals(3))
        {
            despacho += "Processo corrigido";
            if (listaRemessa.Count > 0)
            {
                despacho += " e enviado arquivo(s):\n\n";
                var listaArquivo = listaRemessa.FirstOrDefault()?.Documentos;
                if (listaArquivo != null && listaArquivo.Count > 0)
                {
                    foreach (var a in listaArquivo)
                    {
                        despacho += a.ArquivoNavigation.TipoarquivoNavigation.Nome + ";\n";
                    }
                    despacho += "\nTotal de " + listaArquivo.Count + " arquivo(s)";
                }
            }
            despacho += " para aceite.";
        }
        // DESPACHO 4 - Supervisor Encaminha o projeto para analista
        else if (tipoTramite.Equals(4))
        {
            despacho += "Processo analisado. \"Aceito\". Repassado para Analista para análise.";
        }
        // DESPACHO 5 - Resposta do analista em relação a uma remessa
        else if (tipoTramite.Equals(5))
        {
            despacho += "Processo analisado. Cumprir as Exigências do Analista:\n\n";
            if (listaRemessa.Count > 0)
            {
                despacho += " e enviado arquivo(s):\n\n";
                var listaExigencia = listaRemessa.FirstOrDefault()?.Remessaexigencia.Select( s=> s.ExigenciaNavigation).ToList();
                if (listaExigencia != null && listaExigencia.Count > 0)
                {
                    foreach (var e in listaExigencia)
                    {
                        if (e.Exigenciaid == 158)
                        {
                            despacho += e.Nome + " ";
                            var listaRemessaexigencia = listaRemessa.FirstOrDefault()?.Remessaexigencia;
                            if (listaRemessaexigencia.Count > 0) despacho += listaRemessaexigencia.FirstOrDefault().Descricao + "\n";
                        }
                        else despacho += e.Nome + "\n";
                    }
                    despacho += "\nTotal de " + listaExigencia.Count + " exigência(s).";
                }
            }
   
            despacho += "Processo analisado.";
        }
        // DESPACHO 6 - Analista Negou algum arquivo
        else if (tipoTramite.Equals(6))
        {
            despacho += "Processo analisado. \"Negado\". Verificar condições para aceite de Documentos/Arquivos.";
        }
        // DESPACHO 7 - Analista Encaminha o projeto para o supervisor (já com o parecer emitido)
        else if (tipoTramite.Equals(7))
        {
            despacho += "Processo analisado. \"Aceito\".";
        }
        // DESPACHO 8 - Supervisor Emite parecer
        else if (tipoTramite.Equals(8))
        {
            despacho += "Processo analisado. \"Aceito\". Repassado para emissão de parecer.";
        }
        // DESPACHO 9 - Supervisor Emite o parecer e aprova o projeto
        else if (tipoTramite.Equals(9))
        {
            despacho += "Processo analisado e projeto aprovado.";
        }
        return despacho;
    }

    public string CriarDespachoProprietario(Projeto projeto, int tipoTramite)
    {
        string despacho = "Data: " + FormatarData(DateTime.Now) + ", ";
        if (tipoTramite.Equals(1))
        {
            despacho += "O processo foi protocolado.";
        }
        else if (tipoTramite.Equals(2))
        {
            despacho += "O processo foi analisado e \"negado\". Verifique as condições para aceite de documentos/arquivos.";
        }
        else if (tipoTramite.Equals(3))
        {
            despacho += "O processo foi corrigido e enviado para a análise.";
        }
        else if (tipoTramite.Equals(4))
        {
            despacho += "O processo foi analisado e \"aceito\". Está sendo repassado para o analista para análise.";
        }
        else if (tipoTramite.Equals(5))
        {
            despacho += "O processo foi analisado.";
        }
        else if (tipoTramite.Equals(6))
        {
            despacho += "O processo foi analisado e \"negado\". Verifique as condições para aceite de documentos/arquivos.";
        }
        else if (tipoTramite.Equals(7))
        {
            despacho += "O processo foi analisado e \"aceito\".";
        }
        else if (tipoTramite.Equals(8))
        {
            despacho += "O processo foi analisado e \"aceito\". Está sendo repassado para emissão de parecer.";
        }
        else if (tipoTramite.Equals(9))
        {
            despacho += "O processo foi analisado e o projeto foi aprovado.";
        }
        return despacho;
    }

}

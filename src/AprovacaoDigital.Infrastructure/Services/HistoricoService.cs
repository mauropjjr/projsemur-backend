using AprovacaoDigital.Application.Interfaces.Services;
using AprovacaoDigital.Application.Repositories;
using AprovacaoDigital.Domain.Entities;


namespace AprovacaoDigital.Infrastructure.Services;

public class HistoricoService: IHistoricoServices
{

    private readonly IUnitOfWork _unitOfWork;
    private readonly IProjetoRepository _repository;
    private readonly IHistoricoRepository _historyRepository;
 //   private readonly IMapper _mapper;
    public HistoricoService(IUnitOfWork unitOfWork, IProjetoRepository repository, IHistoricoRepository historyRepository)
    {
        _unitOfWork = unitOfWork;
        _repository = repository;
        _historyRepository = historyRepository;
     //   _mapper = mapper;
    }
    public async Task GerarTramiteProcesso(bool alteraStatus,Projeto projeto, int? tipoTramite, CancellationToken cancellationToken)
    { 
        var historico = projeto?.Historicos.LastOrDefault();
    
        if (projeto.Projetoid == 0 && projeto.Historicos.Any() && string.IsNullOrEmpty(historico.Autor))
        {
            throw new ArgumentException("Projeto não encontrado!");

        }

            string autor = historico?.Autor;
            string email = string.Empty; //pegar de uma forma inteligente esse email

               // Busca o Projeto
           // var projeto = historico.ProjetoNavigation;

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
                    projeto.Status = (int)tipoTramite; // Seta com o mesmo tipo do tramite

                // Salva o projeto
               // var projetoLogic = new Projeto();
                if (tipoTramite == 11 || tipoTramite == 12 || tipoTramite == 20 || tipoTramite == 22)
                {
                    //TODO-Mauro: Não sei pra que ele seta isso e nem onde usa
                    
                   // projetoLogic.getDao().setPermited(true);
                }
                // Altera a data do ultimo tramite do projeto
                else
                {
                    projeto.Dataulttram = DateTime.Now;
                }

             //   _repository.Update(projeto);
            }

            string despacho = string.Empty, despachoemail = string.Empty, despachopropemail = string.Empty, despachoprop = string.Empty;

            if (projeto != null)
            {
                string ps = string.Empty;
                if (projeto.Procsubstituto != null && !projeto.Procsubstituto.Equals(string.Empty))
                {
                    ps = "PROCESSO SUBSTITUIDO POR: " + projeto.Procsubstituto;
                }
                despacho = CriarDespacho(projeto, tipoTramite, cancellationToken) + " " + ps;
                despachoemail = "<b>" + despacho.ToUpper() + "</b>";
                // DESPACHO QUE VAI PARA O PROPRIETARIO
                despachoprop = CriarDespachoProprietario(projeto, tipoTramite) + " " + ps;
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

            await GerarHistoricoTramiteProcesso(projeto, despacho, autor, tipoTramite, cancellationToken);

            /* isso não vai precisar
            if (valida)
            {
                // COMENTADO TEMPORARIAMENTE, POR PROBLEMAS NO ENVIO DE EMAILS
                // SendNotificacaoTramite(projeto, despacho, autor, email);

                string email2 = projeto.ProfissionalNavigation.Emlprf;
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
            } */
   
    }

    private string FormatarData(DateTime data)
    {
        return data.ToString("dd/MM/yyyy HH:mm");
    }
    private string CriarDespacho(Projeto projeto, int? tipoTramite, CancellationToken cancellationToken)
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
   
         //   despacho += "Processo analisado.";
        }
        // DESPACHO 6 - Analista Negou algum arquivo
        else if (tipoTramite.Equals(6))
        {
            //  despacho += "Processo analisado. \"Negado\". Verificar condições para aceite de Documentos/Arquivos.";
            despacho += "Processo enviado para nova análise.";
            if (listaRemessa.Count() > 0)            {
                despacho += " Anexado(s) arquivo(s):\n\n";
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
        }
        // DESPACHO 7 - Analista Encaminha o projeto para o supervisor (já com o parecer emitido)
        else if (tipoTramite.Equals(7))
        {
            despacho += "Processo \"De Acordo\". Ao Administrador.";
        }
        // DESPACHO 8 - Supervisor Emite parecer
        else if (tipoTramite.Equals(8))
        {
            despacho += "Ao Chefe de Divisão para Aprovação.";
        }
        // DESPACHO 9 - Supervisor Emite o parecer e aprova o projeto
        else if (tipoTramite.Equals(9))
        {
            despacho += "\n1 - Encaminhados em Arquivo Digital ao Profissional. " +
                    "Montar 3(três) jogos assinados e anexar ao processo no CAT.";
        }
        else if (tipoTramite.Equals(10))
        {
            despacho += "Ao serviço da análise para nova análise.";
        }
        ///////////////// DESPACHO 5 - 50 dias e o profissional não atendeu as exigencias
        // DESPACHO 11 - 50 dias e o profissional não atendeu as exigencias
        else if (tipoTramite.Equals(11))
        {
            despacho += "Processo com 50 (cinquenta) dias de análise, sem qualquer tramitação. Conforme artigo 35, " +
                    "parágrafo 2º da Lei 1866/79 (Código de Obras) " +
                    "Não sendo atendidas as exigências no prazo de 60 " +
                    "(sessenta) dias, a contar da data do último trâmite de exigência, o processo será INDEFERIDO. " +
                    "DATA DO ÚLTIMO TRÂMITE DE EXIGÊNCIA: " + FormatarData((DateTime)projeto.Dataulttram);
        }
        // DESPACHO 12 - Projeto é Indeferido (60 dias de inatividade)
        else if (tipoTramite.Equals(12))
        {
            despacho += "Processo com 60 (sessenta) dias de análise, sem qualquer tramitação. Conforme artigo 35, " +
                    "parágrafo 2º da Lei 1866/79 (Código de Obras) " +
                    "Não sendo atendidas as exigências no prazo de 60 " +
                    "(sessenta) dias, a contar da data do último trâmite de exigência, o processo será INDEFERIDO. " +
                    "DATA DO ÚLTIMO TRÂMITE DE EXIGÊNCIA: " + FormatarData((DateTime)projeto.Dataulttram);
        }
        // DESPACHO 13 - Projeto é Indeferido (Triagem)
        else if (tipoTramite.Equals(13))
        {
            despacho += "Projeto indeferido na triagem.";
        }

        // DESPACHO 14 - Processo é Aberto (Texto de Abertura do projeto é um tramite)
        else if (tipoTramite.Equals(14))
        {
            despacho += "De " + projeto.AtividadeNavigation.Nome + " no Lote " + projeto.Lote + " Quadra " + projeto.Quadra +
                        " do Bairro " + projeto.Bairro + ", conforme documentos em anexo. OBS.: Na retirada dos documentos, não poderá existir débitos na inscrição " +
                        "do imóvel e nem do profissional responsável.";
        }
        // DESPACHO 15 - Remessa eh Despachada
        else if (tipoTramite.Equals(15))
        {
            despacho += "TODO: DESCOBRIR A ORIGEM DESSE TEXTO "; // this.getTextoDespacho();
        }
        // DESPACHO 16 - Projeto enviado para avaliacao (Avaliação)
        else if (tipoTramite.Equals(16))
        {
            despacho += "Projeto encaminhado para avaliação.";
        }
        // DESPACHO 17 - Projeto avaliado (com Analista)
        else if (tipoTramite.Equals(17))
        {
            despacho += "Projeto avaliado e repassado para o analista.";
        }
        // DESPACHO 18 - Projeto Cancelado/SUBSTITUIDO
        else if (tipoTramite.Equals(18))
        {
            despacho += "Projeto cancelado ou substituido.";
        }
        else if (tipoTramite.Equals(19))
        {
            despacho += "Projeto Arquitetônico PROC: " + projeto.Processo + ", encaminhado ao setor de vistoria.";
        }
        else if (tipoTramite.Equals(20))
        {
            despacho += "Processo com 70 (sessenta) dias de análise, sem qualquer tramitação. " +
                    "Não sendo atendidas as exigências no prazo de 70 " +
                    "(sessenta) dias, a contar da data do último trâmite de exigência, o processo será INDEFERIDO. " +
                    "DATA DO ÚLTIMO TRÂMITE DE EXIGÊNCIA: " + FormatarData((DateTime)projeto.Dataulttram);
        }
        else if (tipoTramite.Equals(21))
        {
            despacho += "Processo com 170 (sessenta) dias de análise, sem qualquer tramitação. " +
                    "Não sendo atendidas as exigências no prazo de 180 " +
                    "(sessenta) dias, a contar da data do último trâmite de exigência, o processo será INDEFERIDO. " +
                    "DATA DO ÚLTIMO TRÂMITE DE EXIGÊNCIA: " +  FormatarData((DateTime)projeto.Dataulttram);
        }
        else if (tipoTramite.Equals(22))
        {
            despacho += "Processo com 180 (sessenta) dias de análise, sem qualquer tramitação. " +
                    "Não sendo atendidas as exigências no prazo de 180 " +
                    "(sessenta) dias, a contar da data do último trâmite de exigência, o processo será INDEFERIDO. " +
                    "DATA DO ÚLTIMO TRÂMITE DE EXIGÊNCIA: " +  FormatarData((DateTime)projeto.Dataulttram);
        }
        return despacho;
    }

    private string CriarDespachoProprietario(Projeto projeto, int? tipoTramite)
    {
        string despacho = "Data: " + FormatarData(DateTime.Now) + ", ";

        // DESPACHO 1 - Criação de remessa
        if (tipoTramite.Equals(1))
        {
            despacho += "Processo protocolado junto a PMCG para análise.";
        }
        // DESPACHO 2 - Supervisor Nega algum documento na pré triagem
        else if (tipoTramite.Equals(2))
        {
            despacho += "Processo retornado ao PROFISSIONAL para averiguação de requisitos.";
        }
        // DESPACHO 3 - Profissional Encaminha o projeto corrigido para pré triagem
        else if (tipoTramite.Equals(3))
        {
            despacho += "Processo corrigido pelo PROFISSIONAL e enviado a PMCG para nova análise.";
        }
        // DESPACHO 4 - Supervisor Encaminhar o projeto para analista
        else if (tipoTramite.Equals(4))
        {
            despacho += "Processo repassado para análise.\n SITUAÇÃO: EM ANÁLISE.\n";
        }
        // DESPACHO 5 - Resposta do analista em relação a uma remessa
        else if (tipoTramite.Equals(5))
        {
            //nesta data, começã a contar os 60 dias para "Indeferir o Processo"
            despacho += "Processo analisado pela PMCG e enviado ao PROFISSIONAL para cumprir as exigências do analista.\n\n";
        }
        // DESPACHO 6 - Profissional cumpre as axigencias e envia novos arquivos corrigidos para nova analise
        else if (tipoTramite.Equals(6))
        {
            despacho += "Processo enviado à PMCG pelo PROFISSIONAL para nova análise.";
        }
        // DESPACHO 7 - Analista encaminha projeto para o Administrador
        else if (tipoTramite.Equals(7))
        {
            despacho += "Processo \"Em tramitação\". Encaminhado ao Supervisor da Área.";
        }
        // DESPACHO 8 - Administrador encaminha projeto para Diretor
        else if (tipoTramite.Equals(8))
        {
            despacho += "Ao Chefe de Divisão Responsável para Aprovação.";
        }
        // DESPACHO 9 - Diretor Aprova o projeto
        else if (tipoTramite.Equals(9))
        {
            despacho += "Projeto Aprovado.\n";
        }
        // DESPACHO 10 - Diretor Nega o Projeto
        else if (tipoTramite.Equals(10))
        {
            despacho += "Ao serviço da análise para nova análise.";
        }
        // DESPACHO 11 - 50 dias e o profissional não atendeu as exigencias
        else if (tipoTramite.Equals(11))
        {
            despacho += "Processo com 50 (cinquenta) dias de análise, sem qualquer tramitação. Conforme artigo 35, " +
                        "parágrafo 2º da Lei 1866/79 (Código de Obras) " +
                        "Não sendo atendidas as exigências no prazo de 60 " +
                        "(sessenta) dias, a contar da data do último trâmite de exigência, o processo será INDEFERIDO. " +
                        "DATA DO ÚLTIMO TRÂMITE DE EXIGÊNCIA: " +  FormatarData((DateTime)projeto.Dataulttram);
        }
        // DESPACHO 12 - Projeto é Indeferido (60 dias de inatividade)
        else if (tipoTramite.Equals(12))
        {
            despacho += "Processo com 60 (sessenta) dias de análise, sem qualquer tramitação. Conforme artigo 35, " +
                    "parágrafo 2º da Lei 1866/79 (Código de Obras) " +
                    "Não sendo atendidas as exigências no prazo de 60 " +
                    "(sessenta) dias, a contar da data do último trâmite de exigência, o processo será INDEFERIDO. " +
                    "DATA DO ÚLTIMO TRÂMITE DE EXIGÊNCIA: " +  FormatarData((DateTime)projeto.Dataulttram);
        }
        // DESPACHO 13 - Projeto é Indeferido (Triagem)
        else if (tipoTramite.Equals(13))
        {
            despacho += "Projeto indeferido pela PMCG na triagem.";
        }

        // DESPACHO 14 - Processo é Aberto (Texto de Abertura do projeto é um tramite)
        else if (tipoTramite.Equals(14))
        {
            despacho += "De " + projeto.AtividadeNavigation.Nome + " no Lote " + projeto.Lote + " Quadra " + projeto.Quadra +
                        " do Bairro " + projeto.Bairro+ ", conforme documentos em anexo. OBS.: Na retirada dos documentos, n&atilde;o poder&aacute; existir d&eacute;bitos na inscri&ccedil;&atilde;o " +
                        "do im&oacute;vel e nem do profissional respons&aacute;vel.";
        }
        // DESPACHO 15 - Remessa eh Despachada
        else if (tipoTramite.Equals(15))
        {
            despacho += "Processo em tramitação.\n SITUAÇÃO: REMESSA REPASSADA.\n";
        }
        // DESPACHO 16 - Projeto enviado para avaliacao (Avaliação)
        else if (tipoTramite.Equals(16))
        {
            despacho += "Processo em tramitação.\n SITUAÇÃO: EM AVALIAÇÃO.\n";
        }
        // DESPACHO 17 - Projeto avaliado (com Analista)
        else if (tipoTramite.Equals(17))
        {
            despacho += "Processo em tramitação.\n SITUAÇÃO: REPASSADO PARA ANÁLISE.\n";
        }
        // DESPACHO 18 - Projeto Cancelado/SUBSTITUIDO
        else if (tipoTramite.Equals(18))
        {
            despacho += "Projeto cancelado ou substituido.";
        }
        else if (tipoTramite.Equals(19))
        {
            despacho += "Projeto Arquitetônico PROC: " + projeto.Processo + ", encaminhado ao setor de vistoria.";
        }
        else if (tipoTramite.Equals(20))
        {
            despacho += "Processo com 70 (sessenta) dias de análise, sem qualquer tramitação. " +
                    "Não sendo atendidas as exigências no prazo de 70 " +
                    "(sessenta) dias, a contar da data do último trâmite de exigência, o processo será INDEFERIDO. " +
                    "DATA DO ÚLTIMO TRÂMITE DE EXIGÊNCIA: " +  FormatarData((DateTime)projeto.Dataulttram);
        }
        else if (tipoTramite.Equals(21))
        {
            despacho += "Processo com 170 (sessenta) dias de análise, sem qualquer tramitação. " +
                    "Não sendo atendidas as exigências no prazo de 180 " +
                    "(sessenta) dias, a contar da data do último trâmite de exigência, o processo será INDEFERIDO. " +
                    "DATA DO ÚLTIMO TRÂMITE DE EXIGÊNCIA: " +  FormatarData((DateTime)projeto.Dataulttram);
        }
        else if (tipoTramite.Equals(22))
        {
            despacho += "Processo com 180 (sessenta) dias de análise, sem qualquer tramitação. " +
                    "Não sendo atendidas as exigências no prazo de 180 " +
                    "(sessenta) dias, a contar da data do último trâmite de exigência, o processo será INDEFERIDO. " +
                    "DATA DO ÚLTIMO TRÂMITE DE EXIGÊNCIA: " +  FormatarData((DateTime)projeto.Dataulttram);
        }

        return despacho;
    }

    public async Task GerarHistoricoTramiteProcesso(Projeto projeto, String despacho, String autor, int? tipotramite, CancellationToken cancellationToken)
    {
        int sequencia = 0;
        var historicos = projeto.Historicos.ToList().OrderByDescending(o => o.Sequencia);
        sequencia = (historicos.Count() > 0)?  historicos.First().Sequencia + 1 : 1;
        var historico = new Historico();
        if (tipotramite == 11 || tipotramite == 12)
        { // 55 DIAS e 60 DIAS
          // historicoDAO.setPermited(true); //não sei ainda pra q é isso
            historico.Grupoaud = 0;
            historico.Unidadeaud = 0;
            historico.Usuarioaud = 0;
            historico.Version = 0;
        }
        historico.Datahora = DateTime.Now;
        historico.Sequencia = sequencia;
        historico.Despacho = despacho;
        historico.Autor = autor;
     //   projeto.Historicos = new List<Historico>() ;
        projeto.Historicos.Add(historico);

        //  _historyRepository.Create(historico);
        _repository.Update(projeto);


    }

    /* 
     * public Boolean gerarHistoricoTramiteProcesso(Projeto projeto, String despacho, String autor, Integer tipotramite) throws Exception {
			Integer sequencia = null;
			// BUSCANDO A NOVA SEQUENCIA
			Criteria crit = HibernateUtil.getCurrentSession().createCriteria(Historico.class);
			crit.add(Restrictions.eq("projeto", projeto));
			crit.addOrder(Order.desc("sequencia"));
			List<Historico> listaHistorico = crit.list();
			if(listaHistorico.size()>0)
				sequencia = listaHistorico.get(0).getSequencia()+1;
			else
				sequencia = 1;
			
			HistoricoDAO historicoDAO = new HistoricoHibernateDAO();
			Historico historico = new Historico();
			if(tipotramite == 11 || tipotramite == 12){ // 55 DIAS e 60 DIAS
				historicoDAO.setPermited(true);
				historico.setGrupoaud(0);
				historico.setUnidadeaud(0);
				historico.setUsuarioaud(0);
				historico.setVersion(0);
			}
			// Seta os atributos do historico do projeto
			historico.setProjeto(projeto);
			historico.setDatahora(new java.sql.Timestamp(today.getTime()));
			historico.setSequencia(sequencia);
			historico.setDespacho(despacho);
			historico.setAutor(autor);
// Salvando o Historico
			historicoDAO.saveOrUpdate(historico);
			return true;
	}
    */
}


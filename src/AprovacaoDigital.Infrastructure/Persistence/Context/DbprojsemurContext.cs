using AprovacaoDigital.Domain.Entities;
using AprovacaoDigital.Infrastructure.Persistence.Configurations;
using AprovacaoDigital.Infrastructure.Persistence.Seeds;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace AprovacaoDigital.Infrastructure.Persistence.Context;

public partial class DbprojsemurContext : DbContext
{
    public IConfiguration Configuration { get; private set; }
    public DbprojsemurContext()
    {
    }

    public DbprojsemurContext(DbContextOptions<DbprojsemurContext> options, IConfiguration _configuration) : base(options)
    {
        Configuration = _configuration;

    }
    #region DataSets
    public virtual DbSet<Analiseprojeto> Analiseprojetos { get; set; }

    public virtual DbSet<Analistum> Analista { get; set; }

    public virtual DbSet<Analistum1> Analista1 { get; set; }

    public virtual DbSet<AreaReceptora> Areareceptoras { get; set; }

    public virtual DbSet<Areareceptora1> Areareceptoras1 { get; set; }

    public virtual DbSet<Armazenamento> Armazenamentos { get; set; }

    public virtual DbSet<Arquivo> Arquivos { get; set; }

    public virtual DbSet<Arquivo1> Arquivos1 { get; set; }

    public virtual DbSet<Arquivo2> Arquivos2 { get; set; }

    public virtual DbSet<Arquivousuario> Arquivousuarios { get; set; }

    public virtual DbSet<Assunto> Assuntos { get; set; }

    public virtual DbSet<Assunto1> Assuntos1 { get; set; }

    public virtual DbSet<Atividade> Atividades { get; set; }

    public virtual DbSet<Audit> Audits { get; set; }

    public virtual DbSet<Audit1> Audits1 { get; set; }

    public virtual DbSet<Aviso> Avisos { get; set; }

    public virtual DbSet<Bairro> Bairros { get; set; }

    public virtual DbSet<Bairro1> Bairros1 { get; set; }

    public virtual DbSet<Bemvindo> Bemvindos { get; set; }

    public virtual DbSet<Caracteristica> Caracteristicas { get; set; }

    public virtual DbSet<Caracteristicaemp> Caracteristicaemps { get; set; }

    public virtual DbSet<Certidao> Certidaos { get; set; }

    public virtual DbSet<Certidaoconformidade> Certidaoconformidades { get; set; }

    public virtual DbSet<Cidade> Cidades { get; set; }

    public virtual DbSet<Classe> Classes { get; set; }

    public virtual DbSet<Classificacao> Classificacaos { get; set; }

    public virtual DbSet<Classificacao1> Classificacaos1 { get; set; }

    public virtual DbSet<Codificacao> Codificacaos { get; set; }

    public virtual DbSet<Comunicado> Comunicados { get; set; }

    public virtual DbSet<Contratado> Contratados { get; set; }

    public virtual DbSet<Controleresiduo> Controleresiduos { get; set; }

    public virtual DbSet<Ctr> Ctrs { get; set; }

    public virtual DbSet<Ctr1> Ctrs1 { get; set; }

    public virtual DbSet<Ctrresiduo> Ctrresiduos { get; set; }

    public virtual DbSet<DestinoFinal> Destinofinals { get; set; }

    public virtual DbSet<Documento> Documentos { get; set; }

    public virtual DbSet<Documento1> Documentos1 { get; set; }

    public virtual DbSet<Empresa> Empresas { get; set; }

    public virtual DbSet<Empresa1> Empresas1 { get; set; }

    public virtual DbSet<Empresa2> Empresas2 { get; set; }

    public virtual DbSet<Empresaresiduo> Empresaresiduos { get; set; }

    public virtual DbSet<Endereco> Enderecos { get; set; }

    public virtual DbSet<Entidade> Entidades { get; set; }

    public virtual DbSet<Estadofisico> Estadofisicos { get; set; }

    public virtual DbSet<Evento> Eventos { get; set; }

    public virtual DbSet<Exigencia> Exigencia { get; set; }

    public virtual DbSet<Extrato> Extratos { get; set; }

    public virtual DbSet<Faseobra> Faseobras { get; set; }

    public virtual DbSet<Fiscal> Fiscals { get; set; }

    public virtual DbSet<Fonterecurso> Fonterecursos { get; set; }

    public virtual DbSet<Grupo> Grupos { get; set; }

    public virtual DbSet<Grupousuario> Grupousuarios { get; set; }

    public virtual DbSet<Historico> Historicos { get; set; }

    public virtual DbSet<Logacesso> Logacessos { get; set; }

    public virtual DbSet<Logradouro> Logradouros { get; set; }

    public virtual DbSet<Logsistema> Logsistemas { get; set; }

    public virtual DbSet<Mensagem> Mensagems { get; set; }

    public virtual DbSet<Ministerio> Ministerios { get; set; }

    public virtual DbSet<Modulo> Modulos { get; set; }

    public virtual DbSet<Modulogrupo> Modulogrupos { get; set; }

    public virtual DbSet<Modulosistema> Modulosistemas { get; set; }

    public virtual DbSet<Modulosistemausuario> Modulosistemausuarios { get; set; }

    public virtual DbSet<Natureza> Naturezas { get; set; }

    public virtual DbSet<Nomecoluna> Nomecolunas { get; set; }

    public virtual DbSet<Numeroprocesso> Numeroprocessos { get; set; }

    public virtual DbSet<Obra> Obras { get; set; }

    public virtual DbSet<Obraandamento> Obraandamentos { get; set; }

    public virtual DbSet<Obradatum> Obradata { get; set; }

    public virtual DbSet<Obraevento> Obraeventos { get; set; }

    public virtual DbSet<Obraparlamentar> Obraparlamentars { get; set; }

    public virtual DbSet<Ocorrencium> Ocorrencia { get; set; }

    public virtual DbSet<Parlamentar> Parlamentars { get; set; }

    public virtual DbSet<Pedidoped> Pedidopeds { get; set; }

    public virtual DbSet<Permissaoentidade> Permissaoentidades { get; set; }

    public virtual DbSet<Pessoa> Pessoas { get; set; }

    public virtual DbSet<Prfage> Prfages { get; set; }

    public virtual DbSet<PrfageTmp> PrfageTmps { get; set; }

    public virtual DbSet<Profissional> Profissionals { get; set; }

    public virtual DbSet<Profissional1> Profissionals1 { get; set; }

    public virtual DbSet<Projeto> Projetos { get; set; }

    public virtual DbSet<Projeto1> Projetos1 { get; set; }

    public virtual DbSet<Projeto2> Projetos2 { get; set; }

    public virtual DbSet<ProjetoAnistium> ProjetoAnistia { get; set; }

    public virtual DbSet<Projetoana> Projetoanas { get; set; }

    public virtual DbSet<Projetoin> Projetoins { get; set; }

    public virtual DbSet<Proprietario> Proprietarios { get; set; }

    public virtual DbSet<Recibo> Recibos { get; set; }

    public virtual DbSet<Recurso> Recursos { get; set; }

    public virtual DbSet<Regiao> Regiaos { get; set; }

    public virtual DbSet<Regiaourbana> Regiaourbanas { get; set; }

    public virtual DbSet<Regiaourbana1> Regiaourbanas1 { get; set; }

    public virtual DbSet<Relatorio> Relatorios { get; set; }

    public virtual DbSet<Relobra> Relobras { get; set; }

    public virtual DbSet<Remessa> Remessas { get; set; }

    public virtual DbSet<Remessa1> Remessas1 { get; set; }

    public virtual DbSet<Remessaexigencia> Remessaexigencia { get; set; }

    public virtual DbSet<Requerimento> Requerimentos { get; set; }

    public virtual DbSet<Residuo> Residuos { get; set; }

    public virtual DbSet<Residuo1> Residuos1 { get; set; }

    public virtual DbSet<Residuoarea> Residuoareas { get; set; }

    public virtual DbSet<Residuocaracteristica> Residuocaracteristicas { get; set; }

    public virtual DbSet<ResiduosAreareceptora> ResiduosAreareceptoras { get; set; }

    public virtual DbSet<ResiduosArmazenamento> ResiduosArmazenamentos { get; set; }

    public virtual DbSet<ResiduosCtr> ResiduosCtrs { get; set; }

    public virtual DbSet<ResiduosCtrresiduo> ResiduosCtrresiduos { get; set; }

    public virtual DbSet<ResiduosEmpresa> ResiduosEmpresas { get; set; }

    public virtual DbSet<ResiduosEstadofisico> ResiduosEstadofisicos { get; set; }

    public virtual DbSet<ResiduosResiduo> ResiduosResiduos { get; set; }

    public virtual DbSet<ResiduosTransportadora> ResiduosTransportadoras { get; set; }

    public virtual DbSet<ResiduosUnidade> ResiduosUnidades { get; set; }

    public virtual DbSet<Revinfo> Revinfos { get; set; }

    public virtual DbSet<Rua> Ruas { get; set; }

    public virtual DbSet<Sistema> Sistemas { get; set; }

    public virtual DbSet<Sistemacontexto> Sistemacontextos { get; set; }

    public virtual DbSet<Situacao> Situacaos { get; set; }

    public virtual DbSet<Situacao1> Situacaos1 { get; set; }

    public virtual DbSet<Status> Statuses { get; set; }

    public virtual DbSet<Status1> Statuses1 { get; set; }

    public virtual DbSet<Status2> Statuses2 { get; set; }

    public virtual DbSet<Tema> Temas { get; set; }


    public virtual DbSet<Tipoarquivo> Tipoarquivos { get; set; }

    public virtual DbSet<TipoArquivoAgenda> Tipoarquivos1 { get; set; }

    public virtual DbSet<Tipocontrole> Tipocontroles { get; set; }

    public virtual DbSet<Tipologradouro> Tipologradouros { get; set; }

    public virtual DbSet<Tipomandato> Tipomandatos { get; set; }

    public virtual DbSet<Tipounidade> Tipounidades { get; set; }

    public virtual DbSet<Tipoveiculodivulgacao> Tipoveiculodivulgacaos { get; set; }

    public virtual DbSet<Tmpbairroregiao> Tmpbairroregiaos { get; set; }

    public virtual DbSet<Tmpproc> Tmpprocs { get; set; }

    public virtual DbSet<Transportador> Transportadors { get; set; }

    public virtual DbSet<Transportadora> Transportadoras { get; set; }

    public virtual DbSet<Transportadoraresiduo> Transportadoraresiduos { get; set; }

    public virtual DbSet<Unidade> Unidades { get; set; }

    public virtual DbSet<Unidade1> Unidades1 { get; set; }

    public virtual DbSet<Unidadeusuario> Unidadeusuarios { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<Usuariocargo> Usuariocargos { get; set; }

    public virtual DbSet<UsuariosAdmin> UsuariosAdmins { get; set; }

    public virtual DbSet<Usuariosistema> Usuariosistemas { get; set; }

    public virtual DbSet<Valorcoluna> Valorcolunas { get; set; }

    public virtual DbSet<Veiculodivulgacao> Veiculodivulgacaos { get; set; }

    public virtual DbSet<Zoneamento> Zoneamentos { get; set; }

    #endregion

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("Server=10.0.0.211;Database=DBPROJSEMUR;Port=5432;User Id=upsemur;Password=up14semur20").EnableSensitiveDataLogging();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        InitialConfiguration.ModelBuilder(modelBuilder);
        #region Gerar Seeds
        //TesteSeeds.Configure(modelBuilder);
        Status1Seeds.Configure(modelBuilder);
        #endregion

    
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

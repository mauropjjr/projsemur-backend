using System;
using System.Collections.Generic;
using System.Reflection;
using AprovacaoDigital.Domain.Entities;
using AprovacaoDigital.Infrastructure.Persistence.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

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
        => optionsBuilder.UseNpgsql("Server=10.0.0.211;Database=DBPROJSEMUR;Port=5432;User Id=upsemur;Password=up14semur20");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        InitialConfiguration.ModelBuilder(modelBuilder);
        #region Gerar Seeds
        //TesteSeeds.Configure(modelBuilder);
        #endregion

        //#region Mapeamentos da migração

        //modelBuilder.UseCollation("pt_BR.UTF-8");

        //modelBuilder.Entity<Analiseprojeto>(entity =>
        //{
        //    entity.HasKey(e => e.Analiseprojetoid).HasName("analiseprojeto_pkey");

        //    entity.ToTable("analiseprojeto", "agenda");

        //    entity.Property(e => e.Analiseprojetoid).HasColumnName("analiseprojetoid");
        //    entity.Property(e => e.Analista).HasColumnName("analista");
        //    entity.Property(e => e.Codificacao).HasColumnName("codificacao");
        //    entity.Property(e => e.Datahora)
        //        .HasColumnType("character varying")
        //        .HasColumnName("datahora");
        //    entity.Property(e => e.Grupoaud)
        //        .HasDefaultValue(0)
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Numeroanalise).HasColumnName("numeroanalise");
        //    entity.Property(e => e.Numeroanalisereal).HasColumnName("numeroanalisereal");
        //    entity.Property(e => e.Projeto).HasColumnName("projeto");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasDefaultValue(0)
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasColumnName("version");

        //    entity.HasOne(d => d.AnalistaNavigation).WithMany(p => p.Analiseprojetos)
        //        .HasForeignKey(d => d.Analista)
        //        .HasConstraintName("analiseprojeto_fk1");

        //    entity.HasOne(d => d.CodificacaoNavigation).WithMany(p => p.Analiseprojetos)
        //        .HasForeignKey(d => d.Codificacao)
        //        .HasConstraintName("analiseprojeto_fk2");

        //    entity.HasOne(d => d.ProjetoNavigation).WithMany(p => p.Analiseprojetos)
        //        .HasForeignKey(d => d.Projeto)
        //        .HasConstraintName("analiseprojeto_fk");
        //});

        //modelBuilder.Entity<Analistum>(entity =>
        //{
        //    entity.HasKey(e => e.Analistaid).HasName("analista_pkey");

        //    entity.ToTable("analista", "agenda");

        //    entity.Property(e => e.Analistaid).HasColumnName("analistaid");
        //    entity.Property(e => e.Atividade).HasColumnName("atividade");
        //    entity.Property(e => e.Codigomainframe).HasColumnName("codigomainframe");
        //    entity.Property(e => e.Dataexclusao).HasColumnName("dataexclusao");
        //    entity.Property(e => e.Flagativo).HasColumnName("flagativo");
        //    entity.Property(e => e.Grupo).HasColumnName("grupo");
        //    entity.Property(e => e.Grupoaud)
        //        .HasDefaultValue(0)
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Legenda)
        //        .HasColumnType("character varying")
        //        .HasColumnName("legenda");
        //    entity.Property(e => e.Nome)
        //        .HasMaxLength(250)
        //        .HasColumnName("nome");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuario)
        //        .HasDefaultValue(0)
        //        .HasColumnName("usuario");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasDefaultValue(0)
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasColumnName("version");
        //});

        //modelBuilder.Entity<Analistum1>(entity =>
        //{
        //    entity.HasKey(e => e.Analistaid).HasName("analista_pkey");

        //    entity.ToTable("analista", "cartografia");

        //    entity.Property(e => e.Analistaid)
        //        .HasComment("Código do analista")
        //        .HasColumnName("analistaid");
        //    entity.Property(e => e.Codmain)
        //        .HasComment("Código do analista no cadastro do mainframe, tem que estar correto para EXPORTAÇÃO DOS PROJ para o MAINFRAME")
        //        .HasColumnName("codmain");
        //    entity.Property(e => e.Nome)
        //        .HasMaxLength(100)
        //        .HasComment("Nome do analista")
        //        .HasColumnName("nome");
        //});

        //modelBuilder.Entity<Areareceptora>(entity =>
        //{
        //    entity.HasKey(e => e.Areareceptoraid).HasName("areareceptora_pkey");

        //    entity.ToTable("areareceptora", "agenda", tb => tb.HasComment("template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Área Receptora]\r\nfiltersgrid[#text_filter,#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Áreas Receptoras]"));

        //    entity.Property(e => e.Areareceptoraid)
        //        .HasComment("forminputlabel[Código]\r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("areareceptoraid");
        //    entity.Property(e => e.Ativo)
        //        .HasDefaultValue(0)
        //        .HasColumnName("ativo");
        //    entity.Property(e => e.Bairro)
        //        .HasMaxLength(100)
        //        .HasComment("forminputlabel[Bairro]\r\nforminputsize[30]\r\nforminputclass[uppercase]\r\n\r\ngeragridmain[false]")
        //        .HasColumnName("bairro");
        //    entity.Property(e => e.Endereco)
        //        .HasMaxLength(300)
        //        .HasComment("forminputlabel[Endereço]\r\nforminputsize[30]\r\nforminputclass[uppercase]\r\n\r\ngeragridmain[false]")
        //        .HasColumnName("endereco");
        //    entity.Property(e => e.Grupoaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Latitude)
        //        .HasMaxLength(50)
        //        .HasComment("forminputlabel[latitude]\r\nforminputsize[10]\r\nforminputclass[ro]\r\n\r\ngeragridmain[false]")
        //        .HasColumnName("latitude");
        //    entity.Property(e => e.Longitude)
        //        .HasMaxLength(50)
        //        .HasComment("forminputlabel[longitude]\r\nforminputsize[10]\r\nforminputclass[ro]\r\n\r\ngeragridmain[false]")
        //        .HasColumnName("longitude");
        //    entity.Property(e => e.Nome)
        //        .HasMaxLength(200)
        //        .HasComment("forminputlabel[Nome]\r\nforminputsize[50]\r\nforminputclass[uppercase]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Nome]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("nome");
        //    entity.Property(e => e.Numero)
        //        .HasComment("forminputlabel[N°]\r\nforminputsize[10]\r\nforminputclass[number]\r\n\r\ngeragridmain[false]")
        //        .HasColumnName("numero");
        //    entity.Property(e => e.Numerolicenca)
        //        .HasMaxLength(100)
        //        .HasComment("forminputlabel[N° Licença]\r\nforminputsize[20]\r\nforminputclass[number]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[N° Licença]\r\ncolumngridtype[ro]\r\ncolumngridsize[120]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("numerolicenca");
        //    entity.Property(e => e.Regiao).HasColumnName("regiao");
        //    entity.Property(e => e.Telefone)
        //        .HasMaxLength(50)
        //        .HasComment("forminputlabel[Telefone]\r\nforminputsize[12]\r\nforminputclass[phone]\r\n\r\ngeragridmain[false]")
        //        .HasColumnName("telefone");
        //    entity.Property(e => e.Tipo)
        //        .HasComment("0-Ecoponto / 1-Ponto-Apoio\r\n\r\nforminputlabel[Tipo]\r\nforminputsize[30]\r\nforminputclass[required]\r\n\r\ngeragridmain[false]")
        //        .HasColumnName("tipo");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("version");
        //});

        //modelBuilder.Entity<Areareceptora1>(entity =>
        //{
        //    entity.HasKey(e => e.Areareceptoraid).HasName("areareceptora_pkey");

        //    entity.ToTable("areareceptora", "residuos", tb => tb.HasComment("template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs]\r\n\r\nformtitle[Cadastro de Área Receptora]\r\nfiltersgrid[#text_filter,#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Áreas Receptoras]"));

        //    entity.HasIndex(e => e.Inscricaomunicipal, "areareceptora_idx");

        //    entity.Property(e => e.Areareceptoraid)
        //        .HasComment("forminputlabel[Código]\r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("areareceptoraid");
        //    entity.Property(e => e.Bairro)
        //        .HasMaxLength(255)
        //        .HasColumnName("bairro");
        //    entity.Property(e => e.Cep)
        //        .HasMaxLength(8)
        //        .HasColumnName("cep");
        //    entity.Property(e => e.Codigo)
        //        .HasComment("forminputlabel[Código]\r\nforminputsize[10]\r\nforminputclass[number]\r\n\r\ngeragridmain[false]")
        //        .HasColumnName("codigo");
        //    entity.Property(e => e.Complemento)
        //        .HasMaxLength(200)
        //        .HasColumnName("complemento");
        //    entity.Property(e => e.Empresa).HasColumnName("empresa");
        //    entity.Property(e => e.Grupoaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]")
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Inscricaomunicipal)
        //        .HasPrecision(11)
        //        .HasComment("forminputlabel[Inscrição Municipal]\r\nforminputsize[15]\r\nforminputclass[inscricaomunicipal]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Inscrição Municipal]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("inscricaomunicipal");
        //    entity.Property(e => e.Licencaambiental)
        //        .HasMaxLength(20)
        //        .HasColumnName("licencaambiental");
        //    entity.Property(e => e.Nome)
        //        .HasComment("forminputlabel[Nome]\r\nforminputsize[50]\r\nforminputclass[uppercase]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Nome]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnType("character varying")
        //        .HasColumnName("nome");
        //    entity.Property(e => e.Numero)
        //        .HasMaxLength(10)
        //        .HasColumnName("numero");
        //    entity.Property(e => e.Rua)
        //        .HasColumnType("character varying")
        //        .HasColumnName("rua");
        //    entity.Property(e => e.Senha)
        //        .HasColumnType("character varying")
        //        .HasColumnName("senha");
        //    entity.Property(e => e.Situacao)
        //        .HasComment("forminputlabel[Situação]\r\nforminputsize[10]\r\n\r\ngeragridmain[false]")
        //        .HasColumnName("situacao");
        //    entity.Property(e => e.Telefone)
        //        .HasColumnType("character varying")
        //        .HasColumnName("telefone");
        //    entity.Property(e => e.Transportadora).HasColumnName("transportadora");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]")
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuario).HasColumnName("usuario");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]")
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Validadelicenca).HasColumnName("validadelicenca");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]")
        //        .HasColumnName("version");

        //    entity.HasOne(d => d.EmpresaNavigation).WithMany(p => p.Areareceptora1s)
        //        .HasForeignKey(d => d.Empresa)
        //        .HasConstraintName("areareceptora_fk");

        //    entity.HasOne(d => d.TransportadoraNavigation).WithMany(p => p.Areareceptora1s)
        //        .HasForeignKey(d => d.Transportadora)
        //        .HasConstraintName("areareceptora_fk1");
        //});

        //modelBuilder.Entity<Armazenamento>(entity =>
        //{
        //    entity.HasKey(e => e.Armazenamentoid).HasName("armazenamento_pkey");

        //    entity.ToTable("armazenamento", "residuos", tb => tb.HasComment("template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs]\r\n\r\nformtitle[Cadastro de Armazenamento]\r\nfiltersgrid[#text_filter,#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Armazenamentos]"));

        //    entity.Property(e => e.Armazenamentoid)
        //        .HasComment("forminputlabel[Código]\r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("armazenamentoid");
        //    entity.Property(e => e.Grupoaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]")
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Nome)
        //        .HasComment("forminputlabel[Nome]\r\nforminputsize[50]\r\nforminputclass[uppercase]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Nome]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnType("character varying")
        //        .HasColumnName("nome");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]")
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]")
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]")
        //        .HasColumnName("version");
        //});

        //modelBuilder.Entity<Arquivo>(entity =>
        //{
        //    entity.HasKey(e => e.Arquivoid).HasName("arquivo_pk");

        //    entity.ToTable("arquivo", tb => tb.HasComment("template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Arquivo]\r\nfieldsgrid[arquivoid,nome,url,modulo.nome:arquivoid]\r\nfiltersgrid[#text_filter,#text_filter,#text_filter,#text_filter] \r\n\r\nfieldsform[arquivoid,nome,url,modulo.moduloid,modulo.nome] \r\n\r\ngridtitle[Lista de Arquivos]\r\n\r\n"));

        //    entity.Property(e => e.Arquivoid)
        //        .HasComment("forminputlabel[Código] \r\nforminputsize[7]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Código] \r\ncolumngridtype[ro] \r\ncolumngridsize[80] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnName("arquivoid");
        //    entity.Property(e => e.Grupoaud).HasColumnName("grupoaud");
        //    entity.Property(e => e.Modulosistema)
        //        .HasComment("forminputlabel[Módulo Sistema]\r\nforminputsize[250]\r\n\r\nsearchmode[combobox]\r\ncomboboxresultfield[modulo.nome]\r\n\r\ncolumngridid[modulosistema.modulo.nome]\r\ncolumngridtitle[Módulo Sistema]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("modulosistema");
        //    entity.Property(e => e.Nome)
        //        .HasMaxLength(250)
        //        .HasComment("forminputlabel[Nome] \r\nforminputsize[50]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Nome] \r\ncolumngridtype[ro] \r\ncolumngridsize[*] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnName("nome");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Url)
        //        .HasMaxLength(500)
        //        .HasComment("forminputlabel[URL] \r\nforminputsize[50]")
        //        .HasColumnName("url");
        //    entity.Property(e => e.Usuarioaud).HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version).HasColumnName("version");

        //    entity.HasOne(d => d.ModulosistemaNavigation).WithMany(p => p.Arquivos)
        //        .HasForeignKey(d => d.Modulosistema)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("arquivo_fk");
        //});

        //modelBuilder.Entity<Arquivo1>(entity =>
        //{
        //    entity.HasKey(e => e.Arquivoid).HasName("arquivo_pkey");

        //    entity.ToTable("arquivo", "cartografia");

        //    entity.Property(e => e.Arquivoid)
        //        .HasComment("Código do arquivo")
        //        .HasColumnName("arquivoid");
        //    entity.Property(e => e.Conteudo)
        //        .HasComment("Conteudo do arquivo")
        //        .HasColumnName("conteudo");
        //    entity.Property(e => e.Tipoarquivo)
        //        .HasComment("Tipo do arquivo")
        //        .HasColumnName("tipoarquivo");

        //    entity.HasOne(d => d.TipoarquivoNavigation).WithMany(p => p.Arquivo1s)
        //        .HasForeignKey(d => d.Tipoarquivo)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("arquivo_fk");
        //});

        //modelBuilder.Entity<Arquivo2>(entity =>
        //{
        //    entity.HasKey(e => e.Arquivoid).HasName("arquivo_pkey");

        //    entity.ToTable("arquivo", "agenda");

        //    entity.Property(e => e.Arquivoid).HasColumnName("arquivoid");
        //    entity.Property(e => e.Caminho)
        //        .HasColumnType("character varying")
        //        .HasColumnName("caminho");
        //    entity.Property(e => e.Conteudo).HasColumnName("conteudo");
        //    entity.Property(e => e.Grupoaud)
        //        .HasDefaultValue(0)
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Tipoarquivo).HasColumnName("tipoarquivo");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasDefaultValue(0)
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasColumnName("version");

        //    entity.HasOne(d => d.TipoarquivoNavigation).WithMany(p => p.Arquivo2s)
        //        .HasForeignKey(d => d.Tipoarquivo)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("arquivo_fk");
        //});

        //modelBuilder.Entity<Arquivousuario>(entity =>
        //{
        //    entity.HasKey(e => e.Arquivousuarioid).HasName("arquivousuario_pk");

        //    entity.ToTable("arquivousuario", tb => tb.HasComment("template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]  \r\n\r\nformtitle[Cadastro de Arquivo / Usuário]   \r\nfieldsgrid[arquivousuarioid,usuario.nome,arquivo.url,permissao.nome:arquivousuarioid] \r\n\r\nfieldsform[arquivousuarioid,usuario.usuarioid,usuario.nome,arquivo.arquivoid,arquivo.url,permissao.permissaoid,permissao.nome] \r\n\r\ngridtitle[Lista de Arquivos / Usuário]"));

        //    entity.Property(e => e.Arquivousuarioid)
        //        .HasComment("forminputlabel[Código] forminputsize[7]  columngridid[] columngridtitle[Código] columngridtype[ro] columngridsize[80] columngridalign[left] columngridcolor[white]")
        //        .HasColumnName("arquivousuarioid");
        //    entity.Property(e => e.Arquivo)
        //        .HasComment("forminputlabel[Arquivo]\r\nforminputsize[250]\r\n\r\nsearchmode[popup]\r\npopupresultfield[nome]\r\npopupfieldsgrid[arquivoid,nome,url,modulo.nome:arquivoid]\r\n\r\ncolumngridid[arquivo.nome]\r\ncolumngridtitle[Arquivo]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("arquivo");
        //    entity.Property(e => e.Denyarquivo)
        //        .HasComment("forminputlabel[DenyArquivo]\r\nforminputsize[50]\r\n\r\ngeragridmain[false]")
        //        .HasColumnType("character varying")
        //        .HasColumnName("denyarquivo");
        //    entity.Property(e => e.Grantarquivo)
        //        .HasComment("forminputlabel[GrantArquivo]\r\nforminputsize[50]\r\n\r\ngeragridmain[false]")
        //        .HasColumnType("character varying")
        //        .HasColumnName("grantarquivo");
        //    entity.Property(e => e.Grupoaud).HasColumnName("grupoaud");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuario)
        //        .HasComment("forminputlabel[Usuário]\r\nforminputsize[50]\r\n\r\nsearchmode[popup]\r\npopupresultfield[nome]\r\npopupfieldsgrid[usuarioid,nome,login,senha:usuarioid]\r\n\r\ncolumngridid[usuario.nome]\r\ncolumngridtitle[Usuário]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("usuario");
        //    entity.Property(e => e.Usuarioaud).HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasColumnName("version");

        //    entity.HasOne(d => d.ArquivoNavigation).WithMany(p => p.Arquivousuarios)
        //        .HasForeignKey(d => d.Arquivo)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("arquivo_arquivousuario_fk");

        //    entity.HasOne(d => d.UsuarioNavigation).WithMany(p => p.Arquivousuarios)
        //        .HasForeignKey(d => d.Usuario)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("usuario_arquivousuario_fk");
        //});

        //modelBuilder.Entity<Assunto>(entity =>
        //{
        //    entity.HasKey(e => e.Assuntoid).HasName("assunto_pkey");

        //    entity.ToTable("assunto", "cartografia");

        //    entity.Property(e => e.Assuntoid)
        //        .HasComment("Código do assunto")
        //        .HasColumnName("assuntoid");
        //    entity.Property(e => e.Descricao)
        //        .HasMaxLength(100)
        //        .HasComment("Descrição do assunto")
        //        .HasColumnName("descricao");
        //});

        //modelBuilder.Entity<Assunto1>(entity =>
        //{
        //    entity.HasKey(e => e.Assuntoid).HasName("assunto_pkey");

        //    entity.ToTable("assunto", "agenda");

        //    entity.Property(e => e.Assuntoid)
        //        .ValueGeneratedNever()
        //        .HasColumnName("assuntoid");
        //    entity.Property(e => e.Grupoaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Nome)
        //        .HasColumnType("character varying")
        //        .HasColumnName("nome");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("version");
        //});

        //modelBuilder.Entity<Atividade>(entity =>
        //{
        //    entity.HasKey(e => e.Atividadeid).HasName("atividade_pkey");

        //    entity.ToTable("atividade", "agenda", tb => tb.HasComment("template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Atividade]\r\n\r\nfiltersgrid[#text_filter,#text_filter] \r\n\r\n\r\ngridtitle[Lista de Atividade]\r\n"));

        //    entity.Property(e => e.Atividadeid)
        //        .HasComment("forminputlabel[Código] \r\nforminputsize[7]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Código] \r\ncolumngridtype[ro] \r\ncolumngridsize[80] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnName("atividadeid");
        //    entity.Property(e => e.Grupoaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Nome)
        //        .HasComment("forminputlabel[Nome] \r\nforminputsize[70]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Nome] \r\ncolumngridtype[ro] \r\ncolumngridsize[*] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnType("character varying")
        //        .HasColumnName("nome");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("version");
        //});

        //modelBuilder.Entity<Audit>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("audit");

        //    entity.Property(e => e.Auditid).HasColumnName("auditid");
        //    entity.Property(e => e.Data)
        //        .HasColumnType("timestamp without time zone")
        //        .HasColumnName("data");
        //    entity.Property(e => e.Entidade).HasColumnName("entidade");
        //    entity.Property(e => e.Grupoaud).HasColumnName("grupoaud");
        //    entity.Property(e => e.Id).HasColumnName("id");
        //    entity.Property(e => e.Sistema).HasColumnName("sistema");
        //    entity.Property(e => e.Strjson)
        //        .HasColumnType("character varying")
        //        .HasColumnName("strjson");
        //    entity.Property(e => e.Tipomanutencao)
        //        .HasMaxLength(1)
        //        .HasColumnName("tipomanutencao");
        //    entity.Property(e => e.Unidadeaud).HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud).HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version).HasColumnName("version");
        //});

        //modelBuilder.Entity<Audit1>(entity =>
        //{
        //    entity.HasKey(e => e.Auditid).HasName("audit_pkey");

        //    entity.ToTable("audit", "agenda");

        //    entity.Property(e => e.Auditid).HasColumnName("auditid");
        //    entity.Property(e => e.Data)
        //        .HasColumnType("timestamp without time zone")
        //        .HasColumnName("data");
        //    entity.Property(e => e.Entidade).HasColumnName("entidade");
        //    entity.Property(e => e.Grupoaud).HasColumnName("grupoaud");
        //    entity.Property(e => e.Id).HasColumnName("id");
        //    entity.Property(e => e.Profissional)
        //        .HasColumnType("character varying")
        //        .HasColumnName("profissional");
        //    entity.Property(e => e.Sistema).HasColumnName("sistema");
        //    entity.Property(e => e.Strjson)
        //        .HasColumnType("character varying")
        //        .HasColumnName("strjson");
        //    entity.Property(e => e.Tipomanutencao)
        //        .HasMaxLength(1)
        //        .HasColumnName("tipomanutencao");
        //    entity.Property(e => e.Unidadeaud).HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud).HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version).HasColumnName("version");
        //});

        //modelBuilder.Entity<Aviso>(entity =>
        //{
        //    entity.HasKey(e => e.Avisoid).HasName("aviso_pkey");

        //    entity.ToTable("aviso");

        //    entity.Property(e => e.Avisoid)
        //        .HasDefaultValueSql("nextval(('\"public\".\"aviso_avisoid_seq\"'::text)::regclass)")
        //        .HasColumnName("avisoid");
        //    entity.Property(e => e.Datafinal)
        //        .HasColumnType("timestamp without time zone")
        //        .HasColumnName("datafinal");
        //    entity.Property(e => e.Datainicial)
        //        .HasColumnType("timestamp without time zone")
        //        .HasColumnName("datainicial");
        //    entity.Property(e => e.Grupo).HasColumnName("grupo");
        //    entity.Property(e => e.Grupoaud).HasColumnName("grupoaud");
        //    entity.Property(e => e.Mensagem).HasColumnName("mensagem");
        //    entity.Property(e => e.Sistema).HasColumnName("sistema");
        //    entity.Property(e => e.Situacao).HasColumnName("situacao");
        //    entity.Property(e => e.Unidade).HasColumnName("unidade");
        //    entity.Property(e => e.Unidadeaud).HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuario).HasColumnName("usuario");
        //    entity.Property(e => e.Usuarioaud).HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version).HasColumnName("version");
        //});

        //modelBuilder.Entity<Bairro>(entity =>
        //{
        //    entity.HasKey(e => e.Bairroid).HasName("bairro_pkey");

        //    entity.ToTable("bairro", tb => tb.HasComment("template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs]\r\n\r\nformtitle[Cadastro de Bairros]\r\n\r\nfiltersgrid[#text_filter,#text_filter]\r\ngridtitle[Lista de Bairros]"));

        //    entity.HasIndex(e => e.Nome, "bairro_nome_idx");

        //    entity.HasIndex(e => e.Estado, "bairro_uf_idx");

        //    entity.Property(e => e.Bairroid)
        //        .HasComment("forminputlabel[Código] \r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("bairroid");
        //    entity.Property(e => e.Abreviatura)
        //        .HasColumnType("character varying")
        //        .HasColumnName("abreviatura");
        //    entity.Property(e => e.Cidade).HasColumnName("cidade");
        //    entity.Property(e => e.Estado)
        //        .HasMaxLength(2)
        //        .HasColumnName("estado");
        //    entity.Property(e => e.Grupoaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Nome)
        //        .HasComment("forminputlabel[Nome]\r\nforminputsize[70]\r\nforminputclass[uppercase]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Nome]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnType("character varying")
        //        .HasColumnName("nome");
        //    entity.Property(e => e.Regiaourbana).HasColumnName("regiaourbana");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("version");

        //    entity.HasOne(d => d.RegiaourbanaNavigation).WithMany(p => p.Bairros)
        //        .HasForeignKey(d => d.Regiaourbana)
        //        .HasConstraintName("bairro_fk1");
        //});

        //modelBuilder.Entity<Bairro1>(entity =>
        //{
        //    entity.HasKey(e => e.Bairroid).HasName("bairro_pkey");

        //    entity.ToTable("bairro", "sisobra", tb => tb.HasComment("template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Bairro]\r\nfiltersgrid[#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Bairros]"));

        //    entity.Property(e => e.Bairroid)
        //        .HasComment("forminputlabel[Código] \r\nforminputsize[7]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Código] \r\ncolumngridtype[ro] \r\ncolumngridsize[80] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnName("bairroid");
        //    entity.Property(e => e.Grupoaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Nome)
        //        .HasComment("forminputlabel[Nome] \r\nforminputsize[70]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Nome] \r\ncolumngridtype[ro] \r\ncolumngridsize[*] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnType("character varying")
        //        .HasColumnName("nome");
        //    entity.Property(e => e.Regiaourbana)
        //        .HasComment("forminputlabel[Região Urbana] \r\nforminputsize[100]\r\n\r\nsearchmode[popup] \r\npopupresultfield[regiaourbana.nome]\r\npopupfieldsgrid[regiaourbanaid,nome]\r\n\r\ncolumngridid[] \r\ncolumngridtitle[Região Urbana] \r\ncolumngridtype[ro] \r\ncolumngridsize[100] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnName("regiaourbana");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("version");

        //    entity.HasOne(d => d.RegiaourbanaNavigation).WithMany(p => p.Bairro1s)
        //        .HasForeignKey(d => d.Regiaourbana)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("bairro_fk");
        //});

        //modelBuilder.Entity<Bemvindo>(entity =>
        //{
        //    entity.HasKey(e => e.Bemvindoid).HasName("bemvindo_pkey");

        //    entity.ToTable("bemvindo", "agenda");

        //    entity.Property(e => e.Bemvindoid).HasColumnName("bemvindoid");
        //    entity.Property(e => e.Ativo)
        //        .HasDefaultValue(0)
        //        .HasColumnName("ativo");
        //    entity.Property(e => e.Conteudo)
        //        .HasColumnType("character varying")
        //        .HasColumnName("conteudo");
        //    entity.Property(e => e.Datahora)
        //        .HasDefaultValueSql("now()")
        //        .HasColumnType("timestamp without time zone")
        //        .HasColumnName("datahora");
        //    entity.Property(e => e.Grupoaud)
        //        .HasDefaultValue(0)
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasDefaultValue(0)
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(1)
        //        .HasColumnName("version");
        //});

        //modelBuilder.Entity<Caracteristica>(entity =>
        //{
        //    entity.HasKey(e => e.Caracteristicaid).HasName("caracteristica_pkey");

        //    entity.ToTable("caracteristica", "residuos", tb => tb.HasComment("template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs]\r\n\r\nformtitle[Cadastro de Característica]\r\nfiltersgrid[#text_filter,#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Características]"));

        //    entity.Property(e => e.Caracteristicaid)
        //        .HasComment("forminputlabel[Código]\r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("caracteristicaid");
        //    entity.Property(e => e.Grupoaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]")
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Nome)
        //        .HasComment("forminputlabel[Nome]\r\nforminputsize[50]\r\nforminputclass[uppercase]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Nome]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnType("character varying")
        //        .HasColumnName("nome");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]")
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]")
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]")
        //        .HasColumnName("version");
        //});

        //modelBuilder.Entity<Caracteristicaemp>(entity =>
        //{
        //    entity.HasKey(e => e.Caracteristicaempid).HasName("caracteristicaemp_pkey");

        //    entity.ToTable("caracteristicaemp", "agenda", tb => tb.HasComment("template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Característica do Empreendimento]\r\nfiltersgrid[#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Características do Empreendimento]"));

        //    entity.Property(e => e.Caracteristicaempid)
        //        .HasComment("forminputlabel[Código]\r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("caracteristicaempid");
        //    entity.Property(e => e.Grupoaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Nome)
        //        .HasMaxLength(200)
        //        .HasComment("forminputlabel[Nome]\r\nforminputsize[50]\r\nforminputclass[uppercase]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Nome]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("nome");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("version");
        //});

        //modelBuilder.Entity<Certidao>(entity =>
        //{
        //    entity.HasKey(e => e.Certidaoid).HasName("ceridao_pkey");

        //    entity.ToTable("certidao", "divulgacao");

        //    entity.Property(e => e.Certidaoid).HasColumnName("certidaoid");
        //    entity.Property(e => e.Ano).HasColumnName("ano");
        //    entity.Property(e => e.Cep).HasColumnName("cep");
        //    entity.Property(e => e.Conesp)
        //        .HasComment("Condições Específicas")
        //        .HasColumnName("conesp");
        //    entity.Property(e => e.Conger)
        //        .HasComment("Condições Gerais")
        //        .HasColumnName("conger");
        //    entity.Property(e => e.Datacertidao).HasColumnName("datacertidao");
        //    entity.Property(e => e.Dimensaox)
        //        .HasPrecision(6, 2)
        //        .HasColumnName("dimensaox");
        //    entity.Property(e => e.Dimensaoy)
        //        .HasPrecision(6, 2)
        //        .HasColumnName("dimensaoy");
        //    entity.Property(e => e.Grupoaud)
        //        .HasDefaultValue(0)
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Inscricaoeconomica)
        //        .HasColumnType("character varying")
        //        .HasColumnName("inscricaoeconomica");
        //    entity.Property(e => e.Inscricaoimobiliaria)
        //        .HasColumnType("character varying")
        //        .HasColumnName("inscricaoimobiliaria");
        //    entity.Property(e => e.Numerocertidao).HasColumnName("numerocertidao");
        //    entity.Property(e => e.Numeroprocesso)
        //        .HasColumnType("character varying")
        //        .HasColumnName("numeroprocesso");
        //    entity.Property(e => e.Regular).HasColumnName("regular");
        //    entity.Property(e => e.Tipoveiculodivulgacao).HasColumnName("tipoveiculodivulgacao");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasDefaultValue(0)
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasColumnName("version");

        //    entity.HasOne(d => d.TipoveiculodivulgacaoNavigation).WithMany(p => p.Certidaos)
        //        .HasForeignKey(d => d.Tipoveiculodivulgacao)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("certidao_fk");
        //});

        //modelBuilder.Entity<Certidaoconformidade>(entity =>
        //{
        //    entity.HasKey(e => e.Certidaoconid).HasName("certidaoconformidade_pkey");

        //    entity.ToTable("certidaoconformidade", "divulgacao");

        //    entity.Property(e => e.Certidaoconid).HasColumnName("certidaoconid");
        //    entity.Property(e => e.Ano).HasColumnName("ano");
        //    entity.Property(e => e.Cep).HasColumnName("cep");
        //    entity.Property(e => e.Datacertidao).HasColumnName("datacertidao");
        //    entity.Property(e => e.Grupoaud)
        //        .HasDefaultValue(0)
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Inscricaoimobiliaria)
        //        .HasColumnType("character varying")
        //        .HasColumnName("inscricaoimobiliaria");
        //    entity.Property(e => e.Numerocertidaocon).HasColumnName("numerocertidaocon");
        //    entity.Property(e => e.Numeroprocesso)
        //        .HasColumnType("character varying")
        //        .HasColumnName("numeroprocesso");
        //    entity.Property(e => e.Tipoveiculodivulgacao).HasColumnName("tipoveiculodivulgacao");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasDefaultValue(0)
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasColumnName("version");

        //    entity.HasOne(d => d.TipoveiculodivulgacaoNavigation).WithMany(p => p.Certidaoconformidades)
        //        .HasForeignKey(d => d.Tipoveiculodivulgacao)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("certidaoconformidade_fk");
        //});

        //modelBuilder.Entity<Cidade>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("cidade", tb => tb.HasComment("template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs]\r\nformtitle[Cadastro de Cidade]\r\nfiltersgrid[#text_filter,#text_filter]\r\ngridtitle[Lista de Cidade]"));

        //    entity.HasIndex(e => e.Estado, "cidade_estado_idx");

        //    entity.HasIndex(e => e.Nome, "cidade_nome_idx");

        //    entity.Property(e => e.Cep)
        //        .HasMaxLength(10)
        //        .HasColumnName("cep");
        //    entity.Property(e => e.Cidadeid)
        //        .ValueGeneratedOnAdd()
        //        .HasComment("forminputlabel[Código] \r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("cidadeid");
        //    entity.Property(e => e.Estado)
        //        .HasColumnType("character varying")
        //        .HasColumnName("estado");
        //    entity.Property(e => e.Grupoaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Nome)
        //        .HasComment("forminputlabel[Nome]\r\nforminputsize[70]\r\nforminputclass[uppercase]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Nome]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnType("character varying")
        //        .HasColumnName("nome");
        //    entity.Property(e => e.Situacao)
        //        .HasColumnType("character varying")
        //        .HasColumnName("situacao");
        //    entity.Property(e => e.Tipo)
        //        .HasColumnType("character varying")
        //        .HasColumnName("tipo");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("version");
        //});

        //modelBuilder.Entity<Classe>(entity =>
        //{
        //    entity.HasKey(e => e.Classeid).HasName("classe_pkey");

        //    entity.ToTable("classe", "agenda", tb => tb.HasComment("template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Classe]\r\nfiltersgrid[#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Classes]"));

        //    entity.Property(e => e.Classeid)
        //        .HasComment("forminputlabel[Código]\r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("classeid");
        //    entity.Property(e => e.Grupoaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Nome)
        //        .HasMaxLength(200)
        //        .HasComment("forminputlabel[Nome]\r\nforminputsize[50]\r\nforminputclass[uppercase]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Nome]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("nome");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("version");
        //});

        //modelBuilder.Entity<Classificacao>(entity =>
        //{
        //    entity.HasKey(e => e.Classificacaoid).HasName("classificacao_pkey");

        //    entity.ToTable("classificacao", "residuos", tb => tb.HasComment("template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs]\r\n\r\nformtitle[Cadastro de Classificação]\r\nfiltersgrid[#text_filter,#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Classificações]"));

        //    entity.Property(e => e.Classificacaoid)
        //        .HasComment("forminputlabel[Código]\r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("classificacaoid");
        //    entity.Property(e => e.Grupoaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]")
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Nome)
        //        .HasComment("forminputlabel[Nome]\r\nforminputsize[50]\r\nforminputclass[uppercase]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Nome]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnType("character varying")
        //        .HasColumnName("nome");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]")
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]")
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]")
        //        .HasColumnName("version");
        //});

        //modelBuilder.Entity<Classificacao1>(entity =>
        //{
        //    entity.HasKey(e => e.Classificacaoid).HasName("classificacao_pkey");

        //    entity.ToTable("classificacao", "sisobra", tb => tb.HasComment("template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Classificação]\r\nfiltersgrid[#text_filter,#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Classificações]"));

        //    entity.Property(e => e.Classificacaoid)
        //        .HasComment("forminputlabel[Código] \r\nforminputsize[7]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Código] \r\ncolumngridtype[ro] \r\ncolumngridsize[80] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnName("classificacaoid");
        //    entity.Property(e => e.Grupoaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Icone)
        //        .HasComment("forminputlabel[Ícone] \r\nforminputsize[70]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Ícone] \r\ncolumngridtype[ro] \r\ncolumngridsize[*] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnType("character varying")
        //        .HasColumnName("icone");
        //    entity.Property(e => e.Nome)
        //        .HasComment("forminputlabel[Nome] \r\nforminputsize[70]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Nome] \r\ncolumngridtype[ro] \r\ncolumngridsize[*] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnType("character varying")
        //        .HasColumnName("nome");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("version");
        //});

        //modelBuilder.Entity<Codificacao>(entity =>
        //{
        //    entity.HasKey(e => e.Codificacaoid).HasName("codificacao_pkey");

        //    entity.ToTable("codificacao", "agenda");

        //    entity.Property(e => e.Codificacaoid).HasColumnName("codificacaoid");
        //    entity.Property(e => e.Especial).HasColumnName("especial");
        //    entity.Property(e => e.Fatoratual)
        //        .HasDefaultValueSql("0")
        //        .HasColumnName("fatoratual");
        //    entity.Property(e => e.Grupoaud)
        //        .HasDefaultValue(0)
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Nome)
        //        .HasColumnType("character varying")
        //        .HasColumnName("nome");
        //    entity.Property(e => e.Pontoanalise1)
        //        .HasDefaultValue(0)
        //        .HasColumnName("pontoanalise1");
        //    entity.Property(e => e.Pontoanalise2)
        //        .HasDefaultValue(0)
        //        .HasColumnName("pontoanalise2");
        //    entity.Property(e => e.Pontoanalise3)
        //        .HasDefaultValue(0)
        //        .HasColumnName("pontoanalise3");
        //    entity.Property(e => e.Pontoanalise4)
        //        .HasDefaultValue(0)
        //        .HasColumnName("pontoanalise4");
        //    entity.Property(e => e.Pontoanalise5)
        //        .HasDefaultValue(0)
        //        .HasColumnName("pontoanalise5");
        //    entity.Property(e => e.Pontobase)
        //        .HasDefaultValue(0)
        //        .HasColumnName("pontobase");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasDefaultValue(0)
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasColumnName("version");
        //});

        //modelBuilder.Entity<Comunicado>(entity =>
        //{
        //    entity.HasKey(e => e.Comunicadoid).HasName("comunicado_pkey");

        //    entity.ToTable("comunicado", "divulgacao");

        //    entity.Property(e => e.Comunicadoid).HasColumnName("comunicadoid");
        //    entity.Property(e => e.Ano).HasColumnName("ano");
        //    entity.Property(e => e.Cargo)
        //        .HasMaxLength(255)
        //        .HasComment("Cargo/Função")
        //        .HasColumnName("cargo");
        //    entity.Property(e => e.Exigencia)
        //        .HasComment("Texto descritivo das exigências")
        //        .HasColumnName("exigencia");
        //    entity.Property(e => e.Grupoaud)
        //        .HasComment("Grupo Logado (auditoria)")
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Inscricaoeconomica)
        //        .HasMaxLength(11)
        //        .HasComment("Inscrição Municpal")
        //        .HasColumnName("inscricaoeconomica");
        //    entity.Property(e => e.Local)
        //        .HasMaxLength(255)
        //        .HasComment("Localalidade de referência")
        //        .HasColumnName("local");
        //    entity.Property(e => e.Numerocomunicado).HasColumnName("numerocomunicado");
        //    entity.Property(e => e.Processo)
        //        .HasMaxLength(15)
        //        .HasColumnName("processo");
        //    entity.Property(e => e.Registrado)
        //        .HasMaxLength(255)
        //        .HasComment("Funcionário que registra o comunicado")
        //        .HasColumnName("registrado");
        //    entity.Property(e => e.Tipo)
        //        .HasComment("1 - Indefirido\r\n2 - Vistoria")
        //        .HasColumnName("tipo");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasComment("Unidade Logado (auditoria)")
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasComment("Usuario Logado (auditoria)")
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasComment("Versao do registro (auditoria)")
        //        .HasColumnName("version");
        //});

        //modelBuilder.Entity<Contratado>(entity =>
        //{
        //    entity.HasKey(e => e.Contratadoid).HasName("contratado_pkey");

        //    entity.ToTable("contratado", "sisobra", tb => tb.HasComment("template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Contratado]\r\nfiltersgrid[#text_filter,#text_filter,#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Contratados]"));

        //    entity.Property(e => e.Contratadoid)
        //        .HasComment("forminputlabel[Código] \r\nforminputsize[7]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Código] \r\ncolumngridtype[ro] \r\ncolumngridsize[80] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnName("contratadoid");
        //    entity.Property(e => e.Grupoaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Nome)
        //        .HasComment("forminputlabel[Nome] \r\nforminputsize[70]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Nome] \r\ncolumngridtype[ro] \r\ncolumngridsize[*] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnType("character varying")
        //        .HasColumnName("nome");
        //    entity.Property(e => e.Responsavel)
        //        .HasComment("forminputlabel[Responsável] \r\nforminputsize[70]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Responsável] \r\ncolumngridtype[ro] \r\ncolumngridsize[*] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnType("character varying")
        //        .HasColumnName("responsavel");
        //    entity.Property(e => e.Telefone)
        //        .HasComment("forminputlabel[Telefone] \r\nforminputsize[10]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Telefone] \r\ncolumngridtype[ro] \r\ncolumngridsize[20] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnType("character varying")
        //        .HasColumnName("telefone");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("version");
        //});

        //modelBuilder.Entity<Controleresiduo>(entity =>
        //{
        //    entity.HasKey(e => e.Controleresiduoid).HasName("controleresiduo_pkey");

        //    entity.ToTable("controleresiduo", "agenda", tb => tb.HasComment("template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Controle de Resíduo]\r\nfiltersgrid[#text_filter,#text_filter,#text_filter,#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Controles de Resíduos]"));

        //    entity.Property(e => e.Controleresiduoid)
        //        .ValueGeneratedOnAdd()
        //        .HasComment("forminputlabel[Código]\r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("controleresiduoid");
        //    entity.Property(e => e.Botaforapeso)
        //        .HasComment("forminputlabel[Peso Bota-fora]\r\nforminputsize[15]\r\nforminputclass[required number]\r\n\r\ngeragridmain[false]")
        //        .HasColumnName("botaforapeso");
        //    entity.Property(e => e.Botaforavolume)
        //        .HasComment("forminputlabel[Volume Bota-fora]\r\nforminputsize[15]\r\nforminputclass[required number]\r\n\r\ngeragridmain[false]")
        //        .HasColumnName("botaforavolume");
        //    entity.Property(e => e.Caracteristicaemp)
        //        .HasComment("forminputlabel[Caracterização do Empreendimento]\r\nforminputsize[250]\r\n\r\nsearchmode[combobox]\r\ncomboboxresultfield[caracteristicaemp.nome]\r\n\r\ncolumngridid[caracteristicaemp.nome]\r\ncolumngridtitle[Caracterização do Empreendimento]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("caracteristicaemp");
        //    entity.Property(e => e.Construcaoarea)
        //        .HasComment("forminputlabel[Área Construção]\r\nforminputsize[15]\r\nforminputclass[required number]\r\n\r\ngeragridmain[false]")
        //        .HasColumnName("construcaoarea");
        //    entity.Property(e => e.Contrucaopeso)
        //        .HasComment("forminputlabel[Peso Construção]\r\nforminputsize[15]\r\nforminputclass[required number]\r\n\r\ngeragridmain[false]")
        //        .HasColumnName("contrucaopeso");
        //    entity.Property(e => e.Contrucaovolume)
        //        .HasComment("forminputlabel[Volume Construção]\r\nforminputsize[15]\r\nforminputclass[required number]\r\n\r\ngeragridmain[false]")
        //        .HasColumnName("contrucaovolume");
        //    entity.Property(e => e.Datahoracadastro)
        //        .HasComment("forminputlabel[Data Cadastro]\r\nforminputsize[15]\r\nforminputclass[]\r\n\r\ngeragridmain[false]")
        //        .HasColumnType("timestamp without time zone")
        //        .HasColumnName("datahoracadastro");
        //    entity.Property(e => e.Demolicaopeso)
        //        .HasComment("forminputlabel[Peso Demolição]\r\nforminputsize[15]\r\nforminputclass[required number]\r\n\r\ngeragridmain[false]")
        //        .HasColumnName("demolicaopeso");
        //    entity.Property(e => e.Demolicaovolume)
        //        .HasComment("forminputlabel[Volume Demolição]\r\nforminputsize[15]\r\nforminputclass[required number]\r\n\r\ngeragridmain[false]")
        //        .HasColumnName("demolicaovolume");
        //    entity.Property(e => e.Emprestpeso)
        //        .HasComment("forminputlabel[Peso Empréstimo]\r\nforminputsize[15]\r\nforminputclass[required number]\r\n\r\ngeragridmain[false]")
        //        .HasColumnName("emprestpeso");
        //    entity.Property(e => e.Emprestvolume)
        //        .HasComment("forminputlabel[Volume Empréstimo]\r\nforminputsize[15]\r\nforminputclass[required number]\r\n\r\ngeragridmain[false]")
        //        .HasColumnName("emprestvolume");
        //    entity.Property(e => e.Grupoaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Inscricaoimobiliaria)
        //        .HasMaxLength(20)
        //        .HasColumnName("inscricaoimobiliaria");
        //    entity.Property(e => e.Prfage).HasColumnName("prfage");
        //    entity.Property(e => e.Projeto)
        //        .HasMaxLength(22)
        //        .HasComment("forminputlabel[Projeto]\r\nforminputsize[30]\r\n\r\nsearchmode[popup]\r\npopupresultfield[processo]\r\npopupfieldsgrid[projetoid,processo:projetoid]\r\n\r\ncolumngridid[projeto.processo]\r\ncolumngridtitle[Projeto]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("projeto");
        //    entity.Property(e => e.Proprietario)
        //        .HasMaxLength(200)
        //        .HasColumnName("proprietario");
        //    entity.Property(e => e.Segregacaomat)
        //        .HasComment("0-Sim / 1-Nao\r\nforminputlabel[Haverá Segregação do material no canteiro de obras?]\r\nforminputsize[15]\r\nforminputclass[required number]\r\n\r\ngeragridmain[false]")
        //        .HasColumnName("segregacaomat");
        //    entity.Property(e => e.Status)
        //        .HasComment("forminputlabel[Status]\r\nforminputsize[180]\r\n\r\nsearchmode[combobox]\r\ncomboboxresultfield[status.descricao]\r\n\r\ncolumngridid[status.descricao]\r\ncolumngridtitle[Status]\r\ncolumngridtype[ro]\r\ncolumngridsize[50]\r\ncolumngridalign[left]")
        //        .HasColumnName("status");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("version");

        //    entity.HasOne(d => d.CaracteristicaempNavigation).WithMany(p => p.Controleresiduos)
        //        .HasForeignKey(d => d.Caracteristicaemp)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("controleresiduo_fk1");

        //    entity.HasOne(d => d.ControleresiduoNavigation).WithOne(p => p.Controleresiduo)
        //        .HasForeignKey<Controleresiduo>(d => d.Controleresiduoid)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("controleresiduo_fk2");

        //    entity.HasOne(d => d.StatusNavigation).WithMany(p => p.Controleresiduos)
        //        .HasForeignKey(d => d.Status)
        //        .HasConstraintName("controleresiduo_fk");
        //});

        //modelBuilder.Entity<Ctr>(entity =>
        //{
        //    entity.HasKey(e => e.Ctrid).HasName("ctr_pkey");

        //    entity.ToTable("ctr", "agenda", tb => tb.HasComment("template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de CTR]\r\nfiltersgrid[#text_filter,#text_filter,#text_filter,#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de CTR]"));

        //    entity.Property(e => e.Ctrid)
        //        .HasComment("forminputlabel[Código]\r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("ctrid");
        //    entity.Property(e => e.Areareceptora)
        //        .HasComment("forminputlabel[Área Receptora]\r\nforminputsize[180]\r\n\r\nsearchmode[combobox]\r\ncomboboxresultfield[areareceptora.nome]\r\n\r\ncolumngridid[areareceptora.nome]\r\ncolumngridtitle[Área Receptora]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("areareceptora");
        //    entity.Property(e => e.Controleresiduo)
        //        .HasComment("forminputlabel[controleresiduo]\r\nforminputsize[15]\r\nforminputclass[]\r\n\r\ngeragridmain[false]")
        //        .HasColumnName("controleresiduo");
        //    entity.Property(e => e.Datahorabaixa)
        //        .HasColumnType("timestamp without time zone")
        //        .HasColumnName("datahorabaixa");
        //    entity.Property(e => e.Datahoracadastro)
        //        .HasColumnType("timestamp without time zone")
        //        .HasColumnName("datahoracadastro");
        //    entity.Property(e => e.Grupoaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Inscricaoimobiliaria)
        //        .HasMaxLength(30)
        //        .HasColumnName("inscricaoimobiliaria");
        //    entity.Property(e => e.Nomecondutor)
        //        .HasMaxLength(99)
        //        .HasComment("forminputlabel[Nome Condutor]\r\nforminputsize[15]\r\nforminputclass[required uppercase]\r\n\r\ngeragridmain[false]")
        //        .HasColumnName("nomecondutor");
        //    entity.Property(e => e.Numeroctr)
        //        .HasMaxLength(22)
        //        .HasComment("forminputlabel[Número-CTR]\r\nforminputsize[15]\r\nforminputclass[required number]\r\n\r\ngeragridmain[false]")
        //        .HasColumnName("numeroctr");
        //    entity.Property(e => e.Placaveiculo)
        //        .HasMaxLength(22)
        //        .HasComment("forminputlabel[Placa Veículo]\r\nforminputsize[15]\r\nforminputclass[required uppercase]\r\n\r\ngeragridmain[false]")
        //        .HasColumnName("placaveiculo");
        //    entity.Property(e => e.Prfage).HasColumnName("prfage");
        //    entity.Property(e => e.Processo)
        //        .HasMaxLength(15)
        //        .HasColumnName("processo");
        //    entity.Property(e => e.Proprietario)
        //        .HasMaxLength(200)
        //        .HasColumnName("proprietario");
        //    entity.Property(e => e.Status).HasColumnName("status");
        //    entity.Property(e => e.Transportador)
        //        .HasComment("forminputlabel[Transportadora]\r\nforminputsize[180]\r\n\r\nsearchmode[combobox]\r\ncomboboxresultfield[transportadora.nome]\r\n\r\ncolumngridid[transportadora.nome]\r\ncolumngridtitle[Transportadora]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("transportador");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("version");
        //    entity.Property(e => e.Volumeclassea)
        //        .HasPrecision(10, 2)
        //        .HasComment("forminputlabel[volume classe a]\r\nforminputsize[15]\r\nforminputclass[number]\r\n\r\ngeragridmain[false]")
        //        .HasColumnName("volumeclassea");
        //    entity.Property(e => e.Volumeclasseb)
        //        .HasPrecision(10, 2)
        //        .HasComment("forminputlabel[volume classe b]\r\nforminputsize[15]\r\nforminputclass[number]\r\n\r\ngeragridmain[false]")
        //        .HasColumnName("volumeclasseb");
        //    entity.Property(e => e.Volumeclassec)
        //        .HasPrecision(10, 2)
        //        .HasComment("forminputlabel[volume classe c]\r\nforminputsize[15]\r\nforminputclass[number]\r\n\r\ngeragridmain[false]")
        //        .HasColumnName("volumeclassec");
        //    entity.Property(e => e.Volumeclassed)
        //        .HasPrecision(10, 2)
        //        .HasComment("forminputlabel[volume classe d]\r\nforminputsize[15]\r\nforminputclass[number]\r\n\r\ngeragridmain[false]")
        //        .HasColumnName("volumeclassed");

        //    entity.HasOne(d => d.AreareceptoraNavigation).WithMany(p => p.Ctrs)
        //        .HasForeignKey(d => d.Areareceptora)
        //        .HasConstraintName("ctr_fk1");

        //    entity.HasOne(d => d.PrfageNavigation).WithMany(p => p.Ctrs)
        //        .HasForeignKey(d => d.Prfage)
        //        .HasConstraintName("ctr_fk3");

        //    entity.HasOne(d => d.StatusNavigation).WithMany(p => p.Ctrs)
        //        .HasForeignKey(d => d.Status)
        //        .HasConstraintName("ctr_fk2");

        //    entity.HasOne(d => d.TransportadorNavigation).WithMany(p => p.Ctrs)
        //        .HasForeignKey(d => d.Transportador)
        //        .HasConstraintName("ctr_fk");
        //});

        //modelBuilder.Entity<Ctr1>(entity =>
        //{
        //    entity.HasKey(e => e.Ctrid).HasName("ctr_pkey");

        //    entity.ToTable("ctr", "residuos", tb => tb.HasComment("template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs]\r\n\r\nformtitle[Cadastro de CTR]\r\nfiltersgrid[#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de CTR's]"));

        //    entity.Property(e => e.Ctrid)
        //        .HasComment("forminputlabel[Código]\r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("ctrid");
        //    entity.Property(e => e.Areareceptora)
        //        .HasComment("forminputlabel[Área-Receptora]\nforminputsize[180]\n\nsearchmode[comboboxdet]\ncomboboxresultfield[areareceptora.nome]\n\ngeragridmain[false]")
        //        .HasColumnName("areareceptora");
        //    entity.Property(e => e.Areareceptora2).HasColumnName("areareceptora2");
        //    entity.Property(e => e.Armazenamento)
        //        .HasComment("forminputlabel[Armazenamento]\r\nforminputsize[110]\r\n\r\nsearchmode[combobox]\r\ncomboboxresultfield[armazenamento.nome]\r\n\r\ngeragridmain[false]")
        //        .HasColumnName("armazenamento");
        //    entity.Property(e => e.Autotransporte)
        //        .HasDefaultValue(0)
        //        .HasColumnName("autotransporte");
        //    entity.Property(e => e.Codigobaixa).HasColumnName("codigobaixa");
        //    entity.Property(e => e.Datahoracadastro)
        //        .HasComment("forminputlabel[Data/Hora Cad.]\r\nforminputsize[14]\r\nforminputclass[ro]\r\n\r\ngeragridmain[false]")
        //        .HasColumnType("timestamp without time zone")
        //        .HasColumnName("datahoracadastro");
        //    entity.Property(e => e.Datahoradesfinal)
        //        .HasColumnType("timestamp without time zone")
        //        .HasColumnName("datahoradesfinal");
        //    entity.Property(e => e.Datahoraentrega)
        //        .HasComment("forminputlabel[Data/Hora Entrega]\nforminputsize[14]\nforminputclass[datetime]\n\ngeragridmain[false]")
        //        .HasColumnType("timestamp without time zone")
        //        .HasColumnName("datahoraentrega");
        //    entity.Property(e => e.Datahorafinalizado)
        //        .HasColumnType("timestamp without time zone")
        //        .HasColumnName("datahorafinalizado");
        //    entity.Property(e => e.Datahorancertificado)
        //        .HasColumnType("timestamp without time zone")
        //        .HasColumnName("datahorancertificado");
        //    entity.Property(e => e.Datahoratransportadora)
        //        .HasColumnType("timestamp without time zone")
        //        .HasColumnName("datahoratransportadora");
        //    entity.Property(e => e.Empresa).HasColumnName("empresa");
        //    entity.Property(e => e.Grupoaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]")
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Nomecondutor)
        //        .HasMaxLength(150)
        //        .HasComment("forminputlabel[Responsável]\r\nforminputsize[15]\r\nforminputclass[uppercase]\r\n\r\ngeragridmain[false]")
        //        .HasColumnName("nomecondutor");
        //    entity.Property(e => e.Numeromanifesto).HasColumnName("numeromanifesto");
        //    entity.Property(e => e.Obsdestfinal)
        //        .HasColumnType("character varying")
        //        .HasColumnName("obsdestfinal");
        //    entity.Property(e => e.Obsdestfinal2)
        //        .HasColumnType("character varying")
        //        .HasColumnName("obsdestfinal2");
        //    entity.Property(e => e.Placaveiculo)
        //        .HasMaxLength(8)
        //        .HasComment("forminputlabel[Placa Veículo]\r\nforminputsize[12]\r\nforminputclass[uppercase]\r\n\r\ngeragridmain[false]")
        //        .HasColumnName("placaveiculo");
        //    entity.Property(e => e.Quantidade)
        //        .HasPrecision(10, 2)
        //        .HasComment("forminputlabel[Quantidade]\r\nforminputsize[10]\r\nforminputclass[number]\r\n\r\ngeragridmain[false]")
        //        .HasColumnName("quantidade");
        //    entity.Property(e => e.Residuo)
        //        .HasComment("forminputlabel[Resíduo]\r\nforminputsize[30]\r\nforminputclass[uppercase]\r\n\r\nsearchmode[popupdet]\r\npopupresultfield[nome]\r\npopupfieldsgrid[residuoid,nome,estadofisico.nome:residuoid]\r\n\r\ncolumngridid[residuo.nome]\r\ncolumngridtitle[Resíduo]\r\ncolumngridtype[ro]\r\ncolumngridsize[150]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("residuo");
        //    entity.Property(e => e.Situacao)
        //        .HasComment("forminputlabel[Situação]\r\nforminputsize[10]\r\n\r\ngeragridmain[false]")
        //        .HasColumnName("situacao");
        //    entity.Property(e => e.Transportadora)
        //        .HasComment("forminputlabel[Transportadora]\r\nforminputsize[180]\r\n\r\nsearchmode[comboboxdet]\r\ncomboboxresultfield[transportadora.nome]\r\n\r\ngeragridmain[false]")
        //        .HasColumnName("transportadora");
        //    entity.Property(e => e.Transportadorasiat)
        //        .HasPrecision(11)
        //        .HasComment("forminputlabel[Transportadora-SIAT]\r\nforminputsize[10]\r\nforminputclass[number]\r\n\r\ngeragridmain[false]")
        //        .HasColumnName("transportadorasiat");
        //    entity.Property(e => e.Unidade)
        //        .HasComment("forminputlabel[Unidade]\r\nforminputsize[110]\r\n\r\nsearchmode[combobox]\r\ncomboboxresultfield[unidade.nome]\r\n\r\ngeragridmain[false]")
        //        .HasColumnName("unidade");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]")
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]")
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]")
        //        .HasColumnName("version");

        //    entity.HasOne(d => d.AreareceptoraNavigation).WithMany(p => p.Ctr1AreareceptoraNavigations)
        //        .HasForeignKey(d => d.Areareceptora)
        //        .HasConstraintName("ctr_fk4");

        //    entity.HasOne(d => d.Areareceptora2Navigation).WithMany(p => p.Ctr1Areareceptora2Navigations)
        //        .HasForeignKey(d => d.Areareceptora2)
        //        .HasConstraintName("ctr_fk6");

        //    entity.HasOne(d => d.ArmazenamentoNavigation).WithMany(p => p.Ctr1s)
        //        .HasForeignKey(d => d.Armazenamento)
        //        .HasConstraintName("ctr_fk3");

        //    entity.HasOne(d => d.EmpresaNavigation).WithMany(p => p.Ctr1s)
        //        .HasForeignKey(d => d.Empresa)
        //        .HasConstraintName("ctr_fk");

        //    entity.HasOne(d => d.TransportadoraNavigation).WithMany(p => p.Ctr1s)
        //        .HasForeignKey(d => d.Transportadora)
        //        .HasConstraintName("ctr_fk5");

        //    entity.HasOne(d => d.UnidadeNavigation).WithMany(p => p.Ctr1s)
        //        .HasForeignKey(d => d.Unidade)
        //        .HasConstraintName("ctr_fk2");
        //});

        //modelBuilder.Entity<Ctrresiduo>(entity =>
        //{
        //    entity.HasKey(e => e.Ctrresiduoid).HasName("ctrresiduo_pkey");

        //    entity.ToTable("ctrresiduo", "residuos");

        //    entity.Property(e => e.Ctrresiduoid).HasColumnName("ctrresiduoid");
        //    entity.Property(e => e.Codigobaixa)
        //        .HasComment("forminputlabel[Codigo Baixa]\nforminputsize[50]\nforminputclass[uppercase]\n\ncolumngridid[]\ncolumngridtitle[Codigo Baixa]\ncolumngridtype[ro]\ncolumngridsize[*]\ncolumngridalign[left]\ncolumngridcolor[white]")
        //        .HasColumnType("character varying")
        //        .HasColumnName("codigobaixa");
        //    entity.Property(e => e.Ctr)
        //        .HasComment("forminputlabel[Ctr]\r\nforminputsize[10]\r\n\r\ngeragridmain[false]")
        //        .HasColumnName("ctr");
        //    entity.Property(e => e.Grupoaud)
        //        .HasComment("geraentity[false]\ngeraform[false]\ngeraformdet[false]\ngeragridmain[false]")
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Numeromanifesto)
        //        .HasComment("forminputlabel[Numero Manifesto]\nforminputsize[50]\nforminputclass[uppercase]\n\ncolumngridid[]\ncolumngridtitle[Numero Manifesto]\ncolumngridtype[ro]\ncolumngridsize[*]\ncolumngridalign[left]\ncolumngridcolor[white]")
        //        .HasColumnType("character varying")
        //        .HasColumnName("numeromanifesto");
        //    entity.Property(e => e.Qtde)
        //        .HasComment("forminputlabel[Quantidade]\nforminputsize[50]\nforminputclass[uppercase]\n\ncolumngridid[]\ncolumngridtitle[Quantidade]\ncolumngridtype[ro]\ncolumngridsize[*]\ncolumngridalign[left]\ncolumngridcolor[white]")
        //        .HasColumnName("qtde");
        //    entity.Property(e => e.Qtdetrans).HasColumnName("qtdetrans");
        //    entity.Property(e => e.Residuo)
        //        .HasComment("forminputlabel[Resíduo]\nforminputsize[30]\nforminputclass[uppercase]\n\nsearchmode[popupdet]\npopupresultfield[nome]\npopupfieldsgrid[residuoid,nome,estadofisico.nome:residuoid]\n\ncolumngridid[residuo.nome]\ncolumngridtitle[Resíduo]\ncolumngridtype[ro]\ncolumngridsize[150]\ncolumngridalign[left]\ncolumngridcolor[white]")
        //        .HasColumnName("residuo");
        //    entity.Property(e => e.Unidade)
        //        .HasComment("forminputlabel[Unidade]\r\nforminputsize[110]\r\n\r\nsearchmode[combobox]\r\ncomboboxresultfield[unidade.nome]\r\n\r\ngeragridmain[false]")
        //        .HasColumnName("unidade");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasComment("geraentity[false]\ngeraform[false]\ngeraformdet[false]\ngeragridmain[false]")
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Unidadetrans)
        //        .HasComment("forminputlabel[Unidade Transportadora]\r\nforminputsize[110]\r\n\r\nsearchmode[combobox]\r\ncomboboxresultfield[unidadetrans.nome]\r\n\r\ngeragridmain[false]")
        //        .HasColumnName("unidadetrans");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasComment("geraentity[false]\ngeraform[false]\ngeraformdet[false]\ngeragridmain[false]")
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasComment("geraentity[false]\ngeraform[false]\ngeraformdet[false]\ngeragridmain[false]")
        //        .HasColumnName("version");

        //    entity.HasOne(d => d.CtrNavigation).WithMany(p => p.Ctrresiduos)
        //        .HasForeignKey(d => d.Ctr)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("ctrresiduo_fk");

        //    entity.HasOne(d => d.UnidadeNavigation).WithMany(p => p.CtrresiduoUnidadeNavigations)
        //        .HasForeignKey(d => d.Unidade)
        //        .HasConstraintName("ctrresiduo_fk2");

        //    entity.HasOne(d => d.UnidadetransNavigation).WithMany(p => p.CtrresiduoUnidadetransNavigations)
        //        .HasForeignKey(d => d.Unidadetrans)
        //        .HasConstraintName("ctrresiduo_fk3");
        //});

        //modelBuilder.Entity<Destinofinal>(entity =>
        //{
        //    entity.HasKey(e => e.Destinofinalid).HasName("destinofinal_pkey");

        //    entity.ToTable("destinofinal", "agenda");

        //    entity.Property(e => e.Destinofinalid).HasColumnName("destinofinalid");
        //    entity.Property(e => e.Grupoaud).HasColumnName("grupoaud");
        //    entity.Property(e => e.Nome)
        //        .HasMaxLength(200)
        //        .HasColumnName("nome");
        //    entity.Property(e => e.Unidadeaud).HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud).HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version).HasColumnName("version");
        //});

        //modelBuilder.Entity<Documento>(entity =>
        //{
        //    entity.HasKey(e => e.Documentoid).HasName("documento_pkey");

        //    entity.ToTable("documento", "agenda", tb => tb.HasComment("template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Documentos]\r\n\r\nfiltersgrid[#text_filter,#text_filter] \r\n\r\n\r\ngridtitle[Lista de Documentos]\r\n"));

        //    entity.HasIndex(e => e.Arquivo, "documento_arquivo_idx");

        //    entity.HasIndex(e => e.Remessa, "documento_remessa_idx");

        //    entity.HasIndex(e => e.Situacao, "documento_situacao_idx");

        //    entity.Property(e => e.Documentoid)
        //        .HasComment("forminputlabel[Código] \r\nforminputsize[7]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Código] \r\ncolumngridtype[ro] \r\ncolumngridsize[80] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnName("documentoid");
        //    entity.Property(e => e.Arquivo).HasColumnName("arquivo");
        //    entity.Property(e => e.Caminho)
        //        .HasComment("forminputlabel[Caminho] \r\nforminputsize[70]  \r\n\r\ngeragridmain[false]")
        //        .HasColumnType("character varying")
        //        .HasColumnName("caminho");
        //    entity.Property(e => e.Grupoaud)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Remessa)
        //        .HasComment("forminputlabel[Remessa]\r\nforminputsize[250]\r\n\r\nsearchmode[combobox]\r\ncomboboxresultfield[remessa.titulo]\r\n\r\ngeragridmain[false]")
        //        .HasColumnName("remessa");
        //    entity.Property(e => e.Situacao)
        //        .HasComment("forminputlabel[Situacao] \r\nforminputsize[250]  \r\n\r\n\r\nsearchmode[combobox]\r\ncomboboxresultfield[situacao.descricao]\r\n\r\ncolumngridid[situacao.descricao]\r\ncolumngridtitle[Situacao]\r\ncolumngridtype[ro]\r\ncolumngridsize[300]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("situacao");
        //    entity.Property(e => e.Titulo)
        //        .HasComment("forminputlabel[Titulo] \r\nforminputsize[70]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Titulo] \r\ncolumngridtype[ro] \r\ncolumngridsize[*] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnType("character varying")
        //        .HasColumnName("titulo");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("version");

        //    entity.HasOne(d => d.ArquivoNavigation).WithMany(p => p.Documentos)
        //        .HasForeignKey(d => d.Arquivo)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("documento_fk2");

        //    entity.HasOne(d => d.RemessaNavigation).WithMany(p => p.Documentos)
        //        .HasForeignKey(d => d.Remessa)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("documento_fk");

        //    entity.HasOne(d => d.SituacaoNavigation).WithMany(p => p.Documentos)
        //        .HasForeignKey(d => d.Situacao)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("documento_fk1");
        //});

        //modelBuilder.Entity<Documento1>(entity =>
        //{
        //    entity.HasKey(e => e.Documentoid).HasName("documento_pkey");

        //    entity.ToTable("documento", "cartografia");

        //    entity.Property(e => e.Documentoid)
        //        .HasComment("Código do documento")
        //        .HasColumnName("documentoid");
        //    entity.Property(e => e.Arquivo)
        //        .HasComment("Arquivo vinculado")
        //        .HasColumnName("arquivo");
        //    entity.Property(e => e.Remessa)
        //        .HasComment("Remessa vinculado")
        //        .HasColumnName("remessa");
        //    entity.Property(e => e.Situacao)
        //        .HasComment("Situação do documento")
        //        .HasColumnName("situacao");

        //    entity.HasOne(d => d.ArquivoNavigation).WithMany(p => p.Documento1s)
        //        .HasForeignKey(d => d.Arquivo)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("documento_fk2");

        //    entity.HasOne(d => d.RemessaNavigation).WithMany(p => p.Documento1s)
        //        .HasForeignKey(d => d.Remessa)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("documento_fk");

        //    entity.HasOne(d => d.SituacaoNavigation).WithMany(p => p.Documento1s)
        //        .HasForeignKey(d => d.Situacao)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("documento_fk1");
        //});

        //modelBuilder.Entity<Empresa>(entity =>
        //{
        //    entity.HasKey(e => e.Empresaid).HasName("empresa_pkey");

        //    entity.ToTable("empresa", "divulgacao", tb => tb.HasComment("template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Responsável]\r\nfiltersgrid[#text_filter,#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Responsáveis]"));

        //    entity.Property(e => e.Empresaid)
        //        .HasComment("forminputlabel[Código]\r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("empresaid");
        //    entity.Property(e => e.Celular)
        //        .HasComment("forminputlabel[Celular]\r\nforminputsize[12]\r\nforminputclass[phone]\r\n\r\ngeragridmain[false]")
        //        .HasColumnType("character varying")
        //        .HasColumnName("celular");
        //    entity.Property(e => e.Cep)
        //        .HasComment("forminputlabel[CEP]\r\nforminputsize[10]\r\nforminputclass[number]\r\n\r\ngeragridmain[false]")
        //        .HasColumnName("cep");
        //    entity.Property(e => e.Complemento)
        //        .HasComment("forminputlabel[Complemento]\r\nforminputsize[30]\r\nforminputclass[uppercase]\r\n\r\ngeragridmain[false]")
        //        .HasColumnType("character varying")
        //        .HasColumnName("complemento");
        //    entity.Property(e => e.Grupoaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Nome)
        //        .HasComment("forminputlabel[Nome]\r\nforminputsize[50]\r\nforminputclass[uppercase]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Nome]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnType("character varying")
        //        .HasColumnName("nome");
        //    entity.Property(e => e.Numero)
        //        .HasComment("forminputlabel[N&ordm;]\r\nforminputsize[10]\r\nforminputclass[number]\r\n\r\ngeragridmain[false]")
        //        .HasColumnName("numero");
        //    entity.Property(e => e.Responsavel)
        //        .HasComment("forminputlabel[Responsável]\r\nforminputsize[50]\r\nforminputclass[uppercase]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Responsável]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnType("character varying")
        //        .HasColumnName("responsavel");
        //    entity.Property(e => e.Rua)
        //        .HasComment("forminputlabel[Rua]\r\nforminputsize[12]\r\nforminputclass[ro]\r\n\r\ngeragridmain[false]")
        //        .HasColumnName("rua");
        //    entity.Property(e => e.Telefone)
        //        .HasComment("forminputlabel[Telefone]\r\nforminputsize[12]\r\nforminputclass[phone]\r\n\r\ngeragridmain[false]")
        //        .HasColumnType("character varying")
        //        .HasColumnName("telefone");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("version");

        //    entity.HasOne(d => d.RuaNavigation).WithMany(p => p.Empresas)
        //        .HasForeignKey(d => d.Rua)
        //        .HasConstraintName("empresa_fk");
        //});

        //modelBuilder.Entity<Empresa1>(entity =>
        //{
        //    entity.HasKey(e => e.Empresaid).HasName("empresa_pkey");

        //    entity.ToTable("empresa", tb => tb.HasComment("template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs]\r\n\r\nformtitle[Cadastro de Empresa]\r\nfiltersgrid[#text_filter,#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Empresas]"));

        //    entity.HasIndex(e => e.Cpfcnpj, "empresa_cpfcnpj_idx");

        //    entity.HasIndex(e => e.Inscricaomunicipal, "empresa_inscricaomunicipal_idx");

        //    entity.Property(e => e.Empresaid)
        //        .HasDefaultValueSql("nextval(('\"recadempresa\".\"empresa_empresaid_seq\"'::text)::regclass)")
        //        .HasComment("forminputlabel[Código] \r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("empresaid");
        //    entity.Property(e => e.Ativo)
        //        .HasComment("Este campo serve para validar quais empresas podem ou nao logar.")
        //        .HasColumnName("ativo");
        //    entity.Property(e => e.Atualizadosiat)
        //        .HasDefaultValue(false)
        //        .HasColumnName("atualizadosiat");
        //    entity.Property(e => e.Bairrocorresp)
        //        .HasMaxLength(50)
        //        .HasComment("forminputlabel[Bairro Correspondência]\r\nforminputsize[40]\r\nforminputclass[uppercase]\r\ngeragridmain[false]")
        //        .HasColumnName("bairrocorresp");
        //    entity.Property(e => e.Bairrolocal)
        //        .HasMaxLength(50)
        //        .HasComment("forminputlabel[Bairro Localização]\r\nforminputsize[30]\r\nforminputclass[uppercase]\r\ngeragridmain[false]")
        //        .HasColumnName("bairrolocal");
        //    entity.Property(e => e.Celcorresp)
        //        .HasMaxLength(9)
        //        .HasComment("forminputlabel[Cel. Correspondência]\r\nforminputsize[15]\r\nforminputclass[uppercase]\r\ngeragridmain[false]")
        //        .HasColumnName("celcorresp");
        //    entity.Property(e => e.Cellocal)
        //        .HasMaxLength(9)
        //        .HasColumnName("cellocal");
        //    entity.Property(e => e.Cepcorresp)
        //        .HasMaxLength(9)
        //        .HasComment("forminputlabel[CEP Correspondência]\r\nforminputsize[10]\r\nforminputclass[cep]\r\ngeragridmain[false]")
        //        .HasColumnName("cepcorresp");
        //    entity.Property(e => e.Ceplocal)
        //        .HasMaxLength(9)
        //        .HasComment("forminputlabel[CEP Localização]\r\nforminputsize[10]\r\nforminputclass[cep]\r\ngeragridmain[false]")
        //        .HasColumnName("ceplocal");
        //    entity.Property(e => e.Cidadecorresp)
        //        .HasMaxLength(50)
        //        .HasComment("forminputlabel[Cidade Correspondência]\r\nforminputsize[40]\r\nforminputclass[uppercase]\r\ngeragridmain[false]")
        //        .HasColumnName("cidadecorresp");
        //    entity.Property(e => e.Cidadelocal)
        //        .HasMaxLength(50)
        //        .HasComment("forminputlabel[Cidade Localização]\r\nforminputsize[30]\r\nforminputclass[uppercase]\r\ngeragridmain[false]")
        //        .HasColumnName("cidadelocal");
        //    entity.Property(e => e.Codpaiscorresp)
        //        .HasComment("forminputlabel[Cod. País Correspondência]\r\nforminputsize[20]\r\nforminputclass[number]\r\ngeragridmain[false]")
        //        .HasColumnName("codpaiscorresp");
        //    entity.Property(e => e.Codpaislocal)
        //        .HasComment("forminputlabel[Código País Localização]\r\nforminputsize[30]\r\nforminputclass[number]\r\ngeragridmain[false]")
        //        .HasColumnName("codpaislocal");
        //    entity.Property(e => e.Complendcorresp)
        //        .HasMaxLength(50)
        //        .HasComment("forminputlabel[Complemento Correspondência]\r\nforminputsize[30]\r\nforminputclass[uppercase]\r\ngeragridmain[false]")
        //        .HasColumnName("complendcorresp");
        //    entity.Property(e => e.Complendlocal)
        //        .HasMaxLength(50)
        //        .HasComment("forminputlabel[Complemento Endereço Localização]\r\nforminputsize[20]\r\nforminputclass[uppercase]\r\ngeragridmain[false]")
        //        .HasColumnName("complendlocal");
        //    entity.Property(e => e.Contador)
        //        .HasComment("forminputlabel[Contador]\r\nforminputsize[10]\r\ngeragridmain[false]")
        //        .HasColumnName("contador");
        //    entity.Property(e => e.Cpfcnpj)
        //        .HasMaxLength(21)
        //        .HasComment("forminputlabel[CPF/CNPJ] \r\nforminputsize[15]\r\nforminputclass[number]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[CPF/CNPJ]\r\ncolumngridtype[ro]\r\ncolumngridsize[100]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("cpfcnpj");
        //    entity.Property(e => e.Cpfresponsavel)
        //        .HasColumnType("character varying")
        //        .HasColumnName("cpfresponsavel");
        //    entity.Property(e => e.Datahoraalteracao)
        //        .HasComment("geraform[false]\r\ngeragridmain[false]")
        //        .HasColumnType("timestamp without time zone")
        //        .HasColumnName("datahoraalteracao");
        //    entity.Property(e => e.Dddcelcorresp)
        //        .HasMaxLength(3)
        //        .HasComment("forminputlabel[DDD-Cel. Correspondência]\r\nforminputsize[10]\r\nforminputclass[number]\r\ngeragridmain[false]")
        //        .HasColumnName("dddcelcorresp");
        //    entity.Property(e => e.Dddcellocal)
        //        .HasMaxLength(3)
        //        .HasColumnName("dddcellocal");
        //    entity.Property(e => e.Dddfaxcorresp)
        //        .HasMaxLength(3)
        //        .HasComment("forminputlabel[DDD-Fax Correspondência]\r\nforminputsize[10]\r\nforminputclass[number]\r\ngeragridmain[false]")
        //        .HasColumnName("dddfaxcorresp");
        //    entity.Property(e => e.Dddfaxlocal)
        //        .HasMaxLength(3)
        //        .HasComment("forminputlabel[DDD-Fax Localização]\r\nforminputsize[10]\r\nforminputclass[number]\r\ngeragridmain[false]")
        //        .HasColumnName("dddfaxlocal");
        //    entity.Property(e => e.Dddfonecorresp)
        //        .HasMaxLength(3)
        //        .HasComment("forminputlabel[DDD-Fone Correspondência] \r\nforminputsize[10]\r\nforminputclass[number]\r\ngeragridmain[false]")
        //        .HasColumnName("dddfonecorresp");
        //    entity.Property(e => e.Dddfonelocal)
        //        .HasMaxLength(3)
        //        .HasComment("forminputlabel[DDD-Fone Localização]\r\nforminputsize[10]\r\nforminputclass[number]\r\ngeragridmain[false]")
        //        .HasColumnName("dddfonelocal");
        //    entity.Property(e => e.Disponivel)
        //        .HasComment("Empresas ques estao visiveis (listagem grid) para o login da prefeitura")
        //        .HasColumnName("disponivel");
        //    entity.Property(e => e.Distritocorresp)
        //        .HasMaxLength(50)
        //        .HasComment("forminputlabel[Distrito Correspondência]\r\nforminputsize[30]\r\nforminputclass[uppercase]\r\ngeragridmain[false]")
        //        .HasColumnName("distritocorresp");
        //    entity.Property(e => e.Distritolocal)
        //        .HasMaxLength(50)
        //        .HasComment("forminputlabel[Distrito Localização]\r\nforminputsize[30]\r\nforminputclass[uppercase]\r\ngeragridmain[false]")
        //        .HasColumnName("distritolocal");
        //    entity.Property(e => e.Email)
        //        .HasMaxLength(40)
        //        .HasComment("forminputlabel[Email]\r\nforminputsize[40]\r\nforminputclass[email]\r\ngeragridmain[false]")
        //        .HasColumnName("email");
        //    entity.Property(e => e.Endcorresp)
        //        .HasColumnType("character varying")
        //        .HasColumnName("endcorresp");
        //    entity.Property(e => e.Endlocal)
        //        .HasColumnType("character varying")
        //        .HasColumnName("endlocal");
        //    entity.Property(e => e.Etapa).HasColumnName("etapa");
        //    entity.Property(e => e.Faxcorresp)
        //        .HasMaxLength(9)
        //        .HasComment("forminputlabel[Fax Correspondência]\r\nforminputsize[15]\r\nforminputclass[uppercase]\r\ngeragridmain[false]")
        //        .HasColumnName("faxcorresp");
        //    entity.Property(e => e.Faxlocal)
        //        .HasMaxLength(9)
        //        .HasComment("forminputlabel[Fax Localização]\r\nforminputsize[15]\r\nforminputclass[uppercase]\r\ngeragridmain[false]")
        //        .HasColumnName("faxlocal");
        //    entity.Property(e => e.Fonecorresp)
        //        .HasMaxLength(9)
        //        .HasComment("forminputlabel[Fone Correspondência] \r\nforminputsize[15]\r\nforminputclass[uppercase]\r\ngeragridmain[false]")
        //        .HasColumnName("fonecorresp");
        //    entity.Property(e => e.Fonelocal)
        //        .HasMaxLength(9)
        //        .HasComment("forminputlabel[Fone Localização]\r\nforminputsize[15]\r\nforminputclass[uppercase]\r\ngeragridmain[false]")
        //        .HasColumnName("fonelocal");
        //    entity.Property(e => e.Grupoaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Inscricaoestadual)
        //        .HasMaxLength(15)
        //        .HasComment("forminputlabel[Inscrição Estadual] \r\nforminputsize[15]\r\nforminputclass[number]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Inscrição Estadual]\r\ncolumngridtype[ro]\r\ncolumngridsize[100]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("inscricaoestadual");
        //    entity.Property(e => e.Inscricaomunicipal)
        //        .HasMaxLength(30)
        //        .HasComment("forminputlabel[Inscrição Municipal] \r\nforminputsize[15]\r\nforminputclass[number]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Inscrição Municipal]\r\ncolumngridtype[ro]\r\ncolumngridsize[100]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("inscricaomunicipal");
        //    entity.Property(e => e.Ipalteracao)
        //        .HasMaxLength(40)
        //        .HasComment("geraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("ipalteracao");
        //    entity.Property(e => e.Logradourocorresp)
        //        .HasMaxLength(50)
        //        .HasComment("forminputlabel[Logradouro Correspondência]\r\nforminputsize[30]\r\nforminputclass[uppercase]\r\ngeragridmain[false]")
        //        .HasColumnName("logradourocorresp");
        //    entity.Property(e => e.Logradourolocal)
        //        .HasMaxLength(50)
        //        .HasComment("forminputlabel[Logradouro Localização]\r\nforminputsize[30]\r\nforminputclass[uppercase]\r\ngeragridmain[false]")
        //        .HasColumnName("logradourolocal");
        //    entity.Property(e => e.Nomefantasia)
        //        .HasMaxLength(120)
        //        .HasComment("forminputlabel[Nome Fantasia]\r\nforminputsize[50]\r\nforminputclass[uppercase]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Nome-Fantasia]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("nomefantasia");
        //    entity.Property(e => e.Numeroendcorresp)
        //        .HasComment("forminputlabel[Nº Correspondência]\r\nforminputsize[10]\r\nforminputclass[number]\r\ngeragridmain[false]")
        //        .HasColumnName("numeroendcorresp");
        //    entity.Property(e => e.Numeroendlocal).HasColumnName("numeroendlocal");
        //    entity.Property(e => e.Numeronire)
        //        .HasMaxLength(20)
        //        .HasComment("forminputlabel[Número NIRE] \r\nforminputsize[10]\r\nforminputclass[number]\r\ngeragridmain[false]")
        //        .HasColumnName("numeronire");
        //    entity.Property(e => e.Observacao)
        //        .HasMaxLength(200)
        //        .HasComment("forminputlabel[Observação] \r\nforminputsize[50]\r\nforminputclass[uppercase]")
        //        .HasColumnName("observacao");
        //    entity.Property(e => e.Primeiraatualizacao)
        //        .HasDefaultValue(false)
        //        .HasColumnName("primeiraatualizacao");
        //    entity.Property(e => e.Razaosocial)
        //        .HasMaxLength(250)
        //        .HasComment("forminputlabel[Razão Social] \r\nforminputsize[40]\r\nforminputclass[uppercase]\r\ngeragridmain[false]")
        //        .HasColumnName("razaosocial");
        //    entity.Property(e => e.Razaosocialreduzido)
        //        .HasMaxLength(50)
        //        .HasComment("forminputlabel[Razão Social Reduzido] \r\nforminputsize[30]\r\nforminputclass[uppercase]\r\ngeragridmain[false]")
        //        .HasColumnName("razaosocialreduzido");
        //    entity.Property(e => e.Respostaxml).HasColumnName("respostaxml");
        //    entity.Property(e => e.Senha)
        //        .HasColumnType("character varying")
        //        .HasColumnName("senha");
        //    entity.Property(e => e.Situacao)
        //        .HasMaxLength(1)
        //        .HasComment("SITUAÇÃO ( A / I )\r\n\r\nforminputlabel[Situação] \r\nforminputsize[10]\r\nforminputclass[uppercase]\r\ngeragridmain[false]")
        //        .HasColumnName("situacao");
        //    entity.Property(e => e.Tipobairrocorresp)
        //        .HasMaxLength(30)
        //        .HasComment("forminputlabel[Tipo Bairro Correspondência]\r\nforminputsize[20]\r\nforminputclass[uppercase]\r\ngeragridmain[false]")
        //        .HasColumnName("tipobairrocorresp");
        //    entity.Property(e => e.Tipologcorresp)
        //        .HasMaxLength(30)
        //        .HasComment("forminputlabel[Tipo Logradouro Correspondência]\r\nforminputsize[30]\r\nforminputclass[uppercase]\r\ngeragridmain[false]")
        //        .HasColumnName("tipologcorresp");
        //    entity.Property(e => e.Tipologlocal)
        //        .HasMaxLength(30)
        //        .HasComment("forminputlabel[Tipo Logradouro Localização]\r\nforminputsize[20]\r\nforminputclass[uppercase]\r\ngeragridmain[false]")
        //        .HasColumnName("tipologlocal");
        //    entity.Property(e => e.Tipopessoa)
        //        .HasMaxLength(3)
        //        .HasComment("TIPO DA PESSOA ( PF / PJ / PFE)\r\n\r\nforminputlabel[Tipo Pessoa]\r\nforminputsize[5]\r\nforminputclass[uppercase]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Tipo-Pessoa]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("tipopessoa");
        //    entity.Property(e => e.Ufcorresp)
        //        .HasMaxLength(50)
        //        .HasComment("forminputlabel[UF Correspondência]\r\nforminputsize[20]\r\nforminputclass[uppercase]\r\ngeragridmain[false]")
        //        .HasColumnName("ufcorresp");
        //    entity.Property(e => e.Uflocal)
        //        .HasMaxLength(50)
        //        .HasComment("forminputlabel[UF Localização]\r\nforminputsize[15]\r\nforminputclass[uppercase]\r\ngeragridmain[false]")
        //        .HasColumnName("uflocal");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuario)
        //        .HasDefaultValue(147)
        //        .HasColumnName("usuario");
        //    entity.Property(e => e.Usuarioalteracao).HasColumnName("usuarioalteracao");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("version");
        //});

        //modelBuilder.Entity<Empresa2>(entity =>
        //{
        //    entity.HasKey(e => e.Empresaid).HasName("empresa_pkey");

        //    entity.ToTable("empresa", "residuos", tb => tb.HasComment("template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs]\r\n\r\nformtitle[Cadastro de Empresa]\r\nfiltersgrid[#text_filter,#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Empresas]"));

        //    entity.HasIndex(e => e.Inscricaomunicipal, "empresa_inscricaomunicipal_key1").IsUnique();

        //    entity.Property(e => e.Empresaid)
        //        .HasComment("forminputlabel[Código]\r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("empresaid");
        //    entity.Property(e => e.Datacadastro)
        //        .HasColumnType("timestamp without time zone")
        //        .HasColumnName("datacadastro");
        //    entity.Property(e => e.Datalicenciamento)
        //        .HasComment("forminputlabel[Data Licenciamento]\r\nforminputsize[10]\r\nforminputclass[date]\r\n\r\ngeragridmain[false]")
        //        .HasColumnName("datalicenciamento");
        //    entity.Property(e => e.Datavenclicenciamento)
        //        .HasComment("forminputlabel[Dt. Venc. Licenciamento]\r\nforminputsize[10]\r\nforminputclass[number]\r\n\r\ngeragridmain[false]")
        //        .HasColumnName("datavenclicenciamento");
        //    entity.Property(e => e.Email)
        //        .HasColumnType("character varying")
        //        .HasColumnName("email");
        //    entity.Property(e => e.Grupoaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]")
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Inscricaoeconomica)
        //        .HasMaxLength(25)
        //        .HasColumnName("inscricaoeconomica");
        //    entity.Property(e => e.Inscricaomunicipal)
        //        .HasColumnType("character varying")
        //        .HasColumnName("inscricaomunicipal");
        //    entity.Property(e => e.Nome)
        //        .HasColumnType("character varying")
        //        .HasColumnName("nome");
        //    entity.Property(e => e.Numerolicenciamento)
        //        .HasComment("forminputlabel[Nº Licenciamento]\r\nforminputsize[10]\r\nforminputclass[number]\r\n\r\ngeragridmain[false]")
        //        .HasColumnName("numerolicenciamento");
        //    entity.Property(e => e.Razaosocial)
        //        .HasColumnType("character varying")
        //        .HasColumnName("razaosocial");
        //    entity.Property(e => e.Senha)
        //        .HasComment("forminputlabel[Senha]\r\nforminputsize[10]\r\nforminputclass[]\r\n\r\ngeragridmain[false]")
        //        .HasColumnType("character varying")
        //        .HasColumnName("senha");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]")
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuario).HasColumnName("usuario");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]")
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]")
        //        .HasColumnName("version");
        //});

        //modelBuilder.Entity<Empresaresiduo>(entity =>
        //{
        //    entity.HasKey(e => e.Empresaresiduoid).HasName("empresaresiduo_pkey");

        //    entity.ToTable("empresaresiduo", "residuos", tb => tb.HasComment("template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs]\r\n\r\nformtitle[Cadastro de Resíduo da Empresa]\r\nfiltersgrid[#text_filter,#text_filter,#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Resíduos da Empresa]"));

        //    entity.Property(e => e.Empresaresiduoid)
        //        .HasComment("forminputlabel[Código]\r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("empresaresiduoid");
        //    entity.Property(e => e.Armazenamento)
        //        .HasComment("forminputlabel[Armazenamento]\r\nforminputsize[150]\r\n\r\nsearchmode[combobox]\r\ncomboboxresultfield[armazenamento.nome]\r\n\r\ncolumngridid[armazenamento.nome]\r\ncolumngridtitle[Armazenamento]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("armazenamento");
        //    entity.Property(e => e.Empresa).HasColumnName("empresa");
        //    entity.Property(e => e.Grupoaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]")
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Residuo)
        //        .HasComment("forminputlabel[Resíduo]\r\nforminputsize[30]\r\nforminputclass[uppercase]\r\n\r\nsearchmode[popup]\r\npopupresultfield[nome]\r\npopupfieldsgrid[residuoid,nome:residuoid]\r\n\r\ncolumngridid[residuo.nome]\r\ncolumngridtitle[Resíduo]\r\ncolumngridtype[ro]\r\ncolumngridsize[150]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("residuo");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]")
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]")
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]")
        //        .HasColumnName("version");

        //    entity.HasOne(d => d.ArmazenamentoNavigation).WithMany(p => p.Empresaresiduos)
        //        .HasForeignKey(d => d.Armazenamento)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("empresaresiduo_fk1");

        //    entity.HasOne(d => d.EmpresaNavigation).WithMany(p => p.Empresaresiduos)
        //        .HasForeignKey(d => d.Empresa)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("empresaresiduo_fk");
        //});

        //modelBuilder.Entity<Endereco>(entity =>
        //{
        //    entity.HasKey(e => e.Enderecoid).HasName("endereco_pkey");

        //    entity.ToTable("endereco");

        //    entity.Property(e => e.Enderecoid).HasColumnName("enderecoid");
        //    entity.Property(e => e.Bairro).HasColumnName("bairro");
        //    entity.Property(e => e.Cep)
        //        .HasColumnType("character varying")
        //        .HasColumnName("cep");
        //    entity.Property(e => e.Logradouro).HasColumnName("logradouro");
        //    entity.Property(e => e.Numero).HasColumnName("numero");
        //    entity.Property(e => e.Tipologradouro).HasColumnName("tipologradouro");
        //});

        //modelBuilder.Entity<Entidade>(entity =>
        //{
        //    entity.HasKey(e => e.Entidadeid).HasName("entidade_pkey");

        //    entity.ToTable("entidade", tb => tb.HasComment("template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Entidade] \r\n\r\nfieldsgrid[entidadeid,nome:entidadeid]\r\nfiltersgrid[#text_filter,#text_filter] \r\n\r\nfieldsform[entidadeid,nome]\r\n\r\ngridtitle[Lista de Entidades]"));

        //    entity.Property(e => e.Entidadeid)
        //        .HasComment("forminputlabel[Código]\r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("entidadeid");
        //    entity.Property(e => e.Grupoaud).HasColumnName("grupoaud");
        //    entity.Property(e => e.Nome)
        //        .HasComment("forminputlabel[Nome]\r\nforminputsize[50]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Nome]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnType("character varying")
        //        .HasColumnName("nome");
        //    entity.Property(e => e.Unidade).HasColumnName("unidade");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud).HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version).HasColumnName("version");
        //});

        //modelBuilder.Entity<Estadofisico>(entity =>
        //{
        //    entity.HasKey(e => e.Estadofisicoid).HasName("estadofisico_pkey");

        //    entity.ToTable("estadofisico", "residuos", tb => tb.HasComment("template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs]\r\n\r\nformtitle[Cadastro de Estado Físico]\r\nfiltersgrid[#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Estado Físico]"));

        //    entity.Property(e => e.Estadofisicoid)
        //        .HasComment("forminputlabel[Código]\r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("estadofisicoid");
        //    entity.Property(e => e.Grupoaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]")
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Nome)
        //        .HasComment("forminputlabel[Nome]\r\nforminputsize[50]\r\nforminputclass[uppercase]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Nome]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnType("character varying")
        //        .HasColumnName("nome");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]")
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]")
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]")
        //        .HasColumnName("version");
        //});

        //modelBuilder.Entity<Evento>(entity =>
        //{
        //    entity.HasKey(e => e.Eventoid).HasName("evento_pkey");

        //    entity.ToTable("evento", "sisobra", tb => tb.HasComment("template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Evento]\r\nfiltersgrid[#text_filter,#text_filter,#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Eventos]"));

        //    entity.Property(e => e.Eventoid)
        //        .HasComment("forminputlabel[Código] \r\nforminputsize[7]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Código] \r\ncolumngridtype[ro] \r\ncolumngridsize[80] \r\ncolumngridalign[left] \r\ncolumngridcolor[]")
        //        .HasColumnName("eventoid");
        //    entity.Property(e => e.Dataevento)
        //        .HasComment("forminputlabel[Data-Evento] \r\nforminputsize[12]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Data-Evento] \r\ncolumngridtype[ro] \r\ncolumngridsize[20] \r\ncolumngridalign[left] \r\ncolumngridcolor[]")
        //        .HasColumnName("dataevento");
        //    entity.Property(e => e.Grupoaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Nome)
        //        .HasComment("forminputlabel[Nome] \r\nforminputsize[70]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Nome] \r\ncolumngridtype[ro] \r\ncolumngridsize[*] \r\ncolumngridalign[left] \r\ncolumngridcolor[]")
        //        .HasColumnType("character varying")
        //        .HasColumnName("nome");
        //    entity.Property(e => e.Status)
        //        .HasMaxLength(1)
        //        .HasDefaultValueSql("'I'::character varying")
        //        .HasComment("forminputlabel[Status] \r\nforminputsize[12]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Status] \r\ncolumngridtype[ro] \r\ncolumngridsize[20] \r\ncolumngridalign[left] \r\ncolumngridcolor[]")
        //        .HasColumnName("status");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("version");
        //});

        //modelBuilder.Entity<Exigencia>(entity =>
        //{
        //    entity.HasKey(e => e.Exigenciaid).HasName("exigencia_pkey");

        //    entity.ToTable("exigencia", "agenda");

        //    entity.Property(e => e.Exigenciaid).HasColumnName("exigenciaid");
        //    entity.Property(e => e.Grupoaud)
        //        .HasDefaultValue(0)
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Nome)
        //        .HasColumnType("character varying")
        //        .HasColumnName("nome");
        //    entity.Property(e => e.Ordem)
        //        .HasColumnType("character varying")
        //        .HasColumnName("ordem");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasDefaultValue(0)
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasColumnName("version");
        //});

        //modelBuilder.Entity<Extrato>(entity =>
        //{
        //    entity.HasKey(e => e.Extratoid).HasName("extrato_pkey");

        //    entity.ToTable("extrato", "divulgacao");

        //    entity.Property(e => e.Extratoid).HasColumnName("extratoid");
        //    entity.Property(e => e.Ano).HasColumnName("ano");
        //    entity.Property(e => e.Dataprocesso)
        //        .HasComment("Data do Processo")
        //        .HasColumnName("dataprocesso");
        //    entity.Property(e => e.Grupoaud).HasColumnName("grupoaud");
        //    entity.Property(e => e.Inscricaoeconomica)
        //        .HasComment("Empresa - Requerente")
        //        .HasColumnType("character varying")
        //        .HasColumnName("inscricaoeconomica");
        //    entity.Property(e => e.Inscricaoimobiliaria)
        //        .HasComment("Localidade pela inscrição imobiliária")
        //        .HasColumnType("character varying")
        //        .HasColumnName("inscricaoimobiliaria");
        //    entity.Property(e => e.Numeroextrato).HasColumnName("numeroextrato");
        //    entity.Property(e => e.Processo)
        //        .HasComment("Processo")
        //        .HasColumnType("character varying")
        //        .HasColumnName("processo");
        //    entity.Property(e => e.Tipoanalise)
        //        .HasComment("1-Autorização Definitiva\r\n2-Uso nao Conforme")
        //        .HasColumnName("tipoanalise");
        //    entity.Property(e => e.Tipoveiculodivulgacao)
        //        .HasComment("Tipo de Veiculo de Divulgação")
        //        .HasColumnName("tipoveiculodivulgacao");
        //    entity.Property(e => e.Unidadeaud).HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud).HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version).HasColumnName("version");

        //    entity.HasOne(d => d.TipoveiculodivulgacaoNavigation).WithMany(p => p.Extratos)
        //        .HasForeignKey(d => d.Tipoveiculodivulgacao)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("extrato_fk");
        //});

        //modelBuilder.Entity<Faseobra>(entity =>
        //{
        //    entity.HasKey(e => e.Faseobraid).HasName("faseobra_pkey");

        //    entity.ToTable("faseobra", "sisobra", tb => tb.HasComment("template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Fase da Obra]\r\nfiltersgrid[#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Fases da Obra]"));

        //    entity.Property(e => e.Faseobraid)
        //        .HasComment("forminputlabel[Código] \r\nforminputsize[7]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Código] \r\ncolumngridtype[ro] \r\ncolumngridsize[80] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnName("faseobraid");
        //    entity.Property(e => e.Grupoaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Nome)
        //        .HasComment("forminputlabel[Nome] \r\nforminputsize[70]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Nome] \r\ncolumngridtype[ro] \r\ncolumngridsize[*] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnType("character varying")
        //        .HasColumnName("nome");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("version");
        //});

        //modelBuilder.Entity<Fiscal>(entity =>
        //{
        //    entity.HasKey(e => e.Fiscalid).HasName("fiscal_pkey");

        //    entity.ToTable("fiscal", "sisobra", tb => tb.HasComment("template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Fiscal]\r\nfiltersgrid[#text_filter,#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Fiscais]"));

        //    entity.Property(e => e.Fiscalid)
        //        .HasComment("forminputlabel[Código] \r\nforminputsize[7]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Código] \r\ncolumngridtype[ro] \r\ncolumngridsize[80] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnName("fiscalid");
        //    entity.Property(e => e.Grupoaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Nome)
        //        .HasComment("forminputlabel[Nome] \r\nforminputsize[70]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Nome] \r\ncolumngridtype[ro] \r\ncolumngridsize[*] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnType("character varying")
        //        .HasColumnName("nome");
        //    entity.Property(e => e.Telefone)
        //        .HasComment("forminputlabel[Telefone] \r\nforminputsize[10]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Telefone] \r\ncolumngridtype[ro] \r\ncolumngridsize[20] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnType("character varying")
        //        .HasColumnName("telefone");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("version");
        //});

        //modelBuilder.Entity<Fonterecurso>(entity =>
        //{
        //    entity.HasKey(e => e.Fonterecursoid).HasName("fonterecurso_pkey");

        //    entity.ToTable("fonterecurso", "sisobra", tb => tb.HasComment("template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Fonte Recurso]\r\nfiltersgrid[#text_filter,#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Fontes de Recurso]"));

        //    entity.Property(e => e.Fonterecursoid)
        //        .HasComment("forminputlabel[Código] \r\nforminputsize[7]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Código] \r\ncolumngridtype[ro] \r\ncolumngridsize[80] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnName("fonterecursoid");
        //    entity.Property(e => e.Grupoaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Nome)
        //        .HasComment("forminputlabel[Nome] \r\nforminputsize[70]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Nome] \r\ncolumngridtype[ro] \r\ncolumngridsize[*] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnType("character varying")
        //        .HasColumnName("nome");
        //    entity.Property(e => e.Sigla)
        //        .HasComment("forminputlabel[Sigla] \r\nforminputsize[10]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Sigla] \r\ncolumngridtype[ro] \r\ncolumngridsize[20] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnType("character varying")
        //        .HasColumnName("sigla");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("version");
        //});

        //modelBuilder.Entity<Grupo>(entity =>
        //{
        //    entity.HasKey(e => e.Grupoid).HasName("grupo_pk");

        //    entity.ToTable("grupo", tb => tb.HasComment("template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]  \r\n\r\nformtitle[Cadastro de Grupo]   \r\nfieldsgrid[grupoid,nome:grupoid] \r\n\r\nfieldsform[grupoid,nome] \r\n\r\ngridtitle[Lista de Grupos]"));

        //    entity.Property(e => e.Grupoid)
        //        .HasComment("forminputlabel[Código] forminputsize[7]  columngridid[] columngridtitle[Código] columngridtype[ro] columngridsize[80] columngridalign[left] columngridcolor[white]")
        //        .HasColumnName("grupoid");
        //    entity.Property(e => e.Grupoaud).HasColumnName("grupoaud");
        //    entity.Property(e => e.Nome)
        //        .HasMaxLength(200)
        //        .HasComment("forminputlabel[Nome] forminputsize[50]  columngridid[] columngridtitle[Nome] columngridtype[ro] columngridsize[*] columngridalign[left] columngridcolor[white]")
        //        .HasColumnName("nome");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud).HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasColumnName("version");
        //});

        //modelBuilder.Entity<Grupousuario>(entity =>
        //{
        //    entity.HasKey(e => e.Grupousuarioid).HasName("grupousuario_pk");

        //    entity.ToTable("grupousuario", tb => tb.HasComment("template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Grupo / Usuário]\r\n\r\nfieldsgrid[grupousuarioid,usuario.nome,grupo.nome,sistema.nome:grupousuarioid]\r\nfiltersgrid[#text_filter,#text_filter,#text_filter,#text_filter] \r\n\r\nfieldsform[grupousuarioid,usuario.usuarioid,usuario.nome,grupo.grupoid,grupo.nome,sistema.sistemaid,sistema.nome] \r\n\r\ngridtitle[Lista de Grupos / Usuário]"));

        //    entity.Property(e => e.Grupousuarioid)
        //        .HasComment("forminputlabel[Código] \r\nforminputsize[7]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Código] \r\ncolumngridtype[ro] \r\ncolumngridsize[80] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnName("grupousuarioid");
        //    entity.Property(e => e.Grupo)
        //        .HasComment("forminputlabel[Grupo]\r\nforminputsize[250]\r\n\r\nsearchmode[combobox]\r\ncomboboxresultfield[nome]\r\n\r\ncolumngridid[grupo.nome]\r\ncolumngridtitle[Grupo]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("grupo");
        //    entity.Property(e => e.Grupoaud).HasColumnName("grupoaud");
        //    entity.Property(e => e.Sistema)
        //        .HasComment("forminputlabel[Sistema]\r\nforminputsize[250]\r\n\r\nsearchmode[combobox]\r\ncomboboxresultfield[nome]\r\n\r\ncolumngridid[sistema.nome]\r\ncolumngridtitle[Sistema]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("sistema");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuario)
        //        .HasComment("forminputlabel[Usuário]\r\nforminputsize[50]\r\n\r\nsearchmode[popup]\r\npopupresultfield[nome]\r\npopupfieldsgrid[usuarioid,nome,login,senha:usuarioid]\r\n\r\ncolumngridid[usuario.nome]\r\ncolumngridtitle[Usuário]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("usuario");
        //    entity.Property(e => e.Usuarioaud).HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasColumnName("version");

        //    entity.HasOne(d => d.GrupoNavigation).WithMany(p => p.Grupousuarios)
        //        .HasForeignKey(d => d.Grupo)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("grupo_grupousuario_fk");

        //    entity.HasOne(d => d.SistemaNavigation).WithMany(p => p.Grupousuarios)
        //        .HasForeignKey(d => d.Sistema)
        //        .HasConstraintName("grupousuario_fk");

        //    entity.HasOne(d => d.UsuarioNavigation).WithMany(p => p.Grupousuarios)
        //        .HasForeignKey(d => d.Usuario)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("usuario_grupousuario_fk");
        //});

        //modelBuilder.Entity<Historico>(entity =>
        //{
        //    entity.HasKey(e => e.Historicoid).HasName("historico_pkey");

        //    entity.ToTable("historico", "agenda");

        //    entity.Property(e => e.Historicoid).HasColumnName("historicoid");
        //    entity.Property(e => e.Autor)
        //        .HasColumnType("character varying")
        //        .HasColumnName("autor");
        //    entity.Property(e => e.Dataexportado)
        //        .HasColumnType("timestamp without time zone")
        //        .HasColumnName("dataexportado");
        //    entity.Property(e => e.Datahora)
        //        .HasColumnType("timestamp without time zone")
        //        .HasColumnName("datahora");
        //    entity.Property(e => e.Despacho)
        //        .HasColumnType("character varying")
        //        .HasColumnName("despacho");
        //    entity.Property(e => e.Exportado)
        //        .HasDefaultValue(0)
        //        .HasColumnName("exportado");
        //    entity.Property(e => e.Grupoaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Projeto).HasColumnName("projeto");
        //    entity.Property(e => e.Sequencia).HasColumnName("sequencia");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("version");

        //    entity.HasOne(d => d.ProjetoNavigation).WithMany(p => p.Historicos)
        //        .HasForeignKey(d => d.Projeto)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("historico_fk");
        //});

        //modelBuilder.Entity<Logacesso>(entity =>
        //{
        //    entity.HasKey(e => e.Logacessoid).HasName("logacesso_pk");

        //    entity.ToTable("logacesso", tb => tb.HasComment("template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]  \r\n\r\nformtitle[Cadastro de Log de acesso]   \r\nfieldsgrid[logacessoid,usuario.nome,sistema.nome,data,ip:logacessoid] \r\n\r\nfieldsform[logacessoid,usuario.usuarioid,usuario.nome,sistema.sistemaid,sistema.nome,data,ip] \r\n\r\ngridtitle[Lista de Logs de acesso]"));

        //    entity.Property(e => e.Logacessoid)
        //        .HasComment("forminputlabel[Código] forminputsize[7]  columngridid[] columngridtitle[Código] columngridtype[ro] columngridsize[80] columngridalign[left] columngridcolor[white]")
        //        .HasColumnName("logacessoid");
        //    entity.Property(e => e.Data)
        //        .HasDefaultValueSql("now()")
        //        .HasComment("forminputlabel[Data] forminputsize[50]  columngridid[] columngridtitle[Data] columngridtype[ro] columngridsize[100] columngridalign[left] columngridcolor[white]")
        //        .HasColumnType("timestamp without time zone")
        //        .HasColumnName("data");
        //    entity.Property(e => e.Grupo).HasColumnName("grupo");
        //    entity.Property(e => e.Grupoaud).HasColumnName("grupoaud");
        //    entity.Property(e => e.Ip)
        //        .HasMaxLength(25)
        //        .HasComment("forminputlabel[IP] forminputsize[50]  columngridid[] columngridtitle[IP] columngridtype[ro] columngridsize[100] columngridalign[left] columngridcolor[white]")
        //        .HasColumnName("ip");
        //    entity.Property(e => e.Sistema)
        //        .HasComment("forminputlabel[Sistema]\r\nforminputsize[250]\r\n\r\nsearchmode[combobox]\r\ncomboboxresultfield[nome]\r\n\r\ncolumngridid[sistema.nome]\r\ncolumngridtitle[Sistema]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("sistema");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuario)
        //        .HasComment("forminputlabel[Usuario]\r\nforminputsize[50]\r\n\r\nsearchmode[popup]\r\npopupresultfield[nome]\r\npopupfieldsgrid[usuarioid,nome,login,senha:usuarioid]\r\n\r\ncolumngridid[usuario.nome]\r\ncolumngridtitle[Usuário]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("usuario");
        //    entity.Property(e => e.Usuarioaud).HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasColumnName("version");

        //    entity.HasOne(d => d.SistemaNavigation).WithMany(p => p.Logacessos)
        //        .HasForeignKey(d => d.Sistema)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("sistema_logacesso_fk");

        //    entity.HasOne(d => d.UsuarioNavigation).WithMany(p => p.Logacessos)
        //        .HasForeignKey(d => d.Usuario)
        //        .HasConstraintName("usuario_logacesso_fk");
        //});

        //modelBuilder.Entity<Logradouro>(entity =>
        //{
        //    entity.HasKey(e => e.Logradouroid).HasName("logradouro_pkey");

        //    entity.ToTable("logradouro");

        //    entity.Property(e => e.Logradouroid).HasColumnName("logradouroid");
        //    entity.Property(e => e.Nome)
        //        .HasColumnType("character varying")
        //        .HasColumnName("nome");
        //});

        //modelBuilder.Entity<Logsistema>(entity =>
        //{
        //    entity.HasKey(e => e.Logsistemaid).HasName("logsistema_pk");

        //    entity.ToTable("logsistema", tb => tb.HasComment("template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]  \r\n\r\nformtitle[Cadastro de Log do sistema]   \r\nfieldsgrid[logsistemaid,sistema.nome,versao,data:logsistemaid] \r\n\r\nfieldsform[logsistemaid,sistema.sistemaid,sistema.nome,versao,data] \r\n\r\ngridtitle[Lista de Logs do sistema]"));

        //    entity.Property(e => e.Logsistemaid)
        //        .HasComment("forminputlabel[Código] forminputsize[7]  columngridid[] columngridtitle[Código] columngridtype[ro] columngridsize[80] columngridalign[left] columngridcolor[white]")
        //        .HasColumnName("logsistemaid");
        //    entity.Property(e => e.Data)
        //        .HasDefaultValueSql("now()")
        //        .HasColumnType("timestamp without time zone")
        //        .HasColumnName("data");
        //    entity.Property(e => e.Grupoaud).HasColumnName("grupoaud");
        //    entity.Property(e => e.Sistema)
        //        .HasComment("forminputlabel[Sistema]\r\nforminputsize[250]\r\n\r\nsearchmode[combobox]\r\ncomboboxresultfield[nome]\r\n\r\ncolumngridid[sistema.nome]\r\ncolumngridtitle[Sistema]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("sistema");
        //    entity.Property(e => e.Unidade).HasColumnName("unidade");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud).HasColumnName("usuarioaud");
        //    entity.Property(e => e.Versao)
        //        .HasMaxLength(30)
        //        .HasComment("forminputlabel[Versão] forminputsize[50]  columngridid[] columngridtitle[Versão] columngridtype[ro] columngridsize[100] columngridalign[left] columngridcolor[white]")
        //        .HasColumnName("versao");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasColumnName("version");

        //    entity.HasOne(d => d.SistemaNavigation).WithMany(p => p.Logsistemas)
        //        .HasForeignKey(d => d.Sistema)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("sistema_logsistema_fk");
        //});

        //modelBuilder.Entity<Mensagem>(entity =>
        //{
        //    entity.HasKey(e => e.Mensagemid).HasName("mensagem_pkey");

        //    entity.ToTable("mensagem", "agenda");

        //    entity.Property(e => e.Mensagemid).HasColumnName("mensagemid");
        //    entity.Property(e => e.Datahora)
        //        .HasColumnType("timestamp without time zone")
        //        .HasColumnName("datahora");
        //    entity.Property(e => e.Grupo)
        //        .HasDefaultValue(0)
        //        .HasColumnName("grupo");
        //    entity.Property(e => e.Grupoaud)
        //        .HasDefaultValue(0)
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Lida)
        //        .HasDefaultValue(0)
        //        .HasColumnName("lida");
        //    entity.Property(e => e.Projeto)
        //        .HasDefaultValue(0)
        //        .HasColumnName("projeto");
        //    entity.Property(e => e.Texto)
        //        .HasDefaultValueSql("0")
        //        .HasColumnType("character varying")
        //        .HasColumnName("texto");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuario)
        //        .HasDefaultValueSql("0")
        //        .HasColumnType("character varying")
        //        .HasColumnName("usuario");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasDefaultValue(0)
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasColumnName("version");
        //});

        //modelBuilder.Entity<Ministerio>(entity =>
        //{
        //    entity.HasKey(e => e.Ministerioid).HasName("ministerio_pkey");

        //    entity.ToTable("ministerio", "sisobra", tb => tb.HasComment("template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Ministério]\r\nfiltersgrid[#text_filter,#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Ministérios]"));

        //    entity.Property(e => e.Ministerioid)
        //        .HasComment("forminputlabel[Código] \r\nforminputsize[7]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Código] \r\ncolumngridtype[ro] \r\ncolumngridsize[80] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnName("ministerioid");
        //    entity.Property(e => e.Grupoaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Nome)
        //        .HasComment("forminputlabel[Nome] \r\nforminputsize[70]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Nome] \r\ncolumngridtype[ro] \r\ncolumngridsize[*] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnType("character varying")
        //        .HasColumnName("nome");
        //    entity.Property(e => e.Sigla)
        //        .HasComment("forminputlabel[Sigla] \r\nforminputsize[10]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Sigla] \r\ncolumngridtype[ro] \r\ncolumngridsize[20] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnType("character varying")
        //        .HasColumnName("sigla");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("version");
        //});

        //modelBuilder.Entity<Modulo>(entity =>
        //{
        //    entity.HasKey(e => e.Moduloid).HasName("modulo_pk");

        //    entity.ToTable("modulo", tb => tb.HasComment("template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]  \r\n\r\nformtitle[Cadastro de Módulo]   \r\nfieldsgrid[moduloid,nome:moduloid] \r\n\r\nfieldsform[moduloid,nome] \r\n\r\ngridtitle[Lista de Módulos]"));

        //    entity.Property(e => e.Moduloid)
        //        .HasComment("forminputlabel[Código] \r\nforminputsize[7]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Código] \r\ncolumngridtype[ro] \r\ncolumngridsize[80] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnName("moduloid");
        //    entity.Property(e => e.Grupoaud).HasColumnName("grupoaud");
        //    entity.Property(e => e.Nome)
        //        .HasMaxLength(250)
        //        .HasComment("forminputlabel[Nome] \r\nforminputsize[50]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Nome] \r\ncolumngridtype[ro] \r\ncolumngridsize[*] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnName("nome");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud).HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasColumnName("version");
        //});

        //modelBuilder.Entity<Modulogrupo>(entity =>
        //{
        //    entity.HasKey(e => e.Modulogrupoid).HasName("modulogrupo_pk");

        //    entity.ToTable("modulogrupo", tb => tb.HasComment("template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]  \r\n\r\nformtitle[Cadastro de Módulos / Grupo]   \r\nfieldsgrid[modulogrupoid,grupo.nome,modulosistema.modulo.nome,menu:modulogrupoid] \r\n\r\nfieldsform[modulogrupoid,grupo.grupoid,grupo.nome,modulosistema.modulosistemaid,modulosistema.modulo.nome,menu] \r\n\r\ngridtitle[Lista de Módulos / Grupo]"));

        //    entity.Property(e => e.Modulogrupoid)
        //        .HasComment("forminputlabel[Código] \r\nforminputsize[7]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Código] \r\ncolumngridtype[ro] \r\ncolumngridsize[80] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnName("modulogrupoid");
        //    entity.Property(e => e.Grupo)
        //        .HasComment("forminputlabel[Grupo]\r\nforminputsize[250]\r\n\r\nsearchmode[combobox]\r\ncomboboxresultfield[nome]\r\n\r\ncolumngridid[grupo.nome]\r\ncolumngridtitle[Grupo]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("grupo");
        //    entity.Property(e => e.Grupoaud).HasColumnName("grupoaud");
        //    entity.Property(e => e.Imagemtopo)
        //        .HasColumnType("character varying")
        //        .HasColumnName("imagemtopo");
        //    entity.Property(e => e.Menu)
        //        .HasComment("forminputlabel[MENU] \r\nforminputsize[50]  \r\n\r\ngeragridmain[false]")
        //        .HasColumnType("character varying")
        //        .HasColumnName("menu");
        //    entity.Property(e => e.Modulosistema)
        //        .HasComment("forminputlabel[Módulo Sistema]\r\nforminputsize[250]\r\n\r\nsearchmode[combobox]\r\ncomboboxresultfield[modulo.nome]\r\n\r\ncolumngridid[modulosistema.modulo.nome]\r\ncolumngridtitle[Módulo Sistema]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("modulosistema");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud).HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasColumnName("version");

        //    entity.HasOne(d => d.GrupoNavigation).WithMany(p => p.Modulogrupos)
        //        .HasForeignKey(d => d.Grupo)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("grupo_modulogrupo_fk");

        //    entity.HasOne(d => d.ModulosistemaNavigation).WithMany(p => p.Modulogrupos)
        //        .HasForeignKey(d => d.Modulosistema)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("modulogrupo_fk");
        //});

        //modelBuilder.Entity<Modulosistema>(entity =>
        //{
        //    entity.HasKey(e => e.Modulosistemaid).HasName("modulosistema_pk");

        //    entity.ToTable("modulosistema", tb => tb.HasComment("template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]  \r\n\r\nformtitle[Cadastro de Módulos / Sistema]   \r\nfieldsgrid[modulosistemaid,modulo.nome,sistema.nome:modulosistemaid] \r\n\r\n\r\nfieldsform[modulosistemaid,modulo.moduloid,modulo.nome,sistema.sistemaid,sistema.nome,manutencao] \r\n\r\ngridtitle[Lista de Módulos / Sistema]"));

        //    entity.Property(e => e.Modulosistemaid)
        //        .HasComment("forminputlabel[Código] forminputsize[7]  columngridid[] columngridtitle[Código] columngridtype[ro] columngridsize[80] columngridalign[left] columngridcolor[white]")
        //        .HasColumnName("modulosistemaid");
        //    entity.Property(e => e.Grupoaud).HasColumnName("grupoaud");
        //    entity.Property(e => e.Manutencao).HasColumnName("manutencao");
        //    entity.Property(e => e.Modulo)
        //        .HasComment("forminputlabel[Módulo]\r\nforminputsize[250]\r\n\r\nsearchmode[combobox]\r\ncomboboxresultfield[nome]\r\n\r\ncolumngridid[modulo.nome]\r\ncolumngridtitle[Módulo]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("modulo");
        //    entity.Property(e => e.Sistema)
        //        .HasComment("forminputlabel[Sistema]\r\nforminputsize[250]\r\n\r\nsearchmode[combobox]\r\ncomboboxresultfield[nome]\r\n\r\ncolumngridid[sistema.nome]\r\ncolumngridtitle[Sistema]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("sistema");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud).HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasColumnName("version");

        //    entity.HasOne(d => d.ModuloNavigation).WithMany(p => p.Modulosistemas)
        //        .HasForeignKey(d => d.Modulo)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("modulo_modulosistema_fk");

        //    entity.HasOne(d => d.SistemaNavigation).WithMany(p => p.Modulosistemas)
        //        .HasForeignKey(d => d.Sistema)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("sistema_modulosistema_fk");
        //});

        //modelBuilder.Entity<Modulosistemausuario>(entity =>
        //{
        //    entity.HasKey(e => e.Modulosistemausuarioid).HasName("modulosistemausuario_pkey");

        //    entity.ToTable("modulosistemausuario", tb => tb.HasComment("template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]  \r\n\r\nformtitle[Cadastro de Modulo/ Sistema / Usuário]   \r\nfieldsgrid[modulosistemausuarioid,modulosistema.modulo.nome,usuario.nome:modulosistemausuarioid] \r\n\r\nfieldsform[modulosistemausuarioid,modulosistema.modulosistemaid,modulosistema.modulo.nome,usuario.usuarioid,usuario.nome,grantmodulo,denymodulo] \r\n\r\ngridtitle[Lista de Modulo/ Sistema / Usuário]   "));

        //    entity.Property(e => e.Modulosistemausuarioid)
        //        .HasComment("forminputlabel[Código]\r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("modulosistemausuarioid");
        //    entity.Property(e => e.Denymodulo)
        //        .HasComment("forminputlabel[DenyModulo]\r\nforminputsize[50]\r\n\r\ngeragridmain[false]")
        //        .HasColumnType("character varying")
        //        .HasColumnName("denymodulo");
        //    entity.Property(e => e.Grantmodulo)
        //        .HasComment("forminputlabel[GrantModulo]\r\nforminputsize[50]\r\n\r\ngeragridmain[false]")
        //        .HasColumnType("character varying")
        //        .HasColumnName("grantmodulo");
        //    entity.Property(e => e.Grupoaud).HasColumnName("grupoaud");
        //    entity.Property(e => e.Modulosistema)
        //        .HasComment("forminputlabel[ModuloSistema]\r\nforminputsize[250]\r\n\r\nsearchmode[combobox]\r\ncomboboxresultfield[modulosistema.modulo.nome]\r\n\r\ngeragridmain[true]\r\n\r\ncolumngridid[modulosistema.modulo.nome]\r\ncolumngridtitle[Modulo Sistema]\r\ncolumngridtype[ro]\r\ncolumngridsize[180]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("modulosistema");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuario)
        //        .HasComment("forminputlabel[Usuário]\r\nforminputsize[50]\r\n\r\nsearchmode[popup]\r\npopupresultfield[nome]\r\npopupfieldsgrid[usuarioid,nome,login,senha:usuarioid]\r\n\r\ncolumngridid[usuario.nome]\r\ncolumngridtitle[Usuário]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("usuario");
        //    entity.Property(e => e.Usuarioaud).HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasColumnName("version");

        //    entity.HasOne(d => d.ModulosistemaNavigation).WithMany(p => p.Modulosistemausuarios)
        //        .HasForeignKey(d => d.Modulosistema)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("modulosistemausuario_fk");

        //    entity.HasOne(d => d.UsuarioNavigation).WithMany(p => p.Modulosistemausuarios)
        //        .HasForeignKey(d => d.Usuario)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("modulosistemausuario_fk1");
        //});

        //modelBuilder.Entity<Natureza>(entity =>
        //{
        //    entity.HasKey(e => e.Naturezaid).HasName("natureza_pkey");

        //    entity.ToTable("natureza", "agenda", tb => tb.HasComment("template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Natureza\r\n\r\nfiltersgrid[#text_filter,#text_filter] \r\n\r\n\r\ngridtitle[Lista de Natureza]\r\n"));

        //    entity.Property(e => e.Naturezaid)
        //        .HasComment("forminputlabel[Código] \r\nforminputsize[7]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Código] \r\ncolumngridtype[ro] \r\ncolumngridsize[80] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnName("naturezaid");
        //    entity.Property(e => e.Grupoaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Nome)
        //        .HasComment("forminputlabel[Nome] \r\nforminputsize[70]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Nome] \r\ncolumngridtype[ro] \r\ncolumngridsize[*] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnType("character varying")
        //        .HasColumnName("nome");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("version");
        //});

        //modelBuilder.Entity<Nomecoluna>(entity =>
        //{
        //    entity.HasKey(e => e.Nomecolunaid).HasName("nomecoluna_pkey");

        //    entity.ToTable("nomecoluna", "agenda", tb => tb.HasComment("template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Nome de Coluna]\r\nfiltersgrid[#text_filter,#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Nomes de Coluna]"));

        //    entity.Property(e => e.Nomecolunaid)
        //        .HasComment("forminputlabel[Código]\r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("nomecolunaid");
        //    entity.Property(e => e.Grupoaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Nome)
        //        .HasMaxLength(200)
        //        .HasComment("forminputlabel[Nome]\r\nforminputsize[50]\r\nforminputclass[uppercase]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Nome]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("nome");
        //    entity.Property(e => e.Residuo)
        //        .HasComment("forminputlabel[Resíduo]\r\nforminputsize[180]\r\n\r\nsearchmode[combobox]\r\ncomboboxresultfield[residuo.nome]\r\n\r\ncolumngridid[residuo.nome]\r\ncolumngridtitle[Resíduo]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("residuo");
        //    entity.Property(e => e.Tipocoluna)
        //        .HasComment("0-Integer / 1-String\r\n\r\nforminputlabel[Tipo Coluna]\r\nforminputsize[30]\r\nforminputclass[required]\r\n\r\ngeragridmain[false]")
        //        .HasColumnName("tipocoluna");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("version");

        //    entity.HasOne(d => d.ResiduoNavigation).WithMany(p => p.Nomecolunas)
        //        .HasForeignKey(d => d.Residuo)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("nomecoluna_fk");
        //});

        //modelBuilder.Entity<Numeroprocesso>(entity =>
        //{
        //    entity.HasKey(e => e.Ano).HasName("numeroprocesso_pkey");

        //    entity.ToTable("numeroprocesso", "agenda");

        //    entity.Property(e => e.Ano)
        //        .ValueGeneratedNever()
        //        .HasColumnName("ano");
        //    entity.Property(e => e.Grupoaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Processo).HasColumnName("processo");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("version");
        //});

        //modelBuilder.Entity<Obra>(entity =>
        //{
        //    entity.HasKey(e => e.Obraid).HasName("obra_pkey");

        //    entity.ToTable("obra", "sisobra", tb => tb.HasComment("template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro do Obra]\r\nfiltersgrid[#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Obras]\r\n\r\nmasterdetails[true]\r\ndetails[obradata,obraandamento]"));

        //    entity.Property(e => e.Obraid)
        //        .HasComment("forminputlabel[Código] \r\nforminputsize[7]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Código] \r\ncolumngridtype[ro] \r\ncolumngridsize[80] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnName("obraid");
        //    entity.Property(e => e.Anoemenda).HasColumnName("anoemenda");
        //    entity.Property(e => e.Bairro)
        //        .HasComment("forminputlabel[Bairro] \r\nforminputsize[100]\r\n\r\nsearchmode[popup] \r\npopupresultfield[bairro.nome]\r\npopupfieldsgrid[bairroid,nome]\r\n\r\ncolumngridid[] \r\ncolumngridtitle[Bairro] \r\ncolumngridtype[ro] \r\ncolumngridsize[100] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnName("bairro");
        //    entity.Property(e => e.Classificacao)
        //        .HasComment("forminputlabel[Classificação] \r\nforminputsize[100]\r\n\r\nsearchmode[combobox] \r\ncomboboxresultfield[nome]\r\n\r\ncolumngridid[70] \r\ncolumngridtitle[Classificação] \r\ncolumngridtype[ro] \r\ncolumngridsize[20] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnName("classificacao");
        //    entity.Property(e => e.Contratado)
        //        .HasComment("forminputlabel[Contratado] \r\nforminputsize[100]\r\n\r\nsearchmode[combobox] \r\ncomboboxresultfield[nome]\r\n\r\ncolumngridid[] \r\ncolumngridtitle[Contratado] \r\ncolumngridtype[ro] \r\ncolumngridsize[70] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnName("contratado");
        //    entity.Property(e => e.Datacadastro)
        //        .HasDefaultValueSql("('now'::text)::date")
        //        .HasComment("forminputlabel[Data Cadastro] \r\nforminputsize[10]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Data Cadastro] \r\ncolumngridtype[ro] \r\ncolumngridsize[20] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnName("datacadastro");
        //    entity.Property(e => e.Dataprevisaoentrega)
        //        .HasComment("forminputlabel[Data Previsão Entrega] \r\nforminputsize[10]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Data Previsão Entrega] \r\ncolumngridtype[ro] \r\ncolumngridsize[20] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnName("dataprevisaoentrega");
        //    entity.Property(e => e.Descricao)
        //        .HasComment("forminputlabel[Descrição] \r\nforminputsize[70]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Descrição] \r\ncolumngridtype[ro] \r\ncolumngridsize[*] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnType("character varying")
        //        .HasColumnName("descricao");
        //    entity.Property(e => e.Endereco)
        //        .HasComment("forminputlabel[Endereço] \r\nforminputsize[70]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Endereço] \r\ncolumngridtype[ro] \r\ncolumngridsize[*] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnType("character varying")
        //        .HasColumnName("endereco");
        //    entity.Property(e => e.Evento).HasColumnName("evento");
        //    entity.Property(e => e.Faseobra)
        //        .HasComment("forminputlabel[Fase da Obra] \r\nforminputsize[50]\r\n\r\nsearchmode[combobox] \r\ncomboboxresultfield[nome]\r\n\r\ncolumngridid[] \r\ncolumngridtitle[Fase da Obra] \r\ncolumngridtype[ro] \r\ncolumngridsize[70] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnName("faseobra");
        //    entity.Property(e => e.Fiscal)
        //        .HasComment("forminputlabel[Fiscal] \r\nforminputsize[100]\r\n\r\nsearchmode[combobox] \r\ncomboboxresultfield[nome]\r\n\r\ncolumngridid[] \r\ncolumngridtitle[Fiscal] \r\ncolumngridtype[ro] \r\ncolumngridsize[70] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnName("fiscal");
        //    entity.Property(e => e.Fonterecurso).HasColumnName("fonterecurso");
        //    entity.Property(e => e.Grupoaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Latitude)
        //        .HasComment("forminputlabel[Latitude] \r\nforminputsize[20]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Latitude] \r\ncolumngridtype[ro] \r\ncolumngridsize[40] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnType("character varying")
        //        .HasColumnName("latitude");
        //    entity.Property(e => e.Longitude)
        //        .HasComment("forminputlabel[Longitude] \r\nforminputsize[20]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Longitude] \r\ncolumngridtype[ro] \r\ncolumngridsize[40] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnType("character varying")
        //        .HasColumnName("longitude");
        //    entity.Property(e => e.Ministerio).HasColumnName("ministerio");
        //    entity.Property(e => e.Numero)
        //        .HasComment("forminputlabel[Número] \r\nforminputsize[10]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Número] \r\ncolumngridtype[ro] \r\ncolumngridsize[30] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnName("numero");
        //    entity.Property(e => e.Recurso).HasColumnName("recurso");
        //    entity.Property(e => e.Status)
        //        .HasComment("forminputlabel[Status] \r\nforminputsize[20]\r\n\r\nsearchmode[combobox] \r\ncomboboxresultfield[nome]\r\n\r\ncolumngridid[] \r\ncolumngridtitle[Status] \r\ncolumngridtype[ro] \r\ncolumngridsize[20] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnName("status");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Valorcontrapartida)
        //        .HasPrecision(30, 2)
        //        .HasComment("forminputlabel[Valor Contra Partida] \r\nforminputsize[10]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Valor Contra Partida]\r\ncolumngridtype[ro] \r\ncolumngridsize[20] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnName("valorcontrapartida");
        //    entity.Property(e => e.Valorfinanciamento)
        //        .HasPrecision(30, 2)
        //        .HasComment("forminputlabel[Valor Financiamento] \r\nforminputsize[10]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Valor Financiamento]\r\ncolumngridtype[ro] \r\ncolumngridsize[20] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnName("valorfinanciamento");
        //    entity.Property(e => e.Valorinvestimento)
        //        .HasPrecision(30, 2)
        //        .HasComment("forminputlabel[Valor Investimento] \r\nforminputsize[10]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Valor Investimento]\r\ncolumngridtype[ro] \r\ncolumngridsize[20] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnName("valorinvestimento");
        //    entity.Property(e => e.Valorinvestimentopre)
        //        .HasPrecision(30, 2)
        //        .HasComment("forminputlabel[Valor Investimento] \r\nforminputsize[10]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Valor Investimento]\r\ncolumngridtype[ro] \r\ncolumngridsize[20] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnName("valorinvestimentopre");
        //    entity.Property(e => e.Valorrepasse)
        //        .HasPrecision(30, 2)
        //        .HasComment("forminputlabel[Valor Repasse] \r\nforminputsize[10]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Valor Repasse]\r\ncolumngridtype[ro] \r\ncolumngridsize[20] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnName("valorrepasse");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("version");

        //    entity.HasOne(d => d.BairroNavigation).WithMany(p => p.Obras)
        //        .HasForeignKey(d => d.Bairro)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("obra_fk5");

        //    entity.HasOne(d => d.ClassificacaoNavigation).WithMany(p => p.Obras)
        //        .HasForeignKey(d => d.Classificacao)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("obra_fk");

        //    entity.HasOne(d => d.ContratadoNavigation).WithMany(p => p.Obras)
        //        .HasForeignKey(d => d.Contratado)
        //        .HasConstraintName("obra_fk2");

        //    entity.HasOne(d => d.EventoNavigation).WithMany(p => p.Obras)
        //        .HasForeignKey(d => d.Evento)
        //        .HasConstraintName("obra_fk8");

        //    entity.HasOne(d => d.FaseobraNavigation).WithMany(p => p.Obras)
        //        .HasForeignKey(d => d.Faseobra)
        //        .HasConstraintName("obra_fk4");

        //    entity.HasOne(d => d.FiscalNavigation).WithMany(p => p.Obras)
        //        .HasForeignKey(d => d.Fiscal)
        //        .HasConstraintName("obra_fk3");

        //    entity.HasOne(d => d.FonterecursoNavigation).WithMany(p => p.Obras)
        //        .HasForeignKey(d => d.Fonterecurso)
        //        .HasConstraintName("obra_fk9");

        //    entity.HasOne(d => d.MinisterioNavigation).WithMany(p => p.Obras)
        //        .HasForeignKey(d => d.Ministerio)
        //        .HasConstraintName("obra_fk7");

        //    entity.HasOne(d => d.RecursoNavigation).WithMany(p => p.Obras)
        //        .HasForeignKey(d => d.Recurso)
        //        .HasConstraintName("obra_fk6");

        //    entity.HasOne(d => d.StatusNavigation).WithMany(p => p.Obras)
        //        .HasForeignKey(d => d.Status)
        //        .HasConstraintName("obra_fk1");
        //});

        //modelBuilder.Entity<Obraandamento>(entity =>
        //{
        //    entity.HasKey(e => e.Obraandamentoid).HasName("obraandamento_pkey");

        //    entity.ToTable("obraandamento", "sisobra", tb => tb.HasComment("template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro do Andamento da Obra]\r\nfiltersgrid[#text_filter,#text_filter,#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Andamentos da Obra]"));

        //    entity.Property(e => e.Obraandamentoid)
        //        .HasComment("forminputlabel[Código] \r\nforminputsize[7]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Código] \r\ncolumngridtype[ro] \r\ncolumngridsize[80] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnName("obraandamentoid");
        //    entity.Property(e => e.Dataandamento)
        //        .HasComment("forminputlabel[Data] \r\nforminputsize[10]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Data] \r\ncolumngridtype[ro] \r\ncolumngridsize[20] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnName("dataandamento");
        //    entity.Property(e => e.Dataprazo)
        //        .HasComment("forminputlabel[Data Prazo] \r\nforminputsize[10]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Data-Prazo] \r\ncolumngridtype[ro] \r\ncolumngridsize[20] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnName("dataprazo");
        //    entity.Property(e => e.Datasituacao)
        //        .HasComment("forminputlabel[Data Situação] \r\nforminputsize[10]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Data Situação] \r\ncolumngridtype[ro] \r\ncolumngridsize[20] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnName("datasituacao");
        //    entity.Property(e => e.Grupoaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Obra)
        //        .HasComment("forminputlabel[Obra] \r\nforminputsize[10]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Obra] \r\ncolumngridtype[ro] \r\ncolumngridsize[10] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnName("obra");
        //    entity.Property(e => e.Obs)
        //        .HasComment("forminputlabel[Observação] \r\nforminputsize[70]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Observação] \r\ncolumngridtype[ro] \r\ncolumngridsize[*] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnType("character varying")
        //        .HasColumnName("obs");
        //    entity.Property(e => e.Situacaoprazo)
        //        .HasComment("1 - Andamento\r\n2 - Concluída\r\n3 - Cancelada\r\n\r\nforminputlabel[Situação] \r\nforminputsize[10]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Situação] \r\ncolumngridtype[ro] \r\ncolumngridsize[20] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnName("situacaoprazo");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("version");

        //    entity.HasOne(d => d.ObraNavigation).WithMany(p => p.Obraandamentos)
        //        .HasForeignKey(d => d.Obra)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("obraandamento_fk");
        //});

        //modelBuilder.Entity<Obradatum>(entity =>
        //{
        //    entity.HasKey(e => e.Obradataid).HasName("obradata_pkey");

        //    entity.ToTable("obradata", "sisobra", tb => tb.HasComment("template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro do Andamento da Obra]\r\nfiltersgrid[#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Andamentos da Obra]"));

        //    entity.Property(e => e.Obradataid)
        //        .HasComment("forminputlabel[Código] \r\nforminputsize[7]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Código] \r\ncolumngridtype[ro] \r\ncolumngridsize[80] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnName("obradataid");
        //    entity.Property(e => e.Controle)
        //        .HasComment("forminputlabel[Nº Controle] \r\nforminputsize[10]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Nº Controle] \r\ncolumngridtype[ro] \r\ncolumngridsize[20] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnType("character varying")
        //        .HasColumnName("controle");
        //    entity.Property(e => e.Data)
        //        .HasComment("forminputlabel[Data] \r\nforminputsize[10]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Data] \r\ncolumngridtype[ro] \r\ncolumngridsize[20] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnName("data");
        //    entity.Property(e => e.Grupoaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Obra)
        //        .HasComment("forminputlabel[Obra] \r\nforminputsize[10]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Obra] \r\ncolumngridtype[ro] \r\ncolumngridsize[10] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnName("obra");
        //    entity.Property(e => e.Obs)
        //        .HasComment("forminputlabel[Observação] \r\nforminputsize[70]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Observação] \r\ncolumngridtype[ro] \r\ncolumngridsize[*] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnType("character varying")
        //        .HasColumnName("obs");
        //    entity.Property(e => e.Status)
        //        .HasComment("forminputlabel[Status] \r\nforminputsize[20]\r\n\r\nsearchmode[combobox] \r\ncomboboxresultfield[nome]\r\n\r\ncolumngridid[] \r\ncolumngridtitle[Status] \r\ncolumngridtype[ro] \r\ncolumngridsize[20] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnName("status");
        //    entity.Property(e => e.Tipocontrole)
        //        .HasComment("forminputlabel[Tipo Controle] \r\nforminputsize[20]\r\n\r\nsearchmode[combobox] \r\ncomboboxresultfield[nome]\r\n\r\ncolumngridid[] \r\ncolumngridtitle[Tipo Controle] \r\ncolumngridtype[ro] \r\ncolumngridsize[20] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnName("tipocontrole");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("version");

        //    entity.HasOne(d => d.ObraNavigation).WithMany(p => p.Obradata)
        //        .HasForeignKey(d => d.Obra)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("obradata_fk");

        //    entity.HasOne(d => d.StatusNavigation).WithMany(p => p.Obradata)
        //        .HasForeignKey(d => d.Status)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("obradata_fk1");

        //    entity.HasOne(d => d.TipocontroleNavigation).WithMany(p => p.Obradata)
        //        .HasForeignKey(d => d.Tipocontrole)
        //        .HasConstraintName("obradata_fk2");
        //});

        //modelBuilder.Entity<Obraevento>(entity =>
        //{
        //    entity.HasKey(e => e.Obraeventoid).HasName("obraevento_pkey");

        //    entity.ToTable("obraevento", "sisobra", tb => tb.HasComment("template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Obra-Evento]\r\nfiltersgrid[#text_filter,#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Obra-Eventos]"));

        //    entity.Property(e => e.Obraeventoid)
        //        .HasComment("forminputlabel[Código]\r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[]")
        //        .HasColumnName("obraeventoid");
        //    entity.Property(e => e.Evento)
        //        .HasComment("forminputlabel[Evento]\r\nforminputsize[70]\r\n\r\nsearchmode[popup]\r\npopupresultfield[evento.nome]\r\npopupfieldsgrid[eventoid,nome]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Evento]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[]")
        //        .HasColumnName("evento");
        //    entity.Property(e => e.Grupoaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Obra)
        //        .HasComment("geragridmain[false]")
        //        .HasColumnName("obra");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("version");

        //    entity.HasOne(d => d.EventoNavigation).WithMany(p => p.Obraeventos)
        //        .HasForeignKey(d => d.Evento)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("obraevento_fk2");

        //    entity.HasOne(d => d.ObraNavigation).WithMany(p => p.Obraeventos)
        //        .HasForeignKey(d => d.Obra)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("obraevento_fk1");
        //});

        //modelBuilder.Entity<Obraparlamentar>(entity =>
        //{
        //    entity.HasKey(e => e.Obraparlamentarid).HasName("obraparlamentar_pkey");

        //    entity.ToTable("obraparlamentar", "sisobra", tb => tb.HasComment("template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Obra-Parlamentar]\r\nfiltersgrid[#text_filter,#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Obra-Parlamentares]"));

        //    entity.Property(e => e.Obraparlamentarid)
        //        .HasComment("forminputlabel[Código]\r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[]")
        //        .HasColumnName("obraparlamentarid");
        //    entity.Property(e => e.Anoemenda)
        //        .HasMaxLength(9)
        //        .HasColumnName("anoemenda");
        //    entity.Property(e => e.Grupoaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Obra)
        //        .HasComment("geragridmain[false]")
        //        .HasColumnName("obra");
        //    entity.Property(e => e.Parlamentar)
        //        .HasComment("forminputlabel[Parlamentar]\r\nforminputsize[70]\r\n\r\nsearchmode[popup]\r\npopupresultfield[parlamentar.nome]\r\npopupfieldsgrid[parlamentarid,nome]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Parlamentar]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[]")
        //        .HasColumnName("parlamentar");
        //    entity.Property(e => e.Tipo)
        //        .HasMaxLength(1)
        //        .HasColumnName("tipo");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("version");

        //    entity.HasOne(d => d.ObraNavigation).WithMany(p => p.Obraparlamentars)
        //        .HasForeignKey(d => d.Obra)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("obraparlamentar_fk1");

        //    entity.HasOne(d => d.ParlamentarNavigation).WithMany(p => p.Obraparlamentars)
        //        .HasForeignKey(d => d.Parlamentar)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("obraparlamentar_fk2");
        //});

        //modelBuilder.Entity<Ocorrencium>(entity =>
        //{
        //    entity.HasKey(e => e.Ocorrenciaid).HasName("ocorrencia_pkey");

        //    entity.ToTable("ocorrencia", "divulgacao", tb => tb.HasComment("template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Ocorrência]\r\nfiltersgrid[#text_filter,#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Ocorrências]"));

        //    entity.Property(e => e.Ocorrenciaid)
        //        .HasComment("forminputlabel[Código]\r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("ocorrenciaid");
        //    entity.Property(e => e.Grupoaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Nome)
        //        .HasComment("forminputlabel[Nome]\r\nforminputsize[50]\r\nforminputclass[uppercase]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Nome]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnType("character varying")
        //        .HasColumnName("nome");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("version");
        //});

        //modelBuilder.Entity<Parlamentar>(entity =>
        //{
        //    entity.HasKey(e => e.Parlamentarid).HasName("parlamentar_pkey");

        //    entity.ToTable("parlamentar", "sisobra", tb => tb.HasComment("template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Parlamentar]\r\nfiltersgrid[#text_filter,#text_filter,#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Parlamentares]"));

        //    entity.Property(e => e.Parlamentarid)
        //        .HasComment("forminputlabel[Código] \r\nforminputsize[7]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Código] \r\ncolumngridtype[ro] \r\ncolumngridsize[80] \r\ncolumngridalign[left] \r\ncolumngridcolor[]")
        //        .HasColumnName("parlamentarid");
        //    entity.Property(e => e.Grupoaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Nome)
        //        .HasComment("forminputlabel[Nome] \r\nforminputsize[70]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Nome] \r\ncolumngridtype[ro] \r\ncolumngridsize[*] \r\ncolumngridalign[left] \r\ncolumngridcolor[]")
        //        .HasColumnType("character varying")
        //        .HasColumnName("nome");
        //    entity.Property(e => e.Status)
        //        .HasMaxLength(1)
        //        .HasDefaultValueSql("'I'::character varying")
        //        .HasComment("forminputlabel[Status] \r\nforminputsize[12]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Status] \r\ncolumngridtype[ro] \r\ncolumngridsize[20] \r\ncolumngridalign[left] \r\ncolumngridcolor[]")
        //        .HasColumnName("status");
        //    entity.Property(e => e.Tipomandato)
        //        .HasComment("forminputlabel[Tipo Mandato]\r\nforminputsize[150]\r\n\r\nsearchmode[combobox]\r\ncomboboxresultfield[nome]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Tipo Mandato]\r\ncolumngridtype[ro]\r\ncolumngridsize[70]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("tipomandato");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("version");

        //    entity.HasOne(d => d.TipomandatoNavigation).WithMany(p => p.Parlamentars)
        //        .HasForeignKey(d => d.Tipomandato)
        //        .HasConstraintName("parlamentar_fk");
        //});

        //modelBuilder.Entity<Pedidoped>(entity =>
        //{
        //    entity.HasKey(e => e.Codigoped).HasName("pedidoped_pkey");

        //    entity.ToTable("pedidoped", "vistoria");

        //    entity.Property(e => e.Codigoped)
        //        .HasComment("Código do pedido")
        //        .HasColumnName("codigoped");
        //    entity.Property(e => e.Bairroped)
        //        .HasMaxLength(50)
        //        .HasComment("Bairro do pedido")
        //        .HasColumnName("bairroped");
        //    entity.Property(e => e.Cepped)
        //        .HasMaxLength(10)
        //        .HasComment("CEP do solicitante no pedido")
        //        .HasColumnName("cepped");
        //    entity.Property(e => e.Codigomic)
        //        .HasComment("Micro-região")
        //        .HasColumnName("codigomic");
        //    entity.Property(e => e.Codigoori)
        //        .HasComment("Origem do Pedido")
        //        .HasColumnName("codigoori");
        //    entity.Property(e => e.Codigosol)
        //        .HasComment("Solicitante do pedido")
        //        .HasColumnName("codigosol");
        //    entity.Property(e => e.Codigotpi)
        //        .HasComment("Tipo do Imovel do pedido")
        //        .HasColumnName("codigotpi");
        //    entity.Property(e => e.Codigotps)
        //        .HasComment("Tipo da Solicitacao")
        //        .HasColumnName("codigotps");
        //    entity.Property(e => e.Complemped)
        //        .HasMaxLength(50)
        //        .HasComment("Complemento do endereço do pedido")
        //        .HasColumnName("complemped");
        //    entity.Property(e => e.Datacadped)
        //        .HasDefaultValueSql("now()")
        //        .HasComment("Data de cadastro do pedido")
        //        .HasColumnType("timestamp without time zone")
        //        .HasColumnName("datacadped");
        //    entity.Property(e => e.Justificaped)
        //        .HasMaxLength(120)
        //        .HasComment("Justificativa do pedido")
        //        .HasColumnName("justificaped");
        //    entity.Property(e => e.Loteped)
        //        .HasMaxLength(5)
        //        .HasComment("Lote do pedido")
        //        .HasColumnName("loteped");
        //    entity.Property(e => e.Numeroped)
        //        .HasMaxLength(10)
        //        .HasComment("Numero da rua do pedido")
        //        .HasColumnName("numeroped");
        //    entity.Property(e => e.Processoped)
        //        .HasMaxLength(20)
        //        .HasComment("Numero do processo ou numero de identificação do pedido.")
        //        .HasColumnName("processoped");
        //    entity.Property(e => e.Quadraped)
        //        .HasMaxLength(5)
        //        .HasComment("Quadra do pedido")
        //        .HasColumnName("quadraped");
        //    entity.Property(e => e.Ruaped)
        //        .HasMaxLength(100)
        //        .HasComment("Rua do pedido")
        //        .HasColumnName("ruaped");
        //});

        //modelBuilder.Entity<Permissaoentidade>(entity =>
        //{
        //    entity.HasKey(e => e.Permissaoentidadeid).HasName("permissaoentidade_pkey");

        //    entity.ToTable("permissaoentidade", tb => tb.HasComment("template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Permissão/Entidade] \r\n\r\nfieldsgrid[permissaoentidadeid,sistema.nome,entidade.nome,grupo.nome:permissaoentidadeid]\r\nfiltersgrid[#text_filter,#text_filter,#text_filter,#text_filter] \r\n\r\nfieldsform[permissaoentidadeid,sistema.sistemaid,sistema.nome,entidade.entidadeid,entidade.nome,grupo.grupoid,grupo.nome,grantentidade,denyentidade,grantcoluna,denycoluna,grantviewcoluna,denyviewcoluna] \r\n\r\ngridtitle[Lista de Permissão/Entidade]"));

        //    entity.Property(e => e.Permissaoentidadeid)
        //        .HasComment("forminputlabel[Código]\r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("permissaoentidadeid");
        //    entity.Property(e => e.Denyabas)
        //        .HasColumnType("character varying")
        //        .HasColumnName("denyabas");
        //    entity.Property(e => e.Denycolumnsgrid)
        //        .HasColumnType("character varying")
        //        .HasColumnName("denycolumnsgrid");
        //    entity.Property(e => e.Denycoluna)
        //        .HasColumnType("character varying")
        //        .HasColumnName("denycoluna");
        //    entity.Property(e => e.Denydelete)
        //        .HasColumnType("character varying")
        //        .HasColumnName("denydelete");
        //    entity.Property(e => e.Denyextrabuttons)
        //        .HasColumnType("character varying")
        //        .HasColumnName("denyextrabuttons");
        //    entity.Property(e => e.Denyfieldsform)
        //        .HasColumnType("character varying")
        //        .HasColumnName("denyfieldsform");
        //    entity.Property(e => e.Denyupdate)
        //        .HasColumnType("character varying")
        //        .HasColumnName("denyupdate");
        //    entity.Property(e => e.Denyview)
        //        .HasColumnType("character varying")
        //        .HasColumnName("denyview");
        //    entity.Property(e => e.Denyviewcoluna)
        //        .HasColumnType("character varying")
        //        .HasColumnName("denyviewcoluna");
        //    entity.Property(e => e.Entidade)
        //        .HasComment("forminputlabel[Entidade]\r\nforminputsize[50]\r\n\r\nsearchmode[popup]\r\npopupresultfield[nome]\r\npopupfieldsgrid[entidadeid,nome:entidadeid]\r\n\r\ngeragridmain[true]\r\n\r\ncolumngridid[entidade.nome]\r\ncolumngridtitle[Entidade]\r\ncolumngridtype[ro]\r\ncolumngridsize[180]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("entidade");
        //    entity.Property(e => e.Extrasinfo)
        //        .HasColumnType("character varying")
        //        .HasColumnName("extrasinfo");
        //    entity.Property(e => e.Filtraunidade)
        //        .HasMaxLength(2)
        //        .HasColumnName("filtraunidade");
        //    entity.Property(e => e.Grantcoluna)
        //        .HasColumnType("character varying")
        //        .HasColumnName("grantcoluna");
        //    entity.Property(e => e.Grantdelete)
        //        .HasMaxLength(2)
        //        .HasColumnName("grantdelete");
        //    entity.Property(e => e.Grantinsert)
        //        .HasMaxLength(2)
        //        .HasColumnName("grantinsert");
        //    entity.Property(e => e.Grantselect)
        //        .HasMaxLength(2)
        //        .HasColumnName("grantselect");
        //    entity.Property(e => e.Grantupdate)
        //        .HasMaxLength(2)
        //        .HasColumnName("grantupdate");
        //    entity.Property(e => e.Grantviewcoluna)
        //        .HasColumnType("character varying")
        //        .HasColumnName("grantviewcoluna");
        //    entity.Property(e => e.Grupo)
        //        .HasComment("forminputlabel[Grupo]\r\nforminputsize[250]\r\n\r\nsearchmode[combobox]\r\ncomboboxresultfield[nome]\r\n\r\ngeragridmain[true]\r\n\r\ncolumngridid[grupo.nome]\r\ncolumngridtitle[Grupo]\r\ncolumngridtype[ro]\r\ncolumngridsize[180]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("grupo");
        //    entity.Property(e => e.Grupoaud).HasColumnName("grupoaud");
        //    entity.Property(e => e.Pathunidade)
        //        .HasColumnType("character varying")
        //        .HasColumnName("pathunidade");
        //    entity.Property(e => e.Pathusuario)
        //        .HasColumnType("character varying")
        //        .HasColumnName("pathusuario");
        //    entity.Property(e => e.Physicaldeletion)
        //        .HasMaxLength(2)
        //        .HasColumnName("physicaldeletion");
        //    entity.Property(e => e.Sistema)
        //        .HasComment("forminputlabel[Sistema]\r\nforminputsize[250]\r\n\r\nsearchmode[combobox]\r\ncomboboxresultfield[nome]\r\n\r\ngeragridmain[true]\r\n\r\ncolumngridid[sistema.nome]\r\ncolumngridtitle[Sistema]\r\ncolumngridtype[ro]\r\ncolumngridsize[180]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("sistema");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud).HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasColumnName("version");

        //    entity.HasOne(d => d.EntidadeNavigation).WithMany(p => p.Permissaoentidades)
        //        .HasForeignKey(d => d.Entidade)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("permissaoentidade_fk1");

        //    entity.HasOne(d => d.GrupoNavigation).WithMany(p => p.Permissaoentidades)
        //        .HasForeignKey(d => d.Grupo)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("permissaoentidade_fk2");

        //    entity.HasOne(d => d.SistemaNavigation).WithMany(p => p.Permissaoentidades)
        //        .HasForeignKey(d => d.Sistema)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("permissaoentidade_fk");
        //});

        //modelBuilder.Entity<Pessoa>(entity =>
        //{
        //    entity.HasKey(e => e.Pessoaid).HasName("pessoa_pkey");

        //    entity.ToTable("pessoa");

        //    entity.Property(e => e.Pessoaid).HasColumnName("pessoaid");
        //    entity.Property(e => e.Cpf)
        //        .HasColumnType("character varying")
        //        .HasColumnName("cpf");
        //    entity.Property(e => e.Email)
        //        .HasColumnType("character varying")
        //        .HasColumnName("email");
        //    entity.Property(e => e.Endereco).HasColumnName("endereco");
        //    entity.Property(e => e.Nome)
        //        .HasColumnType("character varying")
        //        .HasColumnName("nome");
        //    entity.Property(e => e.Rg)
        //        .HasColumnType("character varying")
        //        .HasColumnName("rg");
        //    entity.Property(e => e.Sobrenome)
        //        .HasColumnType("character varying")
        //        .HasColumnName("sobrenome");
        //    entity.Property(e => e.Telefone)
        //        .HasColumnType("character varying")
        //        .HasColumnName("telefone");

        //    entity.HasOne(d => d.EnderecoNavigation).WithMany(p => p.Pessoas)
        //        .HasForeignKey(d => d.Endereco)
        //        .HasConstraintName("pessoa_fk");
        //});

        //modelBuilder.Entity<Prfage>(entity =>
        //{
        //    entity.HasKey(e => e.Codprf).HasName("prfage_pkey");

        //    entity.ToTable("prfage", "agenda");

        //    entity.Property(e => e.Codprf)
        //        .HasDefaultValueSql("nextval(('\"agenda\".\"prfage_codprf_seq\"'::text)::regclass)")
        //        .HasColumnName("codprf");
        //    entity.Property(e => e.Aceprf).HasColumnName("aceprf");
        //    entity.Property(e => e.Arqprf)
        //        .HasComment("ID DO ARQUIVO ANEXADO NA TAB ARQUIVO")
        //        .HasColumnName("arqprf");
        //    entity.Property(e => e.Baiprf)
        //        .HasMaxLength(50)
        //        .HasColumnName("baiprf");
        //    entity.Property(e => e.Cepprf)
        //        .HasMaxLength(10)
        //        .HasColumnName("cepprf");
        //    entity.Property(e => e.Comprf)
        //        .HasMaxLength(20)
        //        .HasColumnName("comprf");
        //    entity.Property(e => e.Conprf)
        //        .HasDefaultValue(0)
        //        .HasComment("CONFIRMACAO DE CHECK DO EMAIL DO PROFISSIONAL")
        //        .HasColumnName("conprf");
        //    entity.Property(e => e.Cpfprf)
        //        .HasMaxLength(14)
        //        .HasColumnName("cpfprf");
        //    entity.Property(e => e.Creprf).HasColumnName("creprf");
        //    entity.Property(e => e.Emlprf)
        //        .HasMaxLength(100)
        //        .HasColumnName("emlprf");
        //    entity.Property(e => e.Extprf)
        //        .HasComment("EXTENSAO DO ARQUIVO ANEXADO")
        //        .HasColumnType("character varying")
        //        .HasColumnName("extprf");
        //    entity.Property(e => e.Fonprf)
        //        .HasMaxLength(20)
        //        .HasColumnName("fonprf");
        //    entity.Property(e => e.Grupoaud)
        //        .HasDefaultValue(0)
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Insprf).HasColumnName("insprf");
        //    entity.Property(e => e.Jusprf)
        //        .HasComment("JUSTIFICATIVA DE ACESSO DO PROF DE FORA!")
        //        .HasColumnType("character varying")
        //        .HasColumnName("jusprf");
        //    entity.Property(e => e.Logprf)
        //        .HasMaxLength(100)
        //        .HasColumnName("logprf");
        //    entity.Property(e => e.Nlcprf)
        //        .HasMaxLength(50)
        //        .HasColumnName("nlcprf");
        //    entity.Property(e => e.Nomprf)
        //        .HasMaxLength(100)
        //        .HasColumnName("nomprf");
        //    entity.Property(e => e.Numprf).HasColumnName("numprf");
        //    entity.Property(e => e.Senprf)
        //        .HasMaxLength(100)
        //        .HasColumnName("senprf");
        //    entity.Property(e => e.Termoaceito)
        //        .HasDefaultValue(0)
        //        .HasComment("0 - Não Aceito / 1 - Aceito")
        //        .HasColumnName("termoaceito");
        //    entity.Property(e => e.Tipprf)
        //        .HasMaxLength(10)
        //        .HasColumnName("tipprf");
        //    entity.Property(e => e.Titprf)
        //        .HasMaxLength(50)
        //        .HasColumnName("titprf");
        //    entity.Property(e => e.Uacprf).HasColumnName("uacprf");
        //    entity.Property(e => e.Ufcprf)
        //        .HasMaxLength(10)
        //        .HasColumnName("ufcprf");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuario)
        //        .HasDefaultValue(0)
        //        .HasColumnName("usuario");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasDefaultValue(0)
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasColumnName("version");
        //    entity.Property(e => e.Visprf)
        //        .HasDefaultValue(1)
        //        .HasColumnName("visprf");

        //    entity.HasOne(d => d.UsuarioNavigation).WithMany(p => p.Prfages)
        //        .HasForeignKey(d => d.Usuario)
        //        .HasConstraintName("prfage_fk");
        //});

        //modelBuilder.Entity<PrfageTmp>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("prfage_tmp", "agenda");

        //    entity.Property(e => e.Aceprf).HasColumnName("aceprf");
        //    entity.Property(e => e.Baiprf)
        //        .HasMaxLength(50)
        //        .HasColumnName("baiprf");
        //    entity.Property(e => e.Cepprf)
        //        .HasMaxLength(10)
        //        .HasColumnName("cepprf");
        //    entity.Property(e => e.Codprf).HasColumnName("codprf");
        //    entity.Property(e => e.Comprf)
        //        .HasMaxLength(20)
        //        .HasColumnName("comprf");
        //    entity.Property(e => e.Cpfprf)
        //        .HasMaxLength(14)
        //        .HasColumnName("cpfprf");
        //    entity.Property(e => e.Creprf).HasColumnName("creprf");
        //    entity.Property(e => e.Emlprf)
        //        .HasMaxLength(100)
        //        .HasColumnName("emlprf");
        //    entity.Property(e => e.Fonprf)
        //        .HasMaxLength(20)
        //        .HasColumnName("fonprf");
        //    entity.Property(e => e.Grupoaud)
        //        .HasDefaultValue(0)
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Insprf).HasColumnName("insprf");
        //    entity.Property(e => e.Logprf)
        //        .HasMaxLength(100)
        //        .HasColumnName("logprf");
        //    entity.Property(e => e.Nlcprf)
        //        .HasMaxLength(50)
        //        .HasColumnName("nlcprf");
        //    entity.Property(e => e.Nomprf)
        //        .HasMaxLength(100)
        //        .HasColumnName("nomprf");
        //    entity.Property(e => e.Numprf).HasColumnName("numprf");
        //    entity.Property(e => e.Senprf)
        //        .HasMaxLength(100)
        //        .HasColumnName("senprf");
        //    entity.Property(e => e.Termoaceito)
        //        .HasDefaultValue(0)
        //        .HasColumnName("termoaceito");
        //    entity.Property(e => e.Tipprf)
        //        .HasMaxLength(10)
        //        .HasColumnName("tipprf");
        //    entity.Property(e => e.Titprf)
        //        .HasMaxLength(50)
        //        .HasColumnName("titprf");
        //    entity.Property(e => e.Uacprf).HasColumnName("uacprf");
        //    entity.Property(e => e.Ufcprf)
        //        .HasMaxLength(10)
        //        .HasColumnName("ufcprf");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuario)
        //        .HasDefaultValue(0)
        //        .HasColumnName("usuario");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasDefaultValue(0)
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasColumnName("version");
        //    entity.Property(e => e.Visprf)
        //        .HasDefaultValue(1)
        //        .HasColumnName("visprf");
        //});

        //modelBuilder.Entity<Profissional>(entity =>
        //{
        //    entity.HasKey(e => e.Profissionalid).HasName("profissional_pkey");

        //    entity.ToTable("profissional", "agenda");

        //    entity.Property(e => e.Profissionalid).HasColumnName("profissionalid");
        //    entity.Property(e => e.Inscricao)
        //        .HasColumnType("character varying")
        //        .HasColumnName("inscricao");
        //    entity.Property(e => e.Numerocre)
        //        .HasColumnType("character varying")
        //        .HasColumnName("numerocre");
        //    entity.Property(e => e.Telefone)
        //        .HasColumnType("character varying")
        //        .HasColumnName("telefone");
        //    entity.Property(e => e.Titulo)
        //        .HasColumnType("character varying")
        //        .HasColumnName("titulo");
        //    entity.Property(e => e.Ufcre)
        //        .HasColumnType("character varying")
        //        .HasColumnName("ufcre");
        //});

        //modelBuilder.Entity<Profissional1>(entity =>
        //{
        //    entity.HasKey(e => e.Profissionalid).HasName("profissional_pkey");

        //    entity.ToTable("profissional", "planurb");

        //    entity.Property(e => e.Profissionalid)
        //        .HasComment("Código do profissional")
        //        .HasColumnName("profissionalid");
        //    entity.Property(e => e.Bairroend)
        //        .HasComment("Endereço bairro")
        //        .HasColumnType("character varying")
        //        .HasColumnName("bairroend");
        //    entity.Property(e => e.Cepend)
        //        .HasComment("Endereço cep")
        //        .HasColumnType("character varying")
        //        .HasColumnName("cepend");
        //    entity.Property(e => e.Cidadeend)
        //        .HasComment("Endereço cidade")
        //        .HasColumnType("character varying")
        //        .HasColumnName("cidadeend");
        //    entity.Property(e => e.Complend)
        //        .HasComment("Endereço complemento")
        //        .HasColumnType("character varying")
        //        .HasColumnName("complend");
        //    entity.Property(e => e.Cpfcnpj)
        //        .HasComment("CPF ou CNPJ do profissional")
        //        .HasColumnType("character varying")
        //        .HasColumnName("cpfcnpj");
        //    entity.Property(e => e.Email)
        //        .HasComment("email do profissional")
        //        .HasColumnType("character varying")
        //        .HasColumnName("email");
        //    entity.Property(e => e.Estadoend)
        //        .HasComment("Endereço estado")
        //        .HasColumnType("character varying")
        //        .HasColumnName("estadoend");
        //    entity.Property(e => e.Inscricao)
        //        .HasComment("Inscrição do profissional")
        //        .HasColumnType("character varying")
        //        .HasColumnName("inscricao");
        //    entity.Property(e => e.Nome)
        //        .HasComment("Nome do profissional")
        //        .HasColumnType("character varying")
        //        .HasColumnName("nome");
        //    entity.Property(e => e.Numeroend)
        //        .HasComment("Endereço número")
        //        .HasColumnType("character varying")
        //        .HasColumnName("numeroend");
        //    entity.Property(e => e.Ruaend)
        //        .HasComment("Endereço rua")
        //        .HasColumnType("character varying")
        //        .HasColumnName("ruaend");
        //    entity.Property(e => e.Telefone1)
        //        .HasComment("Telefone de contato 1")
        //        .HasColumnType("character varying")
        //        .HasColumnName("telefone1");
        //    entity.Property(e => e.Telefone2)
        //        .HasComment("Telefone de contato 2")
        //        .HasColumnType("character varying")
        //        .HasColumnName("telefone2");
        //});

        //modelBuilder.Entity<Projeto>(entity =>
        //{
        //    entity.HasKey(e => e.Projetoid).HasName("projeto_pkey");

        //    entity.ToTable("projeto", "agenda", tb => tb.HasComment("template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Projetos]\r\n\r\nfiltersgrid[#text_filter,#text_filter]\r\n\r\n\r\ngridtitle[Lista de Projetos]\r\n\r\nmasterdetails[true]\r\ndetails[remessa]"));

        //    entity.HasIndex(e => e.Analista, "projeto_analista_idx");

        //    entity.HasIndex(e => e.Codseguranca, "projeto_codseguranca_key").IsUnique();

        //    entity.HasIndex(e => e.Processo, "projeto_processo_key").IsUnique();

        //    entity.HasIndex(e => e.Processoexp, "projeto_processoexp_key").IsUnique();

        //    entity.HasIndex(e => e.Status, "projeto_status_idx");

        //    entity.HasIndex(e => e.Processo, "projeto_teste");

        //    entity.Property(e => e.Projetoid)
        //        .HasComment("forminputlabel[Código]\r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("projetoid");
        //    entity.Property(e => e.Alvara)
        //        .HasColumnType("character varying")
        //        .HasColumnName("alvara");
        //    entity.Property(e => e.Analista).HasColumnName("analista");
        //    entity.Property(e => e.Anolaudoavaliacao).HasColumnName("anolaudoavaliacao");
        //    entity.Property(e => e.Areaexcedente)
        //        .HasPrecision(10, 2)
        //        .HasColumnName("areaexcedente");
        //    entity.Property(e => e.Arealote)
        //        .HasPrecision(10, 2)
        //        .HasColumnName("arealote");
        //    entity.Property(e => e.Areaprojecao)
        //        .HasPrecision(10, 2)
        //        .HasColumnName("areaprojecao");
        //    entity.Property(e => e.Areax)
        //        .HasPrecision(10, 2)
        //        .HasColumnName("areax");
        //    entity.Property(e => e.Areay)
        //        .HasPrecision(10, 2)
        //        .HasColumnName("areay");
        //    entity.Property(e => e.Assunto).HasColumnName("assunto");
        //    entity.Property(e => e.Assuntoalt).HasColumnName("assuntoalt");
        //    entity.Property(e => e.Assuntogrup).HasColumnName("assuntogrup");
        //    entity.Property(e => e.Atividade).HasColumnName("atividade");
        //    entity.Property(e => e.Bairro)
        //        .HasColumnType("character varying")
        //        .HasColumnName("bairro");
        //    entity.Property(e => e.Classificacao)
        //        .HasMaxLength(5)
        //        .HasDefaultValueSql("'NOR'::character varying")
        //        .HasComment("NOR = NORMAL(PADRAO)\r\nESP = ESPECIAL\r\nAPR = APROVE FACIL\nHAB = HABITE-SE LEGAL")
        //        .HasColumnName("classificacao");
        //    entity.Property(e => e.Cnpjempresa)
        //        .HasMaxLength(20)
        //        .HasColumnName("cnpjempresa");
        //    entity.Property(e => e.Codificacao).HasColumnName("codificacao");
        //    entity.Property(e => e.Codseguranca).HasColumnName("codseguranca");
        //    entity.Property(e => e.Cpfprop1)
        //        .HasColumnType("character varying")
        //        .HasColumnName("cpfprop1");
        //    entity.Property(e => e.Cpfprop2)
        //        .HasColumnType("character varying")
        //        .HasColumnName("cpfprop2");
        //    entity.Property(e => e.Cpfprop3)
        //        .HasColumnType("character varying")
        //        .HasColumnName("cpfprop3");
        //    entity.Property(e => e.Cpfproprietario)
        //        .HasColumnType("character varying")
        //        .HasColumnName("cpfproprietario");
        //    entity.Property(e => e.Datacriacao)
        //        .HasComment("forminputlabel[Data Criacao]\r\nforminputsize[30]\r\nforminputclass[datetime]\r\n\r\ngeragridmain[false]")
        //        .HasColumnType("timestamp without time zone")
        //        .HasColumnName("datacriacao");
        //    entity.Property(e => e.Dataencaminhamento)
        //        .HasColumnType("timestamp without time zone")
        //        .HasColumnName("dataencaminhamento");
        //    entity.Property(e => e.Dataexportado)
        //        .HasColumnType("timestamp without time zone")
        //        .HasColumnName("dataexportado");
        //    entity.Property(e => e.Datahomologacao)
        //        .HasComment("forminputlabel[Data Homologacao]\r\nforminputsize[30]\r\nforminputclass[datetime]\r\n\r\ngeragridmain[false]")
        //        .HasColumnType("timestamp without time zone")
        //        .HasColumnName("datahomologacao");
        //    entity.Property(e => e.Datalaudoavaliacao).HasColumnName("datalaudoavaliacao");
        //    entity.Property(e => e.Dataulttram)
        //        .HasColumnType("timestamp without time zone")
        //        .HasColumnName("dataulttram");
        //    entity.Property(e => e.Despacho)
        //        .HasColumnType("character varying")
        //        .HasColumnName("despacho");
        //    entity.Property(e => e.Emailproprietario)
        //        .HasColumnType("character varying")
        //        .HasColumnName("emailproprietario");
        //    entity.Property(e => e.Enquadramento1)
        //        .HasColumnType("character varying")
        //        .HasColumnName("enquadramento1");
        //    entity.Property(e => e.Enquadramento2)
        //        .HasColumnType("character varying")
        //        .HasColumnName("enquadramento2");
        //    entity.Property(e => e.Enquadramento3)
        //        .HasColumnType("character varying")
        //        .HasColumnName("enquadramento3");
        //    entity.Property(e => e.Enquadramento4)
        //        .HasColumnType("character varying")
        //        .HasColumnName("enquadramento4");
        //    entity.Property(e => e.Enquadramento5)
        //        .HasColumnType("character varying")
        //        .HasColumnName("enquadramento5");
        //    entity.Property(e => e.Enquadramento6)
        //        .HasColumnType("character varying")
        //        .HasColumnName("enquadramento6");
        //    entity.Property(e => e.Enquadramentofinal)
        //        .HasColumnType("character varying")
        //        .HasColumnName("enquadramentofinal");
        //    entity.Property(e => e.Exportado)
        //        .HasDefaultValue(0)
        //        .HasColumnName("exportado");
        //    entity.Property(e => e.Finalizado)
        //        .HasDefaultValue(0)
        //        .HasColumnName("finalizado");
        //    entity.Property(e => e.Fiscal).HasColumnName("fiscal");
        //    entity.Property(e => e.Grupoaud)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Inscricao)
        //        .HasColumnType("character varying")
        //        .HasColumnName("inscricao");
        //    entity.Property(e => e.Lote)
        //        .HasColumnType("character varying")
        //        .HasColumnName("lote");
        //    entity.Property(e => e.Lotedireita)
        //        .HasColumnType("character varying")
        //        .HasColumnName("lotedireita");
        //    entity.Property(e => e.Loteesquerda)
        //        .HasColumnType("character varying")
        //        .HasColumnName("loteesquerda");
        //    entity.Property(e => e.Lotefrente)
        //        .HasColumnType("character varying")
        //        .HasColumnName("lotefrente");
        //    entity.Property(e => e.Lotefundo)
        //        .HasColumnType("character varying")
        //        .HasColumnName("lotefundo");
        //    entity.Property(e => e.Natureza).HasColumnName("natureza");
        //    entity.Property(e => e.Numart)
        //        .HasColumnType("character varying")
        //        .HasColumnName("numart");
        //    entity.Property(e => e.Numero).HasColumnName("numero");
        //    entity.Property(e => e.Numerolaudoavaliacao).HasColumnName("numerolaudoavaliacao");
        //    entity.Property(e => e.Processo)
        //        .HasColumnType("character varying")
        //        .HasColumnName("processo");
        //    entity.Property(e => e.Processoexp)
        //        .HasMaxLength(12)
        //        .HasColumnName("processoexp");
        //    entity.Property(e => e.Procsubstituto)
        //        .HasColumnType("character varying")
        //        .HasColumnName("procsubstituto");
        //    entity.Property(e => e.Profissional)
        //        .HasComment("forminputlabel[Profissional]\r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Profissional]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("profissional");
        //    entity.Property(e => e.Proprietario)
        //        .HasColumnType("character varying")
        //        .HasColumnName("proprietario");
        //    entity.Property(e => e.Proprietario1)
        //        .HasColumnType("character varying")
        //        .HasColumnName("proprietario1");
        //    entity.Property(e => e.Proprietario2)
        //        .HasColumnType("character varying")
        //        .HasColumnName("proprietario2");
        //    entity.Property(e => e.Proprietario3)
        //        .HasColumnType("character varying")
        //        .HasColumnName("proprietario3");
        //    entity.Property(e => e.Quadra)
        //        .HasColumnType("character varying")
        //        .HasColumnName("quadra");
        //    entity.Property(e => e.Razaosocialempresa)
        //        .HasMaxLength(200)
        //        .HasColumnName("razaosocialempresa");
        //    entity.Property(e => e.Regiao).HasColumnName("regiao");
        //    entity.Property(e => e.Rua)
        //        .HasColumnType("character varying")
        //        .HasColumnName("rua");
        //    entity.Property(e => e.Status)
        //        .HasDefaultValue(0)
        //        .HasComment("0 - Configuracao - nao aparece em lugar nenuhm\r\n=================== TRIAGEM ================\r\n1 - Não analisado - Triagem(Primeira remessa enviada)	\r\n2 -  Ja analisei e retornei para o Profissional - Triagem (A remessa é analisada e retornada pela triagem.)\r\n3 - Voltou do Profissional corrigido - Triagem (A remessa é respondida pelo profissional (criação de uma nova remessa))\r\n==================== ANALISTA =================\r\n4 - Não analisado - Analista (Primeira remessa enviada)\r\n5 -  Ja analisei e retornei para o Profissional - Analista (A remessa é analisada e retornada pelo analista.)\r\n6 - Voltou do Profissional corrigido - Analista (A remessa é respondida pelo profissional (criação de uma nova remessa))\r\n=================== ADMINISTRADOR ===============\r\n7 - De acordo (Quando o analista gera a remessa final e envia arquivos para análise. Gera assinatura digital também. Profissional não pode ver a Remessa Final.)\r\n===================== DIRETOR ==================\r\n8 - Encaminhado ao Diretor (Quando o administrador confere os dados da remessa final e clica no botao encaminhar para diretor)\r\n9 - Aprovado (Quando o projeto foi efetivamente concluído e aceito. Profissional só visualizará a Remessa Final.)\r\n10 - Negado (Diretor retorna o projeto ao analista para corrigir os arquivos da Remessa Final.)")
        //        .HasColumnName("status");
        //    entity.Property(e => e.StatusAnistia).HasColumnName("status_anistia");
        //    entity.Property(e => e.Telcontato)
        //        .HasMaxLength(30)
        //        .HasColumnName("telcontato");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Usuaval)
        //        .HasColumnType("character varying")
        //        .HasColumnName("usuaval");
        //    entity.Property(e => e.Valorcontrapartida)
        //        .HasPrecision(10, 2)
        //        .HasColumnName("valorcontrapartida");
        //    entity.Property(e => e.Valorcontrapartidaextenso)
        //        .HasColumnType("character varying")
        //        .HasColumnName("valorcontrapartidaextenso");
        //    entity.Property(e => e.Valormetroquadrado)
        //        .HasPrecision(10, 2)
        //        .HasColumnName("valormetroquadrado");
        //    entity.Property(e => e.Valormetroquadradoextenso)
        //        .HasColumnType("character varying")
        //        .HasColumnName("valormetroquadradoextenso");
        //    entity.Property(e => e.Version)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("version");
        //    entity.Property(e => e.Zoneamento).HasColumnName("zoneamento");

        //    entity.HasOne(d => d.AnalistaNavigation).WithMany(p => p.ProjetoAnalistaNavigations)
        //        .HasForeignKey(d => d.Analista)
        //        .HasConstraintName("projeto_fk");

        //    entity.HasOne(d => d.AssuntoNavigation).WithMany(p => p.ProjetoAssuntoNavigations)
        //        .HasForeignKey(d => d.Assunto)
        //        .HasConstraintName("projeto_fk2");

        //    entity.HasOne(d => d.AssuntoaltNavigation).WithMany(p => p.ProjetoAssuntoaltNavigations)
        //        .HasForeignKey(d => d.Assuntoalt)
        //        .HasConstraintName("projeto_fk8");

        //    entity.HasOne(d => d.AtividadeNavigation).WithMany(p => p.Projetos)
        //        .HasForeignKey(d => d.Atividade)
        //        .HasConstraintName("projeto_fk4");

        //    entity.HasOne(d => d.CodificacaoNavigation).WithMany(p => p.Projetos)
        //        .HasForeignKey(d => d.Codificacao)
        //        .HasConstraintName("projeto_fk1");

        //    entity.HasOne(d => d.FiscalNavigation).WithMany(p => p.ProjetoFiscalNavigations)
        //        .HasForeignKey(d => d.Fiscal)
        //        .HasConstraintName("projeto_fk7");

        //    entity.HasOne(d => d.NaturezaNavigation).WithMany(p => p.Projetos)
        //        .HasForeignKey(d => d.Natureza)
        //        .HasConstraintName("projeto_fk3");

        //    entity.HasOne(d => d.ProfissionalNavigation).WithMany(p => p.Projetos)
        //        .HasForeignKey(d => d.Profissional)
        //        .HasConstraintName("projeto_fk5");

        //    entity.HasOne(d => d.RegiaoNavigation).WithMany(p => p.Projetos)
        //        .HasForeignKey(d => d.Regiao)
        //        .HasConstraintName("projeto_fk9");

        //    entity.HasOne(d => d.ZoneamentoNavigation).WithMany(p => p.Projetos)
        //        .HasForeignKey(d => d.Zoneamento)
        //        .HasConstraintName("projeto_fk6");
        //});

        //modelBuilder.Entity<Projeto1>(entity =>
        //{
        //    entity.HasKey(e => e.Projetoid).HasName("projeto_pkey");

        //    entity.ToTable("projeto", "cartografia");

        //    entity.Property(e => e.Projetoid)
        //        .HasComment("Código do projeto")
        //        .HasColumnName("projetoid");
        //    entity.Property(e => e.Assunto)
        //        .HasComment("Assunto do projeto")
        //        .HasColumnName("assunto");
        //    entity.Property(e => e.Datacadastro)
        //        .HasDefaultValueSql("now()")
        //        .HasComment("Data de cadastro")
        //        .HasColumnType("timestamp without time zone")
        //        .HasColumnName("datacadastro");
        //    entity.Property(e => e.Datahomologacao)
        //        .HasComment("Data de aprovação(homologação)")
        //        .HasColumnType("timestamp without time zone")
        //        .HasColumnName("datahomologacao");
        //    entity.Property(e => e.Processo)
        //        .HasMaxLength(20)
        //        .HasComment("Número do processo")
        //        .HasColumnName("processo");
        //    entity.Property(e => e.Status)
        //        .HasComment("Status do projeto")
        //        .HasColumnName("status");

        //    entity.HasOne(d => d.AssuntoNavigation).WithMany(p => p.Projeto1s)
        //        .HasForeignKey(d => d.Assunto)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("projeto_fk1");

        //    entity.HasOne(d => d.StatusNavigation).WithMany(p => p.Projeto1s)
        //        .HasForeignKey(d => d.Status)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("projeto_fk");
        //});

        //modelBuilder.Entity<Projeto2>(entity =>
        //{
        //    entity.HasKey(e => e.Projetoid).HasName("projeto_pkey");

        //    entity.ToTable("projeto", "planurb");

        //    entity.Property(e => e.Projetoid)
        //        .HasComment("Código do PROJETO")
        //        .HasColumnName("projetoid");
        //    entity.Property(e => e.Datacadastro)
        //        .HasDefaultValueSql("now()")
        //        .HasComment("Data de cadastro do Projeto")
        //        .HasColumnType("timestamp without time zone")
        //        .HasColumnName("datacadastro");
        //    entity.Property(e => e.Inscricao)
        //        .HasMaxLength(11)
        //        .HasComment("Inscrição Imobiliária")
        //        .HasColumnName("inscricao");
        //});

        //modelBuilder.Entity<ProjetoAnistium>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("projeto_anistia", "agenda");

        //    entity.Property(e => e.Alvara)
        //        .HasColumnType("character varying")
        //        .HasColumnName("alvara");
        //    entity.Property(e => e.Analista).HasColumnName("analista");
        //    entity.Property(e => e.Anolaudoavaliacao).HasColumnName("anolaudoavaliacao");
        //    entity.Property(e => e.Areaexcedente)
        //        .HasPrecision(10, 2)
        //        .HasColumnName("areaexcedente");
        //    entity.Property(e => e.Arealote)
        //        .HasPrecision(10, 2)
        //        .HasColumnName("arealote");
        //    entity.Property(e => e.Areaprojecao)
        //        .HasPrecision(10, 2)
        //        .HasColumnName("areaprojecao");
        //    entity.Property(e => e.Areax)
        //        .HasPrecision(10, 2)
        //        .HasColumnName("areax");
        //    entity.Property(e => e.Areay)
        //        .HasPrecision(10, 2)
        //        .HasColumnName("areay");
        //    entity.Property(e => e.Assunto).HasColumnName("assunto");
        //    entity.Property(e => e.Assuntoalt).HasColumnName("assuntoalt");
        //    entity.Property(e => e.Assuntogrup).HasColumnName("assuntogrup");
        //    entity.Property(e => e.Atividade).HasColumnName("atividade");
        //    entity.Property(e => e.Bairro)
        //        .HasColumnType("character varying")
        //        .HasColumnName("bairro");
        //    entity.Property(e => e.Classificacao)
        //        .HasMaxLength(5)
        //        .HasDefaultValueSql("'NOR'::character varying")
        //        .HasColumnName("classificacao");
        //    entity.Property(e => e.Cnpjempresa)
        //        .HasMaxLength(20)
        //        .HasColumnName("cnpjempresa");
        //    entity.Property(e => e.Codificacao).HasColumnName("codificacao");
        //    entity.Property(e => e.Codseguranca).HasColumnName("codseguranca");
        //    entity.Property(e => e.Cpfprop1)
        //        .HasColumnType("character varying")
        //        .HasColumnName("cpfprop1");
        //    entity.Property(e => e.Cpfprop2)
        //        .HasColumnType("character varying")
        //        .HasColumnName("cpfprop2");
        //    entity.Property(e => e.Cpfprop3)
        //        .HasColumnType("character varying")
        //        .HasColumnName("cpfprop3");
        //    entity.Property(e => e.Cpfproprietario)
        //        .HasColumnType("character varying")
        //        .HasColumnName("cpfproprietario");
        //    entity.Property(e => e.Datacriacao)
        //        .HasColumnType("timestamp without time zone")
        //        .HasColumnName("datacriacao");
        //    entity.Property(e => e.Dataencaminhamento)
        //        .HasColumnType("timestamp without time zone")
        //        .HasColumnName("dataencaminhamento");
        //    entity.Property(e => e.Dataexportado)
        //        .HasColumnType("timestamp without time zone")
        //        .HasColumnName("dataexportado");
        //    entity.Property(e => e.Datahomologacao)
        //        .HasColumnType("timestamp without time zone")
        //        .HasColumnName("datahomologacao");
        //    entity.Property(e => e.Datalaudoavaliacao).HasColumnName("datalaudoavaliacao");
        //    entity.Property(e => e.Dataulttram)
        //        .HasColumnType("timestamp without time zone")
        //        .HasColumnName("dataulttram");
        //    entity.Property(e => e.Despacho)
        //        .HasColumnType("character varying")
        //        .HasColumnName("despacho");
        //    entity.Property(e => e.Emailproprietario)
        //        .HasColumnType("character varying")
        //        .HasColumnName("emailproprietario");
        //    entity.Property(e => e.Enquadramento1)
        //        .HasColumnType("character varying")
        //        .HasColumnName("enquadramento1");
        //    entity.Property(e => e.Enquadramento2)
        //        .HasColumnType("character varying")
        //        .HasColumnName("enquadramento2");
        //    entity.Property(e => e.Enquadramento3)
        //        .HasColumnType("character varying")
        //        .HasColumnName("enquadramento3");
        //    entity.Property(e => e.Enquadramento4)
        //        .HasColumnType("character varying")
        //        .HasColumnName("enquadramento4");
        //    entity.Property(e => e.Enquadramento5)
        //        .HasColumnType("character varying")
        //        .HasColumnName("enquadramento5");
        //    entity.Property(e => e.Enquadramento6)
        //        .HasColumnType("character varying")
        //        .HasColumnName("enquadramento6");
        //    entity.Property(e => e.Enquadramentofinal)
        //        .HasColumnType("character varying")
        //        .HasColumnName("enquadramentofinal");
        //    entity.Property(e => e.Exportado)
        //        .HasDefaultValue(0)
        //        .HasColumnName("exportado");
        //    entity.Property(e => e.Finalizado)
        //        .HasDefaultValue(0)
        //        .HasColumnName("finalizado");
        //    entity.Property(e => e.Fiscal).HasColumnName("fiscal");
        //    entity.Property(e => e.Grupoaud).HasColumnName("grupoaud");
        //    entity.Property(e => e.Inscricao)
        //        .HasColumnType("character varying")
        //        .HasColumnName("inscricao");
        //    entity.Property(e => e.Lote)
        //        .HasColumnType("character varying")
        //        .HasColumnName("lote");
        //    entity.Property(e => e.Lotedireita)
        //        .HasColumnType("character varying")
        //        .HasColumnName("lotedireita");
        //    entity.Property(e => e.Loteesquerda)
        //        .HasColumnType("character varying")
        //        .HasColumnName("loteesquerda");
        //    entity.Property(e => e.Lotefrente)
        //        .HasColumnType("character varying")
        //        .HasColumnName("lotefrente");
        //    entity.Property(e => e.Lotefundo)
        //        .HasColumnType("character varying")
        //        .HasColumnName("lotefundo");
        //    entity.Property(e => e.Natureza).HasColumnName("natureza");
        //    entity.Property(e => e.Numart)
        //        .HasColumnType("character varying")
        //        .HasColumnName("numart");
        //    entity.Property(e => e.Numero).HasColumnName("numero");
        //    entity.Property(e => e.Numerolaudoavaliacao).HasColumnName("numerolaudoavaliacao");
        //    entity.Property(e => e.Processo)
        //        .HasColumnType("character varying")
        //        .HasColumnName("processo");
        //    entity.Property(e => e.Processoexp)
        //        .HasMaxLength(12)
        //        .HasColumnName("processoexp");
        //    entity.Property(e => e.Procsubstituto)
        //        .HasColumnType("character varying")
        //        .HasColumnName("procsubstituto");
        //    entity.Property(e => e.Profissional).HasColumnName("profissional");
        //    entity.Property(e => e.Projetoid).HasColumnName("projetoid");
        //    entity.Property(e => e.Proprietario)
        //        .HasColumnType("character varying")
        //        .HasColumnName("proprietario");
        //    entity.Property(e => e.Proprietario1)
        //        .HasColumnType("character varying")
        //        .HasColumnName("proprietario1");
        //    entity.Property(e => e.Proprietario2)
        //        .HasColumnType("character varying")
        //        .HasColumnName("proprietario2");
        //    entity.Property(e => e.Proprietario3)
        //        .HasColumnType("character varying")
        //        .HasColumnName("proprietario3");
        //    entity.Property(e => e.Quadra)
        //        .HasColumnType("character varying")
        //        .HasColumnName("quadra");
        //    entity.Property(e => e.Razaosocialempresa)
        //        .HasMaxLength(200)
        //        .HasColumnName("razaosocialempresa");
        //    entity.Property(e => e.Regiao).HasColumnName("regiao");
        //    entity.Property(e => e.Rua)
        //        .HasColumnType("character varying")
        //        .HasColumnName("rua");
        //    entity.Property(e => e.Status)
        //        .HasDefaultValue(0)
        //        .HasColumnName("status");
        //    entity.Property(e => e.Telcontato)
        //        .HasMaxLength(30)
        //        .HasColumnName("telcontato");
        //    entity.Property(e => e.Unidadeaud).HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud).HasColumnName("usuarioaud");
        //    entity.Property(e => e.Usuaval)
        //        .HasColumnType("character varying")
        //        .HasColumnName("usuaval");
        //    entity.Property(e => e.Valorcontrapartida)
        //        .HasPrecision(10, 2)
        //        .HasColumnName("valorcontrapartida");
        //    entity.Property(e => e.Valorcontrapartidaextenso)
        //        .HasColumnType("character varying")
        //        .HasColumnName("valorcontrapartidaextenso");
        //    entity.Property(e => e.Valormetroquadrado)
        //        .HasPrecision(10, 2)
        //        .HasColumnName("valormetroquadrado");
        //    entity.Property(e => e.Valormetroquadradoextenso)
        //        .HasColumnType("character varying")
        //        .HasColumnName("valormetroquadradoextenso");
        //    entity.Property(e => e.Version).HasColumnName("version");
        //    entity.Property(e => e.Zoneamento).HasColumnName("zoneamento");
        //});

        //modelBuilder.Entity<Projetoana>(entity =>
        //{
        //    entity.HasKey(e => e.Projetoanaid).HasName("projetoana_pkey");

        //    entity.ToTable("projetoana", "cartografia");

        //    entity.Property(e => e.Projetoanaid)
        //        .HasComment("Código do projetoana")
        //        .HasColumnName("projetoanaid");
        //    entity.Property(e => e.Analista)
        //        .HasComment("Analista vinculado")
        //        .HasColumnName("analista");
        //    entity.Property(e => e.Dataencaminhado)
        //        .HasComment("Data do encaminhamento")
        //        .HasColumnType("timestamp without time zone")
        //        .HasColumnName("dataencaminhado");
        //    entity.Property(e => e.Projeto)
        //        .HasComment("Projeto vinculado")
        //        .HasColumnName("projeto");

        //    entity.HasOne(d => d.AnalistaNavigation).WithMany(p => p.Projetoanas)
        //        .HasForeignKey(d => d.Analista)
        //        .HasConstraintName("projetoana_fk1");

        //    entity.HasOne(d => d.ProjetoNavigation).WithMany(p => p.Projetoanas)
        //        .HasForeignKey(d => d.Projeto)
        //        .HasConstraintName("projetoana_fk");
        //});

        //modelBuilder.Entity<Projetoin>(entity =>
        //{
        //    entity.HasKey(e => e.Projetoinsid).HasName("projetoins_pkey");

        //    entity.ToTable("projetoins", "cartografia");

        //    entity.Property(e => e.Projetoinsid)
        //        .HasComment("Código do projetoins")
        //        .HasColumnName("projetoinsid");
        //    entity.Property(e => e.Bairro)
        //        .HasMaxLength(80)
        //        .HasComment("Bairro")
        //        .HasColumnName("bairro");
        //    entity.Property(e => e.Compl)
        //        .HasMaxLength(80)
        //        .HasComment("Complemento do logradouro")
        //        .HasColumnName("compl");
        //    entity.Property(e => e.Cpfcnpj)
        //        .HasMaxLength(20)
        //        .HasComment("CPF ou CNPJ do proprietario")
        //        .HasColumnName("cpfcnpj");
        //    entity.Property(e => e.Inscricao)
        //        .HasMaxLength(12)
        //        .HasComment("Inscrição imobiliaria")
        //        .HasColumnName("inscricao");
        //    entity.Property(e => e.Logradouro)
        //        .HasMaxLength(80)
        //        .HasComment("Logradouro")
        //        .HasColumnName("logradouro");
        //    entity.Property(e => e.Lote)
        //        .HasMaxLength(5)
        //        .HasComment("Lote")
        //        .HasColumnName("lote");
        //    entity.Property(e => e.Numero)
        //        .HasMaxLength(12)
        //        .HasComment("Número do logradouro")
        //        .HasColumnName("numero");
        //    entity.Property(e => e.Parcelamento)
        //        .HasMaxLength(80)
        //        .HasComment("Parcelamento")
        //        .HasColumnName("parcelamento");
        //    entity.Property(e => e.Projeto)
        //        .HasComment("Projeto vinculado")
        //        .HasColumnName("projeto");
        //    entity.Property(e => e.Proprietario)
        //        .HasMaxLength(100)
        //        .HasComment("Proprietario")
        //        .HasColumnName("proprietario");
        //    entity.Property(e => e.Quadra)
        //        .HasMaxLength(5)
        //        .HasComment("Quadra")
        //        .HasColumnName("quadra");
        //    entity.Property(e => e.Regiao)
        //        .HasMaxLength(80)
        //        .HasComment("Região")
        //        .HasColumnName("regiao");

        //    entity.HasOne(d => d.ProjetoNavigation).WithMany(p => p.Projetoins)
        //        .HasForeignKey(d => d.Projeto)
        //        .HasConstraintName("projetoins_fk");
        //});

        //modelBuilder.Entity<Proprietario>(entity =>
        //{
        //    entity.HasKey(e => e.Proprietarioid).HasName("proprietario_pkey");

        //    entity.ToTable("proprietario", "divulgacao", tb => tb.HasComment("template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Proprietário]\r\nfiltersgrid[#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Proprietários]"));

        //    entity.Property(e => e.Proprietarioid)
        //        .HasComment("forminputlabel[Código]\r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("proprietarioid");
        //    entity.Property(e => e.Celular)
        //        .HasComment("forminputlabel[Celular]\r\nforminputsize[12]\r\nforminputclass[phone]\r\n\r\ngeragridmain[false]")
        //        .HasColumnType("character varying")
        //        .HasColumnName("celular");
        //    entity.Property(e => e.Cep)
        //        .HasComment("forminputlabel[CEP]\r\nforminputsize[10]\r\nforminputclass[number]\r\n\r\ngeragridmain[false]")
        //        .HasColumnName("cep");
        //    entity.Property(e => e.Complemento)
        //        .HasComment("forminputlabel[Complemento]\r\nforminputsize[30]\r\nforminputclass[uppercase]\r\n\r\ngeragridmain[false]")
        //        .HasColumnType("character varying")
        //        .HasColumnName("complemento");
        //    entity.Property(e => e.Grupoaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Nome)
        //        .HasComment("forminputlabel[Nome]\r\nforminputsize[50]\r\nforminputclass[uppercase]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Nome]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnType("character varying")
        //        .HasColumnName("nome");
        //    entity.Property(e => e.Numero)
        //        .HasComment("forminputlabel[N&ordm;]\r\nforminputsize[10]\r\nforminputclass[number]\r\n\r\ngeragridmain[false]")
        //        .HasColumnName("numero");
        //    entity.Property(e => e.Rua)
        //        .HasComment("forminputlabel[Rua]\r\nforminputsize[12]\r\nforminputclass[ro]\r\n\r\ngeragridmain[false]")
        //        .HasColumnName("rua");
        //    entity.Property(e => e.Telefone)
        //        .HasComment("forminputlabel[Telefone]\r\nforminputsize[12]\r\nforminputclass[phone]\r\n\r\ngeragridmain[false]")
        //        .HasColumnType("character varying")
        //        .HasColumnName("telefone");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("version");

        //    entity.HasOne(d => d.RuaNavigation).WithMany(p => p.Proprietarios)
        //        .HasForeignKey(d => d.Rua)
        //        .HasConstraintName("proprietario_fk");
        //});

        //modelBuilder.Entity<Recibo>(entity =>
        //{
        //    entity.HasKey(e => e.Reciboid).HasName("recibo_pkey");

        //    entity.ToTable("recibo", "auditoria");

        //    entity.Property(e => e.Reciboid).HasColumnName("reciboid");
        //    entity.Property(e => e.Cpf)
        //        .HasColumnType("character varying")
        //        .HasColumnName("cpf");
        //    entity.Property(e => e.Doador)
        //        .HasColumnType("character varying")
        //        .HasColumnName("doador");
        //    entity.Property(e => e.Numero).HasColumnName("numero");
        //    entity.Property(e => e.Valor)
        //        .HasColumnType("character varying")
        //        .HasColumnName("valor");
        //});

        //modelBuilder.Entity<Recurso>(entity =>
        //{
        //    entity.HasKey(e => e.Recursoid).HasName("recurso_pkey");

        //    entity.ToTable("recurso", "sisobra", tb => tb.HasComment("template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Recurso]\r\nfiltersgrid[#text_filter,#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Recursos]"));

        //    entity.Property(e => e.Recursoid)
        //        .HasComment("forminputlabel[Código] \r\nforminputsize[7]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Código] \r\ncolumngridtype[ro] \r\ncolumngridsize[80] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnName("recursoid");
        //    entity.Property(e => e.Grupoaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Nome)
        //        .HasComment("forminputlabel[Nome] \r\nforminputsize[70]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Nome] \r\ncolumngridtype[ro] \r\ncolumngridsize[*] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnType("character varying")
        //        .HasColumnName("nome");
        //    entity.Property(e => e.Sigla)
        //        .HasComment("forminputlabel[Sigla] \r\nforminputsize[10]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Sigla] \r\ncolumngridtype[ro] \r\ncolumngridsize[20] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnType("character varying")
        //        .HasColumnName("sigla");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("version");
        //});

        //modelBuilder.Entity<Regiao>(entity =>
        //{
        //    entity.HasKey(e => e.Regiaoid).HasName("regiao_pkey");

        //    entity.ToTable("regiao", "agenda");

        //    entity.Property(e => e.Regiaoid).HasColumnName("regiaoid");
        //    entity.Property(e => e.Grupoaud)
        //        .HasDefaultValue(0)
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Nome)
        //        .HasMaxLength(50)
        //        .HasColumnName("nome");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasDefaultValue(0)
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(1)
        //        .HasColumnName("version");
        //});

        //modelBuilder.Entity<Regiaourbana>(entity =>
        //{
        //    entity.HasKey(e => e.Regiaourbanaid).HasName("regiaourbana_pkey");

        //    entity.ToTable("regiaourbana", "sisobra", tb => tb.HasComment("template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Região Urbana]\r\nfiltersgrid[#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Regiões Urbanas]"));

        //    entity.Property(e => e.Regiaourbanaid)
        //        .HasComment("forminputlabel[Código] \r\nforminputsize[7]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Código] \r\ncolumngridtype[ro] \r\ncolumngridsize[80] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnName("regiaourbanaid");
        //    entity.Property(e => e.Grupoaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Nome)
        //        .HasComment("forminputlabel[Nome] \r\nforminputsize[70]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Nome] \r\ncolumngridtype[ro] \r\ncolumngridsize[*] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnType("character varying")
        //        .HasColumnName("nome");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("version");
        //});

        //modelBuilder.Entity<Regiaourbana1>(entity =>
        //{
        //    entity.HasKey(e => e.Regiaourbanaid).HasName("regiaourbana_pkey");

        //    entity.ToTable("regiaourbana");

        //    entity.Property(e => e.Regiaourbanaid).HasColumnName("regiaourbanaid");
        //    entity.Property(e => e.Grupoaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Nome)
        //        .HasColumnType("character varying")
        //        .HasColumnName("nome");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("version");
        //});

        //modelBuilder.Entity<Relatorio>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("relatorio", "divulgacao");

        //    entity.Property(e => e.Bairroimo)
        //        .HasMaxLength(255)
        //        .HasColumnName("bairroimo");
        //    entity.Property(e => e.Dataexpedicao).HasColumnName("dataexpedicao");
        //    entity.Property(e => e.Enderecoempresa)
        //        .HasMaxLength(255)
        //        .HasColumnName("enderecoempresa");
        //    entity.Property(e => e.Enderecoimobiliaria)
        //        .HasMaxLength(255)
        //        .HasColumnName("enderecoimobiliaria");
        //    entity.Property(e => e.Grupoaud).HasColumnName("grupoaud");
        //    entity.Property(e => e.Inscricaoeconomica)
        //        .HasMaxLength(11)
        //        .HasColumnName("inscricaoeconomica");
        //    entity.Property(e => e.Inscricaoimobiliaria)
        //        .HasMaxLength(11)
        //        .HasColumnName("inscricaoimobiliaria");
        //    entity.Property(e => e.Nomeempresa)
        //        .HasMaxLength(255)
        //        .HasColumnName("nomeempresa");
        //    entity.Property(e => e.Numeroautorizacao)
        //        .HasMaxLength(15)
        //        .HasColumnName("numeroautorizacao");
        //    entity.Property(e => e.Ordem).HasColumnName("ordem");
        //    entity.Property(e => e.Parcelamentoimo)
        //        .HasMaxLength(255)
        //        .HasColumnName("parcelamentoimo");
        //    entity.Property(e => e.Prazo).HasColumnName("prazo");
        //    entity.Property(e => e.Regiaoimo)
        //        .HasMaxLength(100)
        //        .HasColumnName("regiaoimo");
        //    entity.Property(e => e.Relatorioid).HasColumnName("relatorioid");
        //    entity.Property(e => e.Tipodivulgacao)
        //        .HasMaxLength(255)
        //        .HasColumnName("tipodivulgacao");
        //    entity.Property(e => e.Unidadeaud).HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud).HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version).HasColumnName("version");
        //});

        //modelBuilder.Entity<Relobra>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("relobra", "sisobra");

        //    entity.Property(e => e.Anomes)
        //        .HasColumnType("character varying")
        //        .HasColumnName("anomes");
        //    entity.Property(e => e.Nome)
        //        .HasColumnType("character varying")
        //        .HasColumnName("nome");
        //    entity.Property(e => e.Tempo)
        //        .HasColumnType("character varying")
        //        .HasColumnName("tempo");
        //    entity.Property(e => e.Total).HasColumnName("total");
        //    entity.Property(e => e.Valorinvestimento)
        //        .HasPrecision(30, 2)
        //        .HasColumnName("valorinvestimento");
        //});

        //modelBuilder.Entity<Remessa>(entity =>
        //{
        //    entity.HasKey(e => e.Remessaid).HasName("remessa_pkey");

        //    entity.ToTable("remessa", "agenda", tb => tb.HasComment("template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Remessa]\r\n\r\nfiltersgrid[#text_filter,#text_filter] \r\n\r\n\r\ngridtitle[Lista de Remessa]\r\n\r\nmasterdetails[true]\r\ndetails[documento]"));

        //    entity.Property(e => e.Remessaid)
        //        .HasComment("forminputlabel[Código] \r\nforminputsize[7]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Código] \r\ncolumngridtype[ro] \r\ncolumngridsize[80] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnName("remessaid");
        //    entity.Property(e => e.Analista).HasColumnName("analista");
        //    entity.Property(e => e.Data)
        //        .HasComment("forminputlabel[Data Criacao] \r\nforminputsize[30]  \r\nforminputclass[datetime]\r\n\r\ngeragridmain[false]")
        //        .HasColumnType("timestamp without time zone")
        //        .HasColumnName("data");
        //    entity.Property(e => e.Datahoraexigencia)
        //        .HasColumnType("timestamp without time zone")
        //        .HasColumnName("datahoraexigencia");
        //    entity.Property(e => e.Descricao)
        //        .HasComment("forminputlabel[Descricao] \r\nforminputsize[80]  \r\n\r\ngeragridmain[false]")
        //        .HasColumnType("character varying")
        //        .HasColumnName("descricao");
        //    entity.Property(e => e.Despacho)
        //        .HasColumnType("character varying")
        //        .HasColumnName("despacho");
        //    entity.Property(e => e.Despachosemadur)
        //        .HasColumnType("character varying")
        //        .HasColumnName("despachosemadur");
        //    entity.Property(e => e.Exigido)
        //        .HasDefaultValue(0)
        //        .HasColumnName("exigido");
        //    entity.Property(e => e.Grupoaud)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Projeto)
        //        .HasComment("forminputlabel[Projeto]\r\nforminputsize[250]\r\n\r\nsearchmode[combobox]\r\ncomboboxresultfield[projeto.titulo]\r\n\r\ngeragridmain[false]")
        //        .HasColumnName("projeto");
        //    entity.Property(e => e.Remetente)
        //        .HasMaxLength(3)
        //        .IsFixedLength()
        //        .HasColumnName("remetente");
        //    entity.Property(e => e.Status)
        //        .HasComment("PROF - Remessa em construção pelo Profissional.\r\nCONF - Remessa Conferida pelo Ananalista/Supervisor\r\nFIN - Remessa finalizada pelo Profissional.\r\nRMF - Remessa Final")
        //        .HasColumnType("character varying")
        //        .HasColumnName("status");
        //    entity.Property(e => e.Titulo)
        //        .HasComment("forminputlabel[Titulo] \r\nforminputsize[70]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Titulo] \r\ncolumngridtype[ro] \r\ncolumngridsize[*] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnType("character varying")
        //        .HasColumnName("titulo");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("version");

        //    entity.HasOne(d => d.AnalistaNavigation).WithMany(p => p.Remessas)
        //        .HasForeignKey(d => d.Analista)
        //        .HasConstraintName("remessa_fk1");

        //    entity.HasOne(d => d.ProjetoNavigation).WithMany(p => p.Remessas)
        //        .HasForeignKey(d => d.Projeto)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("remessa_fk");
        //});

        //modelBuilder.Entity<Remessa1>(entity =>
        //{
        //    entity.HasKey(e => e.Remessaid).HasName("remessa_pkey");

        //    entity.ToTable("remessa", "cartografia");

        //    entity.Property(e => e.Remessaid)
        //        .HasComment("Código da remessa")
        //        .HasColumnName("remessaid");
        //    entity.Property(e => e.Analista)
        //        .HasComment("Analista vinculado que analisou a remessa")
        //        .HasColumnName("analista");
        //    entity.Property(e => e.Data)
        //        .HasDefaultValueSql("now()")
        //        .HasComment("Data de cadastro da remessa")
        //        .HasColumnType("timestamp without time zone")
        //        .HasColumnName("data");
        //    entity.Property(e => e.Descricao)
        //        .HasMaxLength(50)
        //        .HasComment("Descrição da remessa")
        //        .HasColumnName("descricao");
        //    entity.Property(e => e.Projeto)
        //        .HasComment("Projeto vinculado")
        //        .HasColumnName("projeto");
        //    entity.Property(e => e.Status)
        //        .HasMaxLength(5)
        //        .HasComment("Status da remessa, FIN = FINALIZADA , ANA = EM ANALISE")
        //        .HasColumnName("status");

        //    entity.HasOne(d => d.AnalistaNavigation).WithMany(p => p.Remessa1s)
        //        .HasForeignKey(d => d.Analista)
        //        .HasConstraintName("remessa_fk1");

        //    entity.HasOne(d => d.ProjetoNavigation).WithMany(p => p.Remessa1s)
        //        .HasForeignKey(d => d.Projeto)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("remessa_fk");
        //});

        //modelBuilder.Entity<Remessaexigencia>(entity =>
        //{
        //    entity.HasKey(e => e.Remessaexigenciaid).HasName("remessaexigencia_pkey");

        //    entity.ToTable("remessaexigencia", "agenda");

        //    entity.Property(e => e.Remessaexigenciaid).HasColumnName("remessaexigenciaid");
        //    entity.Property(e => e.Descricao)
        //        .HasColumnType("character varying")
        //        .HasColumnName("descricao");
        //    entity.Property(e => e.Exigencia).HasColumnName("exigencia");
        //    entity.Property(e => e.Grupoaud)
        //        .HasDefaultValue(0)
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Remessa).HasColumnName("remessa");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasDefaultValue(0)
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasColumnName("version");

        //    entity.HasOne(d => d.ExigenciaNavigation).WithMany(p => p.Remessaexigencia)
        //        .HasForeignKey(d => d.Exigencia)
        //        .HasConstraintName("remessaexigencia_fk1");

        //    entity.HasOne(d => d.RemessaNavigation).WithMany(p => p.Remessaexigencia)
        //        .HasForeignKey(d => d.Remessa)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("remessaexigencia_fk");
        //});

        //modelBuilder.Entity<Requerimento>(entity =>
        //{
        //    entity.HasKey(e => e.Requerimentoid).HasName("requerimento_pkey");

        //    entity.ToTable("requerimento", "planurb");

        //    entity.Property(e => e.Requerimentoid)
        //        .HasComment("Código do requerimento")
        //        .HasColumnName("requerimentoid");
        //    entity.Property(e => e.Datacadastro)
        //        .HasDefaultValueSql("now()")
        //        .HasComment("Data de cadastro do requerimento")
        //        .HasColumnType("timestamp without time zone")
        //        .HasColumnName("datacadastro");
        //    entity.Property(e => e.Endereco)
        //        .HasComment("Localização, endereço ou proximidade (exato ou aproximada)")
        //        .HasColumnType("character varying")
        //        .HasColumnName("endereco");
        //    entity.Property(e => e.Profissional)
        //        .HasComment("Profissional requerente")
        //        .HasColumnName("profissional");
        //    entity.Property(e => e.Proprietario)
        //        .HasComment("Proprietário requerente")
        //        .HasColumnType("character varying")
        //        .HasColumnName("proprietario");
        //    entity.Property(e => e.Telproprietario)
        //        .HasComment("Telefone do proprietário")
        //        .HasColumnType("character varying")
        //        .HasColumnName("telproprietario");
        //    entity.Property(e => e.Tipoatividade)
        //        .HasComment("Tipo de atividade/Empreendimento")
        //        .HasColumnName("tipoatividade");
        //    entity.Property(e => e.Tiporequerimento)
        //        .HasMaxLength(5)
        //        .HasComment("Tipo do requerimento: GDU GDR GUIV")
        //        .HasColumnName("tiporequerimento");

        //    entity.HasOne(d => d.ProfissionalNavigation).WithMany(p => p.Requerimentos)
        //        .HasForeignKey(d => d.Profissional)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("requerimento_fk");
        //});

        //modelBuilder.Entity<Residuo>(entity =>
        //{
        //    entity.HasKey(e => e.Residuoid).HasName("residuo_pkey");

        //    entity.ToTable("residuo", "agenda", tb => tb.HasComment("template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Resíduo]\r\nfiltersgrid[#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Resíduos]"));

        //    entity.Property(e => e.Residuoid)
        //        .HasComment("forminputlabel[Código]\r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("residuoid");
        //    entity.Property(e => e.Classe)
        //        .HasComment("forminputlabel[Classe]\r\nforminputsize[180]\r\n\r\nsearchmode[combobox]\r\ncomboboxresultfield[classe.nome]\r\n\r\ncolumngridid[classe.nome]\r\ncolumngridtitle[Classe]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("classe");
        //    entity.Property(e => e.Grupoaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Nome)
        //        .HasMaxLength(200)
        //        .HasComment("forminputlabel[Nome]\r\nforminputsize[50]\r\nforminputclass[uppercase]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Nome]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("nome");
        //    entity.Property(e => e.Reutilizacao)
        //        .HasComment("0-Sim / 1-Não\r\n\r\nforminputlabel[Reutilização]\r\nforminputsize[30]\r\nforminputclass[required]\r\n\r\ngeragridmain[false]")
        //        .HasColumnName("reutilizacao");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("version");

        //    entity.HasOne(d => d.ClasseNavigation).WithMany(p => p.Residuos)
        //        .HasForeignKey(d => d.Classe)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("residuo_fk");
        //});

        //modelBuilder.Entity<Residuo1>(entity =>
        //{
        //    entity.HasKey(e => e.Residuoid).HasName("residuo_pkey");

        //    entity.ToTable("residuo", "residuos", tb => tb.HasComment("template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs]\r\n\r\nformtitle[Cadastro de Resíduo]\r\nfiltersgrid[#text_filter,#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Resíduos]"));

        //    entity.Property(e => e.Residuoid)
        //        .HasComment("forminputlabel[Código]\r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("residuoid");
        //    entity.Property(e => e.Armazenamento).HasColumnName("armazenamento");
        //    entity.Property(e => e.Autotransporte).HasColumnName("autotransporte");
        //    entity.Property(e => e.Caracteristica).HasColumnName("caracteristica");
        //    entity.Property(e => e.Classificacao).HasColumnName("classificacao");
        //    entity.Property(e => e.Codigo)
        //        .HasMaxLength(20)
        //        .HasColumnName("codigo");
        //    entity.Property(e => e.Estadofisico)
        //        .HasComment("forminputlabel[Estado Físico]\r\nforminputsize[150]\r\n\r\nsearchmode[combobox]\r\ncomboboxresultfield[estadofisico.nome]\r\n\r\ncolumngridid[estadofisico.nome]\r\ncolumngridtitle[Estado Físico]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("estadofisico");
        //    entity.Property(e => e.Grupoaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]")
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Nome)
        //        .HasComment("forminputlabel[Nome]\r\nforminputsize[50]\r\nforminputclass[uppercase]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Nome]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnType("character varying")
        //        .HasColumnName("nome");
        //    entity.Property(e => e.Numeroonu).HasColumnName("numeroonu");
        //    entity.Property(e => e.Numerorisco).HasColumnName("numerorisco");
        //    entity.Property(e => e.Obs)
        //        .HasComment("forminputlabel[Observação]\r\nforminputsize[50]\r\nforminputclass[uppercase]\r\n\r\ngeragridmain[false]")
        //        .HasColumnType("character varying")
        //        .HasColumnName("obs");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]")
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]")
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]")
        //        .HasColumnName("version");

        //    entity.HasOne(d => d.ArmazenamentoNavigation).WithMany(p => p.Residuo1s)
        //        .HasForeignKey(d => d.Armazenamento)
        //        .HasConstraintName("residuo_fk3");

        //    entity.HasOne(d => d.CaracteristicaNavigation).WithMany(p => p.Residuo1s)
        //        .HasForeignKey(d => d.Caracteristica)
        //        .HasConstraintName("residuo_fk2");

        //    entity.HasOne(d => d.ClassificacaoNavigation).WithMany(p => p.Residuo1s)
        //        .HasForeignKey(d => d.Classificacao)
        //        .HasConstraintName("residuo_fk1");

        //    entity.HasOne(d => d.EstadofisicoNavigation).WithMany(p => p.Residuo1s)
        //        .HasForeignKey(d => d.Estadofisico)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("residuo_fk");
        //});

        //modelBuilder.Entity<Residuoarea>(entity =>
        //{
        //    entity.HasKey(e => e.Residuoareaid).HasName("residuoarea_pkey");

        //    entity.ToTable("residuoarea", "residuos", tb => tb.HasComment("template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs]\r\n\r\nformtitle[Cadastro de Resíduo da Área Receptora]\r\nfiltersgrid[#text_filter,#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Resíduos da Área Receptora]"));

        //    entity.Property(e => e.Residuoareaid)
        //        .HasComment("forminputlabel[Código]\r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("residuoareaid");
        //    entity.Property(e => e.Areareceptora)
        //        .HasComment("forminputlabel[Área Receptora]\r\nforminputsize[150]\r\n\r\nsearchmode[combobox]\r\ncomboboxresultfield[areareceptora.nome]\r\n\r\ncolumngridid[areareceptora.nome]\r\ncolumngridtitle[Área Receptora]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("areareceptora");
        //    entity.Property(e => e.Grupoaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]")
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Residuo)
        //        .HasComment("forminputlabel[Resíduo]\r\nforminputsize[30]\r\nforminputclass[uppercase]\r\n\r\nsearchmode[popup]\r\npopupresultfield[nome]\r\npopupfieldsgrid[residuoid,nome:residuoid]\r\n\r\ncolumngridid[residuo.nome]\r\ncolumngridtitle[Resíduo]\r\ncolumngridtype[ro]\r\ncolumngridsize[150]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("residuo");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]")
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]")
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]")
        //        .HasColumnName("version");

        //    entity.HasOne(d => d.AreareceptoraNavigation).WithMany(p => p.Residuoareas)
        //        .HasForeignKey(d => d.Areareceptora)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("residuoarea_fk1");

        //    entity.HasOne(d => d.ResiduoNavigation).WithMany(p => p.Residuoareas)
        //        .HasForeignKey(d => d.Residuo)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("residuoarea_fk");
        //});

        //modelBuilder.Entity<Residuocaracteristica>(entity =>
        //{
        //    entity.HasKey(e => e.Residuocaracteristicaid).HasName("residuocaracteristica_pkey");

        //    entity.ToTable("residuocaracteristica", "residuos", tb => tb.HasComment("template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs]\r\n\r\nformtitle[Cadastro de Característica de Resíduo]\r\nfiltersgrid[#text_filter,#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Características do Resíduo]"));

        //    entity.Property(e => e.Residuocaracteristicaid)
        //        .HasComment("forminputlabel[Código]\r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("residuocaracteristicaid");
        //    entity.Property(e => e.Caracteristica)
        //        .HasComment("forminputlabel[Característica]\r\nforminputsize[150]\r\n\r\nsearchmode[combobox]\r\ncomboboxresultfield[caracteristica.nome]\r\n\r\ncolumngridid[caracteristica.nome]\r\ncolumngridtitle[Característica]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("caracteristica");
        //    entity.Property(e => e.Grupoaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]")
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Residuo)
        //        .HasComment("forminputlabel[Resíduo]\r\nforminputsize[30]\r\nforminputclass[uppercase]\r\n\r\nsearchmode[popup]\r\npopupresultfield[nome]\r\npopupfieldsgrid[residuoid,nome:residuoid]\r\n\r\ncolumngridid[residuo.nome]\r\ncolumngridtitle[Resíduo]\r\ncolumngridtype[ro]\r\ncolumngridsize[150]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("residuo");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]")
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]")
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]")
        //        .HasColumnName("version");

        //    entity.HasOne(d => d.CaracteristicaNavigation).WithMany(p => p.Residuocaracteristicas)
        //        .HasForeignKey(d => d.Caracteristica)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("residuocaracteristica_fk1");

        //    entity.HasOne(d => d.ResiduoNavigation).WithMany(p => p.Residuocaracteristicas)
        //        .HasForeignKey(d => d.Residuo)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("residuocaracteristica_fk");
        //});

        //modelBuilder.Entity<ResiduosAreareceptora>(entity =>
        //{
        //    entity.HasKey(e => new { e.Areareceptoraid, e.Rev }).HasName("residuos_areareceptora_pkey");

        //    entity.ToTable("residuos_areareceptora", "auditoria");

        //    entity.Property(e => e.Areareceptoraid).HasColumnName("areareceptoraid");
        //    entity.Property(e => e.Rev).HasColumnName("rev");
        //    entity.Property(e => e.Bairro)
        //        .HasMaxLength(255)
        //        .HasColumnName("bairro");
        //    entity.Property(e => e.Cep)
        //        .HasMaxLength(255)
        //        .HasColumnName("cep");
        //    entity.Property(e => e.Codigo).HasColumnName("codigo");
        //    entity.Property(e => e.Complemento)
        //        .HasMaxLength(255)
        //        .HasColumnName("complemento");
        //    entity.Property(e => e.Empresa).HasColumnName("empresa");
        //    entity.Property(e => e.Inscricaomunicipal).HasColumnName("inscricaomunicipal");
        //    entity.Property(e => e.Licencaambiental)
        //        .HasMaxLength(20)
        //        .HasColumnName("licencaambiental");
        //    entity.Property(e => e.Nome)
        //        .HasMaxLength(255)
        //        .HasColumnName("nome");
        //    entity.Property(e => e.Numero)
        //        .HasMaxLength(255)
        //        .HasColumnName("numero");
        //    entity.Property(e => e.Revtype).HasColumnName("revtype");
        //    entity.Property(e => e.Rua)
        //        .HasMaxLength(255)
        //        .HasColumnName("rua");
        //    entity.Property(e => e.Senha)
        //        .HasColumnType("character varying")
        //        .HasColumnName("senha");
        //    entity.Property(e => e.Situacao).HasColumnName("situacao");
        //    entity.Property(e => e.Telefone)
        //        .HasMaxLength(255)
        //        .HasColumnName("telefone");
        //    entity.Property(e => e.Transportadora).HasColumnName("transportadora");
        //    entity.Property(e => e.Usuario).HasColumnName("usuario");
        //    entity.Property(e => e.Validadelicenca).HasColumnName("validadelicenca");

        //    entity.HasOne(d => d.RevNavigation).WithMany(p => p.ResiduosAreareceptoras)
        //        .HasForeignKey(d => d.Rev)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("fk311a9ab777f68f91");
        //});

        //modelBuilder.Entity<ResiduosArmazenamento>(entity =>
        //{
        //    entity.HasKey(e => new { e.Armazenamentoid, e.Rev }).HasName("residuos_armazenamento_pkey");

        //    entity.ToTable("residuos_armazenamento", "auditoria");

        //    entity.Property(e => e.Armazenamentoid).HasColumnName("armazenamentoid");
        //    entity.Property(e => e.Rev).HasColumnName("rev");
        //    entity.Property(e => e.Nome)
        //        .HasMaxLength(255)
        //        .HasColumnName("nome");
        //    entity.Property(e => e.Revtype).HasColumnName("revtype");

        //    entity.HasOne(d => d.RevNavigation).WithMany(p => p.ResiduosArmazenamentos)
        //        .HasForeignKey(d => d.Rev)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("fkb943b68d77f68f91");
        //});

        //modelBuilder.Entity<ResiduosCtr>(entity =>
        //{
        //    entity.HasKey(e => new { e.Ctrid, e.Rev }).HasName("residuos_ctr_pkey");

        //    entity.ToTable("residuos_ctr", "auditoria");

        //    entity.Property(e => e.Ctrid).HasColumnName("ctrid");
        //    entity.Property(e => e.Rev).HasColumnName("rev");
        //    entity.Property(e => e.Areareceptora).HasColumnName("areareceptora");
        //    entity.Property(e => e.Areareceptora2).HasColumnName("areareceptora2");
        //    entity.Property(e => e.Armazenamento).HasColumnName("armazenamento");
        //    entity.Property(e => e.Autotransporte).HasColumnName("autotransporte");
        //    entity.Property(e => e.Codigobaixa).HasColumnName("codigobaixa");
        //    entity.Property(e => e.Datahoracadastro)
        //        .HasColumnType("timestamp without time zone")
        //        .HasColumnName("datahoracadastro");
        //    entity.Property(e => e.Datahoradesfinal)
        //        .HasColumnType("timestamp without time zone")
        //        .HasColumnName("datahoradesfinal");
        //    entity.Property(e => e.Datahoraentrega)
        //        .HasColumnType("timestamp without time zone")
        //        .HasColumnName("datahoraentrega");
        //    entity.Property(e => e.Datahorafinalizado)
        //        .HasColumnType("timestamp without time zone")
        //        .HasColumnName("datahorafinalizado");
        //    entity.Property(e => e.Datahorancertificado)
        //        .HasColumnType("timestamp without time zone")
        //        .HasColumnName("datahorancertificado");
        //    entity.Property(e => e.Datahoratransportadora)
        //        .HasColumnType("timestamp without time zone")
        //        .HasColumnName("datahoratransportadora");
        //    entity.Property(e => e.Empresa).HasColumnName("empresa");
        //    entity.Property(e => e.Nomecondutor)
        //        .HasMaxLength(255)
        //        .HasColumnName("nomecondutor");
        //    entity.Property(e => e.Numeromanifesto).HasColumnName("numeromanifesto");
        //    entity.Property(e => e.Obsdestfinal)
        //        .HasMaxLength(255)
        //        .HasColumnName("obsdestfinal");
        //    entity.Property(e => e.Obsdestfinal2)
        //        .HasColumnType("character varying")
        //        .HasColumnName("obsdestfinal2");
        //    entity.Property(e => e.Placaveiculo)
        //        .HasMaxLength(255)
        //        .HasColumnName("placaveiculo");
        //    entity.Property(e => e.Quantidade).HasColumnName("quantidade");
        //    entity.Property(e => e.Residuo).HasColumnName("residuo");
        //    entity.Property(e => e.Responsavel)
        //        .HasMaxLength(255)
        //        .HasColumnName("responsavel");
        //    entity.Property(e => e.Revtype).HasColumnName("revtype");
        //    entity.Property(e => e.Situacao).HasColumnName("situacao");
        //    entity.Property(e => e.Transportadora).HasColumnName("transportadora");
        //    entity.Property(e => e.Transportadorasiat).HasColumnName("transportadorasiat");
        //    entity.Property(e => e.Unidade).HasColumnName("unidade");

        //    entity.HasOne(d => d.RevNavigation).WithMany(p => p.ResiduosCtrs)
        //        .HasForeignKey(d => d.Rev)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("fk3d7f4be077f68f91");
        //});

        //modelBuilder.Entity<ResiduosCtrresiduo>(entity =>
        //{
        //    entity.HasKey(e => new { e.Ctrresiduoid, e.Rev }).HasName("residuos_ctrresiduo_pkey");

        //    entity.ToTable("residuos_ctrresiduo", "auditoria");

        //    entity.Property(e => e.Ctrresiduoid).HasColumnName("ctrresiduoid");
        //    entity.Property(e => e.Rev).HasColumnName("rev");
        //    entity.Property(e => e.Codigobaixa)
        //        .HasMaxLength(255)
        //        .HasColumnName("codigobaixa");
        //    entity.Property(e => e.Ctr).HasColumnName("ctr");
        //    entity.Property(e => e.Numeromanifesto)
        //        .HasMaxLength(255)
        //        .HasColumnName("numeromanifesto");
        //    entity.Property(e => e.Qtde).HasColumnName("qtde");
        //    entity.Property(e => e.Qtdetrans).HasColumnName("qtdetrans");
        //    entity.Property(e => e.Residuo).HasColumnName("residuo");
        //    entity.Property(e => e.Revtype).HasColumnName("revtype");
        //    entity.Property(e => e.Unidade).HasColumnName("unidade");
        //    entity.Property(e => e.Unidadetrans).HasColumnName("unidadetrans");

        //    entity.HasOne(d => d.RevNavigation).WithMany(p => p.ResiduosCtrresiduos)
        //        .HasForeignKey(d => d.Rev)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("residuos_rev_fkey");
        //});

        //modelBuilder.Entity<ResiduosEmpresa>(entity =>
        //{
        //    entity.HasKey(e => new { e.Empresaid, e.Rev }).HasName("residuos_empresa_pkey");

        //    entity.ToTable("residuos_empresa", "auditoria");

        //    entity.Property(e => e.Empresaid).HasColumnName("empresaid");
        //    entity.Property(e => e.Rev).HasColumnName("rev");
        //    entity.Property(e => e.Datacadastro)
        //        .HasColumnType("timestamp without time zone")
        //        .HasColumnName("datacadastro");
        //    entity.Property(e => e.Datalicenciamento).HasColumnName("datalicenciamento");
        //    entity.Property(e => e.Datavenclicenciamento).HasColumnName("datavenclicenciamento");
        //    entity.Property(e => e.Email)
        //        .HasColumnType("character varying")
        //        .HasColumnName("email");
        //    entity.Property(e => e.Inscricaoeconomica)
        //        .HasMaxLength(25)
        //        .HasColumnName("inscricaoeconomica");
        //    entity.Property(e => e.Inscricaomunicipal)
        //        .HasColumnType("character varying")
        //        .HasColumnName("inscricaomunicipal");
        //    entity.Property(e => e.Nome)
        //        .HasMaxLength(255)
        //        .HasColumnName("nome");
        //    entity.Property(e => e.Numerolicenciamento).HasColumnName("numerolicenciamento");
        //    entity.Property(e => e.Razaosocial)
        //        .HasColumnType("character varying")
        //        .HasColumnName("razaosocial");
        //    entity.Property(e => e.Revtype).HasColumnName("revtype");
        //    entity.Property(e => e.Senha)
        //        .HasMaxLength(255)
        //        .HasColumnName("senha");
        //    entity.Property(e => e.Usuario).HasColumnName("usuario");

        //    entity.HasOne(d => d.RevNavigation).WithMany(p => p.ResiduosEmpresas)
        //        .HasForeignKey(d => d.Rev)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("fkf12a12c877f68f91");
        //});

        //modelBuilder.Entity<ResiduosEstadofisico>(entity =>
        //{
        //    entity.HasKey(e => new { e.Estadofisicoid, e.Rev }).HasName("residuos_estadofisico_pkey");

        //    entity.ToTable("residuos_estadofisico", "auditoria");

        //    entity.Property(e => e.Estadofisicoid).HasColumnName("estadofisicoid");
        //    entity.Property(e => e.Rev).HasColumnName("rev");
        //    entity.Property(e => e.Nome)
        //        .HasMaxLength(255)
        //        .HasColumnName("nome");
        //    entity.Property(e => e.Revtype).HasColumnName("revtype");

        //    entity.HasOne(d => d.RevNavigation).WithMany(p => p.ResiduosEstadofisicos)
        //        .HasForeignKey(d => d.Rev)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("fk8e9ca28c77f68f91");
        //});

        //modelBuilder.Entity<ResiduosResiduo>(entity =>
        //{
        //    entity.HasKey(e => new { e.Residuoid, e.Rev }).HasName("residuos_residuo_pkey");

        //    entity.ToTable("residuos_residuo", "auditoria");

        //    entity.Property(e => e.Residuoid).HasColumnName("residuoid");
        //    entity.Property(e => e.Rev).HasColumnName("rev");
        //    entity.Property(e => e.Armazenamento).HasColumnName("armazenamento");
        //    entity.Property(e => e.Autotransporte).HasColumnName("autotransporte");
        //    entity.Property(e => e.Caracteristica).HasColumnName("caracteristica");
        //    entity.Property(e => e.Classificacao).HasColumnName("classificacao");
        //    entity.Property(e => e.Codigo)
        //        .HasMaxLength(20)
        //        .HasColumnName("codigo");
        //    entity.Property(e => e.Estadofisico).HasColumnName("estadofisico");
        //    entity.Property(e => e.Nome)
        //        .HasMaxLength(255)
        //        .HasColumnName("nome");
        //    entity.Property(e => e.Numeroonu).HasColumnName("numeroonu");
        //    entity.Property(e => e.Numerorisco).HasColumnName("numerorisco");
        //    entity.Property(e => e.Obs)
        //        .HasMaxLength(255)
        //        .HasColumnName("obs");
        //    entity.Property(e => e.Revtype).HasColumnName("revtype");

        //    entity.HasOne(d => d.RevNavigation).WithMany(p => p.ResiduosResiduos)
        //        .HasForeignKey(d => d.Rev)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("fk935a7bd477f68f91");
        //});

        //modelBuilder.Entity<ResiduosTransportadora>(entity =>
        //{
        //    entity.HasKey(e => new { e.Transportadoraid, e.Rev }).HasName("residuos_transportadora_pkey");

        //    entity.ToTable("residuos_transportadora", "auditoria");

        //    entity.Property(e => e.Transportadoraid).HasColumnName("transportadoraid");
        //    entity.Property(e => e.Rev).HasColumnName("rev");
        //    entity.Property(e => e.Ativo).HasColumnName("ativo");
        //    entity.Property(e => e.Bairro)
        //        .HasMaxLength(255)
        //        .HasColumnName("bairro");
        //    entity.Property(e => e.Cep)
        //        .HasMaxLength(255)
        //        .HasColumnName("cep");
        //    entity.Property(e => e.Cnpj)
        //        .HasMaxLength(255)
        //        .HasColumnName("cnpj");
        //    entity.Property(e => e.Complemento)
        //        .HasMaxLength(255)
        //        .HasColumnName("complemento");
        //    entity.Property(e => e.Datacadastro)
        //        .HasColumnType("timestamp without time zone")
        //        .HasColumnName("datacadastro");
        //    entity.Property(e => e.Email)
        //        .HasColumnType("character varying")
        //        .HasColumnName("email");
        //    entity.Property(e => e.Inscricaomunicipal)
        //        .HasMaxLength(255)
        //        .HasColumnName("inscricaomunicipal");
        //    entity.Property(e => e.Licencaambiental)
        //        .HasMaxLength(20)
        //        .HasColumnName("licencaambiental");
        //    entity.Property(e => e.Nome)
        //        .HasMaxLength(255)
        //        .HasColumnName("nome");
        //    entity.Property(e => e.Numero)
        //        .HasMaxLength(255)
        //        .HasColumnName("numero");
        //    entity.Property(e => e.Responsavel)
        //        .HasMaxLength(255)
        //        .HasColumnName("responsavel");
        //    entity.Property(e => e.Revtype).HasColumnName("revtype");
        //    entity.Property(e => e.Rua)
        //        .HasMaxLength(255)
        //        .HasColumnName("rua");
        //    entity.Property(e => e.Senha)
        //        .HasMaxLength(255)
        //        .HasColumnName("senha");
        //    entity.Property(e => e.Telefone)
        //        .HasMaxLength(255)
        //        .HasColumnName("telefone");
        //    entity.Property(e => e.Usuario).HasColumnName("usuario");
        //    entity.Property(e => e.Validadelicenca).HasColumnName("validadelicenca");

        //    entity.HasOne(d => d.RevNavigation).WithMany(p => p.ResiduosTransportadoras)
        //        .HasForeignKey(d => d.Rev)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("fkdc11f3377f68f91");
        //});

        //modelBuilder.Entity<ResiduosUnidade>(entity =>
        //{
        //    entity.HasKey(e => new { e.Unidadeid, e.Rev }).HasName("residuos_unidade_pkey");

        //    entity.ToTable("residuos_unidade", "auditoria");

        //    entity.Property(e => e.Unidadeid).HasColumnName("unidadeid");
        //    entity.Property(e => e.Rev).HasColumnName("rev");
        //    entity.Property(e => e.Nome)
        //        .HasMaxLength(255)
        //        .HasColumnName("nome");
        //    entity.Property(e => e.Revtype).HasColumnName("revtype");

        //    entity.HasOne(d => d.RevNavigation).WithMany(p => p.ResiduosUnidades)
        //        .HasForeignKey(d => d.Rev)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("fk40d98ced77f68f91");
        //});

        //modelBuilder.Entity<Revinfo>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("revinfo_pkey");

        //    entity.ToTable("revinfo", "auditoria");

        //    entity.Property(e => e.Id)
        //        .ValueGeneratedNever()
        //        .HasColumnName("id");
        //    entity.Property(e => e.Datahoraalteracao)
        //        .HasColumnType("timestamp without time zone")
        //        .HasColumnName("datahoraalteracao");
        //    entity.Property(e => e.Timestamp).HasColumnName("timestamp");
        //    entity.Property(e => e.Usuarioid).HasColumnName("usuarioid");
        //    entity.Property(e => e.Usuarionome)
        //        .HasMaxLength(150)
        //        .HasColumnName("usuarionome");
        //});

        //modelBuilder.Entity<Rua>(entity =>
        //{
        //    entity.HasKey(e => e.Ruaid).HasName("rua_pkey");

        //    entity.ToTable("rua", tb => tb.HasComment("template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs]\r\n\r\n\r\n\r\nformtitle[Cadastro de Rua]\r\n\r\nfiltersgrid[#text_filter,#text_filter]\r\n\r\n\r\n\r\ngridtitle[Lista de Ruas]"));

        //    entity.HasIndex(e => e.Cep, "rua_cep_idx");

        //    entity.HasIndex(e => e.Estado, "rua_estado_idx");

        //    entity.HasIndex(e => e.Nome, "rua_nome_idx");

        //    entity.Property(e => e.Ruaid)
        //        .HasComment("forminputlabel[Código] \r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("ruaid");
        //    entity.Property(e => e.Ativo)
        //        .HasMaxLength(1)
        //        .HasColumnName("ativo");
        //    entity.Property(e => e.Bairrofinal).HasColumnName("bairrofinal");
        //    entity.Property(e => e.Bairroinicial).HasColumnName("bairroinicial");
        //    entity.Property(e => e.Cep)
        //        .HasColumnType("character varying")
        //        .HasColumnName("cep");
        //    entity.Property(e => e.Cidade).HasColumnName("cidade");
        //    entity.Property(e => e.Complemento)
        //        .HasColumnType("character varying")
        //        .HasColumnName("complemento");
        //    entity.Property(e => e.Estado)
        //        .HasMaxLength(2)
        //        .HasColumnName("estado");
        //    entity.Property(e => e.Grupoaud)
        //        .HasDefaultValue(0)
        //        .HasComment("\r\ngeraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Nome)
        //        .HasComment("forminputlabel[Nome]\r\nforminputsize[70]\r\nforminputclass[uppercase]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Nome]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnType("character varying")
        //        .HasColumnName("nome");
        //    entity.Property(e => e.Nomepopular)
        //        .HasColumnType("character varying")
        //        .HasColumnName("nomepopular");
        //    entity.Property(e => e.Tipo)
        //        .HasColumnType("character varying")
        //        .HasColumnName("tipo");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasComment("\r\ngeraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasDefaultValue(0)
        //        .HasComment("\r\ngeraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasComment("\r\ngeraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("version");

        //    entity.HasOne(d => d.BairrofinalNavigation).WithMany(p => p.RuaBairrofinalNavigations)
        //        .HasForeignKey(d => d.Bairrofinal)
        //        .HasConstraintName("rua_fk2");

        //    entity.HasOne(d => d.BairroinicialNavigation).WithMany(p => p.RuaBairroinicialNavigations)
        //        .HasForeignKey(d => d.Bairroinicial)
        //        .HasConstraintName("rua_fk1");
        //});

        //modelBuilder.Entity<Sistema>(entity =>
        //{
        //    entity.HasKey(e => e.Sistemaid).HasName("sistema_pk");

        //    entity.ToTable("sistema", tb => tb.HasComment("template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Sistema]\r\n\r\nfieldsgrid[sistemaid,nome,urlteste,urlproducao,emproducao,manutencao,versao:sistemaid]\r\nfiltersgrid[#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter]\r\n\r\nfieldsform[sistemaid,nome,urlteste,urlproducao,emproducao,manutencao,tema.temaid,tema.nome,urlfooter,urlheader,urllogo,urlmenuprincipal,usuariosonline,versao] \r\n \r\ngridtitle[Lista de Sistemas]"));

        //    entity.Property(e => e.Sistemaid)
        //        .HasComment("forminputlabel[Código] \r\nforminputsize[7]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Código] \r\ncolumngridtype[ro] \r\ncolumngridsize[80] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnName("sistemaid");
        //    entity.Property(e => e.Emproducao)
        //        .HasDefaultValue(0)
        //        .HasComment("forminputlabel[Em produção] \r\nforminputsize[50]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Em produção] \r\ncolumngridtype[ro] \r\ncolumngridsize[*] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnName("emproducao");
        //    entity.Property(e => e.Grupoaud).HasColumnName("grupoaud");
        //    entity.Property(e => e.Manutencao)
        //        .HasDefaultValue(0)
        //        .HasComment("forminputlabel[Em manutenção] \r\nforminputsize[50]")
        //        .HasColumnName("manutencao");
        //    entity.Property(e => e.Nome)
        //        .HasMaxLength(200)
        //        .HasComment("forminputlabel[Nome] \r\nforminputsize[50] \r\n \r\ncolumngridid[] \r\ncolumngridtitle[Nome] \r\ncolumngridtype[ro] \r\ncolumngridsize[*] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnName("nome");
        //    entity.Property(e => e.Restarttime)
        //        .HasColumnType("timestamp(0) without time zone")
        //        .HasColumnName("restarttime");
        //    entity.Property(e => e.Tema)
        //        .HasComment("forminputlabel[Tema]\r\nforminputsize[250]\r\n\r\nsearchmode[combobox]\r\ncomboboxresultfield[nome]\r\n\r\ngeragridmain[false]\r\n\r\ncolumngridid[tema.nome]\r\ncolumngridtitle[Tema]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("tema");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Urlfooter)
        //        .HasComment("forminputlabel[URL footer] \r\nforminputsize[50]\r\n\r\ngeragridmain[false]")
        //        .HasColumnName("urlfooter");
        //    entity.Property(e => e.Urlheader)
        //        .HasMaxLength(500)
        //        .HasComment("forminputlabel[URL header] \r\nforminputsize[50]\r\n\r\ngeragridmain[false]")
        //        .HasColumnName("urlheader");
        //    entity.Property(e => e.Urllogo)
        //        .HasMaxLength(500)
        //        .HasComment("forminputlabel[URL logo] \r\nforminputsize[50]\r\n\r\ngeragridmain[false]")
        //        .HasColumnName("urllogo");
        //    entity.Property(e => e.Urlmenuprincipal)
        //        .HasMaxLength(500)
        //        .HasComment("forminputlabel[URL Menu principal] \r\nforminputsize[50]\r\n\r\ngeragridmain[false]")
        //        .HasColumnName("urlmenuprincipal");
        //    entity.Property(e => e.Urlproducao)
        //        .HasMaxLength(500)
        //        .HasComment("forminputlabel[URL de produção] \r\nforminputsize[50]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[URL de produção] \r\ncolumngridtype[ro] \r\ncolumngridsize[*] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnName("urlproducao");
        //    entity.Property(e => e.Urlteste)
        //        .HasMaxLength(500)
        //        .HasComment("forminputlabel[URL de teste] \r\nforminputsize[50]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[URL de teste] \r\ncolumngridtype[ro] \r\ncolumngridsize[*] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnName("urlteste");
        //    entity.Property(e => e.Usuarioaud).HasColumnName("usuarioaud");
        //    entity.Property(e => e.Usuariosonline)
        //        .HasComment("forminputlabel[Usuários online] \r\nforminputsize[50]\r\n\r\ngeragridmain[false]")
        //        .HasColumnName("usuariosonline");
        //    entity.Property(e => e.Versao)
        //        .HasMaxLength(30)
        //        .HasComment("forminputlabel[Versão] \r\nforminputsize[50] \r\n \r\ncolumngridid[] \r\ncolumngridtitle[Versão] \r\ncolumngridtype[ro] \r\ncolumngridsize[*] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnName("versao");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasColumnName("version");

        //    entity.HasOne(d => d.TemaNavigation).WithMany(p => p.Sistemas)
        //        .HasForeignKey(d => d.Tema)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("tema_sistema_fk");
        //});

        //modelBuilder.Entity<Sistemacontexto>(entity =>
        //{
        //    entity.HasKey(e => e.Sistemacontextoid).HasName("sistemacontexto_pkey");

        //    entity.ToTable("sistemacontexto");

        //    entity.Property(e => e.Sistemacontextoid).HasColumnName("sistemacontextoid");
        //    entity.Property(e => e.Contexto)
        //        .HasColumnType("character varying")
        //        .HasColumnName("contexto");
        //    entity.Property(e => e.Emproducao)
        //        .HasDefaultValue(true)
        //        .HasColumnName("emproducao");
        //    entity.Property(e => e.Grupoaud)
        //        .HasDefaultValue(0)
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Sistema).HasColumnName("sistema");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasDefaultValue(0)
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(1)
        //        .HasColumnName("version");

        //    entity.HasOne(d => d.SistemaNavigation).WithMany(p => p.Sistemacontextos)
        //        .HasForeignKey(d => d.Sistema)
        //        .HasConstraintName("sistemacontexto_fk");
        //});

        //modelBuilder.Entity<Situacao>(entity =>
        //{
        //    entity.HasKey(e => e.Situacaoid).HasName("situacao_pkey");

        //    entity.ToTable("situacao", "agenda", tb => tb.HasComment("template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Situacao]\r\n\r\nfiltersgrid[#text_filter,#text_filter] \r\n\r\n\r\ngridtitle[Lista de Situacao]\r\n"));

        //    entity.Property(e => e.Situacaoid)
        //        .HasDefaultValueSql("nextval(('\"agenda\".\"situacao_situacaoid_seq\"'::text)::regclass)")
        //        .HasComment("forminputlabel[Código] \r\nforminputsize[7]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Código] \r\ncolumngridtype[ro] \r\ncolumngridsize[80] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnName("situacaoid");
        //    entity.Property(e => e.Descricao)
        //        .HasMaxLength(300)
        //        .HasComment("forminputlabel[Descricao] \r\nforminputsize[70]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Descricao] \r\ncolumngridtype[ro] \r\ncolumngridsize[*] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnName("descricao");
        //    entity.Property(e => e.Grupoaud)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("version");
        //});

        //modelBuilder.Entity<Situacao1>(entity =>
        //{
        //    entity.HasKey(e => e.Situacaoid).HasName("situacao_pkey");

        //    entity.ToTable("situacao", "cartografia");

        //    entity.Property(e => e.Situacaoid)
        //        .HasComment("Código da situação")
        //        .HasColumnName("situacaoid");
        //    entity.Property(e => e.Descricao)
        //        .HasMaxLength(50)
        //        .HasComment("Descrição da situação")
        //        .HasColumnName("descricao");
        //});

        //modelBuilder.Entity<Status>(entity =>
        //{
        //    entity.HasKey(e => e.Statusid).HasName("status_pkey");

        //    entity.ToTable("status", "agenda", tb => tb.HasComment("template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Status]\r\nfiltersgrid[#text_filter,#text_filter,#text_filter,#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Status]"));

        //    entity.Property(e => e.Statusid)
        //        .HasComment("forminputlabel[Código]\r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("statusid");
        //    entity.Property(e => e.Descricao)
        //        .HasMaxLength(99)
        //        .HasComment("forminputlabel[Descricao]\r\nforminputsize[15]\r\nforminputclass[required]\r\n\r\n")
        //        .HasColumnName("descricao");
        //    entity.Property(e => e.Grupoaud)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("version");
        //});

        //modelBuilder.Entity<Status1>(entity =>
        //{
        //    entity.HasKey(e => e.Statusid).HasName("status_pkey");

        //    entity.ToTable("status", "cartografia", tb => tb.HasComment("Status do projeto"));

        //    entity.Property(e => e.Statusid)
        //        .HasComment("Código do status")
        //        .HasColumnName("statusid");
        //    entity.Property(e => e.Descricao)
        //        .HasMaxLength(50)
        //        .HasComment("Descrição do status")
        //        .HasColumnName("descricao");
        //});

        //modelBuilder.Entity<Status2>(entity =>
        //{
        //    entity.HasKey(e => e.Statusid).HasName("status_pkey");

        //    entity.ToTable("status", "sisobra", tb => tb.HasComment("template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Status]\r\nfiltersgrid[#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Status]"));

        //    entity.Property(e => e.Statusid)
        //        .HasComment("forminputlabel[Código] \r\nforminputsize[7]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Código] \r\ncolumngridtype[ro] \r\ncolumngridsize[80] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnName("statusid");
        //    entity.Property(e => e.Grupoaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Nome)
        //        .HasComment("forminputlabel[Nome] \r\nforminputsize[70]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Nome] \r\ncolumngridtype[ro] \r\ncolumngridsize[*] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnType("character varying")
        //        .HasColumnName("nome");
        //    entity.Property(e => e.Orderna).HasColumnName("orderna");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("version");
        //});

        //modelBuilder.Entity<Tema>(entity =>
        //{
        //    entity.HasKey(e => e.Temaid).HasName("tema_pk");

        //    entity.ToTable("tema", tb => tb.HasComment("template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]  \r\n\r\nformtitle[Cadastro de Tema]   \r\nfieldsgrid[temaid,nome,url:temaid] \r\nfieldsform[temaid,nome,url] \r\n\r\ngridtitle[Lista de Temas]"));

        //    entity.Property(e => e.Temaid)
        //        .HasComment("forminputlabel[Código] forminputsize[7]  columngridid[] columngridtitle[Código] columngridtype[ro] columngridsize[80] columngridalign[left] columngridcolor[white]")
        //        .HasColumnName("temaid");
        //    entity.Property(e => e.Grupoaud).HasColumnName("grupoaud");
        //    entity.Property(e => e.Nome)
        //        .HasMaxLength(250)
        //        .HasComment("forminputlabel[Nome] forminputsize[50]  columngridid[] columngridtitle[Nome] columngridtype[ro] columngridsize[*] columngridalign[left] columngridcolor[white]")
        //        .HasColumnName("nome");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Url)
        //        .HasMaxLength(500)
        //        .HasComment("forminputlabel[URL] forminputsize[50]  columngridid[] columngridtitle[URL] columngridtype[ro] columngridsize[*] columngridalign[left] columngridcolor[white]")
        //        .HasColumnName("url");
        //    entity.Property(e => e.Usuarioaud).HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version).HasColumnName("version");
        //});

        //modelBuilder.Entity<Teste>(entity =>
        //{
        //    entity.ToTable("Teste");

        //    entity.Property(e => e.Descricao).HasMaxLength(255);
        //});

        //modelBuilder.Entity<Tipoarquivo>(entity =>
        //{
        //    entity.HasKey(e => e.Tipoarquivoid).HasName("tipoarquivo_pkey");

        //    entity.ToTable("tipoarquivo", "cartografia");

        //    entity.Property(e => e.Tipoarquivoid)
        //        .HasComment("Código do tipo de arquivo")
        //        .HasColumnName("tipoarquivoid");
        //    entity.Property(e => e.Descricao)
        //        .HasMaxLength(100)
        //        .HasComment("Descricao do tipo")
        //        .HasColumnName("descricao");
        //    entity.Property(e => e.Extensao)
        //        .HasMaxLength(5)
        //        .HasComment("Extensão do arquivo")
        //        .HasColumnName("extensao");
        //});

        //modelBuilder.Entity<Tipoarquivo1>(entity =>
        //{
        //    entity.HasKey(e => e.Tipoarquivoid).HasName("tipoarquivo_pkey");

        //    entity.ToTable("tipoarquivo", "agenda");

        //    entity.Property(e => e.Tipoarquivoid).HasColumnName("tipoarquivoid");
        //    entity.Property(e => e.Ativo)
        //        .HasDefaultValue(1)
        //        .HasColumnName("ativo");
        //    entity.Property(e => e.Contenttype)
        //        .HasMaxLength(25)
        //        .HasColumnName("contenttype");
        //    entity.Property(e => e.Extension)
        //        .HasMaxLength(5)
        //        .HasColumnName("extension");
        //    entity.Property(e => e.Grupoaud)
        //        .HasDefaultValue(0)
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Nome)
        //        .HasColumnType("character varying")
        //        .HasColumnName("nome");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasDefaultValue(0)
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasColumnName("version");
        //});

        //modelBuilder.Entity<Tipocontrole>(entity =>
        //{
        //    entity.HasKey(e => e.Tipocontroleid).HasName("tipocontrole_pkey");

        //    entity.ToTable("tipocontrole", "sisobra", tb => tb.HasComment("template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Tipo de Controle]\r\nfiltersgrid[#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Tipos de Controle]"));

        //    entity.Property(e => e.Tipocontroleid)
        //        .HasComment("forminputlabel[Código] \r\nforminputsize[7]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Código] \r\ncolumngridtype[ro] \r\ncolumngridsize[80] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnName("tipocontroleid");
        //    entity.Property(e => e.Grupoaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Nome)
        //        .HasComment("forminputlabel[Nome] \r\nforminputsize[70]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Nome] \r\ncolumngridtype[ro] \r\ncolumngridsize[*] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnType("character varying")
        //        .HasColumnName("nome");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("version");
        //});

        //modelBuilder.Entity<Tipologradouro>(entity =>
        //{
        //    entity.HasKey(e => e.Tipologradouroid).HasName("tipologradouro_pkey");

        //    entity.ToTable("tipologradouro");

        //    entity.Property(e => e.Tipologradouroid).HasColumnName("tipologradouroid");
        //    entity.Property(e => e.Nome)
        //        .HasColumnType("character varying")
        //        .HasColumnName("nome");
        //});

        //modelBuilder.Entity<Tipomandato>(entity =>
        //{
        //    entity.HasKey(e => e.Tipomandatoid).HasName("tipomandato_pkey");

        //    entity.ToTable("tipomandato", "sisobra", tb => tb.HasComment("template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Tipo-Mandato]\r\nfiltersgrid[#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Tipos de Mandato]"));

        //    entity.Property(e => e.Tipomandatoid)
        //        .HasComment("forminputlabel[Código] \r\nforminputsize[7]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Código] \r\ncolumngridtype[ro] \r\ncolumngridsize[80] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnName("tipomandatoid");
        //    entity.Property(e => e.Grupoaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Nome)
        //        .HasComment("forminputlabel[Nome] \r\nforminputsize[70]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Nome] \r\ncolumngridtype[ro] \r\ncolumngridsize[*] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnType("character varying")
        //        .HasColumnName("nome");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("version");
        //});

        //modelBuilder.Entity<Tipounidade>(entity =>
        //{
        //    entity.HasKey(e => e.Tipounidadeid).HasName("tipounidade_pkey");

        //    entity.ToTable("tipounidade", tb => tb.HasComment("template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Tipo de Unidade] \r\n\r\nfieldsgrid[tipounidadeid,nome:tipounidadeid]\r\nfiltersgrid[#text_filter,#text_filter] \r\n\r\nfieldsform[tipounidadeid,nome]\r\n\r\ngridtitle[Lista de Tipos de Unidades]"));

        //    entity.Property(e => e.Tipounidadeid)
        //        .HasComment("forminputlabel[Código]\r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("tipounidadeid");
        //    entity.Property(e => e.Grupoaud).HasColumnName("grupoaud");
        //    entity.Property(e => e.Nome)
        //        .HasMaxLength(80)
        //        .HasComment("forminputlabel[Nome]\r\nforminputsize[60]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Nome]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("nome");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud).HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasColumnName("version");
        //});

        //modelBuilder.Entity<Tipoveiculodivulgacao>(entity =>
        //{
        //    entity.HasKey(e => e.Tipoveiculodivulgacaoid).HasName("tipoveiculodivulgacao_pkey");

        //    entity.ToTable("tipoveiculodivulgacao", "divulgacao", tb => tb.HasComment("template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Tipo Veículo de Divulgação]\r\nfiltersgrid[#text_filter,#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Tipos de Veículos de Divulgação]"));

        //    entity.Property(e => e.Tipoveiculodivulgacaoid)
        //        .HasComment("forminputlabel[Código]\r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("tipoveiculodivulgacaoid");
        //    entity.Property(e => e.Grupoaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Lei)
        //        .HasComment("forminputlabel[Lei]\r\nforminputsize[20]\r\nforminputclass[uppercase]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Lei]\r\ncolumngridtype[ro]\r\ncolumngridsize[130]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnType("character varying")
        //        .HasColumnName("lei");
        //    entity.Property(e => e.Nome)
        //        .HasComment("forminputlabel[Nome]\r\nforminputsize[50]\r\nforminputclass[uppercase]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Nome]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnType("character varying")
        //        .HasColumnName("nome");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("version");
        //});

        //modelBuilder.Entity<Tmpbairroregiao>(entity =>
        //{
        //    entity.HasKey(e => e.Tmpbairroregiaoid).HasName("tmpbairroregiao_pkey");

        //    entity.ToTable("tmpbairroregiao");

        //    entity.Property(e => e.Tmpbairroregiaoid)
        //        .ValueGeneratedNever()
        //        .HasColumnName("tmpbairroregiaoid");
        //    entity.Property(e => e.Bairro)
        //        .HasColumnType("character varying")
        //        .HasColumnName("bairro");
        //    entity.Property(e => e.Bairroid).HasColumnName("bairroid");
        //    entity.Property(e => e.Parcelamento)
        //        .HasColumnType("character varying")
        //        .HasColumnName("parcelamento");
        //    entity.Property(e => e.Regiao)
        //        .HasColumnType("character varying")
        //        .HasColumnName("regiao");
        //    entity.Property(e => e.Regiaoid).HasColumnName("regiaoid");
        //});

        //modelBuilder.Entity<Tmpproc>(entity =>
        //{
        //    entity.HasKey(e => e.Tmpprocid).HasName("tmpproc_pkey");

        //    entity.ToTable("tmpproc", "agenda");

        //    entity.Property(e => e.Tmpprocid).HasColumnName("tmpprocid");
        //    entity.Property(e => e.Inscricao)
        //        .HasColumnType("character varying")
        //        .HasColumnName("inscricao");
        //    entity.Property(e => e.Processo)
        //        .HasColumnType("character varying")
        //        .HasColumnName("processo");
        //});

        //modelBuilder.Entity<Transportador>(entity =>
        //{
        //    entity.HasKey(e => e.Transportadorid).HasName("transportador_pkey");

        //    entity.ToTable("transportador", "agenda", tb => tb.HasComment("template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Transportador]\r\nfiltersgrid[#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Transportadores]"));

        //    entity.Property(e => e.Transportadorid)
        //        .HasComment("forminputlabel[Código]\r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("transportadorid");
        //    entity.Property(e => e.Ativo)
        //        .HasDefaultValue(0)
        //        .HasColumnName("ativo");
        //    entity.Property(e => e.Cadmunicipal)
        //        .HasMaxLength(50)
        //        .HasComment("forminputlabel[Cadastro Municipal]\r\nforminputsize[20]\r\nforminputclass[number]\r\n\r\ngeragridmain[false]")
        //        .HasColumnName("cadmunicipal");
        //    entity.Property(e => e.Cep)
        //        .HasColumnType("character varying")
        //        .HasColumnName("cep");
        //    entity.Property(e => e.Datacadastro).HasColumnName("datacadastro");
        //    entity.Property(e => e.Datavalidade).HasColumnName("datavalidade");
        //    entity.Property(e => e.Endereco)
        //        .HasMaxLength(200)
        //        .HasComment("forminputlabel[Endereço]\r\nforminputsize[30]\r\nforminputclass[uppercase]\r\n\r\ngeragridmain[false]")
        //        .HasColumnName("endereco");
        //    entity.Property(e => e.Grupoaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Nome)
        //        .HasMaxLength(200)
        //        .HasComment("forminputlabel[Nome]\r\nforminputsize[50]\r\nforminputclass[uppercase]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Nome]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("nome");
        //    entity.Property(e => e.Rua)
        //        .HasColumnType("character varying")
        //        .HasColumnName("rua");
        //    entity.Property(e => e.Telefone)
        //        .HasMaxLength(50)
        //        .HasComment("forminputlabel[Telefone]\r\nforminputsize[12]\r\nforminputclass[phone]\r\n\r\ngeragridmain[false]")
        //        .HasColumnName("telefone");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("version");
        //});

        //modelBuilder.Entity<Transportadora>(entity =>
        //{
        //    entity.HasKey(e => e.Transportadoraid).HasName("transportadora_pkey");

        //    entity.ToTable("transportadora", "residuos", tb => tb.HasComment("template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs]\r\n\r\nformtitle[Cadastro de Transportadora]\r\nfiltersgrid[#text_filter,#text_filter,#text_filter,#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Transportadoras]"));

        //    entity.HasIndex(e => e.Inscricaomunicipal, "transportadora_idx");

        //    entity.Property(e => e.Transportadoraid)
        //        .HasComment("forminputlabel[Código]\r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("transportadoraid");
        //    entity.Property(e => e.Ativo).HasColumnName("ativo");
        //    entity.Property(e => e.Bairro)
        //        .HasMaxLength(255)
        //        .HasColumnName("bairro");
        //    entity.Property(e => e.Cep)
        //        .HasMaxLength(8)
        //        .HasColumnName("cep");
        //    entity.Property(e => e.Cnpj)
        //        .HasComment("forminputlabel[CNPJ]\r\nforminputsize[10]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[CNPJ]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnType("character varying")
        //        .HasColumnName("cnpj");
        //    entity.Property(e => e.Complemento)
        //        .HasMaxLength(200)
        //        .HasColumnName("complemento");
        //    entity.Property(e => e.Datacadastro)
        //        .HasColumnType("timestamp without time zone")
        //        .HasColumnName("datacadastro");
        //    entity.Property(e => e.Email)
        //        .HasColumnType("character varying")
        //        .HasColumnName("email");
        //    entity.Property(e => e.Grupoaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]")
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Inscricaomunicipal)
        //        .HasColumnType("character varying")
        //        .HasColumnName("inscricaomunicipal");
        //    entity.Property(e => e.Licencaambiental)
        //        .HasMaxLength(20)
        //        .HasColumnName("licencaambiental");
        //    entity.Property(e => e.Nome)
        //        .HasComment("forminputlabel[Nome]\r\nforminputsize[50]\r\nforminputclass[uppercase]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Nome]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnType("character varying")
        //        .HasColumnName("nome");
        //    entity.Property(e => e.Numero)
        //        .HasMaxLength(10)
        //        .HasColumnName("numero");
        //    entity.Property(e => e.Responsavel)
        //        .HasComment("forminputlabel[Responsável]\r\nforminputsize[20]\r\nforminputclass[uppercase]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Responsável]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnType("character varying")
        //        .HasColumnName("responsavel");
        //    entity.Property(e => e.Rua)
        //        .HasColumnType("character varying")
        //        .HasColumnName("rua");
        //    entity.Property(e => e.Senha)
        //        .HasMaxLength(255)
        //        .HasColumnName("senha");
        //    entity.Property(e => e.Telefone)
        //        .HasComment("forminputlabel[Telefone]\r\nforminputsize[12]\r\nforminputclass[phone]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Telefone]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnType("character varying")
        //        .HasColumnName("telefone");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]")
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuario).HasColumnName("usuario");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]")
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Validadelicenca).HasColumnName("validadelicenca");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]")
        //        .HasColumnName("version");
        //});

        //modelBuilder.Entity<Transportadoraresiduo>(entity =>
        //{
        //    entity.HasKey(e => e.Transportadoraresiduoid).HasName("transportadoraresiduo_pkey");

        //    entity.ToTable("transportadoraresiduo", "residuos");

        //    entity.Property(e => e.Transportadoraresiduoid)
        //        .HasDefaultValueSql("nextval('residuos.transportadoraresiduo_transportadoraresiduoid_seq1'::regclass)")
        //        .HasColumnName("transportadoraresiduoid");
        //    entity.Property(e => e.Grupoaud).HasColumnName("grupoaud");
        //    entity.Property(e => e.Licencaambiental)
        //        .HasMaxLength(20)
        //        .HasColumnName("licencaambiental");
        //    entity.Property(e => e.Residuo).HasColumnName("residuo");
        //    entity.Property(e => e.Transportadora).HasColumnName("transportadora");
        //    entity.Property(e => e.Unidadeaud).HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud).HasColumnName("usuarioaud");
        //    entity.Property(e => e.Validadelicenca).HasColumnName("validadelicenca");
        //    entity.Property(e => e.Version).HasColumnName("version");

        //    entity.HasOne(d => d.ResiduoNavigation).WithMany(p => p.Transportadoraresiduos)
        //        .HasForeignKey(d => d.Residuo)
        //        .HasConstraintName("fkda9472e3e4fc0580");

        //    entity.HasOne(d => d.TransportadoraNavigation).WithMany(p => p.Transportadoraresiduos)
        //        .HasForeignKey(d => d.Transportadora)
        //        .HasConstraintName("fkda9472e324a06d8e");
        //});

        //modelBuilder.Entity<Unidade>(entity =>
        //{
        //    entity.HasKey(e => e.Unidadeid).HasName("unidade_pkey");

        //    entity.ToTable("unidade", tb => tb.HasComment("template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Unidade] \r\n\r\nfieldsgrid[unidadeid,nome:unidadeid]\r\nfiltersgrid[#text_filter,#text_filter] \r\n\r\nfieldsform[unidadeid,nome]\r\n\r\ngridtitle[Lista de Unidades]"));

        //    entity.Property(e => e.Unidadeid)
        //        .HasComment("forminputlabel[Código]\r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("unidadeid");
        //    entity.Property(e => e.Grupoaud).HasColumnName("grupoaud");
        //    entity.Property(e => e.Nome)
        //        .HasComment("forminputlabel[Nome]\r\nforminputsize[60]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Nome]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnType("character varying")
        //        .HasColumnName("nome");
        //    entity.Property(e => e.Tipounidade)
        //        .HasComment("forminputlabel[Tipo Unidade]\r\nforminputsize[250]\r\n\r\nsearchmode[combobox]\r\ncomboboxresultfield[nome]\r\n\r\ngeragridmain[false]\r\n")
        //        .HasColumnName("tipounidade");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud).HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasColumnName("version");

        //    entity.HasOne(d => d.TipounidadeNavigation).WithMany(p => p.Unidades)
        //        .HasForeignKey(d => d.Tipounidade)
        //        .HasConstraintName("unidade_fk");
        //});

        //modelBuilder.Entity<Unidade1>(entity =>
        //{
        //    entity.HasKey(e => e.Unidadeid).HasName("unidade_pkey");

        //    entity.ToTable("unidade", "residuos", tb => tb.HasComment("template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs]\r\n\r\nformtitle[Cadastro de Unidade]\r\nfiltersgrid[#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Unidades]"));

        //    entity.Property(e => e.Unidadeid)
        //        .HasComment("forminputlabel[Código]\r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("unidadeid");
        //    entity.Property(e => e.Grupoaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]")
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Nome)
        //        .HasComment("forminputlabel[Nome]\r\nforminputsize[50]\r\nforminputclass[uppercase]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Nome]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnType("character varying")
        //        .HasColumnName("nome");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]")
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]")
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]")
        //        .HasColumnName("version");
        //});

        //modelBuilder.Entity<Unidadeusuario>(entity =>
        //{
        //    entity.HasKey(e => e.Unidadeusuarioid).HasName("unidadeusuario_pkey");

        //    entity.ToTable("unidadeusuario", tb => tb.HasComment("template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Usuario x Unidade] \r\n\r\nfieldsgrid[usuariounidadeid,unidade.nome,usuario.nome:usuariounidadeid]\r\nfiltersgrid[#text_filter,#text_filter] \r\n\r\nfieldsform[usuariounidadeid,unidade.nome,usuario.nome]\r\n\r\ngridtitle[Lista de Usuario x Unidade]"));

        //    entity.Property(e => e.Unidadeusuarioid)
        //        .HasComment("forminputlabel[Código]\r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("unidadeusuarioid");
        //    entity.Property(e => e.Grupoaud).HasColumnName("grupoaud");
        //    entity.Property(e => e.Grupousuario)
        //        .HasComment("forminputlabel[Grupo Usuario]\r\nforminputsize[250]\r\n\r\nsearchmode[combobox]\r\ncomboboxresultfield[nome]\r\n\r\ngeragridmain[false]\r\n")
        //        .HasColumnName("grupousuario");
        //    entity.Property(e => e.Unidade)
        //        .HasComment("forminputlabel[Unidade]\r\nforminputsize[250]\r\n\r\nsearchmode[combobox]\r\ncomboboxresultfield[nome]\r\n\r\ngeragridmain[false]\r\n")
        //        .HasColumnName("unidade");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuario)
        //        .HasComment("forminputlabel[Usuario]\r\nforminputsize[250]\r\n\r\nsearchmode[combobox]\r\ncomboboxresultfield[nome]\r\n\r\ngeragridmain[false]\r\n")
        //        .HasColumnName("usuario");
        //    entity.Property(e => e.Usuarioaud).HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasColumnName("version");

        //    entity.HasOne(d => d.GrupousuarioNavigation).WithMany(p => p.Unidadeusuarios)
        //        .HasForeignKey(d => d.Grupousuario)
        //        .HasConstraintName("unidadeusuario_fk2");

        //    entity.HasOne(d => d.UnidadeNavigation).WithMany(p => p.Unidadeusuarios)
        //        .HasForeignKey(d => d.Unidade)
        //        .HasConstraintName("unidadeusuario_fk");

        //    entity.HasOne(d => d.UsuarioNavigation).WithMany(p => p.Unidadeusuarios)
        //        .HasForeignKey(d => d.Usuario)
        //        .HasConstraintName("unidadeusuario_fk1");
        //});

        //modelBuilder.Entity<Usuario>(entity =>
        //{
        //    entity.HasKey(e => e.Usuarioid).HasName("usuario_pk");

        //    entity.ToTable("usuario", tb => tb.HasComment("template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]  \r\n\r\nformtitle[Cadastro de Usuários]   \r\nfieldsgrid[usuarioid,nome,login,senha:usuarioid] \r\nfieldsform[usuarioid,nome,login,senha] \r\n\r\ngridtitle[Lista de Usuários]"));

        //    entity.Property(e => e.Usuarioid)
        //        .HasComment("forminputlabel[Código] \r\nforminputsize[7]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Código] \r\ncolumngridtype[ro] \r\ncolumngridsize[80] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnName("usuarioid");
        //    entity.Property(e => e.Email)
        //        .HasColumnType("character varying")
        //        .HasColumnName("email");
        //    entity.Property(e => e.Grupoaud).HasColumnName("grupoaud");
        //    entity.Property(e => e.Login)
        //        .HasMaxLength(50)
        //        .HasComment("forminputlabel[Login]\r\nforminputsize[20]")
        //        .HasColumnName("login");
        //    entity.Property(e => e.Nome)
        //        .HasMaxLength(250)
        //        .HasComment("forminputlabel[Nome] \r\nforminputsize[50]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Nome] \r\ncolumngridtype[ro] \r\ncolumngridsize[*] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
        //        .HasColumnName("nome");
        //    entity.Property(e => e.Senha)
        //        .HasMaxLength(50)
        //        .HasComment("forminputlabel[Senha]\r\nforminputsize[20]")
        //        .HasColumnName("senha");
        //    entity.Property(e => e.Tipocredid).HasColumnName("tipocredid");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud).HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasColumnName("version");
        //});

        //modelBuilder.Entity<Usuariocargo>(entity =>
        //{
        //    entity.HasKey(e => e.Usuariocargoid).HasName("usuariocargo_pkey");

        //    entity.ToTable("usuariocargo", "divulgacao");

        //    entity.Property(e => e.Usuariocargoid).HasColumnName("usuariocargoid");
        //    entity.Property(e => e.Cargo)
        //        .HasColumnType("character varying")
        //        .HasColumnName("cargo");
        //    entity.Property(e => e.Grupoaud)
        //        .HasDefaultValue(0)
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuario).HasColumnName("usuario");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasDefaultValue(0)
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasColumnName("version");

        //    entity.HasOne(d => d.UsuarioNavigation).WithMany(p => p.Usuariocargos)
        //        .HasForeignKey(d => d.Usuario)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("usuariocargo_fk");
        //});

        //modelBuilder.Entity<UsuariosAdmin>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToView("usuarios_admin");

        //    entity.Property(e => e.IdGrupo).HasColumnName("(# ID) Grupo");
        //    entity.Property(e => e.IdNome).HasColumnName("(# ID) Nome");
        //    entity.Property(e => e.Login).HasMaxLength(50);
        //    entity.Property(e => e.NomeDoGrupo)
        //        .HasMaxLength(200)
        //        .HasColumnName("Nome do Grupo");
        //    entity.Property(e => e.NomeDoUsuário)
        //        .HasMaxLength(250)
        //        .HasColumnName("Nome do Usuário");
        //});

        //modelBuilder.Entity<Usuariosistema>(entity =>
        //{
        //    entity.HasKey(e => e.Usuariosistemaid).HasName("usuariosistema_pk");

        //    entity.ToTable("usuariosistema", tb => tb.HasComment("template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]  \r\n\r\nformtitle[Cadastro de Usuários / Sistema]   \r\n\r\nfieldsgrid[usuariosistemaid,sistema.nome,usuario.nome,tema.nome,qtdeacessos:usuariosistemaid] \r\nfieldsform[usuariosistemaid,sistema.sistemaid,sistema.nome,usuario.usuarioid,usuario.nome,tema.temaid,tema.nome,qtdeacessos,ultimoacesso,dataexpiracao]\r\n\r\ngridtitle[Lista de Usuários / Sistema]"));

        //    entity.Property(e => e.Usuariosistemaid).HasColumnName("usuariosistemaid");
        //    entity.Property(e => e.Dataexpiracao)
        //        .HasComment("forminputlabel[Expiração de acesso] \r\nforminputsize[50]\r\n\r\ngeragridmain[false]")
        //        .HasColumnType("timestamp without time zone")
        //        .HasColumnName("dataexpiracao");
        //    entity.Property(e => e.Grupoaud).HasColumnName("grupoaud");
        //    entity.Property(e => e.Sistema)
        //        .HasComment("forminputlabel[Sistema]\r\nforminputsize[250]\r\n\r\nsearchmode[combobox]\r\ncomboboxresultfield[nome]\r\n\r\ngeragridmain[true]\r\n\r\ncolumngridid[sistema.nome]\r\ncolumngridtitle[Sistema]\r\ncolumngridtype[ro]\r\ncolumngridsize[180]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("sistema");
        //    entity.Property(e => e.Tema)
        //        .HasComment("forminputlabel[Tema]\r\nforminputsize[250]\r\n\r\nsearchmode[combobox]\r\ncomboboxresultfield[nome]\r\n\r\ngeragridmain[true]\r\n\r\ncolumngridid[tema.nome]\r\ncolumngridtitle[Tema]\r\ncolumngridtype[ro]\r\ncolumngridsize[180]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("tema");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuario)
        //        .HasComment("forminputlabel[Usuário]\r\nforminputsize[50]\r\n\r\nsearchmode[popup]\r\npopupresultfield[nome]\r\npopupfieldsgrid[usuarioid,nome,login,senha:usuarioid]\r\n\r\ngeragridmain[true]\r\n\r\ncolumngridid[usuario.nome]\r\ncolumngridtitle[Usuário]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("usuario");
        //    entity.Property(e => e.Usuarioaud).HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasColumnName("version");

        //    entity.HasOne(d => d.SistemaNavigation).WithMany(p => p.Usuariosistemas)
        //        .HasForeignKey(d => d.Sistema)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("sistema_usuariosistema_fk");

        //    entity.HasOne(d => d.TemaNavigation).WithMany(p => p.Usuariosistemas)
        //        .HasForeignKey(d => d.Tema)
        //        .HasConstraintName("tema_usuariosistema_fk");

        //    entity.HasOne(d => d.UsuarioNavigation).WithMany(p => p.Usuariosistemas)
        //        .HasForeignKey(d => d.Usuario)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("usuario_usuariosistema_fk");
        //});

        //modelBuilder.Entity<Valorcoluna>(entity =>
        //{
        //    entity.HasKey(e => e.Valorcolunaid).HasName("valorcoluna_pkey");

        //    entity.ToTable("valorcoluna", "agenda", tb => tb.HasComment("template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Valor de Coluna]\r\nfiltersgrid[#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Valores de Coluna]"));

        //    entity.Property(e => e.Valorcolunaid)
        //        .HasComment("forminputlabel[Código]\r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("valorcolunaid");
        //    entity.Property(e => e.Aplicacao)
        //        .HasMaxLength(200)
        //        .HasColumnName("aplicacao");
        //    entity.Property(e => e.Construcao).HasColumnName("construcao");
        //    entity.Property(e => e.Controleresiduo)
        //        .HasComment("forminputlabel[Controle-Resíduo]\r\nforminputsize[12]\r\nforminputclass[ro]\r\n\r\ngeragridmain[false]")
        //        .HasColumnName("controleresiduo");
        //    entity.Property(e => e.Demolicao).HasColumnName("demolicao");
        //    entity.Property(e => e.Destinofinal).HasColumnName("destinofinal");
        //    entity.Property(e => e.Grupoaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Processo)
        //        .HasMaxLength(200)
        //        .HasColumnName("processo");
        //    entity.Property(e => e.Quantidade).HasColumnName("quantidade");
        //    entity.Property(e => e.Residuo)
        //        .HasComment("forminputlabel[Coluna]\r\nforminputsize[180]\r\n\r\nsearchmode[combobox]\r\ncomboboxresultfield[nomecoluna.nome]\r\n\r\ncolumngridid[nomecoluna.nome]\r\ncolumngridtitle[Coluna]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("residuo");
        //    entity.Property(e => e.Reutilizacao)
        //        .HasMaxLength(200)
        //        .HasColumnName("reutilizacao");
        //    entity.Property(e => e.Total).HasColumnName("total");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("version");

        //    entity.HasOne(d => d.ControleresiduoNavigation).WithMany(p => p.Valorcolunas)
        //        .HasForeignKey(d => d.Controleresiduo)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("valorcoluna_fk1");

        //    entity.HasOne(d => d.DestinofinalNavigation).WithMany(p => p.Valorcolunas)
        //        .HasForeignKey(d => d.Destinofinal)
        //        .HasConstraintName("valorcoluna_fk2");

        //    entity.HasOne(d => d.ResiduoNavigation).WithMany(p => p.Valorcolunas)
        //        .HasForeignKey(d => d.Residuo)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("valorcoluna_fk");
        //});

        //modelBuilder.Entity<Veiculodivulgacao>(entity =>
        //{
        //    entity.HasKey(e => e.Veiculodivulgacaoid).HasName("veiculodivulgacao_pkey");

        //    entity.ToTable("veiculodivulgacao", "divulgacao", tb => tb.HasComment("template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Veículo de Divulgação]\r\nfiltersgrid[#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Veículos de Divulgação]"));

        //    entity.Property(e => e.Veiculodivulgacaoid)
        //        .HasComment("forminputlabel[Código]\r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("veiculodivulgacaoid");
        //    entity.Property(e => e.Cep)
        //        .HasComment("forminputlabel[CEP]\r\nforminputsize[10]\r\nforminputclass[number]\r\n\r\ngeragridmain[false]")
        //        .HasColumnName("cep");
        //    entity.Property(e => e.Condesp)
        //        .HasMaxLength(100)
        //        .HasColumnName("condesp");
        //    entity.Property(e => e.Datacadastro)
        //        .HasComment("forminputlabel[Data-Cadastro]\r\nforminputsize[12]\r\nforminputclass[data]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Data-Cadastro]\r\ncolumngridtype[ro]\r\ncolumngridsize[110]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("datacadastro");
        //    entity.Property(e => e.Dataprazo)
        //        .HasComment("forminputlabel[Data-Prazo]\r\nforminputsize[12]\r\nforminputclass[data]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Data-Prazo]\r\ncolumngridtype[ro]\r\ncolumngridsize[110]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("dataprazo");
        //    entity.Property(e => e.Datpro)
        //        .HasComment("Data de abertura do processo no protocolo")
        //        .HasColumnName("datpro");
        //    entity.Property(e => e.Dimensaox)
        //        .HasPrecision(6, 2)
        //        .HasColumnName("dimensaox");
        //    entity.Property(e => e.Dimensaoy)
        //        .HasPrecision(6, 2)
        //        .HasColumnName("dimensaoy");
        //    entity.Property(e => e.Grupoaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Idarquivodivulgacao)
        //        .HasComment("ID do arquivo localizado no banco 10.0.0.148 - SADWEB.arqanx")
        //        .HasColumnName("idarquivodivulgacao");
        //    entity.Property(e => e.Inscricaoeconomica)
        //        .HasComment("forminputlabel[Insc. Econômica]\r\nforminputsize[15]\r\nforminputclass[required]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Insc. Econômica]\r\ncolumngridtype[ro]\r\ncolumngridsize[120]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnType("character varying")
        //        .HasColumnName("inscricaoeconomica");
        //    entity.Property(e => e.Inscricaoimobiliaria)
        //        .HasComment("forminputlabel[Insc. Imobiliária]\r\nforminputsize[15]\r\nforminputclass[required]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Insc. Imobiliária]\r\ncolumngridtype[ro]\r\ncolumngridsize[120]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnType("character varying")
        //        .HasColumnName("inscricaoimobiliaria");
        //    entity.Property(e => e.Latitude)
        //        .HasComment("forminputlabel[Latitude]\r\nforminputsize[12]\r\nforminputclass[ro]\r\n\r\ngeragridmain[false]")
        //        .HasColumnType("character varying")
        //        .HasColumnName("latitude");
        //    entity.Property(e => e.Longitude)
        //        .HasComment("forminputlabel[Longitude]\r\nforminputsize[12]\r\nforminputclass[ro]\r\n\r\ngeragridmain[false]")
        //        .HasColumnType("character varying")
        //        .HasColumnName("longitude");
        //    entity.Property(e => e.Nronai)
        //        .HasComment("Numero da NAIN")
        //        .HasColumnName("nronai");
        //    entity.Property(e => e.Numeroautorizacao)
        //        .HasComment("forminputlabel[N&ordm; Autorização]\r\nforminputsize[15]\r\nforminputclass[required]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[N&ordm; Autorização]\r\ncolumngridtype[ro]\r\ncolumngridsize[120]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnType("character varying")
        //        .HasColumnName("numeroautorizacao");
        //    entity.Property(e => e.Numeroprocesso)
        //        .HasComment("forminputlabel[N&ordm; Processo]\r\nforminputsize[15]\r\nforminputclass[required]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[N&ordm; Processo]\r\ncolumngridtype[ro]\r\ncolumngridsize[120]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnType("character varying")
        //        .HasColumnName("numeroprocesso");
        //    entity.Property(e => e.Obsdiv)
        //        .HasComment("Observação")
        //        .HasColumnName("obsdiv");
        //    entity.Property(e => e.Ocorrencia).HasColumnName("ocorrencia");
        //    entity.Property(e => e.Regular)
        //        .HasComment("1 - SIM\n2 - NÃO")
        //        .HasColumnName("regular");
        //    entity.Property(e => e.Tipoveiculodivulgacao)
        //        .HasComment("forminputlabel[Tipo Veículo Divulgação]\r\nforminputsize[250]\r\n\r\nsearchmode[combobox]\r\ncomboboxresultfield[tipoveiculodivulgacao.nome]\r\n\r\ncolumngridid[tipoveiculodivulgacao.nome]\r\ncolumngridtitle[Tipo Veículo Divulgação]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
        //        .HasColumnName("tipoveiculodivulgacao");
        //    entity.Property(e => e.Tippro)
        //        .HasMaxLength(1)
        //        .HasComment("Tipo de Processo")
        //        .HasColumnName("tippro");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasComment("geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
        //        .HasColumnName("version");

        //    entity.HasOne(d => d.OcorrenciaNavigation).WithMany(p => p.Veiculodivulgacaos)
        //        .HasForeignKey(d => d.Ocorrencia)
        //        .HasConstraintName("veiculodivulgacao_fk1");

        //    entity.HasOne(d => d.TipoveiculodivulgacaoNavigation).WithMany(p => p.Veiculodivulgacaos)
        //        .HasForeignKey(d => d.Tipoveiculodivulgacao)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("veiculodivulgacao_fk");
        //});

        //modelBuilder.Entity<Zoneamento>(entity =>
        //{
        //    entity.HasKey(e => e.Zoneamentoid).HasName("zoneamento_pkey");

        //    entity.ToTable("zoneamento", "agenda");

        //    entity.Property(e => e.Zoneamentoid).HasColumnName("zoneamentoid");
        //    entity.Property(e => e.Grupoaud)
        //        .HasDefaultValue(0)
        //        .HasColumnName("grupoaud");
        //    entity.Property(e => e.Nome)
        //        .HasColumnType("character varying")
        //        .HasColumnName("nome");
        //    entity.Property(e => e.Taxa)
        //        .HasPrecision(10, 2)
        //        .HasDefaultValueSql("0")
        //        .HasColumnName("taxa");
        //    entity.Property(e => e.Unidadeaud)
        //        .HasDefaultValue(0)
        //        .HasColumnName("unidadeaud");
        //    entity.Property(e => e.Usuarioaud)
        //        .HasDefaultValue(0)
        //        .HasColumnName("usuarioaud");
        //    entity.Property(e => e.Version)
        //        .HasDefaultValue(0)
        //        .HasColumnName("version");
        //});
        //modelBuilder.HasSequence("advogado_advogadoid_seq");
        //modelBuilder.HasSequence("agenda_agendaid_seq", "agenda");
        //modelBuilder.HasSequence("analista_analistaid_seq", "agenda");
        //modelBuilder.HasSequence("arquivo_arquivoid_seq", "agenda");
        //modelBuilder.HasSequence("arquivo_arquivoid_seq");
        //modelBuilder.HasSequence("arquivousuario_arquivousuarioid_seq");
        //modelBuilder.HasSequence("aviso_avisoid_seq").HasMax(2147483647L);
        //modelBuilder.HasSequence("documento_documentoid_seq", "agenda");
        //modelBuilder.HasSequence("entidade_entidadeid_seq");
        //modelBuilder.HasSequence("grupo_grupoid_seq");
        //modelBuilder.HasSequence("grupousuario_grupousuarioid_seq");
        //modelBuilder.HasSequence("hibernate_sequence", "auditoria");
        //modelBuilder.HasSequence("local_localid_seq").HasMax(2147483647L);
        //modelBuilder.HasSequence("logacesso_logacessoid_seq");
        //modelBuilder.HasSequence("logsistema_logsistemaid_seq");
        //modelBuilder.HasSequence("modulo_moduloid_seq");
        //modelBuilder.HasSequence("modulogrupo_modulogrupoid_seq");
        //modelBuilder.HasSequence("modulosistema_modulosistemaid_seq");
        //modelBuilder.HasSequence("modulosistemausuario_modulosistemausuarioid_seq");
        //modelBuilder.HasSequence("permissaoentidade_permissaoentidadeid_seq");
        //modelBuilder.HasSequence("prfage_codprf_seq", "agenda").HasMax(2147483647L);
        //modelBuilder.HasSequence("processo_processoid_seq");
        //modelBuilder.HasSequence("processo_sequencia_seq");
        //modelBuilder.HasSequence("projeto_projetoid_seq", "agenda");
        //modelBuilder.HasSequence("relatorioid_seq", "divulgacao").HasMax(99999999999999L);
        //modelBuilder.HasSequence("remessa_remessaid_seq", "agenda");
        //modelBuilder.HasSequence("sistema_sistemaid_seq");
        //modelBuilder.HasSequence("situacao_situacaoid_seq", "agenda").HasMax(2147483647L);
        //modelBuilder.HasSequence("situacao_situacaoid_seq").HasMax(2147483647L);
        //modelBuilder.HasSequence("tema_temaid_seq");
        //modelBuilder.HasSequence("tipoarquivo_tipoarquivoid_seq", "agenda");
        //modelBuilder.HasSequence("tipoprocesso_tipoprocessoid_seq").HasMax(2147483647L);
        //modelBuilder.HasSequence("tipounidade_tipounidadeid_seq");
        //modelBuilder.HasSequence("tramiteinterno_tramiteinternoid_seq");
        //modelBuilder.HasSequence("transportadoraresiduo_transportadoraresiduoid_seq", "residuos");
        //modelBuilder.HasSequence("unidade_unidadeid_seq");
        //modelBuilder.HasSequence("unidadeusuario_unidadeusuarioid_seq");
        //modelBuilder.HasSequence("usuario_usuarioid_seq");
        //modelBuilder.HasSequence("usuariosistema_usuariosistemaid_seq");

        //#endregion
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

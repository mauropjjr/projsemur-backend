using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace AprovacaoDigital.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "agenda");

            migrationBuilder.EnsureSchema(
                name: "cartografia");

            migrationBuilder.EnsureSchema(
                name: "residuos");

            migrationBuilder.EnsureSchema(
                name: "sisobra");

            migrationBuilder.EnsureSchema(
                name: "divulgacao");

            migrationBuilder.EnsureSchema(
                name: "vistoria");

            migrationBuilder.EnsureSchema(
                name: "planurb");

            migrationBuilder.EnsureSchema(
                name: "auditoria");

            migrationBuilder.CreateSequence(
                name: "advogado_advogadoid_seq");

            migrationBuilder.CreateSequence(
                name: "agenda_agendaid_seq",
                schema: "agenda");

            migrationBuilder.CreateSequence(
                name: "analista_analistaid_seq",
                schema: "agenda");

            migrationBuilder.CreateSequence(
                name: "arquivo_arquivoid_seq");

            migrationBuilder.CreateSequence(
                name: "arquivo_arquivoid_seq",
                schema: "agenda");

            migrationBuilder.CreateSequence(
                name: "arquivousuario_arquivousuarioid_seq");

            migrationBuilder.CreateSequence(
                name: "aviso_avisoid_seq",
                maxValue: 2147483647L);

            migrationBuilder.CreateSequence(
                name: "documento_documentoid_seq",
                schema: "agenda");

            migrationBuilder.CreateSequence(
                name: "entidade_entidadeid_seq");

            migrationBuilder.CreateSequence(
                name: "grupo_grupoid_seq");

            migrationBuilder.CreateSequence(
                name: "grupousuario_grupousuarioid_seq");

            migrationBuilder.CreateSequence(
                name: "hibernate_sequence",
                schema: "auditoria");

            migrationBuilder.CreateSequence(
                name: "local_localid_seq",
                maxValue: 2147483647L);

            migrationBuilder.CreateSequence(
                name: "logacesso_logacessoid_seq");

            migrationBuilder.CreateSequence(
                name: "logsistema_logsistemaid_seq");

            migrationBuilder.CreateSequence(
                name: "modulo_moduloid_seq");

            migrationBuilder.CreateSequence(
                name: "modulogrupo_modulogrupoid_seq");

            migrationBuilder.CreateSequence(
                name: "modulosistema_modulosistemaid_seq");

            migrationBuilder.CreateSequence(
                name: "modulosistemausuario_modulosistemausuarioid_seq");

            migrationBuilder.CreateSequence(
                name: "permissaoentidade_permissaoentidadeid_seq");

            migrationBuilder.CreateSequence(
                name: "prfage_codprf_seq",
                schema: "agenda",
                maxValue: 2147483647L);

            migrationBuilder.CreateSequence(
                name: "processo_processoid_seq");

            migrationBuilder.CreateSequence(
                name: "processo_sequencia_seq");

            migrationBuilder.CreateSequence(
                name: "projeto_projetoid_seq",
                schema: "agenda");

            migrationBuilder.CreateSequence(
                name: "relatorioid_seq",
                schema: "divulgacao",
                maxValue: 99999999999999L);

            migrationBuilder.CreateSequence(
                name: "remessa_remessaid_seq",
                schema: "agenda");

            migrationBuilder.CreateSequence(
                name: "sistema_sistemaid_seq");

            migrationBuilder.CreateSequence(
                name: "situacao_situacaoid_seq",
                maxValue: 2147483647L);

            migrationBuilder.CreateSequence(
                name: "situacao_situacaoid_seq",
                schema: "agenda",
                maxValue: 2147483647L);

            migrationBuilder.CreateSequence(
                name: "tema_temaid_seq");

            migrationBuilder.CreateSequence(
                name: "tipoarquivo_tipoarquivoid_seq",
                schema: "agenda");

            migrationBuilder.CreateSequence(
                name: "tipoprocesso_tipoprocessoid_seq",
                maxValue: 2147483647L);

            migrationBuilder.CreateSequence(
                name: "tipounidade_tipounidadeid_seq");

            migrationBuilder.CreateSequence(
                name: "tramiteinterno_tramiteinternoid_seq");

            migrationBuilder.CreateSequence(
                name: "transportadoraresiduo_transportadoraresiduoid_seq",
                schema: "residuos");

            migrationBuilder.CreateSequence(
                name: "unidade_unidadeid_seq");

            migrationBuilder.CreateSequence(
                name: "unidadeusuario_unidadeusuarioid_seq");

            migrationBuilder.CreateSequence(
                name: "usuario_usuarioid_seq");

            migrationBuilder.CreateSequence(
                name: "usuariosistema_usuariosistemaid_seq");

            migrationBuilder.CreateTable(
                name: "analista",
                schema: "agenda",
                columns: table => new
                {
                    analistaid = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: true),
                    legenda = table.Column<string>(type: "character varying", nullable: true),
                    codigomainframe = table.Column<int>(type: "integer", nullable: true),
                    grupo = table.Column<int>(type: "integer", nullable: true),
                    atividade = table.Column<int>(type: "integer", nullable: true),
                    dataexclusao = table.Column<int>(type: "integer", nullable: true),
                    grupoaud = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    usuarioaud = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    unidadeaud = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    version = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    usuario = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    flagativo = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("analista_pkey", x => x.analistaid);
                });

            migrationBuilder.CreateTable(
                name: "analista",
                schema: "cartografia",
                columns: table => new
                {
                    analistaid = table.Column<int>(type: "integer", nullable: false, comment: "Código do analista")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false, comment: "Nome do analista"),
                    codmain = table.Column<int>(type: "integer", nullable: false, comment: "Código do analista no cadastro do mainframe, tem que estar correto para EXPORTAÇÃO DOS PROJ para o MAINFRAME")
                },
                constraints: table =>
                {
                    table.PrimaryKey("analista_pkey", x => x.analistaid);
                });

            migrationBuilder.CreateTable(
                name: "areareceptora",
                schema: "agenda",
                columns: table => new
                {
                    areareceptoraid = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Código]\r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    tipo = table.Column<int>(type: "integer", nullable: false, comment: "0-Ecoponto / 1-Ponto-Apoio\r\n\r\nforminputlabel[Tipo]\r\nforminputsize[30]\r\nforminputclass[required]\r\n\r\ngeragridmain[false]"),
                    nome = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false, comment: "forminputlabel[Nome]\r\nforminputsize[50]\r\nforminputclass[uppercase]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Nome]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    numerolicenca = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false, comment: "forminputlabel[N° Licença]\r\nforminputsize[20]\r\nforminputclass[number]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[N° Licença]\r\ncolumngridtype[ro]\r\ncolumngridsize[120]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    regiao = table.Column<int>(type: "integer", nullable: false),
                    endereco = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: true, comment: "forminputlabel[Endereço]\r\nforminputsize[30]\r\nforminputclass[uppercase]\r\n\r\ngeragridmain[false]"),
                    numero = table.Column<int>(type: "integer", nullable: true, comment: "forminputlabel[N°]\r\nforminputsize[10]\r\nforminputclass[number]\r\n\r\ngeragridmain[false]"),
                    bairro = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true, comment: "forminputlabel[Bairro]\r\nforminputsize[30]\r\nforminputclass[uppercase]\r\n\r\ngeragridmain[false]"),
                    telefone = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true, comment: "forminputlabel[Telefone]\r\nforminputsize[12]\r\nforminputclass[phone]\r\n\r\ngeragridmain[false]"),
                    latitude = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true, comment: "forminputlabel[latitude]\r\nforminputsize[10]\r\nforminputclass[ro]\r\n\r\ngeragridmain[false]"),
                    longitude = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true, comment: "forminputlabel[longitude]\r\nforminputsize[10]\r\nforminputclass[ro]\r\n\r\ngeragridmain[false]"),
                    usuarioaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    grupoaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    version = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    unidadeaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    ativo = table.Column<int>(type: "integer", nullable: true, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("areareceptora_pkey", x => x.areareceptoraid);
                },
                comment: "template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Área Receptora]\r\nfiltersgrid[#text_filter,#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Áreas Receptoras]");

            migrationBuilder.CreateTable(
                name: "armazenamento",
                schema: "residuos",
                columns: table => new
                {
                    armazenamentoid = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Código]\r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "character varying", nullable: false, comment: "forminputlabel[Nome]\r\nforminputsize[50]\r\nforminputclass[uppercase]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Nome]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    usuarioaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]"),
                    grupoaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]"),
                    unidadeaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]"),
                    version = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]")
                },
                constraints: table =>
                {
                    table.PrimaryKey("armazenamento_pkey", x => x.armazenamentoid);
                },
                comment: "template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs]\r\n\r\nformtitle[Cadastro de Armazenamento]\r\nfiltersgrid[#text_filter,#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Armazenamentos]");

            migrationBuilder.CreateTable(
                name: "assunto",
                schema: "agenda",
                columns: table => new
                {
                    assuntoid = table.Column<int>(type: "integer", nullable: false),
                    nome = table.Column<string>(type: "character varying", nullable: false),
                    grupoaud = table.Column<int>(type: "integer", nullable: true, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    usuarioaud = table.Column<int>(type: "integer", nullable: true, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    unidadeaud = table.Column<int>(type: "integer", nullable: true, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    version = table.Column<int>(type: "integer", nullable: true, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
                },
                constraints: table =>
                {
                    table.PrimaryKey("assunto_pkey", x => x.assuntoid);
                });

            migrationBuilder.CreateTable(
                name: "assunto",
                schema: "cartografia",
                columns: table => new
                {
                    assuntoid = table.Column<int>(type: "integer", nullable: false, comment: "Código do assunto")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descricao = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false, comment: "Descrição do assunto")
                },
                constraints: table =>
                {
                    table.PrimaryKey("assunto_pkey", x => x.assuntoid);
                });

            migrationBuilder.CreateTable(
                name: "atividade",
                schema: "agenda",
                columns: table => new
                {
                    atividadeid = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Código] \r\nforminputsize[7]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Código] \r\ncolumngridtype[ro] \r\ncolumngridsize[80] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "character varying", nullable: false, comment: "forminputlabel[Nome] \r\nforminputsize[70]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Nome] \r\ncolumngridtype[ro] \r\ncolumngridsize[*] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]"),
                    grupoaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    usuarioaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    unidadeaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    version = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
                },
                constraints: table =>
                {
                    table.PrimaryKey("atividade_pkey", x => x.atividadeid);
                },
                comment: "template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Atividade]\r\n\r\nfiltersgrid[#text_filter,#text_filter] \r\n\r\n\r\ngridtitle[Lista de Atividade]\r\n");

            migrationBuilder.CreateTable(
                name: "audit",
                columns: table => new
                {
                    auditid = table.Column<int>(type: "integer", nullable: false),
                    sistema = table.Column<int>(type: "integer", nullable: true),
                    entidade = table.Column<int>(type: "integer", nullable: true),
                    data = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    strjson = table.Column<string>(type: "character varying", nullable: true),
                    usuarioaud = table.Column<int>(type: "integer", nullable: true),
                    grupoaud = table.Column<int>(type: "integer", nullable: true),
                    unidadeaud = table.Column<int>(type: "integer", nullable: true),
                    version = table.Column<int>(type: "integer", nullable: true),
                    id = table.Column<int>(type: "integer", nullable: true),
                    tipomanutencao = table.Column<string>(type: "character varying(1)", maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "audit",
                schema: "agenda",
                columns: table => new
                {
                    auditid = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    sistema = table.Column<int>(type: "integer", nullable: true),
                    entidade = table.Column<int>(type: "integer", nullable: true),
                    data = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    strjson = table.Column<string>(type: "character varying", nullable: true),
                    usuarioaud = table.Column<int>(type: "integer", nullable: true),
                    grupoaud = table.Column<int>(type: "integer", nullable: true),
                    unidadeaud = table.Column<int>(type: "integer", nullable: true),
                    version = table.Column<int>(type: "integer", nullable: true),
                    id = table.Column<int>(type: "integer", nullable: true),
                    tipomanutencao = table.Column<string>(type: "character varying(1)", maxLength: 1, nullable: true),
                    profissional = table.Column<string>(type: "character varying", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("audit_pkey", x => x.auditid);
                });

            migrationBuilder.CreateTable(
                name: "aviso",
                columns: table => new
                {
                    avisoid = table.Column<int>(type: "integer", nullable: false, defaultValueSql: "nextval(('\"public\".\"aviso_avisoid_seq\"'::text)::regclass)"),
                    datainicial = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    datafinal = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    unidade = table.Column<int>(type: "integer", nullable: true),
                    grupo = table.Column<int>(type: "integer", nullable: true),
                    usuario = table.Column<int>(type: "integer", nullable: true),
                    sistema = table.Column<int>(type: "integer", nullable: true),
                    situacao = table.Column<int>(type: "integer", nullable: true),
                    mensagem = table.Column<string>(type: "text", nullable: true),
                    usuarioaud = table.Column<int>(type: "integer", nullable: true),
                    grupoaud = table.Column<int>(type: "integer", nullable: true),
                    unidadeaud = table.Column<int>(type: "integer", nullable: true),
                    version = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("aviso_pkey", x => x.avisoid);
                });

            migrationBuilder.CreateTable(
                name: "bemvindo",
                schema: "agenda",
                columns: table => new
                {
                    bemvindoid = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    conteudo = table.Column<string>(type: "character varying", nullable: true),
                    ativo = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    unidadeaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    grupoaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    usuarioaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    version = table.Column<int>(type: "integer", nullable: false, defaultValue: 1),
                    datahora = table.Column<DateTime>(type: "timestamp without time zone", nullable: true, defaultValueSql: "now()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("bemvindo_pkey", x => x.bemvindoid);
                });

            migrationBuilder.CreateTable(
                name: "caracteristica",
                schema: "residuos",
                columns: table => new
                {
                    caracteristicaid = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Código]\r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "character varying", nullable: false, comment: "forminputlabel[Nome]\r\nforminputsize[50]\r\nforminputclass[uppercase]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Nome]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    usuarioaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]"),
                    grupoaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]"),
                    unidadeaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]"),
                    version = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]")
                },
                constraints: table =>
                {
                    table.PrimaryKey("caracteristica_pkey", x => x.caracteristicaid);
                },
                comment: "template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs]\r\n\r\nformtitle[Cadastro de Característica]\r\nfiltersgrid[#text_filter,#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Características]");

            migrationBuilder.CreateTable(
                name: "caracteristicaemp",
                schema: "agenda",
                columns: table => new
                {
                    caracteristicaempid = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Código]\r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false, comment: "forminputlabel[Nome]\r\nforminputsize[50]\r\nforminputclass[uppercase]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Nome]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    usuarioaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    grupoaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    version = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    unidadeaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
                },
                constraints: table =>
                {
                    table.PrimaryKey("caracteristicaemp_pkey", x => x.caracteristicaempid);
                },
                comment: "template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Característica do Empreendimento]\r\nfiltersgrid[#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Características do Empreendimento]");

            migrationBuilder.CreateTable(
                name: "cidade",
                columns: table => new
                {
                    cidadeid = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Código] \r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    estado = table.Column<string>(type: "character varying", nullable: true),
                    nome = table.Column<string>(type: "character varying", nullable: true, comment: "forminputlabel[Nome]\r\nforminputsize[70]\r\nforminputclass[uppercase]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Nome]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    cep = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    situacao = table.Column<string>(type: "character varying", nullable: true),
                    tipo = table.Column<string>(type: "character varying", nullable: true),
                    usuarioaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    grupoaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    version = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    unidadeaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
                },
                constraints: table =>
                {
                },
                comment: "template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs]\r\nformtitle[Cadastro de Cidade]\r\nfiltersgrid[#text_filter,#text_filter]\r\ngridtitle[Lista de Cidade]");

            migrationBuilder.CreateTable(
                name: "classe",
                schema: "agenda",
                columns: table => new
                {
                    classeid = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Código]\r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false, comment: "forminputlabel[Nome]\r\nforminputsize[50]\r\nforminputclass[uppercase]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Nome]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    usuarioaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    grupoaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    version = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    unidadeaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
                },
                constraints: table =>
                {
                    table.PrimaryKey("classe_pkey", x => x.classeid);
                },
                comment: "template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Classe]\r\nfiltersgrid[#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Classes]");

            migrationBuilder.CreateTable(
                name: "classificacao",
                schema: "residuos",
                columns: table => new
                {
                    classificacaoid = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Código]\r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "character varying", nullable: false, comment: "forminputlabel[Nome]\r\nforminputsize[50]\r\nforminputclass[uppercase]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Nome]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    usuarioaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]"),
                    grupoaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]"),
                    unidadeaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]"),
                    version = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]")
                },
                constraints: table =>
                {
                    table.PrimaryKey("classificacao_pkey", x => x.classificacaoid);
                },
                comment: "template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs]\r\n\r\nformtitle[Cadastro de Classificação]\r\nfiltersgrid[#text_filter,#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Classificações]");

            migrationBuilder.CreateTable(
                name: "classificacao",
                schema: "sisobra",
                columns: table => new
                {
                    classificacaoid = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Código] \r\nforminputsize[7]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Código] \r\ncolumngridtype[ro] \r\ncolumngridsize[80] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "character varying", nullable: false, comment: "forminputlabel[Nome] \r\nforminputsize[70]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Nome] \r\ncolumngridtype[ro] \r\ncolumngridsize[*] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]"),
                    icone = table.Column<string>(type: "character varying", nullable: false, comment: "forminputlabel[Ícone] \r\nforminputsize[70]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Ícone] \r\ncolumngridtype[ro] \r\ncolumngridsize[*] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]"),
                    usuarioaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    grupoaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    unidadeaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    version = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
                },
                constraints: table =>
                {
                    table.PrimaryKey("classificacao_pkey", x => x.classificacaoid);
                },
                comment: "template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Classificação]\r\nfiltersgrid[#text_filter,#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Classificações]");

            migrationBuilder.CreateTable(
                name: "codificacao",
                schema: "agenda",
                columns: table => new
                {
                    codificacaoid = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "character varying", nullable: true),
                    grupoaud = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    unidadeaud = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    usuarioaud = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    version = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    fatoratual = table.Column<decimal>(type: "numeric", nullable: true, defaultValueSql: "0"),
                    pontobase = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    pontoanalise1 = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    pontoanalise2 = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    pontoanalise3 = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    pontoanalise4 = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    pontoanalise5 = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    especial = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("codificacao_pkey", x => x.codificacaoid);
                });

            migrationBuilder.CreateTable(
                name: "comunicado",
                schema: "divulgacao",
                columns: table => new
                {
                    comunicadoid = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    numerocomunicado = table.Column<int>(type: "integer", nullable: false),
                    ano = table.Column<int>(type: "integer", nullable: false),
                    inscricaoeconomica = table.Column<string>(type: "character varying(11)", maxLength: 11, nullable: true, comment: "Inscrição Municpal"),
                    local = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true, comment: "Localalidade de referência"),
                    exigencia = table.Column<string>(type: "text", nullable: true, comment: "Texto descritivo das exigências"),
                    registrado = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true, comment: "Funcionário que registra o comunicado"),
                    cargo = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true, comment: "Cargo/Função"),
                    usuarioaud = table.Column<int>(type: "integer", nullable: true, comment: "Usuario Logado (auditoria)"),
                    grupoaud = table.Column<int>(type: "integer", nullable: true, comment: "Grupo Logado (auditoria)"),
                    unidadeaud = table.Column<int>(type: "integer", nullable: true, comment: "Unidade Logado (auditoria)"),
                    version = table.Column<int>(type: "integer", nullable: true, comment: "Versao do registro (auditoria)"),
                    processo = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: true),
                    tipo = table.Column<int>(type: "integer", nullable: true, comment: "1 - Indefirido\r\n2 - Vistoria")
                },
                constraints: table =>
                {
                    table.PrimaryKey("comunicado_pkey", x => x.comunicadoid);
                });

            migrationBuilder.CreateTable(
                name: "contratado",
                schema: "sisobra",
                columns: table => new
                {
                    contratadoid = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Código] \r\nforminputsize[7]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Código] \r\ncolumngridtype[ro] \r\ncolumngridsize[80] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "character varying", nullable: false, comment: "forminputlabel[Nome] \r\nforminputsize[70]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Nome] \r\ncolumngridtype[ro] \r\ncolumngridsize[*] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]"),
                    telefone = table.Column<string>(type: "character varying", nullable: true, comment: "forminputlabel[Telefone] \r\nforminputsize[10]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Telefone] \r\ncolumngridtype[ro] \r\ncolumngridsize[20] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]"),
                    responsavel = table.Column<string>(type: "character varying", nullable: true, comment: "forminputlabel[Responsável] \r\nforminputsize[70]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Responsável] \r\ncolumngridtype[ro] \r\ncolumngridsize[*] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]"),
                    usuarioaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    grupoaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    unidadeaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    version = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
                },
                constraints: table =>
                {
                    table.PrimaryKey("contratado_pkey", x => x.contratadoid);
                },
                comment: "template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Contratado]\r\nfiltersgrid[#text_filter,#text_filter,#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Contratados]");

            migrationBuilder.CreateTable(
                name: "destinofinal",
                schema: "agenda",
                columns: table => new
                {
                    destinofinalid = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    usuarioaud = table.Column<int>(type: "integer", nullable: true),
                    unidadeaud = table.Column<int>(type: "integer", nullable: true),
                    grupoaud = table.Column<int>(type: "integer", nullable: true),
                    version = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("destinofinal_pkey", x => x.destinofinalid);
                });

            migrationBuilder.CreateTable(
                name: "empresa",
                columns: table => new
                {
                    empresaid = table.Column<int>(type: "integer", nullable: false, defaultValueSql: "nextval(('\"recadempresa\".\"empresa_empresaid_seq\"'::text)::regclass)", comment: "forminputlabel[Código] \r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    tipopessoa = table.Column<string>(type: "character varying(3)", maxLength: 3, nullable: true, comment: "TIPO DA PESSOA ( PF / PJ / PFE)\r\n\r\nforminputlabel[Tipo Pessoa]\r\nforminputsize[5]\r\nforminputclass[uppercase]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Tipo-Pessoa]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    inscricaomunicipal = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true, comment: "forminputlabel[Inscrição Municipal] \r\nforminputsize[15]\r\nforminputclass[number]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Inscrição Municipal]\r\ncolumngridtype[ro]\r\ncolumngridsize[100]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    nomefantasia = table.Column<string>(type: "character varying(120)", maxLength: 120, nullable: true, comment: "forminputlabel[Nome Fantasia]\r\nforminputsize[50]\r\nforminputclass[uppercase]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Nome-Fantasia]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    inscricaoestadual = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: true, comment: "forminputlabel[Inscrição Estadual] \r\nforminputsize[15]\r\nforminputclass[number]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Inscrição Estadual]\r\ncolumngridtype[ro]\r\ncolumngridsize[100]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    cpfcnpj = table.Column<string>(type: "character varying(21)", maxLength: 21, nullable: true, comment: "forminputlabel[CPF/CNPJ] \r\nforminputsize[15]\r\nforminputclass[number]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[CPF/CNPJ]\r\ncolumngridtype[ro]\r\ncolumngridsize[100]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    contador = table.Column<int>(type: "integer", nullable: true, comment: "forminputlabel[Contador]\r\nforminputsize[10]\r\ngeragridmain[false]"),
                    razaosocial = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: true, comment: "forminputlabel[Razão Social] \r\nforminputsize[40]\r\nforminputclass[uppercase]\r\ngeragridmain[false]"),
                    razaosocialreduzido = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true, comment: "forminputlabel[Razão Social Reduzido] \r\nforminputsize[30]\r\nforminputclass[uppercase]\r\ngeragridmain[false]"),
                    situacao = table.Column<string>(type: "character varying(1)", maxLength: 1, nullable: true, comment: "SITUAÇÃO ( A / I )\r\n\r\nforminputlabel[Situação] \r\nforminputsize[10]\r\nforminputclass[uppercase]\r\ngeragridmain[false]"),
                    dddfonecorresp = table.Column<string>(type: "character varying(3)", maxLength: 3, nullable: true, comment: "forminputlabel[DDD-Fone Correspondência] \r\nforminputsize[10]\r\nforminputclass[number]\r\ngeragridmain[false]"),
                    fonecorresp = table.Column<string>(type: "character varying(9)", maxLength: 9, nullable: true, comment: "forminputlabel[Fone Correspondência] \r\nforminputsize[15]\r\nforminputclass[uppercase]\r\ngeragridmain[false]"),
                    dddfaxcorresp = table.Column<string>(type: "character varying(3)", maxLength: 3, nullable: true, comment: "forminputlabel[DDD-Fax Correspondência]\r\nforminputsize[10]\r\nforminputclass[number]\r\ngeragridmain[false]"),
                    faxcorresp = table.Column<string>(type: "character varying(9)", maxLength: 9, nullable: true, comment: "forminputlabel[Fax Correspondência]\r\nforminputsize[15]\r\nforminputclass[uppercase]\r\ngeragridmain[false]"),
                    dddcelcorresp = table.Column<string>(type: "character varying(3)", maxLength: 3, nullable: true, comment: "forminputlabel[DDD-Cel. Correspondência]\r\nforminputsize[10]\r\nforminputclass[number]\r\ngeragridmain[false]"),
                    celcorresp = table.Column<string>(type: "character varying(9)", maxLength: 9, nullable: true, comment: "forminputlabel[Cel. Correspondência]\r\nforminputsize[15]\r\nforminputclass[uppercase]\r\ngeragridmain[false]"),
                    tipologcorresp = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true, comment: "forminputlabel[Tipo Logradouro Correspondência]\r\nforminputsize[30]\r\nforminputclass[uppercase]\r\ngeragridmain[false]"),
                    logradourocorresp = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true, comment: "forminputlabel[Logradouro Correspondência]\r\nforminputsize[30]\r\nforminputclass[uppercase]\r\ngeragridmain[false]"),
                    numeroendcorresp = table.Column<int>(type: "integer", nullable: true, comment: "forminputlabel[Nº Correspondência]\r\nforminputsize[10]\r\nforminputclass[number]\r\ngeragridmain[false]"),
                    complendcorresp = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true, comment: "forminputlabel[Complemento Correspondência]\r\nforminputsize[30]\r\nforminputclass[uppercase]\r\ngeragridmain[false]"),
                    tipobairrocorresp = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true, comment: "forminputlabel[Tipo Bairro Correspondência]\r\nforminputsize[20]\r\nforminputclass[uppercase]\r\ngeragridmain[false]"),
                    bairrocorresp = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true, comment: "forminputlabel[Bairro Correspondência]\r\nforminputsize[40]\r\nforminputclass[uppercase]\r\ngeragridmain[false]"),
                    cepcorresp = table.Column<string>(type: "character varying(9)", maxLength: 9, nullable: true, comment: "forminputlabel[CEP Correspondência]\r\nforminputsize[10]\r\nforminputclass[cep]\r\ngeragridmain[false]"),
                    distritocorresp = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true, comment: "forminputlabel[Distrito Correspondência]\r\nforminputsize[30]\r\nforminputclass[uppercase]\r\ngeragridmain[false]"),
                    cidadecorresp = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true, comment: "forminputlabel[Cidade Correspondência]\r\nforminputsize[40]\r\nforminputclass[uppercase]\r\ngeragridmain[false]"),
                    ufcorresp = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true, comment: "forminputlabel[UF Correspondência]\r\nforminputsize[20]\r\nforminputclass[uppercase]\r\ngeragridmain[false]"),
                    codpaiscorresp = table.Column<int>(type: "integer", nullable: true, comment: "forminputlabel[Cod. País Correspondência]\r\nforminputsize[20]\r\nforminputclass[number]\r\ngeragridmain[false]"),
                    dddfonelocal = table.Column<string>(type: "character varying(3)", maxLength: 3, nullable: true, comment: "forminputlabel[DDD-Fone Localização]\r\nforminputsize[10]\r\nforminputclass[number]\r\ngeragridmain[false]"),
                    fonelocal = table.Column<string>(type: "character varying(9)", maxLength: 9, nullable: true, comment: "forminputlabel[Fone Localização]\r\nforminputsize[15]\r\nforminputclass[uppercase]\r\ngeragridmain[false]"),
                    dddfaxlocal = table.Column<string>(type: "character varying(3)", maxLength: 3, nullable: true, comment: "forminputlabel[DDD-Fax Localização]\r\nforminputsize[10]\r\nforminputclass[number]\r\ngeragridmain[false]"),
                    faxlocal = table.Column<string>(type: "character varying(9)", maxLength: 9, nullable: true, comment: "forminputlabel[Fax Localização]\r\nforminputsize[15]\r\nforminputclass[uppercase]\r\ngeragridmain[false]"),
                    tipologlocal = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true, comment: "forminputlabel[Tipo Logradouro Localização]\r\nforminputsize[20]\r\nforminputclass[uppercase]\r\ngeragridmain[false]"),
                    logradourolocal = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true, comment: "forminputlabel[Logradouro Localização]\r\nforminputsize[30]\r\nforminputclass[uppercase]\r\ngeragridmain[false]"),
                    complendlocal = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true, comment: "forminputlabel[Complemento Endereço Localização]\r\nforminputsize[20]\r\nforminputclass[uppercase]\r\ngeragridmain[false]"),
                    bairrolocal = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true, comment: "forminputlabel[Bairro Localização]\r\nforminputsize[30]\r\nforminputclass[uppercase]\r\ngeragridmain[false]"),
                    distritolocal = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true, comment: "forminputlabel[Distrito Localização]\r\nforminputsize[30]\r\nforminputclass[uppercase]\r\ngeragridmain[false]"),
                    cidadelocal = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true, comment: "forminputlabel[Cidade Localização]\r\nforminputsize[30]\r\nforminputclass[uppercase]\r\ngeragridmain[false]"),
                    uflocal = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true, comment: "forminputlabel[UF Localização]\r\nforminputsize[15]\r\nforminputclass[uppercase]\r\ngeragridmain[false]"),
                    codpaislocal = table.Column<int>(type: "integer", nullable: true, comment: "forminputlabel[Código País Localização]\r\nforminputsize[30]\r\nforminputclass[number]\r\ngeragridmain[false]"),
                    ceplocal = table.Column<string>(type: "character varying(9)", maxLength: 9, nullable: true, comment: "forminputlabel[CEP Localização]\r\nforminputsize[10]\r\nforminputclass[cep]\r\ngeragridmain[false]"),
                    numeronire = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true, comment: "forminputlabel[Número NIRE] \r\nforminputsize[10]\r\nforminputclass[number]\r\ngeragridmain[false]"),
                    observacao = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true, comment: "forminputlabel[Observação] \r\nforminputsize[50]\r\nforminputclass[uppercase]"),
                    endlocal = table.Column<string>(type: "character varying", nullable: true),
                    endcorresp = table.Column<string>(type: "character varying", nullable: true),
                    datahoraalteracao = table.Column<DateTime>(type: "timestamp without time zone", nullable: true, comment: "geraform[false]\r\ngeragridmain[false]"),
                    ipalteracao = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: true, comment: "geraform[false]\r\ngeragridmain[false]"),
                    email = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: true, comment: "forminputlabel[Email]\r\nforminputsize[40]\r\nforminputclass[email]\r\ngeragridmain[false]"),
                    senha = table.Column<string>(type: "character varying", nullable: true),
                    usuario = table.Column<int>(type: "integer", nullable: true, defaultValue: 147),
                    usuarioaud = table.Column<int>(type: "integer", nullable: true, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    grupoaud = table.Column<int>(type: "integer", nullable: true, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    version = table.Column<int>(type: "integer", nullable: true, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    unidadeaud = table.Column<int>(type: "integer", nullable: true, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    dddcellocal = table.Column<string>(type: "character varying(3)", maxLength: 3, nullable: true),
                    cellocal = table.Column<string>(type: "character varying(9)", maxLength: 9, nullable: true),
                    numeroendlocal = table.Column<int>(type: "integer", nullable: true),
                    usuarioalteracao = table.Column<int>(type: "integer", nullable: true),
                    cpfresponsavel = table.Column<string>(type: "character varying", nullable: true),
                    atualizadosiat = table.Column<bool>(type: "boolean", nullable: true, defaultValue: false),
                    primeiraatualizacao = table.Column<bool>(type: "boolean", nullable: true, defaultValue: false),
                    disponivel = table.Column<bool>(type: "boolean", nullable: true, comment: "Empresas ques estao visiveis (listagem grid) para o login da prefeitura"),
                    ativo = table.Column<bool>(type: "boolean", nullable: true, comment: "Este campo serve para validar quais empresas podem ou nao logar."),
                    respostaxml = table.Column<string>(type: "text", nullable: true),
                    etapa = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("empresa_pkey", x => x.empresaid);
                },
                comment: "template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs]\r\n\r\nformtitle[Cadastro de Empresa]\r\nfiltersgrid[#text_filter,#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Empresas]");

            migrationBuilder.CreateTable(
                name: "empresa",
                schema: "residuos",
                columns: table => new
                {
                    empresaid = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Código]\r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    senha = table.Column<string>(type: "character varying", nullable: false, comment: "forminputlabel[Senha]\r\nforminputsize[10]\r\nforminputclass[]\r\n\r\ngeragridmain[false]"),
                    datalicenciamento = table.Column<DateOnly>(type: "date", nullable: true, comment: "forminputlabel[Data Licenciamento]\r\nforminputsize[10]\r\nforminputclass[date]\r\n\r\ngeragridmain[false]"),
                    numerolicenciamento = table.Column<int>(type: "integer", nullable: true, comment: "forminputlabel[Nº Licenciamento]\r\nforminputsize[10]\r\nforminputclass[number]\r\n\r\ngeragridmain[false]"),
                    datavenclicenciamento = table.Column<DateOnly>(type: "date", nullable: true, comment: "forminputlabel[Dt. Venc. Licenciamento]\r\nforminputsize[10]\r\nforminputclass[number]\r\n\r\ngeragridmain[false]"),
                    usuarioaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]"),
                    grupoaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]"),
                    unidadeaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]"),
                    version = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]"),
                    nome = table.Column<string>(type: "character varying", nullable: true),
                    inscricaoeconomica = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true),
                    usuario = table.Column<int>(type: "integer", nullable: true),
                    datacadastro = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    razaosocial = table.Column<string>(type: "character varying", nullable: true),
                    email = table.Column<string>(type: "character varying", nullable: true),
                    inscricaomunicipal = table.Column<string>(type: "character varying", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("empresa_pkey", x => x.empresaid);
                },
                comment: "template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs]\r\n\r\nformtitle[Cadastro de Empresa]\r\nfiltersgrid[#text_filter,#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Empresas]");

            migrationBuilder.CreateTable(
                name: "endereco",
                columns: table => new
                {
                    enderecoid = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    logradouro = table.Column<int>(type: "integer", nullable: true),
                    tipologradouro = table.Column<int>(type: "integer", nullable: true),
                    bairro = table.Column<int>(type: "integer", nullable: true),
                    numero = table.Column<int>(type: "integer", nullable: true),
                    cep = table.Column<string>(type: "character varying", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("endereco_pkey", x => x.enderecoid);
                });

            migrationBuilder.CreateTable(
                name: "entidade",
                columns: table => new
                {
                    entidadeid = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Código]\r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "character varying", nullable: false, comment: "forminputlabel[Nome]\r\nforminputsize[50]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Nome]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    usuarioaud = table.Column<int>(type: "integer", nullable: true),
                    grupoaud = table.Column<int>(type: "integer", nullable: true),
                    unidade = table.Column<int>(type: "integer", nullable: true),
                    version = table.Column<int>(type: "integer", nullable: true),
                    unidadeaud = table.Column<int>(type: "integer", nullable: true, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("entidade_pkey", x => x.entidadeid);
                },
                comment: "template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Entidade] \r\n\r\nfieldsgrid[entidadeid,nome:entidadeid]\r\nfiltersgrid[#text_filter,#text_filter] \r\n\r\nfieldsform[entidadeid,nome]\r\n\r\ngridtitle[Lista de Entidades]");

            migrationBuilder.CreateTable(
                name: "estadofisico",
                schema: "residuos",
                columns: table => new
                {
                    estadofisicoid = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Código]\r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "character varying", nullable: false, comment: "forminputlabel[Nome]\r\nforminputsize[50]\r\nforminputclass[uppercase]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Nome]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    usuarioaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]"),
                    grupoaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]"),
                    unidadeaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]"),
                    version = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]")
                },
                constraints: table =>
                {
                    table.PrimaryKey("estadofisico_pkey", x => x.estadofisicoid);
                },
                comment: "template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs]\r\n\r\nformtitle[Cadastro de Estado Físico]\r\nfiltersgrid[#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Estado Físico]");

            migrationBuilder.CreateTable(
                name: "evento",
                schema: "sisobra",
                columns: table => new
                {
                    eventoid = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Código] \r\nforminputsize[7]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Código] \r\ncolumngridtype[ro] \r\ncolumngridsize[80] \r\ncolumngridalign[left] \r\ncolumngridcolor[]")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "character varying", nullable: false, comment: "forminputlabel[Nome] \r\nforminputsize[70]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Nome] \r\ncolumngridtype[ro] \r\ncolumngridsize[*] \r\ncolumngridalign[left] \r\ncolumngridcolor[]"),
                    dataevento = table.Column<DateOnly>(type: "date", nullable: false, comment: "forminputlabel[Data-Evento] \r\nforminputsize[12]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Data-Evento] \r\ncolumngridtype[ro] \r\ncolumngridsize[20] \r\ncolumngridalign[left] \r\ncolumngridcolor[]"),
                    status = table.Column<string>(type: "character varying(1)", maxLength: 1, nullable: false, defaultValueSql: "'I'::character varying", comment: "forminputlabel[Status] \r\nforminputsize[12]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Status] \r\ncolumngridtype[ro] \r\ncolumngridsize[20] \r\ncolumngridalign[left] \r\ncolumngridcolor[]"),
                    usuarioaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    grupoaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    unidadeaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    version = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
                },
                constraints: table =>
                {
                    table.PrimaryKey("evento_pkey", x => x.eventoid);
                },
                comment: "template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Evento]\r\nfiltersgrid[#text_filter,#text_filter,#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Eventos]");

            migrationBuilder.CreateTable(
                name: "exigencia",
                schema: "agenda",
                columns: table => new
                {
                    exigenciaid = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "character varying", nullable: true),
                    usuarioaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    grupoaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    unidadeaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    version = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    ordem = table.Column<string>(type: "character varying", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("exigencia_pkey", x => x.exigenciaid);
                });

            migrationBuilder.CreateTable(
                name: "faseobra",
                schema: "sisobra",
                columns: table => new
                {
                    faseobraid = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Código] \r\nforminputsize[7]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Código] \r\ncolumngridtype[ro] \r\ncolumngridsize[80] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "character varying", nullable: false, comment: "forminputlabel[Nome] \r\nforminputsize[70]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Nome] \r\ncolumngridtype[ro] \r\ncolumngridsize[*] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]"),
                    usuarioaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    grupoaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    unidadeaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    version = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
                },
                constraints: table =>
                {
                    table.PrimaryKey("faseobra_pkey", x => x.faseobraid);
                },
                comment: "template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Fase da Obra]\r\nfiltersgrid[#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Fases da Obra]");

            migrationBuilder.CreateTable(
                name: "fiscal",
                schema: "sisobra",
                columns: table => new
                {
                    fiscalid = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Código] \r\nforminputsize[7]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Código] \r\ncolumngridtype[ro] \r\ncolumngridsize[80] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "character varying", nullable: false, comment: "forminputlabel[Nome] \r\nforminputsize[70]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Nome] \r\ncolumngridtype[ro] \r\ncolumngridsize[*] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]"),
                    telefone = table.Column<string>(type: "character varying", nullable: true, comment: "forminputlabel[Telefone] \r\nforminputsize[10]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Telefone] \r\ncolumngridtype[ro] \r\ncolumngridsize[20] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]"),
                    usuarioaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    grupoaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    unidadeaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    version = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
                },
                constraints: table =>
                {
                    table.PrimaryKey("fiscal_pkey", x => x.fiscalid);
                },
                comment: "template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Fiscal]\r\nfiltersgrid[#text_filter,#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Fiscais]");

            migrationBuilder.CreateTable(
                name: "fonterecurso",
                schema: "sisobra",
                columns: table => new
                {
                    fonterecursoid = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Código] \r\nforminputsize[7]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Código] \r\ncolumngridtype[ro] \r\ncolumngridsize[80] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "character varying", nullable: false, comment: "forminputlabel[Nome] \r\nforminputsize[70]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Nome] \r\ncolumngridtype[ro] \r\ncolumngridsize[*] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]"),
                    sigla = table.Column<string>(type: "character varying", nullable: false, comment: "forminputlabel[Sigla] \r\nforminputsize[10]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Sigla] \r\ncolumngridtype[ro] \r\ncolumngridsize[20] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]"),
                    usuarioaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    grupoaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    unidadeaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    version = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
                },
                constraints: table =>
                {
                    table.PrimaryKey("fonterecurso_pkey", x => x.fonterecursoid);
                },
                comment: "template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Fonte Recurso]\r\nfiltersgrid[#text_filter,#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Fontes de Recurso]");

            migrationBuilder.CreateTable(
                name: "grupo",
                columns: table => new
                {
                    grupoid = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Código] forminputsize[7]  columngridid[] columngridtitle[Código] columngridtype[ro] columngridsize[80] columngridalign[left] columngridcolor[white]")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false, comment: "forminputlabel[Nome] forminputsize[50]  columngridid[] columngridtitle[Nome] columngridtype[ro] columngridsize[*] columngridalign[left] columngridcolor[white]"),
                    usuarioaud = table.Column<int>(type: "integer", nullable: true),
                    grupoaud = table.Column<int>(type: "integer", nullable: true),
                    version = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    unidadeaud = table.Column<int>(type: "integer", nullable: true, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("grupo_pk", x => x.grupoid);
                },
                comment: "template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]  \r\n\r\nformtitle[Cadastro de Grupo]   \r\nfieldsgrid[grupoid,nome:grupoid] \r\n\r\nfieldsform[grupoid,nome] \r\n\r\ngridtitle[Lista de Grupos]");

            migrationBuilder.CreateTable(
                name: "logradouro",
                columns: table => new
                {
                    logradouroid = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "character varying", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("logradouro_pkey", x => x.logradouroid);
                });

            migrationBuilder.CreateTable(
                name: "mensagem",
                schema: "agenda",
                columns: table => new
                {
                    mensagemid = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    projeto = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    datahora = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    usuario = table.Column<string>(type: "character varying", nullable: false, defaultValueSql: "0"),
                    texto = table.Column<string>(type: "character varying", nullable: false, defaultValueSql: "0"),
                    lida = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    grupo = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    usuarioaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    grupoaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    unidadeaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    version = table.Column<int>(type: "integer", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("mensagem_pkey", x => x.mensagemid);
                });

            migrationBuilder.CreateTable(
                name: "ministerio",
                schema: "sisobra",
                columns: table => new
                {
                    ministerioid = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Código] \r\nforminputsize[7]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Código] \r\ncolumngridtype[ro] \r\ncolumngridsize[80] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "character varying", nullable: false, comment: "forminputlabel[Nome] \r\nforminputsize[70]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Nome] \r\ncolumngridtype[ro] \r\ncolumngridsize[*] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]"),
                    sigla = table.Column<string>(type: "character varying", nullable: false, comment: "forminputlabel[Sigla] \r\nforminputsize[10]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Sigla] \r\ncolumngridtype[ro] \r\ncolumngridsize[20] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]"),
                    usuarioaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    grupoaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    unidadeaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    version = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
                },
                constraints: table =>
                {
                    table.PrimaryKey("ministerio_pkey", x => x.ministerioid);
                },
                comment: "template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Ministério]\r\nfiltersgrid[#text_filter,#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Ministérios]");

            migrationBuilder.CreateTable(
                name: "modulo",
                columns: table => new
                {
                    moduloid = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Código] \r\nforminputsize[7]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Código] \r\ncolumngridtype[ro] \r\ncolumngridsize[80] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false, comment: "forminputlabel[Nome] \r\nforminputsize[50]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Nome] \r\ncolumngridtype[ro] \r\ncolumngridsize[*] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]"),
                    usuarioaud = table.Column<int>(type: "integer", nullable: true),
                    grupoaud = table.Column<int>(type: "integer", nullable: true),
                    version = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    unidadeaud = table.Column<int>(type: "integer", nullable: true, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("modulo_pk", x => x.moduloid);
                },
                comment: "template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]  \r\n\r\nformtitle[Cadastro de Módulo]   \r\nfieldsgrid[moduloid,nome:moduloid] \r\n\r\nfieldsform[moduloid,nome] \r\n\r\ngridtitle[Lista de Módulos]");

            migrationBuilder.CreateTable(
                name: "natureza",
                schema: "agenda",
                columns: table => new
                {
                    naturezaid = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Código] \r\nforminputsize[7]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Código] \r\ncolumngridtype[ro] \r\ncolumngridsize[80] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "character varying", nullable: false, comment: "forminputlabel[Nome] \r\nforminputsize[70]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Nome] \r\ncolumngridtype[ro] \r\ncolumngridsize[*] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]"),
                    grupoaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    usuarioaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    unidadeaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    version = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
                },
                constraints: table =>
                {
                    table.PrimaryKey("natureza_pkey", x => x.naturezaid);
                },
                comment: "template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Natureza\r\n\r\nfiltersgrid[#text_filter,#text_filter] \r\n\r\n\r\ngridtitle[Lista de Natureza]\r\n");

            migrationBuilder.CreateTable(
                name: "numeroprocesso",
                schema: "agenda",
                columns: table => new
                {
                    ano = table.Column<int>(type: "integer", nullable: false),
                    processo = table.Column<int>(type: "integer", nullable: false),
                    grupoaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    usuarioaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    unidadeaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    version = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
                },
                constraints: table =>
                {
                    table.PrimaryKey("numeroprocesso_pkey", x => x.ano);
                });

            migrationBuilder.CreateTable(
                name: "ocorrencia",
                schema: "divulgacao",
                columns: table => new
                {
                    ocorrenciaid = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Código]\r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "character varying", nullable: false, comment: "forminputlabel[Nome]\r\nforminputsize[50]\r\nforminputclass[uppercase]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Nome]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    usuarioaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    grupoaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    unidadeaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    version = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
                },
                constraints: table =>
                {
                    table.PrimaryKey("ocorrencia_pkey", x => x.ocorrenciaid);
                },
                comment: "template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Ocorrência]\r\nfiltersgrid[#text_filter,#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Ocorrências]");

            migrationBuilder.CreateTable(
                name: "pedidoped",
                schema: "vistoria",
                columns: table => new
                {
                    codigoped = table.Column<int>(type: "integer", nullable: false, comment: "Código do pedido")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    codigosol = table.Column<int>(type: "integer", nullable: true, comment: "Solicitante do pedido"),
                    ruaped = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true, comment: "Rua do pedido"),
                    numeroped = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true, comment: "Numero da rua do pedido"),
                    bairroped = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true, comment: "Bairro do pedido"),
                    complemped = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true, comment: "Complemento do endereço do pedido"),
                    cepped = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true, comment: "CEP do solicitante no pedido"),
                    quadraped = table.Column<string>(type: "character varying(5)", maxLength: 5, nullable: true, comment: "Quadra do pedido"),
                    loteped = table.Column<string>(type: "character varying(5)", maxLength: 5, nullable: true, comment: "Lote do pedido"),
                    datacadped = table.Column<DateTime>(type: "timestamp without time zone", nullable: true, defaultValueSql: "now()", comment: "Data de cadastro do pedido"),
                    codigomic = table.Column<int>(type: "integer", nullable: true, comment: "Micro-região"),
                    codigotps = table.Column<int>(type: "integer", nullable: true, comment: "Tipo da Solicitacao"),
                    processoped = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true, comment: "Numero do processo ou numero de identificação do pedido."),
                    codigoori = table.Column<int>(type: "integer", nullable: true, comment: "Origem do Pedido"),
                    codigotpi = table.Column<int>(type: "integer", nullable: true, comment: "Tipo do Imovel do pedido"),
                    justificaped = table.Column<string>(type: "character varying(120)", maxLength: 120, nullable: true, comment: "Justificativa do pedido")
                },
                constraints: table =>
                {
                    table.PrimaryKey("pedidoped_pkey", x => x.codigoped);
                });

            migrationBuilder.CreateTable(
                name: "prfage_tmp",
                schema: "agenda",
                columns: table => new
                {
                    codprf = table.Column<int>(type: "integer", nullable: true),
                    insprf = table.Column<long>(type: "bigint", nullable: true),
                    nomprf = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    titprf = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    emlprf = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    creprf = table.Column<long>(type: "bigint", nullable: true),
                    ufcprf = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    cpfprf = table.Column<string>(type: "character varying(14)", maxLength: 14, nullable: true),
                    fonprf = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    tipprf = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    nlcprf = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    comprf = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    numprf = table.Column<int>(type: "integer", nullable: true),
                    baiprf = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    cepprf = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    logprf = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    senprf = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    uacprf = table.Column<DateOnly>(type: "date", nullable: true),
                    aceprf = table.Column<int>(type: "integer", nullable: true),
                    visprf = table.Column<int>(type: "integer", nullable: true, defaultValue: 1),
                    usuario = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    usuarioaud = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    unidadeaud = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    grupoaud = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    version = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    termoaceito = table.Column<int>(type: "integer", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "profissional",
                schema: "agenda",
                columns: table => new
                {
                    profissionalid = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    inscricao = table.Column<string>(type: "character varying", nullable: true),
                    titulo = table.Column<string>(type: "character varying", nullable: true),
                    numerocre = table.Column<string>(type: "character varying", nullable: true),
                    ufcre = table.Column<string>(type: "character varying", nullable: true),
                    telefone = table.Column<string>(type: "character varying", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("profissional_pkey", x => x.profissionalid);
                });

            migrationBuilder.CreateTable(
                name: "profissional",
                schema: "planurb",
                columns: table => new
                {
                    profissionalid = table.Column<int>(type: "integer", nullable: false, comment: "Código do profissional")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "character varying", nullable: false, comment: "Nome do profissional"),
                    cpfcnpj = table.Column<string>(type: "character varying", nullable: false, comment: "CPF ou CNPJ do profissional"),
                    inscricao = table.Column<string>(type: "character varying", nullable: false, comment: "Inscrição do profissional"),
                    email = table.Column<string>(type: "character varying", nullable: true, comment: "email do profissional"),
                    telefone1 = table.Column<string>(type: "character varying", nullable: true, comment: "Telefone de contato 1"),
                    telefone2 = table.Column<string>(type: "character varying", nullable: true, comment: "Telefone de contato 2"),
                    ruaend = table.Column<string>(type: "character varying", nullable: true, comment: "Endereço rua"),
                    numeroend = table.Column<string>(type: "character varying", nullable: true, comment: "Endereço número"),
                    bairroend = table.Column<string>(type: "character varying", nullable: true, comment: "Endereço bairro"),
                    complend = table.Column<string>(type: "character varying", nullable: true, comment: "Endereço complemento"),
                    cepend = table.Column<string>(type: "character varying", nullable: true, comment: "Endereço cep"),
                    cidadeend = table.Column<string>(type: "character varying", nullable: true, comment: "Endereço cidade"),
                    estadoend = table.Column<string>(type: "character varying", nullable: true, comment: "Endereço estado")
                },
                constraints: table =>
                {
                    table.PrimaryKey("profissional_pkey", x => x.profissionalid);
                });

            migrationBuilder.CreateTable(
                name: "projeto",
                schema: "planurb",
                columns: table => new
                {
                    projetoid = table.Column<int>(type: "integer", nullable: false, comment: "Código do PROJETO")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    datacadastro = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "now()", comment: "Data de cadastro do Projeto"),
                    inscricao = table.Column<string>(type: "character varying(11)", maxLength: 11, nullable: false, comment: "Inscrição Imobiliária")
                },
                constraints: table =>
                {
                    table.PrimaryKey("projeto_pkey", x => x.projetoid);
                });

            migrationBuilder.CreateTable(
                name: "projeto_anistia",
                schema: "agenda",
                columns: table => new
                {
                    projetoid = table.Column<int>(type: "integer", nullable: false),
                    datacriacao = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    datahomologacao = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    profissional = table.Column<int>(type: "integer", nullable: true),
                    grupoaud = table.Column<int>(type: "integer", nullable: true),
                    usuarioaud = table.Column<int>(type: "integer", nullable: true),
                    unidadeaud = table.Column<int>(type: "integer", nullable: true),
                    version = table.Column<int>(type: "integer", nullable: true),
                    analista = table.Column<int>(type: "integer", nullable: true),
                    dataencaminhamento = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    finalizado = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    processo = table.Column<string>(type: "character varying", nullable: false),
                    proprietario = table.Column<string>(type: "character varying", nullable: true),
                    inscricao = table.Column<string>(type: "character varying", nullable: true),
                    codificacao = table.Column<int>(type: "integer", nullable: true),
                    codseguranca = table.Column<long>(type: "bigint", nullable: true),
                    assunto = table.Column<int>(type: "integer", nullable: true),
                    processoexp = table.Column<string>(type: "character varying(12)", maxLength: 12, nullable: false),
                    alvara = table.Column<string>(type: "character varying", nullable: true),
                    natureza = table.Column<int>(type: "integer", nullable: true),
                    atividade = table.Column<int>(type: "integer", nullable: true),
                    rua = table.Column<string>(type: "character varying", nullable: true),
                    numero = table.Column<int>(type: "integer", nullable: true),
                    numart = table.Column<string>(type: "character varying", nullable: true),
                    status = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    exportado = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    dataexportado = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    quadra = table.Column<string>(type: "character varying", nullable: true),
                    lote = table.Column<string>(type: "character varying", nullable: true),
                    bairro = table.Column<string>(type: "character varying", nullable: true),
                    dataulttram = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    despacho = table.Column<string>(type: "character varying", nullable: true),
                    cpfproprietario = table.Column<string>(type: "character varying", nullable: true),
                    numerolaudoavaliacao = table.Column<int>(type: "integer", nullable: true),
                    anolaudoavaliacao = table.Column<int>(type: "integer", nullable: true),
                    arealote = table.Column<decimal>(type: "numeric(10,2)", precision: 10, scale: 2, nullable: true),
                    lotefrente = table.Column<string>(type: "character varying", nullable: true),
                    lotefundo = table.Column<string>(type: "character varying", nullable: true),
                    lotedireita = table.Column<string>(type: "character varying", nullable: true),
                    loteesquerda = table.Column<string>(type: "character varying", nullable: true),
                    areaprojecao = table.Column<decimal>(type: "numeric(10,2)", precision: 10, scale: 2, nullable: true),
                    enquadramento1 = table.Column<string>(type: "character varying", nullable: true),
                    enquadramento2 = table.Column<string>(type: "character varying", nullable: true),
                    enquadramento3 = table.Column<string>(type: "character varying", nullable: true),
                    enquadramento4 = table.Column<string>(type: "character varying", nullable: true),
                    enquadramento5 = table.Column<string>(type: "character varying", nullable: true),
                    enquadramento6 = table.Column<string>(type: "character varying", nullable: true),
                    enquadramentofinal = table.Column<string>(type: "character varying", nullable: true),
                    valormetroquadrado = table.Column<decimal>(type: "numeric(10,2)", precision: 10, scale: 2, nullable: true),
                    zoneamento = table.Column<int>(type: "integer", nullable: true),
                    datalaudoavaliacao = table.Column<DateOnly>(type: "date", nullable: true),
                    areaexcedente = table.Column<decimal>(type: "numeric(10,2)", precision: 10, scale: 2, nullable: true),
                    valorcontrapartida = table.Column<decimal>(type: "numeric(10,2)", precision: 10, scale: 2, nullable: true),
                    valorcontrapartidaextenso = table.Column<string>(type: "character varying", nullable: true),
                    valormetroquadradoextenso = table.Column<string>(type: "character varying", nullable: true),
                    areax = table.Column<decimal>(type: "numeric(10,2)", precision: 10, scale: 2, nullable: true),
                    areay = table.Column<decimal>(type: "numeric(10,2)", precision: 10, scale: 2, nullable: true),
                    cnpjempresa = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    razaosocialempresa = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    proprietario1 = table.Column<string>(type: "character varying", nullable: true),
                    proprietario2 = table.Column<string>(type: "character varying", nullable: true),
                    proprietario3 = table.Column<string>(type: "character varying", nullable: true),
                    cpfprop1 = table.Column<string>(type: "character varying", nullable: true),
                    cpfprop2 = table.Column<string>(type: "character varying", nullable: true),
                    cpfprop3 = table.Column<string>(type: "character varying", nullable: true),
                    usuaval = table.Column<string>(type: "character varying", nullable: true),
                    emailproprietario = table.Column<string>(type: "character varying", nullable: true),
                    procsubstituto = table.Column<string>(type: "character varying", nullable: true),
                    fiscal = table.Column<int>(type: "integer", nullable: true),
                    assuntoalt = table.Column<int>(type: "integer", nullable: true),
                    assuntogrup = table.Column<int>(type: "integer", nullable: true),
                    classificacao = table.Column<string>(type: "character varying(5)", maxLength: 5, nullable: true, defaultValueSql: "'NOR'::character varying"),
                    regiao = table.Column<int>(type: "integer", nullable: true),
                    telcontato = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "recibo",
                schema: "auditoria",
                columns: table => new
                {
                    reciboid = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    numero = table.Column<int>(type: "integer", nullable: true),
                    doador = table.Column<string>(type: "character varying", nullable: true),
                    valor = table.Column<string>(type: "character varying", nullable: true),
                    cpf = table.Column<string>(type: "character varying", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("recibo_pkey", x => x.reciboid);
                });

            migrationBuilder.CreateTable(
                name: "recurso",
                schema: "sisobra",
                columns: table => new
                {
                    recursoid = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Código] \r\nforminputsize[7]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Código] \r\ncolumngridtype[ro] \r\ncolumngridsize[80] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "character varying", nullable: false, comment: "forminputlabel[Nome] \r\nforminputsize[70]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Nome] \r\ncolumngridtype[ro] \r\ncolumngridsize[*] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]"),
                    sigla = table.Column<string>(type: "character varying", nullable: false, comment: "forminputlabel[Sigla] \r\nforminputsize[10]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Sigla] \r\ncolumngridtype[ro] \r\ncolumngridsize[20] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]"),
                    usuarioaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    grupoaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    unidadeaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    version = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
                },
                constraints: table =>
                {
                    table.PrimaryKey("recurso_pkey", x => x.recursoid);
                },
                comment: "template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Recurso]\r\nfiltersgrid[#text_filter,#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Recursos]");

            migrationBuilder.CreateTable(
                name: "regiao",
                schema: "agenda",
                columns: table => new
                {
                    regiaoid = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    usuarioaud = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    unidadeaud = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    grupoaud = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    version = table.Column<int>(type: "integer", nullable: true, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("regiao_pkey", x => x.regiaoid);
                });

            migrationBuilder.CreateTable(
                name: "regiaourbana",
                columns: table => new
                {
                    regiaourbanaid = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "character varying", nullable: false),
                    usuarioaud = table.Column<int>(type: "integer", nullable: true, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    grupoaud = table.Column<int>(type: "integer", nullable: true, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    version = table.Column<int>(type: "integer", nullable: true, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    unidadeaud = table.Column<int>(type: "integer", nullable: true, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
                },
                constraints: table =>
                {
                    table.PrimaryKey("regiaourbana_pkey", x => x.regiaourbanaid);
                });

            migrationBuilder.CreateTable(
                name: "regiaourbana",
                schema: "sisobra",
                columns: table => new
                {
                    regiaourbanaid = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Código] \r\nforminputsize[7]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Código] \r\ncolumngridtype[ro] \r\ncolumngridsize[80] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "character varying", nullable: false, comment: "forminputlabel[Nome] \r\nforminputsize[70]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Nome] \r\ncolumngridtype[ro] \r\ncolumngridsize[*] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]"),
                    usuarioaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    grupoaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    unidadeaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    version = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
                },
                constraints: table =>
                {
                    table.PrimaryKey("regiaourbana_pkey", x => x.regiaourbanaid);
                },
                comment: "template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Região Urbana]\r\nfiltersgrid[#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Regiões Urbanas]");

            migrationBuilder.CreateTable(
                name: "relatorio",
                schema: "divulgacao",
                columns: table => new
                {
                    relatorioid = table.Column<int>(type: "integer", nullable: true),
                    ordem = table.Column<int>(type: "integer", nullable: true),
                    regiaoimo = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    bairroimo = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    parcelamentoimo = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    numeroautorizacao = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: true),
                    nomeempresa = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    dataexpedicao = table.Column<DateOnly>(type: "date", nullable: true),
                    prazo = table.Column<DateOnly>(type: "date", nullable: true),
                    tipodivulgacao = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    enderecoempresa = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    enderecoimobiliaria = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    usuarioaud = table.Column<int>(type: "integer", nullable: true),
                    grupoaud = table.Column<int>(type: "integer", nullable: true),
                    unidadeaud = table.Column<int>(type: "integer", nullable: true),
                    version = table.Column<int>(type: "integer", nullable: true),
                    inscricaoimobiliaria = table.Column<string>(type: "character varying(11)", maxLength: 11, nullable: true),
                    inscricaoeconomica = table.Column<string>(type: "character varying(11)", maxLength: 11, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "relobra",
                schema: "sisobra",
                columns: table => new
                {
                    anomes = table.Column<string>(type: "character varying", nullable: true),
                    nome = table.Column<string>(type: "character varying", nullable: true),
                    valorinvestimento = table.Column<decimal>(type: "numeric(30,2)", precision: 30, scale: 2, nullable: true),
                    tempo = table.Column<string>(type: "character varying", nullable: true),
                    total = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "revinfo",
                schema: "auditoria",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    timestamp = table.Column<long>(type: "bigint", nullable: false),
                    usuarioid = table.Column<int>(type: "integer", nullable: false),
                    datahoraalteracao = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    usuarionome = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("revinfo_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "situacao",
                schema: "agenda",
                columns: table => new
                {
                    situacaoid = table.Column<int>(type: "integer", nullable: false, defaultValueSql: "nextval(('\"agenda\".\"situacao_situacaoid_seq\"'::text)::regclass)", comment: "forminputlabel[Código] \r\nforminputsize[7]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Código] \r\ncolumngridtype[ro] \r\ncolumngridsize[80] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]"),
                    descricao = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: true, comment: "forminputlabel[Descricao] \r\nforminputsize[70]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Descricao] \r\ncolumngridtype[ro] \r\ncolumngridsize[*] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]"),
                    grupoaud = table.Column<int>(type: "integer", nullable: true, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    usuarioaud = table.Column<int>(type: "integer", nullable: true, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    unidadeaud = table.Column<int>(type: "integer", nullable: true, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    version = table.Column<int>(type: "integer", nullable: true, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
                },
                constraints: table =>
                {
                    table.PrimaryKey("situacao_pkey", x => x.situacaoid);
                },
                comment: "template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Situacao]\r\n\r\nfiltersgrid[#text_filter,#text_filter] \r\n\r\n\r\ngridtitle[Lista de Situacao]\r\n");

            migrationBuilder.CreateTable(
                name: "situacao",
                schema: "cartografia",
                columns: table => new
                {
                    situacaoid = table.Column<int>(type: "integer", nullable: false, comment: "Código da situação")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descricao = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, comment: "Descrição da situação")
                },
                constraints: table =>
                {
                    table.PrimaryKey("situacao_pkey", x => x.situacaoid);
                });

            migrationBuilder.CreateTable(
                name: "status",
                schema: "agenda",
                columns: table => new
                {
                    statusid = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Código]\r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descricao = table.Column<string>(type: "character varying(99)", maxLength: 99, nullable: true, comment: "forminputlabel[Descricao]\r\nforminputsize[15]\r\nforminputclass[required]\r\n\r\n"),
                    usuarioaud = table.Column<int>(type: "integer", nullable: true, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    grupoaud = table.Column<int>(type: "integer", nullable: true, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    unidadeaud = table.Column<int>(type: "integer", nullable: true, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    version = table.Column<int>(type: "integer", nullable: true, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
                },
                constraints: table =>
                {
                    table.PrimaryKey("status_pkey", x => x.statusid);
                },
                comment: "template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Status]\r\nfiltersgrid[#text_filter,#text_filter,#text_filter,#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Status]");

            migrationBuilder.CreateTable(
                name: "status",
                schema: "cartografia",
                columns: table => new
                {
                    statusid = table.Column<int>(type: "integer", nullable: false, comment: "Código do status")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descricao = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, comment: "Descrição do status")
                },
                constraints: table =>
                {
                    table.PrimaryKey("status_pkey", x => x.statusid);
                },
                comment: "Status do projeto");

            migrationBuilder.CreateTable(
                name: "status",
                schema: "sisobra",
                columns: table => new
                {
                    statusid = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Código] \r\nforminputsize[7]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Código] \r\ncolumngridtype[ro] \r\ncolumngridsize[80] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "character varying", nullable: false, comment: "forminputlabel[Nome] \r\nforminputsize[70]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Nome] \r\ncolumngridtype[ro] \r\ncolumngridsize[*] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]"),
                    usuarioaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    grupoaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    unidadeaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    version = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    orderna = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("status_pkey", x => x.statusid);
                },
                comment: "template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Status]\r\nfiltersgrid[#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Status]");

            migrationBuilder.CreateTable(
                name: "tema",
                columns: table => new
                {
                    temaid = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Código] forminputsize[7]  columngridid[] columngridtitle[Código] columngridtype[ro] columngridsize[80] columngridalign[left] columngridcolor[white]")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false, comment: "forminputlabel[Nome] forminputsize[50]  columngridid[] columngridtitle[Nome] columngridtype[ro] columngridsize[*] columngridalign[left] columngridcolor[white]"),
                    url = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false, comment: "forminputlabel[URL] forminputsize[50]  columngridid[] columngridtitle[URL] columngridtype[ro] columngridsize[*] columngridalign[left] columngridcolor[white]"),
                    usuarioaud = table.Column<int>(type: "integer", nullable: true),
                    grupoaud = table.Column<int>(type: "integer", nullable: true),
                    version = table.Column<int>(type: "integer", nullable: true),
                    unidadeaud = table.Column<int>(type: "integer", nullable: true, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("tema_pk", x => x.temaid);
                },
                comment: "template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]  \r\n\r\nformtitle[Cadastro de Tema]   \r\nfieldsgrid[temaid,nome,url:temaid] \r\nfieldsform[temaid,nome,url] \r\n\r\ngridtitle[Lista de Temas]");

            migrationBuilder.CreateTable(
                name: "Teste",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Descricao = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teste", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TesteOld",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Descricao = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TesteOld", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tipoarquivo",
                schema: "agenda",
                columns: table => new
                {
                    tipoarquivoid = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "character varying", nullable: true),
                    grupoaud = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    usuarioaud = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    unidadeaud = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    version = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    extension = table.Column<string>(type: "character varying(5)", maxLength: 5, nullable: true),
                    contenttype = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true),
                    ativo = table.Column<int>(type: "integer", nullable: true, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("tipoarquivo_pkey", x => x.tipoarquivoid);
                });

            migrationBuilder.CreateTable(
                name: "tipoarquivo",
                schema: "cartografia",
                columns: table => new
                {
                    tipoarquivoid = table.Column<int>(type: "integer", nullable: false, comment: "Código do tipo de arquivo")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descricao = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false, comment: "Descricao do tipo"),
                    extensao = table.Column<string>(type: "character varying(5)", maxLength: 5, nullable: true, comment: "Extensão do arquivo")
                },
                constraints: table =>
                {
                    table.PrimaryKey("tipoarquivo_pkey", x => x.tipoarquivoid);
                });

            migrationBuilder.CreateTable(
                name: "tipocontrole",
                schema: "sisobra",
                columns: table => new
                {
                    tipocontroleid = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Código] \r\nforminputsize[7]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Código] \r\ncolumngridtype[ro] \r\ncolumngridsize[80] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "character varying", nullable: false, comment: "forminputlabel[Nome] \r\nforminputsize[70]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Nome] \r\ncolumngridtype[ro] \r\ncolumngridsize[*] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]"),
                    usuarioaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    grupoaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    unidadeaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    version = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
                },
                constraints: table =>
                {
                    table.PrimaryKey("tipocontrole_pkey", x => x.tipocontroleid);
                },
                comment: "template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Tipo de Controle]\r\nfiltersgrid[#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Tipos de Controle]");

            migrationBuilder.CreateTable(
                name: "tipologradouro",
                columns: table => new
                {
                    tipologradouroid = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "character varying", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("tipologradouro_pkey", x => x.tipologradouroid);
                });

            migrationBuilder.CreateTable(
                name: "tipomandato",
                schema: "sisobra",
                columns: table => new
                {
                    tipomandatoid = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Código] \r\nforminputsize[7]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Código] \r\ncolumngridtype[ro] \r\ncolumngridsize[80] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "character varying", nullable: false, comment: "forminputlabel[Nome] \r\nforminputsize[70]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Nome] \r\ncolumngridtype[ro] \r\ncolumngridsize[*] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]"),
                    usuarioaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    grupoaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    unidadeaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    version = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
                },
                constraints: table =>
                {
                    table.PrimaryKey("tipomandato_pkey", x => x.tipomandatoid);
                },
                comment: "template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Tipo-Mandato]\r\nfiltersgrid[#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Tipos de Mandato]");

            migrationBuilder.CreateTable(
                name: "tipounidade",
                columns: table => new
                {
                    tipounidadeid = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Código]\r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "character varying(80)", maxLength: 80, nullable: true, comment: "forminputlabel[Nome]\r\nforminputsize[60]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Nome]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    version = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    unidadeaud = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    usuarioaud = table.Column<int>(type: "integer", nullable: true),
                    grupoaud = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("tipounidade_pkey", x => x.tipounidadeid);
                },
                comment: "template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Tipo de Unidade] \r\n\r\nfieldsgrid[tipounidadeid,nome:tipounidadeid]\r\nfiltersgrid[#text_filter,#text_filter] \r\n\r\nfieldsform[tipounidadeid,nome]\r\n\r\ngridtitle[Lista de Tipos de Unidades]");

            migrationBuilder.CreateTable(
                name: "tipoveiculodivulgacao",
                schema: "divulgacao",
                columns: table => new
                {
                    tipoveiculodivulgacaoid = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Código]\r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "character varying", nullable: false, comment: "forminputlabel[Nome]\r\nforminputsize[50]\r\nforminputclass[uppercase]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Nome]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    lei = table.Column<string>(type: "character varying", nullable: true, comment: "forminputlabel[Lei]\r\nforminputsize[20]\r\nforminputclass[uppercase]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Lei]\r\ncolumngridtype[ro]\r\ncolumngridsize[130]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    usuarioaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    grupoaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    unidadeaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    version = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
                },
                constraints: table =>
                {
                    table.PrimaryKey("tipoveiculodivulgacao_pkey", x => x.tipoveiculodivulgacaoid);
                },
                comment: "template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Tipo Veículo de Divulgação]\r\nfiltersgrid[#text_filter,#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Tipos de Veículos de Divulgação]");

            migrationBuilder.CreateTable(
                name: "tmpbairroregiao",
                columns: table => new
                {
                    tmpbairroregiaoid = table.Column<int>(type: "integer", nullable: false),
                    parcelamento = table.Column<string>(type: "character varying", nullable: true),
                    bairro = table.Column<string>(type: "character varying", nullable: true),
                    bairroid = table.Column<int>(type: "integer", nullable: true),
                    regiao = table.Column<string>(type: "character varying", nullable: true),
                    regiaoid = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("tmpbairroregiao_pkey", x => x.tmpbairroregiaoid);
                });

            migrationBuilder.CreateTable(
                name: "tmpproc",
                schema: "agenda",
                columns: table => new
                {
                    tmpprocid = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    processo = table.Column<string>(type: "character varying", nullable: true),
                    inscricao = table.Column<string>(type: "character varying", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("tmpproc_pkey", x => x.tmpprocid);
                });

            migrationBuilder.CreateTable(
                name: "transportador",
                schema: "agenda",
                columns: table => new
                {
                    transportadorid = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Código]\r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false, comment: "forminputlabel[Nome]\r\nforminputsize[50]\r\nforminputclass[uppercase]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Nome]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    endereco = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false, comment: "forminputlabel[Endereço]\r\nforminputsize[30]\r\nforminputclass[uppercase]\r\n\r\ngeragridmain[false]"),
                    telefone = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, comment: "forminputlabel[Telefone]\r\nforminputsize[12]\r\nforminputclass[phone]\r\n\r\ngeragridmain[false]"),
                    cadmunicipal = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, comment: "forminputlabel[Cadastro Municipal]\r\nforminputsize[20]\r\nforminputclass[number]\r\n\r\ngeragridmain[false]"),
                    usuarioaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    grupoaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    version = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    unidadeaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    datavalidade = table.Column<DateOnly>(type: "date", nullable: true),
                    datacadastro = table.Column<DateOnly>(type: "date", nullable: true),
                    ativo = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    rua = table.Column<string>(type: "character varying", nullable: true),
                    cep = table.Column<string>(type: "character varying", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("transportador_pkey", x => x.transportadorid);
                },
                comment: "template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Transportador]\r\nfiltersgrid[#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Transportadores]");

            migrationBuilder.CreateTable(
                name: "transportadora",
                schema: "residuos",
                columns: table => new
                {
                    transportadoraid = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Código]\r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "character varying", nullable: false, comment: "forminputlabel[Nome]\r\nforminputsize[50]\r\nforminputclass[uppercase]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Nome]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    cnpj = table.Column<string>(type: "character varying", nullable: false, comment: "forminputlabel[CNPJ]\r\nforminputsize[10]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[CNPJ]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    responsavel = table.Column<string>(type: "character varying", nullable: false, comment: "forminputlabel[Responsável]\r\nforminputsize[20]\r\nforminputclass[uppercase]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Responsável]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    telefone = table.Column<string>(type: "character varying", nullable: false, comment: "forminputlabel[Telefone]\r\nforminputsize[12]\r\nforminputclass[phone]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Telefone]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    inscricaomunicipal = table.Column<string>(type: "character varying", nullable: true),
                    usuarioaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]"),
                    grupoaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]"),
                    unidadeaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]"),
                    version = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]"),
                    ativo = table.Column<int>(type: "integer", nullable: true),
                    senha = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    numero = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    complemento = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    cep = table.Column<string>(type: "character varying(8)", maxLength: 8, nullable: true),
                    bairro = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    rua = table.Column<string>(type: "character varying", nullable: true),
                    licencaambiental = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    validadelicenca = table.Column<DateOnly>(type: "date", nullable: true),
                    usuario = table.Column<int>(type: "integer", nullable: true),
                    datacadastro = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    email = table.Column<string>(type: "character varying", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("transportadora_pkey", x => x.transportadoraid);
                },
                comment: "template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs]\r\n\r\nformtitle[Cadastro de Transportadora]\r\nfiltersgrid[#text_filter,#text_filter,#text_filter,#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Transportadoras]");

            migrationBuilder.CreateTable(
                name: "unidade",
                schema: "residuos",
                columns: table => new
                {
                    unidadeid = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Código]\r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "character varying", nullable: false, comment: "forminputlabel[Nome]\r\nforminputsize[50]\r\nforminputclass[uppercase]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Nome]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    usuarioaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]"),
                    grupoaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]"),
                    unidadeaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]"),
                    version = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]")
                },
                constraints: table =>
                {
                    table.PrimaryKey("unidade_pkey", x => x.unidadeid);
                },
                comment: "template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs]\r\n\r\nformtitle[Cadastro de Unidade]\r\nfiltersgrid[#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Unidades]");

            migrationBuilder.CreateTable(
                name: "usuario",
                columns: table => new
                {
                    usuarioid = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Código] \r\nforminputsize[7]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Código] \r\ncolumngridtype[ro] \r\ncolumngridsize[80] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false, comment: "forminputlabel[Nome] \r\nforminputsize[50]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Nome] \r\ncolumngridtype[ro] \r\ncolumngridsize[*] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]"),
                    login = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, comment: "forminputlabel[Login]\r\nforminputsize[20]"),
                    senha = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, comment: "forminputlabel[Senha]\r\nforminputsize[20]"),
                    usuarioaud = table.Column<int>(type: "integer", nullable: true),
                    grupoaud = table.Column<int>(type: "integer", nullable: true),
                    version = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    unidadeaud = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    email = table.Column<string>(type: "character varying", nullable: true),
                    tipocredid = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("usuario_pk", x => x.usuarioid);
                },
                comment: "template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]  \r\n\r\nformtitle[Cadastro de Usuários]   \r\nfieldsgrid[usuarioid,nome,login,senha:usuarioid] \r\nfieldsform[usuarioid,nome,login,senha] \r\n\r\ngridtitle[Lista de Usuários]");

            migrationBuilder.CreateTable(
                name: "zoneamento",
                schema: "agenda",
                columns: table => new
                {
                    zoneamentoid = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "character varying", nullable: true),
                    taxa = table.Column<decimal>(type: "numeric(10,2)", precision: 10, scale: 2, nullable: true, defaultValueSql: "0"),
                    usuarioaud = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    unidadeaud = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    grupoaud = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    version = table.Column<int>(type: "integer", nullable: true, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("zoneamento_pkey", x => x.zoneamentoid);
                });

            migrationBuilder.CreateTable(
                name: "residuo",
                schema: "agenda",
                columns: table => new
                {
                    residuoid = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Código]\r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false, comment: "forminputlabel[Nome]\r\nforminputsize[50]\r\nforminputclass[uppercase]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Nome]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    classe = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Classe]\r\nforminputsize[180]\r\n\r\nsearchmode[combobox]\r\ncomboboxresultfield[classe.nome]\r\n\r\ncolumngridid[classe.nome]\r\ncolumngridtitle[Classe]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    reutilizacao = table.Column<int>(type: "integer", nullable: true, comment: "0-Sim / 1-Não\r\n\r\nforminputlabel[Reutilização]\r\nforminputsize[30]\r\nforminputclass[required]\r\n\r\ngeragridmain[false]"),
                    usuarioaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    grupoaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    version = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    unidadeaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
                },
                constraints: table =>
                {
                    table.PrimaryKey("residuo_pkey", x => x.residuoid);
                    table.ForeignKey(
                        name: "residuo_fk",
                        column: x => x.classe,
                        principalSchema: "agenda",
                        principalTable: "classe",
                        principalColumn: "classeid");
                },
                comment: "template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Resíduo]\r\nfiltersgrid[#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Resíduos]");

            migrationBuilder.CreateTable(
                name: "empresaresiduo",
                schema: "residuos",
                columns: table => new
                {
                    empresaresiduoid = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Código]\r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    empresa = table.Column<int>(type: "integer", nullable: false),
                    residuo = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Resíduo]\r\nforminputsize[30]\r\nforminputclass[uppercase]\r\n\r\nsearchmode[popup]\r\npopupresultfield[nome]\r\npopupfieldsgrid[residuoid,nome:residuoid]\r\n\r\ncolumngridid[residuo.nome]\r\ncolumngridtitle[Resíduo]\r\ncolumngridtype[ro]\r\ncolumngridsize[150]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    armazenamento = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Armazenamento]\r\nforminputsize[150]\r\n\r\nsearchmode[combobox]\r\ncomboboxresultfield[armazenamento.nome]\r\n\r\ncolumngridid[armazenamento.nome]\r\ncolumngridtitle[Armazenamento]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    usuarioaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]"),
                    grupoaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]"),
                    unidadeaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]"),
                    version = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]")
                },
                constraints: table =>
                {
                    table.PrimaryKey("empresaresiduo_pkey", x => x.empresaresiduoid);
                    table.ForeignKey(
                        name: "empresaresiduo_fk",
                        column: x => x.empresa,
                        principalSchema: "residuos",
                        principalTable: "empresa",
                        principalColumn: "empresaid");
                    table.ForeignKey(
                        name: "empresaresiduo_fk1",
                        column: x => x.armazenamento,
                        principalSchema: "residuos",
                        principalTable: "armazenamento",
                        principalColumn: "armazenamentoid");
                },
                comment: "template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs]\r\n\r\nformtitle[Cadastro de Resíduo da Empresa]\r\nfiltersgrid[#text_filter,#text_filter,#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Resíduos da Empresa]");

            migrationBuilder.CreateTable(
                name: "pessoa",
                columns: table => new
                {
                    pessoaid = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "character varying", nullable: true),
                    sobrenome = table.Column<string>(type: "character varying", nullable: true),
                    email = table.Column<string>(type: "character varying", nullable: true),
                    rg = table.Column<string>(type: "character varying", nullable: true),
                    cpf = table.Column<string>(type: "character varying", nullable: true),
                    telefone = table.Column<string>(type: "character varying", nullable: true),
                    endereco = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pessoa_pkey", x => x.pessoaid);
                    table.ForeignKey(
                        name: "pessoa_fk",
                        column: x => x.endereco,
                        principalTable: "endereco",
                        principalColumn: "enderecoid");
                });

            migrationBuilder.CreateTable(
                name: "residuo",
                schema: "residuos",
                columns: table => new
                {
                    residuoid = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Código]\r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "character varying", nullable: false, comment: "forminputlabel[Nome]\r\nforminputsize[50]\r\nforminputclass[uppercase]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Nome]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    obs = table.Column<string>(type: "character varying", nullable: true, comment: "forminputlabel[Observação]\r\nforminputsize[50]\r\nforminputclass[uppercase]\r\n\r\ngeragridmain[false]"),
                    estadofisico = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Estado Físico]\r\nforminputsize[150]\r\n\r\nsearchmode[combobox]\r\ncomboboxresultfield[estadofisico.nome]\r\n\r\ncolumngridid[estadofisico.nome]\r\ncolumngridtitle[Estado Físico]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    usuarioaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]"),
                    grupoaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]"),
                    unidadeaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]"),
                    version = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]"),
                    classificacao = table.Column<int>(type: "integer", nullable: true),
                    caracteristica = table.Column<int>(type: "integer", nullable: true),
                    numeroonu = table.Column<int>(type: "integer", nullable: true),
                    numerorisco = table.Column<int>(type: "integer", nullable: true),
                    armazenamento = table.Column<int>(type: "integer", nullable: true),
                    codigo = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    autotransporte = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("residuo_pkey", x => x.residuoid);
                    table.ForeignKey(
                        name: "residuo_fk",
                        column: x => x.estadofisico,
                        principalSchema: "residuos",
                        principalTable: "estadofisico",
                        principalColumn: "estadofisicoid");
                    table.ForeignKey(
                        name: "residuo_fk1",
                        column: x => x.classificacao,
                        principalSchema: "residuos",
                        principalTable: "classificacao",
                        principalColumn: "classificacaoid");
                    table.ForeignKey(
                        name: "residuo_fk2",
                        column: x => x.caracteristica,
                        principalSchema: "residuos",
                        principalTable: "caracteristica",
                        principalColumn: "caracteristicaid");
                    table.ForeignKey(
                        name: "residuo_fk3",
                        column: x => x.armazenamento,
                        principalSchema: "residuos",
                        principalTable: "armazenamento",
                        principalColumn: "armazenamentoid");
                },
                comment: "template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs]\r\n\r\nformtitle[Cadastro de Resíduo]\r\nfiltersgrid[#text_filter,#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Resíduos]");

            migrationBuilder.CreateTable(
                name: "requerimento",
                schema: "planurb",
                columns: table => new
                {
                    requerimentoid = table.Column<int>(type: "integer", nullable: false, comment: "Código do requerimento")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    profissional = table.Column<int>(type: "integer", nullable: false, comment: "Profissional requerente"),
                    proprietario = table.Column<string>(type: "character varying", nullable: false, comment: "Proprietário requerente"),
                    telproprietario = table.Column<string>(type: "character varying", nullable: true, comment: "Telefone do proprietário"),
                    tiporequerimento = table.Column<string>(type: "character varying(5)", maxLength: 5, nullable: false, comment: "Tipo do requerimento: GDU GDR GUIV"),
                    datacadastro = table.Column<DateTime>(type: "timestamp without time zone", nullable: true, defaultValueSql: "now()", comment: "Data de cadastro do requerimento"),
                    endereco = table.Column<string>(type: "character varying", nullable: true, comment: "Localização, endereço ou proximidade (exato ou aproximada)"),
                    tipoatividade = table.Column<int>(type: "integer", nullable: true, comment: "Tipo de atividade/Empreendimento")
                },
                constraints: table =>
                {
                    table.PrimaryKey("requerimento_pkey", x => x.requerimentoid);
                    table.ForeignKey(
                        name: "requerimento_fk",
                        column: x => x.profissional,
                        principalSchema: "planurb",
                        principalTable: "profissional",
                        principalColumn: "profissionalid");
                });

            migrationBuilder.CreateTable(
                name: "bairro",
                columns: table => new
                {
                    bairroid = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Código] \r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    estado = table.Column<string>(type: "character varying(2)", maxLength: 2, nullable: true),
                    cidade = table.Column<int>(type: "integer", nullable: true),
                    nome = table.Column<string>(type: "character varying", nullable: true, comment: "forminputlabel[Nome]\r\nforminputsize[70]\r\nforminputclass[uppercase]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Nome]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    abreviatura = table.Column<string>(type: "character varying", nullable: true),
                    usuarioaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    grupoaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    version = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    unidadeaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    regiaourbana = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("bairro_pkey", x => x.bairroid);
                    table.ForeignKey(
                        name: "bairro_fk1",
                        column: x => x.regiaourbana,
                        principalTable: "regiaourbana",
                        principalColumn: "regiaourbanaid");
                },
                comment: "template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs]\r\n\r\nformtitle[Cadastro de Bairros]\r\n\r\nfiltersgrid[#text_filter,#text_filter]\r\ngridtitle[Lista de Bairros]");

            migrationBuilder.CreateTable(
                name: "bairro",
                schema: "sisobra",
                columns: table => new
                {
                    bairroid = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Código] \r\nforminputsize[7]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Código] \r\ncolumngridtype[ro] \r\ncolumngridsize[80] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "character varying", nullable: false, comment: "forminputlabel[Nome] \r\nforminputsize[70]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Nome] \r\ncolumngridtype[ro] \r\ncolumngridsize[*] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]"),
                    usuarioaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    grupoaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    unidadeaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    version = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    regiaourbana = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Região Urbana] \r\nforminputsize[100]\r\n\r\nsearchmode[popup] \r\npopupresultfield[regiaourbana.nome]\r\npopupfieldsgrid[regiaourbanaid,nome]\r\n\r\ncolumngridid[] \r\ncolumngridtitle[Região Urbana] \r\ncolumngridtype[ro] \r\ncolumngridsize[100] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
                },
                constraints: table =>
                {
                    table.PrimaryKey("bairro_pkey", x => x.bairroid);
                    table.ForeignKey(
                        name: "bairro_fk",
                        column: x => x.regiaourbana,
                        principalSchema: "sisobra",
                        principalTable: "regiaourbana",
                        principalColumn: "regiaourbanaid");
                },
                comment: "template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Bairro]\r\nfiltersgrid[#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Bairros]");

            migrationBuilder.CreateTable(
                name: "residuos_areareceptora",
                schema: "auditoria",
                columns: table => new
                {
                    areareceptoraid = table.Column<int>(type: "integer", nullable: false),
                    rev = table.Column<int>(type: "integer", nullable: false),
                    revtype = table.Column<short>(type: "smallint", nullable: true),
                    codigo = table.Column<int>(type: "integer", nullable: true),
                    inscricaomunicipal = table.Column<double>(type: "double precision", nullable: true),
                    nome = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    situacao = table.Column<int>(type: "integer", nullable: true),
                    telefone = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    complemento = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    cep = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    numero = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    rua = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    bairro = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    licencaambiental = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    validadelicenca = table.Column<DateOnly>(type: "date", nullable: true),
                    empresa = table.Column<int>(type: "integer", nullable: true),
                    transportadora = table.Column<int>(type: "integer", nullable: true),
                    senha = table.Column<string>(type: "character varying", nullable: true),
                    usuario = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("residuos_areareceptora_pkey", x => new { x.areareceptoraid, x.rev });
                    table.ForeignKey(
                        name: "fk311a9ab777f68f91",
                        column: x => x.rev,
                        principalSchema: "auditoria",
                        principalTable: "revinfo",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "residuos_armazenamento",
                schema: "auditoria",
                columns: table => new
                {
                    armazenamentoid = table.Column<int>(type: "integer", nullable: false),
                    rev = table.Column<int>(type: "integer", nullable: false),
                    revtype = table.Column<short>(type: "smallint", nullable: true),
                    nome = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("residuos_armazenamento_pkey", x => new { x.armazenamentoid, x.rev });
                    table.ForeignKey(
                        name: "fkb943b68d77f68f91",
                        column: x => x.rev,
                        principalSchema: "auditoria",
                        principalTable: "revinfo",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "residuos_ctr",
                schema: "auditoria",
                columns: table => new
                {
                    ctrid = table.Column<int>(type: "integer", nullable: false),
                    rev = table.Column<int>(type: "integer", nullable: false),
                    revtype = table.Column<short>(type: "smallint", nullable: true),
                    datahoracadastro = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    datahoraentrega = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    placaveiculo = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    quantidade = table.Column<double>(type: "double precision", nullable: true),
                    responsavel = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    situacao = table.Column<int>(type: "integer", nullable: true),
                    transportadorasiat = table.Column<double>(type: "double precision", nullable: true),
                    areareceptora = table.Column<int>(type: "integer", nullable: true),
                    armazenamento = table.Column<int>(type: "integer", nullable: true),
                    empresa = table.Column<int>(type: "integer", nullable: true),
                    residuo = table.Column<int>(type: "integer", nullable: true),
                    transportadora = table.Column<int>(type: "integer", nullable: true),
                    unidade = table.Column<int>(type: "integer", nullable: true),
                    nomecondutor = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    obsdestfinal = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    areareceptora2 = table.Column<int>(type: "integer", nullable: true),
                    obsdestfinal2 = table.Column<string>(type: "character varying", nullable: true),
                    autotransporte = table.Column<int>(type: "integer", nullable: true),
                    numeromanifesto = table.Column<int>(type: "integer", nullable: true),
                    codigobaixa = table.Column<int>(type: "integer", nullable: true),
                    datahoratransportadora = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    datahoradesfinal = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    datahorancertificado = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    datahorafinalizado = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("residuos_ctr_pkey", x => new { x.ctrid, x.rev });
                    table.ForeignKey(
                        name: "fk3d7f4be077f68f91",
                        column: x => x.rev,
                        principalSchema: "auditoria",
                        principalTable: "revinfo",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "residuos_ctrresiduo",
                schema: "auditoria",
                columns: table => new
                {
                    ctrresiduoid = table.Column<int>(type: "integer", nullable: false),
                    rev = table.Column<int>(type: "integer", nullable: false),
                    revtype = table.Column<short>(type: "smallint", nullable: true),
                    ctr = table.Column<int>(type: "integer", nullable: true),
                    residuo = table.Column<int>(type: "integer", nullable: true),
                    qtde = table.Column<int>(type: "integer", nullable: true),
                    unidade = table.Column<int>(type: "integer", nullable: true),
                    qtdetrans = table.Column<int>(type: "integer", nullable: true),
                    unidadetrans = table.Column<int>(type: "integer", nullable: true),
                    codigobaixa = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    numeromanifesto = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("residuos_ctrresiduo_pkey", x => new { x.ctrresiduoid, x.rev });
                    table.ForeignKey(
                        name: "residuos_rev_fkey",
                        column: x => x.rev,
                        principalSchema: "auditoria",
                        principalTable: "revinfo",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "residuos_empresa",
                schema: "auditoria",
                columns: table => new
                {
                    empresaid = table.Column<int>(type: "integer", nullable: false),
                    rev = table.Column<int>(type: "integer", nullable: false),
                    revtype = table.Column<short>(type: "smallint", nullable: true),
                    datalicenciamento = table.Column<DateOnly>(type: "date", nullable: true),
                    datavenclicenciamento = table.Column<DateOnly>(type: "date", nullable: true),
                    inscricaomunicipal = table.Column<string>(type: "character varying", nullable: true),
                    numerolicenciamento = table.Column<int>(type: "integer", nullable: true),
                    senha = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    nome = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    inscricaoeconomica = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true),
                    usuario = table.Column<int>(type: "integer", nullable: true),
                    datacadastro = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    razaosocial = table.Column<string>(type: "character varying", nullable: true),
                    email = table.Column<string>(type: "character varying", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("residuos_empresa_pkey", x => new { x.empresaid, x.rev });
                    table.ForeignKey(
                        name: "fkf12a12c877f68f91",
                        column: x => x.rev,
                        principalSchema: "auditoria",
                        principalTable: "revinfo",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "residuos_estadofisico",
                schema: "auditoria",
                columns: table => new
                {
                    estadofisicoid = table.Column<int>(type: "integer", nullable: false),
                    rev = table.Column<int>(type: "integer", nullable: false),
                    revtype = table.Column<short>(type: "smallint", nullable: true),
                    nome = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("residuos_estadofisico_pkey", x => new { x.estadofisicoid, x.rev });
                    table.ForeignKey(
                        name: "fk8e9ca28c77f68f91",
                        column: x => x.rev,
                        principalSchema: "auditoria",
                        principalTable: "revinfo",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "residuos_residuo",
                schema: "auditoria",
                columns: table => new
                {
                    residuoid = table.Column<int>(type: "integer", nullable: false),
                    rev = table.Column<int>(type: "integer", nullable: false),
                    revtype = table.Column<short>(type: "smallint", nullable: true),
                    nome = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    obs = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    estadofisico = table.Column<int>(type: "integer", nullable: true),
                    classificacao = table.Column<int>(type: "integer", nullable: true),
                    caracteristica = table.Column<int>(type: "integer", nullable: true),
                    numeroonu = table.Column<int>(type: "integer", nullable: true),
                    numerorisco = table.Column<int>(type: "integer", nullable: true),
                    armazenamento = table.Column<int>(type: "integer", nullable: true),
                    codigo = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    autotransporte = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("residuos_residuo_pkey", x => new { x.residuoid, x.rev });
                    table.ForeignKey(
                        name: "fk935a7bd477f68f91",
                        column: x => x.rev,
                        principalSchema: "auditoria",
                        principalTable: "revinfo",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "residuos_transportadora",
                schema: "auditoria",
                columns: table => new
                {
                    transportadoraid = table.Column<int>(type: "integer", nullable: false),
                    rev = table.Column<int>(type: "integer", nullable: false),
                    revtype = table.Column<short>(type: "smallint", nullable: true),
                    cnpj = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    inscricaomunicipal = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    nome = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    responsavel = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    telefone = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    ativo = table.Column<int>(type: "integer", nullable: true),
                    senha = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    numero = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    complemento = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    cep = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    rua = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    bairro = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    licencaambiental = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    validadelicenca = table.Column<DateOnly>(type: "date", nullable: true),
                    usuario = table.Column<int>(type: "integer", nullable: true),
                    datacadastro = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    email = table.Column<string>(type: "character varying", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("residuos_transportadora_pkey", x => new { x.transportadoraid, x.rev });
                    table.ForeignKey(
                        name: "fkdc11f3377f68f91",
                        column: x => x.rev,
                        principalSchema: "auditoria",
                        principalTable: "revinfo",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "residuos_unidade",
                schema: "auditoria",
                columns: table => new
                {
                    unidadeid = table.Column<int>(type: "integer", nullable: false),
                    rev = table.Column<int>(type: "integer", nullable: false),
                    revtype = table.Column<short>(type: "smallint", nullable: true),
                    nome = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("residuos_unidade_pkey", x => new { x.unidadeid, x.rev });
                    table.ForeignKey(
                        name: "fk40d98ced77f68f91",
                        column: x => x.rev,
                        principalSchema: "auditoria",
                        principalTable: "revinfo",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "projeto",
                schema: "cartografia",
                columns: table => new
                {
                    projetoid = table.Column<int>(type: "integer", nullable: false, comment: "Código do projeto")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    datacadastro = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "now()", comment: "Data de cadastro"),
                    processo = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false, comment: "Número do processo"),
                    assunto = table.Column<int>(type: "integer", nullable: false, comment: "Assunto do projeto"),
                    status = table.Column<int>(type: "integer", nullable: false, comment: "Status do projeto"),
                    datahomologacao = table.Column<DateTime>(type: "timestamp without time zone", nullable: true, comment: "Data de aprovação(homologação)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("projeto_pkey", x => x.projetoid);
                    table.ForeignKey(
                        name: "projeto_fk",
                        column: x => x.status,
                        principalSchema: "cartografia",
                        principalTable: "status",
                        principalColumn: "statusid");
                    table.ForeignKey(
                        name: "projeto_fk1",
                        column: x => x.assunto,
                        principalSchema: "cartografia",
                        principalTable: "assunto",
                        principalColumn: "assuntoid");
                });

            migrationBuilder.CreateTable(
                name: "sistema",
                columns: table => new
                {
                    sistemaid = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Código] \r\nforminputsize[7]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Código] \r\ncolumngridtype[ro] \r\ncolumngridsize[80] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false, comment: "forminputlabel[Nome] \r\nforminputsize[50] \r\n \r\ncolumngridid[] \r\ncolumngridtitle[Nome] \r\ncolumngridtype[ro] \r\ncolumngridsize[*] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]"),
                    urlteste = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true, comment: "forminputlabel[URL de teste] \r\nforminputsize[50]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[URL de teste] \r\ncolumngridtype[ro] \r\ncolumngridsize[*] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]"),
                    urlproducao = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true, comment: "forminputlabel[URL de produção] \r\nforminputsize[50]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[URL de produção] \r\ncolumngridtype[ro] \r\ncolumngridsize[*] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]"),
                    emproducao = table.Column<int>(type: "integer", nullable: true, defaultValue: 0, comment: "forminputlabel[Em produção] \r\nforminputsize[50]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Em produção] \r\ncolumngridtype[ro] \r\ncolumngridsize[*] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]"),
                    manutencao = table.Column<int>(type: "integer", nullable: true, defaultValue: 0, comment: "forminputlabel[Em manutenção] \r\nforminputsize[50]"),
                    tema = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Tema]\r\nforminputsize[250]\r\n\r\nsearchmode[combobox]\r\ncomboboxresultfield[nome]\r\n\r\ngeragridmain[false]\r\n\r\ncolumngridid[tema.nome]\r\ncolumngridtitle[Tema]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    urlfooter = table.Column<int>(type: "integer", nullable: true, comment: "forminputlabel[URL footer] \r\nforminputsize[50]\r\n\r\ngeragridmain[false]"),
                    urlheader = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true, comment: "forminputlabel[URL header] \r\nforminputsize[50]\r\n\r\ngeragridmain[false]"),
                    urllogo = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true, comment: "forminputlabel[URL logo] \r\nforminputsize[50]\r\n\r\ngeragridmain[false]"),
                    urlmenuprincipal = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true, comment: "forminputlabel[URL Menu principal] \r\nforminputsize[50]\r\n\r\ngeragridmain[false]"),
                    usuariosonline = table.Column<int>(type: "integer", nullable: true, comment: "forminputlabel[Usuários online] \r\nforminputsize[50]\r\n\r\ngeragridmain[false]"),
                    versao = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false, comment: "forminputlabel[Versão] \r\nforminputsize[50] \r\n \r\ncolumngridid[] \r\ncolumngridtitle[Versão] \r\ncolumngridtype[ro] \r\ncolumngridsize[*] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]"),
                    usuarioaud = table.Column<int>(type: "integer", nullable: true),
                    grupoaud = table.Column<int>(type: "integer", nullable: true),
                    version = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    unidadeaud = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    restarttime = table.Column<DateTime>(type: "timestamp(0) without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("sistema_pk", x => x.sistemaid);
                    table.ForeignKey(
                        name: "tema_sistema_fk",
                        column: x => x.tema,
                        principalTable: "tema",
                        principalColumn: "temaid");
                },
                comment: "template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Sistema]\r\n\r\nfieldsgrid[sistemaid,nome,urlteste,urlproducao,emproducao,manutencao,versao:sistemaid]\r\nfiltersgrid[#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter]\r\n\r\nfieldsform[sistemaid,nome,urlteste,urlproducao,emproducao,manutencao,tema.temaid,tema.nome,urlfooter,urlheader,urllogo,urlmenuprincipal,usuariosonline,versao] \r\n \r\ngridtitle[Lista de Sistemas]");

            migrationBuilder.CreateTable(
                name: "arquivo",
                schema: "agenda",
                columns: table => new
                {
                    arquivoid = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    conteudo = table.Column<byte[]>(type: "bytea", nullable: true),
                    tipoarquivo = table.Column<int>(type: "integer", nullable: false),
                    grupoaud = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    usuarioaud = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    unidadeaud = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    version = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    caminho = table.Column<string>(type: "character varying", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("arquivo_pkey", x => x.arquivoid);
                    table.ForeignKey(
                        name: "arquivo_fk",
                        column: x => x.tipoarquivo,
                        principalSchema: "agenda",
                        principalTable: "tipoarquivo",
                        principalColumn: "tipoarquivoid");
                });

            migrationBuilder.CreateTable(
                name: "arquivo",
                schema: "cartografia",
                columns: table => new
                {
                    arquivoid = table.Column<int>(type: "integer", nullable: false, comment: "Código do arquivo")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    conteudo = table.Column<byte[]>(type: "bytea", nullable: true, comment: "Conteudo do arquivo"),
                    tipoarquivo = table.Column<int>(type: "integer", nullable: false, comment: "Tipo do arquivo")
                },
                constraints: table =>
                {
                    table.PrimaryKey("arquivo_pkey", x => x.arquivoid);
                    table.ForeignKey(
                        name: "arquivo_fk",
                        column: x => x.tipoarquivo,
                        principalSchema: "cartografia",
                        principalTable: "tipoarquivo",
                        principalColumn: "tipoarquivoid");
                });

            migrationBuilder.CreateTable(
                name: "parlamentar",
                schema: "sisobra",
                columns: table => new
                {
                    parlamentarid = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Código] \r\nforminputsize[7]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Código] \r\ncolumngridtype[ro] \r\ncolumngridsize[80] \r\ncolumngridalign[left] \r\ncolumngridcolor[]")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "character varying", nullable: false, comment: "forminputlabel[Nome] \r\nforminputsize[70]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Nome] \r\ncolumngridtype[ro] \r\ncolumngridsize[*] \r\ncolumngridalign[left] \r\ncolumngridcolor[]"),
                    status = table.Column<string>(type: "character varying(1)", maxLength: 1, nullable: false, defaultValueSql: "'I'::character varying", comment: "forminputlabel[Status] \r\nforminputsize[12]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Status] \r\ncolumngridtype[ro] \r\ncolumngridsize[20] \r\ncolumngridalign[left] \r\ncolumngridcolor[]"),
                    usuarioaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    grupoaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    unidadeaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    version = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    tipomandato = table.Column<int>(type: "integer", nullable: true, comment: "forminputlabel[Tipo Mandato]\r\nforminputsize[150]\r\n\r\nsearchmode[combobox]\r\ncomboboxresultfield[nome]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Tipo Mandato]\r\ncolumngridtype[ro]\r\ncolumngridsize[70]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
                },
                constraints: table =>
                {
                    table.PrimaryKey("parlamentar_pkey", x => x.parlamentarid);
                    table.ForeignKey(
                        name: "parlamentar_fk",
                        column: x => x.tipomandato,
                        principalSchema: "sisobra",
                        principalTable: "tipomandato",
                        principalColumn: "tipomandatoid");
                },
                comment: "template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Parlamentar]\r\nfiltersgrid[#text_filter,#text_filter,#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Parlamentares]");

            migrationBuilder.CreateTable(
                name: "unidade",
                columns: table => new
                {
                    unidadeid = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Código]\r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "character varying", nullable: true, comment: "forminputlabel[Nome]\r\nforminputsize[60]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Nome]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    tipounidade = table.Column<int>(type: "integer", nullable: true, comment: "forminputlabel[Tipo Unidade]\r\nforminputsize[250]\r\n\r\nsearchmode[combobox]\r\ncomboboxresultfield[nome]\r\n\r\ngeragridmain[false]\r\n"),
                    version = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    unidadeaud = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    usuarioaud = table.Column<int>(type: "integer", nullable: true),
                    grupoaud = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("unidade_pkey", x => x.unidadeid);
                    table.ForeignKey(
                        name: "unidade_fk",
                        column: x => x.tipounidade,
                        principalTable: "tipounidade",
                        principalColumn: "tipounidadeid");
                },
                comment: "template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Unidade] \r\n\r\nfieldsgrid[unidadeid,nome:unidadeid]\r\nfiltersgrid[#text_filter,#text_filter] \r\n\r\nfieldsform[unidadeid,nome]\r\n\r\ngridtitle[Lista de Unidades]");

            migrationBuilder.CreateTable(
                name: "certidao",
                schema: "divulgacao",
                columns: table => new
                {
                    certidaoid = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    numerocertidao = table.Column<int>(type: "integer", nullable: true),
                    ano = table.Column<int>(type: "integer", nullable: false),
                    tipoveiculodivulgacao = table.Column<int>(type: "integer", nullable: false),
                    inscricaoimobiliaria = table.Column<string>(type: "character varying", nullable: false),
                    inscricaoeconomica = table.Column<string>(type: "character varying", nullable: false),
                    cep = table.Column<int>(type: "integer", nullable: true),
                    regular = table.Column<int>(type: "integer", nullable: true),
                    dimensaox = table.Column<decimal>(type: "numeric(6,2)", precision: 6, scale: 2, nullable: true),
                    dimensaoy = table.Column<decimal>(type: "numeric(6,2)", precision: 6, scale: 2, nullable: true),
                    numeroprocesso = table.Column<string>(type: "character varying", nullable: true),
                    datacertidao = table.Column<DateOnly>(type: "date", nullable: false),
                    usuarioaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    grupoaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    unidadeaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    version = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    conger = table.Column<string>(type: "text", nullable: true, comment: "Condições Gerais"),
                    conesp = table.Column<string>(type: "text", nullable: true, comment: "Condições Específicas")
                },
                constraints: table =>
                {
                    table.PrimaryKey("ceridao_pkey", x => x.certidaoid);
                    table.ForeignKey(
                        name: "certidao_fk",
                        column: x => x.tipoveiculodivulgacao,
                        principalSchema: "divulgacao",
                        principalTable: "tipoveiculodivulgacao",
                        principalColumn: "tipoveiculodivulgacaoid");
                });

            migrationBuilder.CreateTable(
                name: "certidaoconformidade",
                schema: "divulgacao",
                columns: table => new
                {
                    certidaoconid = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    numerocertidaocon = table.Column<int>(type: "integer", nullable: false),
                    ano = table.Column<int>(type: "integer", nullable: false),
                    tipoveiculodivulgacao = table.Column<int>(type: "integer", nullable: false),
                    inscricaoimobiliaria = table.Column<string>(type: "character varying", nullable: false),
                    cep = table.Column<int>(type: "integer", nullable: true),
                    numeroprocesso = table.Column<string>(type: "character varying", nullable: true),
                    datacertidao = table.Column<DateOnly>(type: "date", nullable: false),
                    usuarioaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    grupoaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    unidadeaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    version = table.Column<int>(type: "integer", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("certidaoconformidade_pkey", x => x.certidaoconid);
                    table.ForeignKey(
                        name: "certidaoconformidade_fk",
                        column: x => x.tipoveiculodivulgacao,
                        principalSchema: "divulgacao",
                        principalTable: "tipoveiculodivulgacao",
                        principalColumn: "tipoveiculodivulgacaoid");
                });

            migrationBuilder.CreateTable(
                name: "extrato",
                schema: "divulgacao",
                columns: table => new
                {
                    extratoid = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    numeroextrato = table.Column<int>(type: "integer", nullable: false),
                    ano = table.Column<int>(type: "integer", nullable: false),
                    inscricaoeconomica = table.Column<string>(type: "character varying", nullable: true, comment: "Empresa - Requerente"),
                    inscricaoimobiliaria = table.Column<string>(type: "character varying", nullable: true, comment: "Localidade pela inscrição imobiliária"),
                    tipoveiculodivulgacao = table.Column<int>(type: "integer", nullable: false, comment: "Tipo de Veiculo de Divulgação"),
                    processo = table.Column<string>(type: "character varying", nullable: true, comment: "Processo"),
                    dataprocesso = table.Column<DateOnly>(type: "date", nullable: true, comment: "Data do Processo"),
                    tipoanalise = table.Column<int>(type: "integer", nullable: true, comment: "1-Autorização Definitiva\r\n2-Uso nao Conforme"),
                    usuarioaud = table.Column<int>(type: "integer", nullable: false),
                    grupoaud = table.Column<int>(type: "integer", nullable: false),
                    unidadeaud = table.Column<int>(type: "integer", nullable: false),
                    version = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("extrato_pkey", x => x.extratoid);
                    table.ForeignKey(
                        name: "extrato_fk",
                        column: x => x.tipoveiculodivulgacao,
                        principalSchema: "divulgacao",
                        principalTable: "tipoveiculodivulgacao",
                        principalColumn: "tipoveiculodivulgacaoid");
                });

            migrationBuilder.CreateTable(
                name: "veiculodivulgacao",
                schema: "divulgacao",
                columns: table => new
                {
                    veiculodivulgacaoid = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Código]\r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    tipoveiculodivulgacao = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Tipo Veículo Divulgação]\r\nforminputsize[250]\r\n\r\nsearchmode[combobox]\r\ncomboboxresultfield[tipoveiculodivulgacao.nome]\r\n\r\ncolumngridid[tipoveiculodivulgacao.nome]\r\ncolumngridtitle[Tipo Veículo Divulgação]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    ocorrencia = table.Column<int>(type: "integer", nullable: true),
                    inscricaoimobiliaria = table.Column<string>(type: "character varying", nullable: false, comment: "forminputlabel[Insc. Imobiliária]\r\nforminputsize[15]\r\nforminputclass[required]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Insc. Imobiliária]\r\ncolumngridtype[ro]\r\ncolumngridsize[120]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    inscricaoeconomica = table.Column<string>(type: "character varying", nullable: false, comment: "forminputlabel[Insc. Econômica]\r\nforminputsize[15]\r\nforminputclass[required]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Insc. Econômica]\r\ncolumngridtype[ro]\r\ncolumngridsize[120]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    regular = table.Column<int>(type: "integer", nullable: true, comment: "1 - SIM\n2 - NÃO"),
                    dimensaox = table.Column<decimal>(type: "numeric(6,2)", precision: 6, scale: 2, nullable: true),
                    dimensaoy = table.Column<decimal>(type: "numeric(6,2)", precision: 6, scale: 2, nullable: true),
                    idarquivodivulgacao = table.Column<int>(type: "integer", nullable: true, comment: "ID do arquivo localizado no banco 10.0.0.148 - SADWEB.arqanx"),
                    cep = table.Column<int>(type: "integer", nullable: true, comment: "forminputlabel[CEP]\r\nforminputsize[10]\r\nforminputclass[number]\r\n\r\ngeragridmain[false]"),
                    numeroprocesso = table.Column<string>(type: "character varying", nullable: true, comment: "forminputlabel[N&ordm; Processo]\r\nforminputsize[15]\r\nforminputclass[required]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[N&ordm; Processo]\r\ncolumngridtype[ro]\r\ncolumngridsize[120]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    numeroautorizacao = table.Column<string>(type: "character varying", nullable: true, comment: "forminputlabel[N&ordm; Autorização]\r\nforminputsize[15]\r\nforminputclass[required]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[N&ordm; Autorização]\r\ncolumngridtype[ro]\r\ncolumngridsize[120]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    datacadastro = table.Column<DateOnly>(type: "date", nullable: false, comment: "forminputlabel[Data-Cadastro]\r\nforminputsize[12]\r\nforminputclass[data]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Data-Cadastro]\r\ncolumngridtype[ro]\r\ncolumngridsize[110]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    dataprazo = table.Column<DateOnly>(type: "date", nullable: false, comment: "forminputlabel[Data-Prazo]\r\nforminputsize[12]\r\nforminputclass[data]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Data-Prazo]\r\ncolumngridtype[ro]\r\ncolumngridsize[110]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    latitude = table.Column<string>(type: "character varying", nullable: true, comment: "forminputlabel[Latitude]\r\nforminputsize[12]\r\nforminputclass[ro]\r\n\r\ngeragridmain[false]"),
                    longitude = table.Column<string>(type: "character varying", nullable: true, comment: "forminputlabel[Longitude]\r\nforminputsize[12]\r\nforminputclass[ro]\r\n\r\ngeragridmain[false]"),
                    usuarioaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    grupoaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    unidadeaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    version = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    condesp = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    tippro = table.Column<char>(type: "character(1)", maxLength: 1, nullable: true, comment: "Tipo de Processo"),
                    nronai = table.Column<int>(type: "integer", nullable: true, comment: "Numero da NAIN"),
                    obsdiv = table.Column<string>(type: "text", nullable: true, comment: "Observação"),
                    datpro = table.Column<DateOnly>(type: "date", nullable: true, comment: "Data de abertura do processo no protocolo")
                },
                constraints: table =>
                {
                    table.PrimaryKey("veiculodivulgacao_pkey", x => x.veiculodivulgacaoid);
                    table.ForeignKey(
                        name: "veiculodivulgacao_fk",
                        column: x => x.tipoveiculodivulgacao,
                        principalSchema: "divulgacao",
                        principalTable: "tipoveiculodivulgacao",
                        principalColumn: "tipoveiculodivulgacaoid");
                    table.ForeignKey(
                        name: "veiculodivulgacao_fk1",
                        column: x => x.ocorrencia,
                        principalSchema: "divulgacao",
                        principalTable: "ocorrencia",
                        principalColumn: "ocorrenciaid");
                },
                comment: "template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Veículo de Divulgação]\r\nfiltersgrid[#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Veículos de Divulgação]");

            migrationBuilder.CreateTable(
                name: "areareceptora",
                schema: "residuos",
                columns: table => new
                {
                    areareceptoraid = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Código]\r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "character varying", nullable: false, comment: "forminputlabel[Nome]\r\nforminputsize[50]\r\nforminputclass[uppercase]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Nome]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    situacao = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Situação]\r\nforminputsize[10]\r\n\r\ngeragridmain[false]"),
                    codigo = table.Column<int>(type: "integer", nullable: true, comment: "forminputlabel[Código]\r\nforminputsize[10]\r\nforminputclass[number]\r\n\r\ngeragridmain[false]"),
                    inscricaomunicipal = table.Column<decimal>(type: "numeric(11)", precision: 11, nullable: true, comment: "forminputlabel[Inscrição Municipal]\r\nforminputsize[15]\r\nforminputclass[inscricaomunicipal]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Inscrição Municipal]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    usuarioaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]"),
                    grupoaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]"),
                    unidadeaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]"),
                    version = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]"),
                    telefone = table.Column<string>(type: "character varying", nullable: true),
                    complemento = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    cep = table.Column<string>(type: "character varying(8)", maxLength: 8, nullable: true),
                    numero = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    bairro = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    rua = table.Column<string>(type: "character varying", nullable: true),
                    licencaambiental = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    validadelicenca = table.Column<DateOnly>(type: "date", nullable: true),
                    empresa = table.Column<int>(type: "integer", nullable: true),
                    transportadora = table.Column<int>(type: "integer", nullable: true),
                    senha = table.Column<string>(type: "character varying", nullable: true),
                    usuario = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("areareceptora_pkey", x => x.areareceptoraid);
                    table.ForeignKey(
                        name: "areareceptora_fk",
                        column: x => x.empresa,
                        principalSchema: "residuos",
                        principalTable: "empresa",
                        principalColumn: "empresaid");
                    table.ForeignKey(
                        name: "areareceptora_fk1",
                        column: x => x.transportadora,
                        principalSchema: "residuos",
                        principalTable: "transportadora",
                        principalColumn: "transportadoraid");
                },
                comment: "template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs]\r\n\r\nformtitle[Cadastro de Área Receptora]\r\nfiltersgrid[#text_filter,#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Áreas Receptoras]");

            migrationBuilder.CreateTable(
                name: "prfage",
                schema: "agenda",
                columns: table => new
                {
                    codprf = table.Column<int>(type: "integer", nullable: false, defaultValueSql: "nextval(('\"agenda\".\"prfage_codprf_seq\"'::text)::regclass)"),
                    insprf = table.Column<long>(type: "bigint", nullable: true),
                    nomprf = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    titprf = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    emlprf = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    creprf = table.Column<long>(type: "bigint", nullable: true),
                    ufcprf = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    cpfprf = table.Column<string>(type: "character varying(14)", maxLength: 14, nullable: true),
                    fonprf = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    tipprf = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    nlcprf = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    comprf = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    numprf = table.Column<int>(type: "integer", nullable: true),
                    baiprf = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    cepprf = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    logprf = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    senprf = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    uacprf = table.Column<DateOnly>(type: "date", nullable: true),
                    aceprf = table.Column<int>(type: "integer", nullable: true),
                    visprf = table.Column<int>(type: "integer", nullable: true, defaultValue: 1),
                    usuario = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    usuarioaud = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    unidadeaud = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    grupoaud = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    version = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    termoaceito = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "0 - Não Aceito / 1 - Aceito"),
                    jusprf = table.Column<string>(type: "character varying", nullable: true, comment: "JUSTIFICATIVA DE ACESSO DO PROF DE FORA!"),
                    arqprf = table.Column<int>(type: "integer", nullable: true, comment: "ID DO ARQUIVO ANEXADO NA TAB ARQUIVO"),
                    extprf = table.Column<string>(type: "character varying", nullable: true, comment: "EXTENSAO DO ARQUIVO ANEXADO"),
                    conprf = table.Column<int>(type: "integer", nullable: true, defaultValue: 0, comment: "CONFIRMACAO DE CHECK DO EMAIL DO PROFISSIONAL")
                },
                constraints: table =>
                {
                    table.PrimaryKey("prfage_pkey", x => x.codprf);
                    table.ForeignKey(
                        name: "prfage_fk",
                        column: x => x.usuario,
                        principalTable: "usuario",
                        principalColumn: "usuarioid");
                });

            migrationBuilder.CreateTable(
                name: "usuariocargo",
                schema: "divulgacao",
                columns: table => new
                {
                    usuariocargoid = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    usuario = table.Column<int>(type: "integer", nullable: false),
                    cargo = table.Column<string>(type: "character varying", nullable: false),
                    usuarioaud = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    unidadeaud = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    grupoaud = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    version = table.Column<int>(type: "integer", nullable: true, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("usuariocargo_pkey", x => x.usuariocargoid);
                    table.ForeignKey(
                        name: "usuariocargo_fk",
                        column: x => x.usuario,
                        principalTable: "usuario",
                        principalColumn: "usuarioid");
                });

            migrationBuilder.CreateTable(
                name: "nomecoluna",
                schema: "agenda",
                columns: table => new
                {
                    nomecolunaid = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Código]\r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false, comment: "forminputlabel[Nome]\r\nforminputsize[50]\r\nforminputclass[uppercase]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Nome]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    residuo = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Resíduo]\r\nforminputsize[180]\r\n\r\nsearchmode[combobox]\r\ncomboboxresultfield[residuo.nome]\r\n\r\ncolumngridid[residuo.nome]\r\ncolumngridtitle[Resíduo]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    tipocoluna = table.Column<int>(type: "integer", nullable: false, comment: "0-Integer / 1-String\r\n\r\nforminputlabel[Tipo Coluna]\r\nforminputsize[30]\r\nforminputclass[required]\r\n\r\ngeragridmain[false]"),
                    usuarioaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    grupoaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    version = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    unidadeaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
                },
                constraints: table =>
                {
                    table.PrimaryKey("nomecoluna_pkey", x => x.nomecolunaid);
                    table.ForeignKey(
                        name: "nomecoluna_fk",
                        column: x => x.residuo,
                        principalSchema: "agenda",
                        principalTable: "residuo",
                        principalColumn: "residuoid");
                },
                comment: "template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Nome de Coluna]\r\nfiltersgrid[#text_filter,#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Nomes de Coluna]");

            migrationBuilder.CreateTable(
                name: "residuocaracteristica",
                schema: "residuos",
                columns: table => new
                {
                    residuocaracteristicaid = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Código]\r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    residuo = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Resíduo]\r\nforminputsize[30]\r\nforminputclass[uppercase]\r\n\r\nsearchmode[popup]\r\npopupresultfield[nome]\r\npopupfieldsgrid[residuoid,nome:residuoid]\r\n\r\ncolumngridid[residuo.nome]\r\ncolumngridtitle[Resíduo]\r\ncolumngridtype[ro]\r\ncolumngridsize[150]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    caracteristica = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Característica]\r\nforminputsize[150]\r\n\r\nsearchmode[combobox]\r\ncomboboxresultfield[caracteristica.nome]\r\n\r\ncolumngridid[caracteristica.nome]\r\ncolumngridtitle[Característica]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    usuarioaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]"),
                    grupoaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]"),
                    unidadeaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]"),
                    version = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]")
                },
                constraints: table =>
                {
                    table.PrimaryKey("residuocaracteristica_pkey", x => x.residuocaracteristicaid);
                    table.ForeignKey(
                        name: "residuocaracteristica_fk",
                        column: x => x.residuo,
                        principalSchema: "residuos",
                        principalTable: "residuo",
                        principalColumn: "residuoid");
                    table.ForeignKey(
                        name: "residuocaracteristica_fk1",
                        column: x => x.caracteristica,
                        principalSchema: "residuos",
                        principalTable: "caracteristica",
                        principalColumn: "caracteristicaid");
                },
                comment: "template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs]\r\n\r\nformtitle[Cadastro de Característica de Resíduo]\r\nfiltersgrid[#text_filter,#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Características do Resíduo]");

            migrationBuilder.CreateTable(
                name: "transportadoraresiduo",
                schema: "residuos",
                columns: table => new
                {
                    // transportadoraresiduoid = table.Column<int>(type: "integer", nullable: false, defaultValueSql: "nextval('residuos.transportadoraresiduo_transportadoraresiduoid_seq1'::regclass)"),
                    transportadoraresiduoid = table.Column<int>(type: "integer", nullable: false),
                    grupoaud = table.Column<int>(type: "integer", nullable: true),
                    unidadeaud = table.Column<int>(type: "integer", nullable: true),
                    usuarioaud = table.Column<int>(type: "integer", nullable: true),
                    version = table.Column<int>(type: "integer", nullable: true),
                    residuo = table.Column<int>(type: "integer", nullable: true),
                    transportadora = table.Column<int>(type: "integer", nullable: true),
                    licencaambiental = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    validadelicenca = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("transportadoraresiduo_pkey", x => x.transportadoraresiduoid);
                    //table.ForeignKey(
                    //    name: "fkda9472e324a06d8e",
                    //    column: x => x.transportadora,
                    //    principalSchema: "residuos",
                    //    principalTable: "transportadora",
                    //    principalColumn: "transportadoraid");
                    table.ForeignKey(
                        name: "fkda9472e3e4fc0580",
                        column: x => x.residuo,
                        principalSchema: "residuos",
                        principalTable: "residuo",
                        principalColumn: "residuoid");
                });

            migrationBuilder.CreateTable(
                name: "rua",
                columns: table => new
                {
                    ruaid = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Código] \r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    estado = table.Column<string>(type: "character varying(2)", maxLength: 2, nullable: true),
                    cidade = table.Column<int>(type: "integer", nullable: true),
                    bairroinicial = table.Column<int>(type: "integer", nullable: true),
                    bairrofinal = table.Column<int>(type: "integer", nullable: true),
                    nome = table.Column<string>(type: "character varying", nullable: true, comment: "forminputlabel[Nome]\r\nforminputsize[70]\r\nforminputclass[uppercase]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Nome]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    complemento = table.Column<string>(type: "character varying", nullable: true),
                    cep = table.Column<string>(type: "character varying", nullable: true),
                    tipo = table.Column<string>(type: "character varying", nullable: true),
                    ativo = table.Column<string>(type: "character varying(1)", maxLength: 1, nullable: true),
                    nomepopular = table.Column<string>(type: "character varying", nullable: true),
                    usuarioaud = table.Column<int>(type: "integer", nullable: true, defaultValue: 0, comment: "\r\ngeraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    grupoaud = table.Column<int>(type: "integer", nullable: true, defaultValue: 0, comment: "\r\ngeraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    version = table.Column<int>(type: "integer", nullable: true, defaultValue: 0, comment: "\r\ngeraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    unidadeaud = table.Column<int>(type: "integer", nullable: true, defaultValue: 0, comment: "\r\ngeraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
                },
                constraints: table =>
                {
                    table.PrimaryKey("rua_pkey", x => x.ruaid);
                    table.ForeignKey(
                        name: "rua_fk1",
                        column: x => x.bairroinicial,
                        principalTable: "bairro",
                        principalColumn: "bairroid");
                    table.ForeignKey(
                        name: "rua_fk2",
                        column: x => x.bairrofinal,
                        principalTable: "bairro",
                        principalColumn: "bairroid");
                },
                comment: "template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs]\r\n\r\n\r\n\r\nformtitle[Cadastro de Rua]\r\n\r\nfiltersgrid[#text_filter,#text_filter]\r\n\r\n\r\n\r\ngridtitle[Lista de Ruas]");

            migrationBuilder.CreateTable(
                name: "obra",
                schema: "sisobra",
                columns: table => new
                {
                    obraid = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Código] \r\nforminputsize[7]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Código] \r\ncolumngridtype[ro] \r\ncolumngridsize[80] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    classificacao = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Classificação] \r\nforminputsize[100]\r\n\r\nsearchmode[combobox] \r\ncomboboxresultfield[nome]\r\n\r\ncolumngridid[70] \r\ncolumngridtitle[Classificação] \r\ncolumngridtype[ro] \r\ncolumngridsize[20] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]"),
                    descricao = table.Column<string>(type: "character varying", nullable: false, comment: "forminputlabel[Descrição] \r\nforminputsize[70]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Descrição] \r\ncolumngridtype[ro] \r\ncolumngridsize[*] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]"),
                    status = table.Column<int>(type: "integer", nullable: true, comment: "forminputlabel[Status] \r\nforminputsize[20]\r\n\r\nsearchmode[combobox] \r\ncomboboxresultfield[nome]\r\n\r\ncolumngridid[] \r\ncolumngridtitle[Status] \r\ncolumngridtype[ro] \r\ncolumngridsize[20] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]"),
                    valorrepasse = table.Column<decimal>(type: "numeric(30,2)", precision: 30, scale: 2, nullable: true, comment: "forminputlabel[Valor Repasse] \r\nforminputsize[10]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Valor Repasse]\r\ncolumngridtype[ro] \r\ncolumngridsize[20] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]"),
                    valorcontrapartida = table.Column<decimal>(type: "numeric(30,2)", precision: 30, scale: 2, nullable: true, comment: "forminputlabel[Valor Contra Partida] \r\nforminputsize[10]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Valor Contra Partida]\r\ncolumngridtype[ro] \r\ncolumngridsize[20] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]"),
                    valorfinanciamento = table.Column<decimal>(type: "numeric(30,2)", precision: 30, scale: 2, nullable: true, comment: "forminputlabel[Valor Financiamento] \r\nforminputsize[10]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Valor Financiamento]\r\ncolumngridtype[ro] \r\ncolumngridsize[20] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]"),
                    contratado = table.Column<int>(type: "integer", nullable: true, comment: "forminputlabel[Contratado] \r\nforminputsize[100]\r\n\r\nsearchmode[combobox] \r\ncomboboxresultfield[nome]\r\n\r\ncolumngridid[] \r\ncolumngridtitle[Contratado] \r\ncolumngridtype[ro] \r\ncolumngridsize[70] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]"),
                    fiscal = table.Column<int>(type: "integer", nullable: true, comment: "forminputlabel[Fiscal] \r\nforminputsize[100]\r\n\r\nsearchmode[combobox] \r\ncomboboxresultfield[nome]\r\n\r\ncolumngridid[] \r\ncolumngridtitle[Fiscal] \r\ncolumngridtype[ro] \r\ncolumngridsize[70] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]"),
                    faseobra = table.Column<int>(type: "integer", nullable: true, comment: "forminputlabel[Fase da Obra] \r\nforminputsize[50]\r\n\r\nsearchmode[combobox] \r\ncomboboxresultfield[nome]\r\n\r\ncolumngridid[] \r\ncolumngridtitle[Fase da Obra] \r\ncolumngridtype[ro] \r\ncolumngridsize[70] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]"),
                    datacadastro = table.Column<DateOnly>(type: "date", nullable: true, defaultValueSql: "('now'::text)::date", comment: "forminputlabel[Data Cadastro] \r\nforminputsize[10]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Data Cadastro] \r\ncolumngridtype[ro] \r\ncolumngridsize[20] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]"),
                    dataprevisaoentrega = table.Column<DateOnly>(type: "date", nullable: true, comment: "forminputlabel[Data Previsão Entrega] \r\nforminputsize[10]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Data Previsão Entrega] \r\ncolumngridtype[ro] \r\ncolumngridsize[20] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]"),
                    bairro = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Bairro] \r\nforminputsize[100]\r\n\r\nsearchmode[popup] \r\npopupresultfield[bairro.nome]\r\npopupfieldsgrid[bairroid,nome]\r\n\r\ncolumngridid[] \r\ncolumngridtitle[Bairro] \r\ncolumngridtype[ro] \r\ncolumngridsize[100] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]"),
                    endereco = table.Column<string>(type: "character varying", nullable: true, comment: "forminputlabel[Endereço] \r\nforminputsize[70]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Endereço] \r\ncolumngridtype[ro] \r\ncolumngridsize[*] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]"),
                    numero = table.Column<int>(type: "integer", nullable: true, comment: "forminputlabel[Número] \r\nforminputsize[10]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Número] \r\ncolumngridtype[ro] \r\ncolumngridsize[30] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]"),
                    latitude = table.Column<string>(type: "character varying", nullable: true, comment: "forminputlabel[Latitude] \r\nforminputsize[20]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Latitude] \r\ncolumngridtype[ro] \r\ncolumngridsize[40] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]"),
                    longitude = table.Column<string>(type: "character varying", nullable: true, comment: "forminputlabel[Longitude] \r\nforminputsize[20]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Longitude] \r\ncolumngridtype[ro] \r\ncolumngridsize[40] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]"),
                    usuarioaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    grupoaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    unidadeaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    version = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    valorinvestimento = table.Column<decimal>(type: "numeric(30,2)", precision: 30, scale: 2, nullable: true, comment: "forminputlabel[Valor Investimento] \r\nforminputsize[10]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Valor Investimento]\r\ncolumngridtype[ro] \r\ncolumngridsize[20] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]"),
                    valorinvestimentopre = table.Column<decimal>(type: "numeric(30,2)", precision: 30, scale: 2, nullable: true, comment: "forminputlabel[Valor Investimento] \r\nforminputsize[10]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Valor Investimento]\r\ncolumngridtype[ro] \r\ncolumngridsize[20] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]"),
                    recurso = table.Column<int>(type: "integer", nullable: true),
                    ministerio = table.Column<int>(type: "integer", nullable: true),
                    anoemenda = table.Column<int>(type: "integer", nullable: true),
                    evento = table.Column<int>(type: "integer", nullable: true),
                    fonterecurso = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("obra_pkey", x => x.obraid);
                    table.ForeignKey(
                        name: "obra_fk",
                        column: x => x.classificacao,
                        principalSchema: "sisobra",
                        principalTable: "classificacao",
                        principalColumn: "classificacaoid");
                    table.ForeignKey(
                        name: "obra_fk1",
                        column: x => x.status,
                        principalSchema: "sisobra",
                        principalTable: "status",
                        principalColumn: "statusid");
                    table.ForeignKey(
                        name: "obra_fk2",
                        column: x => x.contratado,
                        principalSchema: "sisobra",
                        principalTable: "contratado",
                        principalColumn: "contratadoid");
                    table.ForeignKey(
                        name: "obra_fk3",
                        column: x => x.fiscal,
                        principalSchema: "sisobra",
                        principalTable: "fiscal",
                        principalColumn: "fiscalid");
                    table.ForeignKey(
                        name: "obra_fk4",
                        column: x => x.faseobra,
                        principalSchema: "sisobra",
                        principalTable: "faseobra",
                        principalColumn: "faseobraid");
                    table.ForeignKey(
                        name: "obra_fk5",
                        column: x => x.bairro,
                        principalSchema: "sisobra",
                        principalTable: "bairro",
                        principalColumn: "bairroid");
                    table.ForeignKey(
                        name: "obra_fk6",
                        column: x => x.recurso,
                        principalSchema: "sisobra",
                        principalTable: "recurso",
                        principalColumn: "recursoid");
                    table.ForeignKey(
                        name: "obra_fk7",
                        column: x => x.ministerio,
                        principalSchema: "sisobra",
                        principalTable: "ministerio",
                        principalColumn: "ministerioid");
                    table.ForeignKey(
                        name: "obra_fk8",
                        column: x => x.evento,
                        principalSchema: "sisobra",
                        principalTable: "evento",
                        principalColumn: "eventoid");
                    table.ForeignKey(
                        name: "obra_fk9",
                        column: x => x.fonterecurso,
                        principalSchema: "sisobra",
                        principalTable: "fonterecurso",
                        principalColumn: "fonterecursoid");
                },
                comment: "template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro do Obra]\r\nfiltersgrid[#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Obras]\r\n\r\nmasterdetails[true]\r\ndetails[obradata,obraandamento]");

            migrationBuilder.CreateTable(
                name: "projetoana",
                schema: "cartografia",
                columns: table => new
                {
                    projetoanaid = table.Column<int>(type: "integer", nullable: false, comment: "Código do projetoana")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    projeto = table.Column<int>(type: "integer", nullable: true, comment: "Projeto vinculado"),
                    analista = table.Column<int>(type: "integer", nullable: true, comment: "Analista vinculado"),
                    dataencaminhado = table.Column<DateTime>(type: "timestamp without time zone", nullable: true, comment: "Data do encaminhamento")
                },
                constraints: table =>
                {
                    table.PrimaryKey("projetoana_pkey", x => x.projetoanaid);
                    table.ForeignKey(
                        name: "projetoana_fk",
                        column: x => x.projeto,
                        principalSchema: "cartografia",
                        principalTable: "projeto",
                        principalColumn: "projetoid");
                    table.ForeignKey(
                        name: "projetoana_fk1",
                        column: x => x.analista,
                        principalSchema: "cartografia",
                        principalTable: "analista",
                        principalColumn: "analistaid");
                });

            migrationBuilder.CreateTable(
                name: "projetoins",
                schema: "cartografia",
                columns: table => new
                {
                    projetoinsid = table.Column<int>(type: "integer", nullable: false, comment: "Código do projetoins")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    inscricao = table.Column<string>(type: "character varying(12)", maxLength: 12, nullable: false, comment: "Inscrição imobiliaria"),
                    projeto = table.Column<int>(type: "integer", nullable: true, comment: "Projeto vinculado"),
                    parcelamento = table.Column<string>(type: "character varying(80)", maxLength: 80, nullable: true, comment: "Parcelamento"),
                    quadra = table.Column<string>(type: "character varying(5)", maxLength: 5, nullable: true, comment: "Quadra"),
                    lote = table.Column<string>(type: "character varying(5)", maxLength: 5, nullable: true, comment: "Lote"),
                    bairro = table.Column<string>(type: "character varying(80)", maxLength: 80, nullable: true, comment: "Bairro"),
                    regiao = table.Column<string>(type: "character varying(80)", maxLength: 80, nullable: true, comment: "Região"),
                    logradouro = table.Column<string>(type: "character varying(80)", maxLength: 80, nullable: true, comment: "Logradouro"),
                    numero = table.Column<string>(type: "character varying(12)", maxLength: 12, nullable: true, comment: "Número do logradouro"),
                    compl = table.Column<string>(type: "character varying(80)", maxLength: 80, nullable: true, comment: "Complemento do logradouro"),
                    proprietario = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true, comment: "Proprietario"),
                    cpfcnpj = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true, comment: "CPF ou CNPJ do proprietario")
                },
                constraints: table =>
                {
                    table.PrimaryKey("projetoins_pkey", x => x.projetoinsid);
                    table.ForeignKey(
                        name: "projetoins_fk",
                        column: x => x.projeto,
                        principalSchema: "cartografia",
                        principalTable: "projeto",
                        principalColumn: "projetoid");
                });

            migrationBuilder.CreateTable(
                name: "remessa",
                schema: "cartografia",
                columns: table => new
                {
                    remessaid = table.Column<int>(type: "integer", nullable: false, comment: "Código da remessa")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descricao = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, comment: "Descrição da remessa"),
                    data = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "now()", comment: "Data de cadastro da remessa"),
                    projeto = table.Column<int>(type: "integer", nullable: false, comment: "Projeto vinculado"),
                    analista = table.Column<int>(type: "integer", nullable: true, comment: "Analista vinculado que analisou a remessa"),
                    status = table.Column<string>(type: "character varying(5)", maxLength: 5, nullable: false, comment: "Status da remessa, FIN = FINALIZADA , ANA = EM ANALISE")
                },
                constraints: table =>
                {
                    table.PrimaryKey("remessa_pkey", x => x.remessaid);
                    table.ForeignKey(
                        name: "remessa_fk",
                        column: x => x.projeto,
                        principalSchema: "cartografia",
                        principalTable: "projeto",
                        principalColumn: "projetoid");
                    table.ForeignKey(
                        name: "remessa_fk1",
                        column: x => x.analista,
                        principalSchema: "cartografia",
                        principalTable: "analista",
                        principalColumn: "analistaid");
                });

            migrationBuilder.CreateTable(
                name: "grupousuario",
                columns: table => new
                {
                    grupousuarioid = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Código] \r\nforminputsize[7]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Código] \r\ncolumngridtype[ro] \r\ncolumngridsize[80] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    usuario = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Usuário]\r\nforminputsize[50]\r\n\r\nsearchmode[popup]\r\npopupresultfield[nome]\r\npopupfieldsgrid[usuarioid,nome,login,senha:usuarioid]\r\n\r\ncolumngridid[usuario.nome]\r\ncolumngridtitle[Usuário]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    grupo = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Grupo]\r\nforminputsize[250]\r\n\r\nsearchmode[combobox]\r\ncomboboxresultfield[nome]\r\n\r\ncolumngridid[grupo.nome]\r\ncolumngridtitle[Grupo]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    sistema = table.Column<int>(type: "integer", nullable: true, comment: "forminputlabel[Sistema]\r\nforminputsize[250]\r\n\r\nsearchmode[combobox]\r\ncomboboxresultfield[nome]\r\n\r\ncolumngridid[sistema.nome]\r\ncolumngridtitle[Sistema]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    usuarioaud = table.Column<int>(type: "integer", nullable: true),
                    grupoaud = table.Column<int>(type: "integer", nullable: true),
                    version = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    unidadeaud = table.Column<int>(type: "integer", nullable: true, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("grupousuario_pk", x => x.grupousuarioid);
                    table.ForeignKey(
                        name: "grupo_grupousuario_fk",
                        column: x => x.grupo,
                        principalTable: "grupo",
                        principalColumn: "grupoid");
                    table.ForeignKey(
                        name: "grupousuario_fk",
                        column: x => x.sistema,
                        principalTable: "sistema",
                        principalColumn: "sistemaid");
                    table.ForeignKey(
                        name: "usuario_grupousuario_fk",
                        column: x => x.usuario,
                        principalTable: "usuario",
                        principalColumn: "usuarioid");
                },
                comment: "template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Grupo / Usuário]\r\n\r\nfieldsgrid[grupousuarioid,usuario.nome,grupo.nome,sistema.nome:grupousuarioid]\r\nfiltersgrid[#text_filter,#text_filter,#text_filter,#text_filter] \r\n\r\nfieldsform[grupousuarioid,usuario.usuarioid,usuario.nome,grupo.grupoid,grupo.nome,sistema.sistemaid,sistema.nome] \r\n\r\ngridtitle[Lista de Grupos / Usuário]");

            migrationBuilder.CreateTable(
                name: "logacesso",
                columns: table => new
                {
                    logacessoid = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Código] forminputsize[7]  columngridid[] columngridtitle[Código] columngridtype[ro] columngridsize[80] columngridalign[left] columngridcolor[white]")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    usuario = table.Column<int>(type: "integer", nullable: true, comment: "forminputlabel[Usuario]\r\nforminputsize[50]\r\n\r\nsearchmode[popup]\r\npopupresultfield[nome]\r\npopupfieldsgrid[usuarioid,nome,login,senha:usuarioid]\r\n\r\ncolumngridid[usuario.nome]\r\ncolumngridtitle[Usuário]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    sistema = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Sistema]\r\nforminputsize[250]\r\n\r\nsearchmode[combobox]\r\ncomboboxresultfield[nome]\r\n\r\ncolumngridid[sistema.nome]\r\ncolumngridtitle[Sistema]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    data = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "now()", comment: "forminputlabel[Data] forminputsize[50]  columngridid[] columngridtitle[Data] columngridtype[ro] columngridsize[100] columngridalign[left] columngridcolor[white]"),
                    ip = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false, comment: "forminputlabel[IP] forminputsize[50]  columngridid[] columngridtitle[IP] columngridtype[ro] columngridsize[100] columngridalign[left] columngridcolor[white]"),
                    grupo = table.Column<int>(type: "integer", nullable: true),
                    usuarioaud = table.Column<int>(type: "integer", nullable: true),
                    grupoaud = table.Column<int>(type: "integer", nullable: true),
                    version = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    unidadeaud = table.Column<int>(type: "integer", nullable: true, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("logacesso_pk", x => x.logacessoid);
                    table.ForeignKey(
                        name: "sistema_logacesso_fk",
                        column: x => x.sistema,
                        principalTable: "sistema",
                        principalColumn: "sistemaid");
                    table.ForeignKey(
                        name: "usuario_logacesso_fk",
                        column: x => x.usuario,
                        principalTable: "usuario",
                        principalColumn: "usuarioid");
                },
                comment: "template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]  \r\n\r\nformtitle[Cadastro de Log de acesso]   \r\nfieldsgrid[logacessoid,usuario.nome,sistema.nome,data,ip:logacessoid] \r\n\r\nfieldsform[logacessoid,usuario.usuarioid,usuario.nome,sistema.sistemaid,sistema.nome,data,ip] \r\n\r\ngridtitle[Lista de Logs de acesso]");

            migrationBuilder.CreateTable(
                name: "logsistema",
                columns: table => new
                {
                    logsistemaid = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Código] forminputsize[7]  columngridid[] columngridtitle[Código] columngridtype[ro] columngridsize[80] columngridalign[left] columngridcolor[white]")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    sistema = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Sistema]\r\nforminputsize[250]\r\n\r\nsearchmode[combobox]\r\ncomboboxresultfield[nome]\r\n\r\ncolumngridid[sistema.nome]\r\ncolumngridtitle[Sistema]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    versao = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false, comment: "forminputlabel[Versão] forminputsize[50]  columngridid[] columngridtitle[Versão] columngridtype[ro] columngridsize[100] columngridalign[left] columngridcolor[white]"),
                    data = table.Column<DateTime>(type: "timestamp without time zone", nullable: true, defaultValueSql: "now()"),
                    usuarioaud = table.Column<int>(type: "integer", nullable: true),
                    grupoaud = table.Column<int>(type: "integer", nullable: true),
                    unidade = table.Column<int>(type: "integer", nullable: true),
                    version = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    unidadeaud = table.Column<int>(type: "integer", nullable: true, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("logsistema_pk", x => x.logsistemaid);
                    table.ForeignKey(
                        name: "sistema_logsistema_fk",
                        column: x => x.sistema,
                        principalTable: "sistema",
                        principalColumn: "sistemaid");
                },
                comment: "template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]  \r\n\r\nformtitle[Cadastro de Log do sistema]   \r\nfieldsgrid[logsistemaid,sistema.nome,versao,data:logsistemaid] \r\n\r\nfieldsform[logsistemaid,sistema.sistemaid,sistema.nome,versao,data] \r\n\r\ngridtitle[Lista de Logs do sistema]");

            migrationBuilder.CreateTable(
                name: "modulosistema",
                columns: table => new
                {
                    modulosistemaid = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Código] forminputsize[7]  columngridid[] columngridtitle[Código] columngridtype[ro] columngridsize[80] columngridalign[left] columngridcolor[white]")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    modulo = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Módulo]\r\nforminputsize[250]\r\n\r\nsearchmode[combobox]\r\ncomboboxresultfield[nome]\r\n\r\ncolumngridid[modulo.nome]\r\ncolumngridtitle[Módulo]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    sistema = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Sistema]\r\nforminputsize[250]\r\n\r\nsearchmode[combobox]\r\ncomboboxresultfield[nome]\r\n\r\ncolumngridid[sistema.nome]\r\ncolumngridtitle[Sistema]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    manutencao = table.Column<int>(type: "integer", nullable: false),
                    usuarioaud = table.Column<int>(type: "integer", nullable: true),
                    grupoaud = table.Column<int>(type: "integer", nullable: true),
                    version = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    unidadeaud = table.Column<int>(type: "integer", nullable: true, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("modulosistema_pk", x => x.modulosistemaid);
                    table.ForeignKey(
                        name: "modulo_modulosistema_fk",
                        column: x => x.modulo,
                        principalTable: "modulo",
                        principalColumn: "moduloid");
                    table.ForeignKey(
                        name: "sistema_modulosistema_fk",
                        column: x => x.sistema,
                        principalTable: "sistema",
                        principalColumn: "sistemaid");
                },
                comment: "template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]  \r\n\r\nformtitle[Cadastro de Módulos / Sistema]   \r\nfieldsgrid[modulosistemaid,modulo.nome,sistema.nome:modulosistemaid] \r\n\r\n\r\nfieldsform[modulosistemaid,modulo.moduloid,modulo.nome,sistema.sistemaid,sistema.nome,manutencao] \r\n\r\ngridtitle[Lista de Módulos / Sistema]");

            migrationBuilder.CreateTable(
                name: "permissaoentidade",
                columns: table => new
                {
                    permissaoentidadeid = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Código]\r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    sistema = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Sistema]\r\nforminputsize[250]\r\n\r\nsearchmode[combobox]\r\ncomboboxresultfield[nome]\r\n\r\ngeragridmain[true]\r\n\r\ncolumngridid[sistema.nome]\r\ncolumngridtitle[Sistema]\r\ncolumngridtype[ro]\r\ncolumngridsize[180]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    entidade = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Entidade]\r\nforminputsize[50]\r\n\r\nsearchmode[popup]\r\npopupresultfield[nome]\r\npopupfieldsgrid[entidadeid,nome:entidadeid]\r\n\r\ngeragridmain[true]\r\n\r\ncolumngridid[entidade.nome]\r\ncolumngridtitle[Entidade]\r\ncolumngridtype[ro]\r\ncolumngridsize[180]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    grupo = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Grupo]\r\nforminputsize[250]\r\n\r\nsearchmode[combobox]\r\ncomboboxresultfield[nome]\r\n\r\ngeragridmain[true]\r\n\r\ncolumngridid[grupo.nome]\r\ncolumngridtitle[Grupo]\r\ncolumngridtype[ro]\r\ncolumngridsize[180]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    usuarioaud = table.Column<int>(type: "integer", nullable: true),
                    grupoaud = table.Column<int>(type: "integer", nullable: true),
                    grantinsert = table.Column<string>(type: "character varying(2)", maxLength: 2, nullable: true),
                    grantdelete = table.Column<string>(type: "character varying(2)", maxLength: 2, nullable: true),
                    grantupdate = table.Column<string>(type: "character varying(2)", maxLength: 2, nullable: true),
                    grantselect = table.Column<string>(type: "character varying(2)", maxLength: 2, nullable: true),
                    grantcoluna = table.Column<string>(type: "character varying", nullable: true),
                    denycoluna = table.Column<string>(type: "character varying", nullable: true),
                    grantviewcoluna = table.Column<string>(type: "character varying", nullable: true),
                    denyviewcoluna = table.Column<string>(type: "character varying", nullable: true),
                    version = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    unidadeaud = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    physicaldeletion = table.Column<string>(type: "character varying(2)", maxLength: 2, nullable: true),
                    filtraunidade = table.Column<string>(type: "character varying(2)", maxLength: 2, nullable: true),
                    denyupdate = table.Column<string>(type: "character varying", nullable: true),
                    denydelete = table.Column<string>(type: "character varying", nullable: true),
                    denyview = table.Column<string>(type: "character varying", nullable: true),
                    pathunidade = table.Column<string>(type: "character varying", nullable: true),
                    pathusuario = table.Column<string>(type: "character varying", nullable: true),
                    denyabas = table.Column<string>(type: "character varying", nullable: true),
                    denycolumnsgrid = table.Column<string>(type: "character varying", nullable: true),
                    denyfieldsform = table.Column<string>(type: "character varying", nullable: true),
                    extrasinfo = table.Column<string>(type: "character varying", nullable: true),
                    denyextrabuttons = table.Column<string>(type: "character varying", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("permissaoentidade_pkey", x => x.permissaoentidadeid);
                    table.ForeignKey(
                        name: "permissaoentidade_fk",
                        column: x => x.sistema,
                        principalTable: "sistema",
                        principalColumn: "sistemaid");
                    table.ForeignKey(
                        name: "permissaoentidade_fk1",
                        column: x => x.entidade,
                        principalTable: "entidade",
                        principalColumn: "entidadeid");
                    table.ForeignKey(
                        name: "permissaoentidade_fk2",
                        column: x => x.grupo,
                        principalTable: "grupo",
                        principalColumn: "grupoid");
                },
                comment: "template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Permissão/Entidade] \r\n\r\nfieldsgrid[permissaoentidadeid,sistema.nome,entidade.nome,grupo.nome:permissaoentidadeid]\r\nfiltersgrid[#text_filter,#text_filter,#text_filter,#text_filter] \r\n\r\nfieldsform[permissaoentidadeid,sistema.sistemaid,sistema.nome,entidade.entidadeid,entidade.nome,grupo.grupoid,grupo.nome,grantentidade,denyentidade,grantcoluna,denycoluna,grantviewcoluna,denyviewcoluna] \r\n\r\ngridtitle[Lista de Permissão/Entidade]");

            migrationBuilder.CreateTable(
                name: "sistemacontexto",
                columns: table => new
                {
                    sistemacontextoid = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    sistema = table.Column<int>(type: "integer", nullable: true),
                    contexto = table.Column<string>(type: "character varying", nullable: true),
                    emproducao = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    usuarioaud = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    grupoaud = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    unidadeaud = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    version = table.Column<int>(type: "integer", nullable: true, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("sistemacontexto_pkey", x => x.sistemacontextoid);
                    table.ForeignKey(
                        name: "sistemacontexto_fk",
                        column: x => x.sistema,
                        principalTable: "sistema",
                        principalColumn: "sistemaid");
                });

            migrationBuilder.CreateTable(
                name: "usuariosistema",
                columns: table => new
                {
                    usuariosistemaid = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    sistema = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Sistema]\r\nforminputsize[250]\r\n\r\nsearchmode[combobox]\r\ncomboboxresultfield[nome]\r\n\r\ngeragridmain[true]\r\n\r\ncolumngridid[sistema.nome]\r\ncolumngridtitle[Sistema]\r\ncolumngridtype[ro]\r\ncolumngridsize[180]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    usuario = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Usuário]\r\nforminputsize[50]\r\n\r\nsearchmode[popup]\r\npopupresultfield[nome]\r\npopupfieldsgrid[usuarioid,nome,login,senha:usuarioid]\r\n\r\ngeragridmain[true]\r\n\r\ncolumngridid[usuario.nome]\r\ncolumngridtitle[Usuário]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    tema = table.Column<int>(type: "integer", nullable: true, comment: "forminputlabel[Tema]\r\nforminputsize[250]\r\n\r\nsearchmode[combobox]\r\ncomboboxresultfield[nome]\r\n\r\ngeragridmain[true]\r\n\r\ncolumngridid[tema.nome]\r\ncolumngridtitle[Tema]\r\ncolumngridtype[ro]\r\ncolumngridsize[180]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    dataexpiracao = table.Column<DateTime>(type: "timestamp without time zone", nullable: true, comment: "forminputlabel[Expiração de acesso] \r\nforminputsize[50]\r\n\r\ngeragridmain[false]"),
                    usuarioaud = table.Column<int>(type: "integer", nullable: true),
                    grupoaud = table.Column<int>(type: "integer", nullable: true),
                    version = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    unidadeaud = table.Column<int>(type: "integer", nullable: true, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("usuariosistema_pk", x => x.usuariosistemaid);
                    table.ForeignKey(
                        name: "sistema_usuariosistema_fk",
                        column: x => x.sistema,
                        principalTable: "sistema",
                        principalColumn: "sistemaid");
                    table.ForeignKey(
                        name: "tema_usuariosistema_fk",
                        column: x => x.tema,
                        principalTable: "tema",
                        principalColumn: "temaid");
                    table.ForeignKey(
                        name: "usuario_usuariosistema_fk",
                        column: x => x.usuario,
                        principalTable: "usuario",
                        principalColumn: "usuarioid");
                },
                comment: "template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]  \r\n\r\nformtitle[Cadastro de Usuários / Sistema]   \r\n\r\nfieldsgrid[usuariosistemaid,sistema.nome,usuario.nome,tema.nome,qtdeacessos:usuariosistemaid] \r\nfieldsform[usuariosistemaid,sistema.sistemaid,sistema.nome,usuario.usuarioid,usuario.nome,tema.temaid,tema.nome,qtdeacessos,ultimoacesso,dataexpiracao]\r\n\r\ngridtitle[Lista de Usuários / Sistema]");

            migrationBuilder.CreateTable(
                name: "ctr",
                schema: "residuos",
                columns: table => new
                {
                    ctrid = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Código]\r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    datahoracadastro = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, comment: "forminputlabel[Data/Hora Cad.]\r\nforminputsize[14]\r\nforminputclass[ro]\r\n\r\ngeragridmain[false]"),
                    empresa = table.Column<int>(type: "integer", nullable: true),
                    residuo = table.Column<int>(type: "integer", nullable: true, comment: "forminputlabel[Resíduo]\r\nforminputsize[30]\r\nforminputclass[uppercase]\r\n\r\nsearchmode[popupdet]\r\npopupresultfield[nome]\r\npopupfieldsgrid[residuoid,nome,estadofisico.nome:residuoid]\r\n\r\ncolumngridid[residuo.nome]\r\ncolumngridtitle[Resíduo]\r\ncolumngridtype[ro]\r\ncolumngridsize[150]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    unidade = table.Column<int>(type: "integer", nullable: true, comment: "forminputlabel[Unidade]\r\nforminputsize[110]\r\n\r\nsearchmode[combobox]\r\ncomboboxresultfield[unidade.nome]\r\n\r\ngeragridmain[false]"),
                    armazenamento = table.Column<int>(type: "integer", nullable: true, comment: "forminputlabel[Armazenamento]\r\nforminputsize[110]\r\n\r\nsearchmode[combobox]\r\ncomboboxresultfield[armazenamento.nome]\r\n\r\ngeragridmain[false]"),
                    areareceptora = table.Column<int>(type: "integer", nullable: true, comment: "forminputlabel[Área-Receptora]\nforminputsize[180]\n\nsearchmode[comboboxdet]\ncomboboxresultfield[areareceptora.nome]\n\ngeragridmain[false]"),
                    transportadora = table.Column<int>(type: "integer", nullable: true, comment: "forminputlabel[Transportadora]\r\nforminputsize[180]\r\n\r\nsearchmode[comboboxdet]\r\ncomboboxresultfield[transportadora.nome]\r\n\r\ngeragridmain[false]"),
                    transportadorasiat = table.Column<decimal>(type: "numeric(11)", precision: 11, nullable: true, comment: "forminputlabel[Transportadora-SIAT]\r\nforminputsize[10]\r\nforminputclass[number]\r\n\r\ngeragridmain[false]"),
                    situacao = table.Column<int>(type: "integer", nullable: true, comment: "forminputlabel[Situação]\r\nforminputsize[10]\r\n\r\ngeragridmain[false]"),
                    quantidade = table.Column<decimal>(type: "numeric(10,2)", precision: 10, scale: 2, nullable: true, comment: "forminputlabel[Quantidade]\r\nforminputsize[10]\r\nforminputclass[number]\r\n\r\ngeragridmain[false]"),
                    datahoraentrega = table.Column<DateTime>(type: "timestamp without time zone", nullable: true, comment: "forminputlabel[Data/Hora Entrega]\nforminputsize[14]\nforminputclass[datetime]\n\ngeragridmain[false]"),
                    nomecondutor = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true, comment: "forminputlabel[Responsável]\r\nforminputsize[15]\r\nforminputclass[uppercase]\r\n\r\ngeragridmain[false]"),
                    placaveiculo = table.Column<string>(type: "character varying(8)", maxLength: 8, nullable: true, comment: "forminputlabel[Placa Veículo]\r\nforminputsize[12]\r\nforminputclass[uppercase]\r\n\r\ngeragridmain[false]"),
                    usuarioaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]"),
                    grupoaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]"),
                    unidadeaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]"),
                    version = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]"),
                    obsdestfinal = table.Column<string>(type: "character varying", nullable: true),
                    areareceptora2 = table.Column<int>(type: "integer", nullable: true),
                    obsdestfinal2 = table.Column<string>(type: "character varying", nullable: true),
                    autotransporte = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    numeromanifesto = table.Column<int>(type: "integer", nullable: true),
                    codigobaixa = table.Column<int>(type: "integer", nullable: true),
                    datahoratransportadora = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    datahoradesfinal = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    datahorancertificado = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    datahorafinalizado = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ctr_pkey", x => x.ctrid);
                    table.ForeignKey(
                        name: "ctr_fk",
                        column: x => x.empresa,
                        principalSchema: "residuos",
                        principalTable: "empresa",
                        principalColumn: "empresaid");
                    table.ForeignKey(
                        name: "ctr_fk2",
                        column: x => x.unidade,
                        principalSchema: "residuos",
                        principalTable: "unidade",
                        principalColumn: "unidadeid");
                    table.ForeignKey(
                        name: "ctr_fk3",
                        column: x => x.armazenamento,
                        principalSchema: "residuos",
                        principalTable: "armazenamento",
                        principalColumn: "armazenamentoid");
                    table.ForeignKey(
                        name: "ctr_fk4",
                        column: x => x.areareceptora,
                        principalSchema: "residuos",
                        principalTable: "areareceptora",
                        principalColumn: "areareceptoraid");
                    table.ForeignKey(
                        name: "ctr_fk5",
                        column: x => x.transportadora,
                        principalSchema: "residuos",
                        principalTable: "transportadora",
                        principalColumn: "transportadoraid");
                    table.ForeignKey(
                        name: "ctr_fk6",
                        column: x => x.areareceptora2,
                        principalSchema: "residuos",
                        principalTable: "areareceptora",
                        principalColumn: "areareceptoraid");
                },
                comment: "template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs]\r\n\r\nformtitle[Cadastro de CTR]\r\nfiltersgrid[#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de CTR's]");

            migrationBuilder.CreateTable(
                name: "residuoarea",
                schema: "residuos",
                columns: table => new
                {
                    residuoareaid = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Código]\r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    residuo = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Resíduo]\r\nforminputsize[30]\r\nforminputclass[uppercase]\r\n\r\nsearchmode[popup]\r\npopupresultfield[nome]\r\npopupfieldsgrid[residuoid,nome:residuoid]\r\n\r\ncolumngridid[residuo.nome]\r\ncolumngridtitle[Resíduo]\r\ncolumngridtype[ro]\r\ncolumngridsize[150]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    areareceptora = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Área Receptora]\r\nforminputsize[150]\r\n\r\nsearchmode[combobox]\r\ncomboboxresultfield[areareceptora.nome]\r\n\r\ncolumngridid[areareceptora.nome]\r\ncolumngridtitle[Área Receptora]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    usuarioaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]"),
                    grupoaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]"),
                    unidadeaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]"),
                    version = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeraformdet[false]\r\ngeragridmain[false]")
                },
                constraints: table =>
                {
                    table.PrimaryKey("residuoarea_pkey", x => x.residuoareaid);
                    table.ForeignKey(
                        name: "residuoarea_fk",
                        column: x => x.residuo,
                        principalSchema: "residuos",
                        principalTable: "residuo",
                        principalColumn: "residuoid");
                    table.ForeignKey(
                        name: "residuoarea_fk1",
                        column: x => x.areareceptora,
                        principalSchema: "residuos",
                        principalTable: "areareceptora",
                        principalColumn: "areareceptoraid");
                },
                comment: "template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs]\r\n\r\nformtitle[Cadastro de Resíduo da Área Receptora]\r\nfiltersgrid[#text_filter,#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Resíduos da Área Receptora]");

            migrationBuilder.CreateTable(
                name: "controleresiduo",
                schema: "agenda",
                columns: table => new
                {
                    controleresiduoid = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Código]\r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    projeto = table.Column<string>(type: "character varying(22)", maxLength: 22, nullable: true, comment: "forminputlabel[Projeto]\r\nforminputsize[30]\r\n\r\nsearchmode[popup]\r\npopupresultfield[processo]\r\npopupfieldsgrid[projetoid,processo:projetoid]\r\n\r\ncolumngridid[projeto.processo]\r\ncolumngridtitle[Projeto]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    caracteristicaemp = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Caracterização do Empreendimento]\r\nforminputsize[250]\r\n\r\nsearchmode[combobox]\r\ncomboboxresultfield[caracteristicaemp.nome]\r\n\r\ncolumngridid[caracteristicaemp.nome]\r\ncolumngridtitle[Caracterização do Empreendimento]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    construcaoarea = table.Column<decimal>(type: "numeric", nullable: false, comment: "forminputlabel[Área Construção]\r\nforminputsize[15]\r\nforminputclass[required number]\r\n\r\ngeragridmain[false]"),
                    contrucaovolume = table.Column<decimal>(type: "numeric", nullable: false, comment: "forminputlabel[Volume Construção]\r\nforminputsize[15]\r\nforminputclass[required number]\r\n\r\ngeragridmain[false]"),
                    contrucaopeso = table.Column<decimal>(type: "numeric", nullable: false, comment: "forminputlabel[Peso Construção]\r\nforminputsize[15]\r\nforminputclass[required number]\r\n\r\ngeragridmain[false]"),
                    demolicaovolume = table.Column<decimal>(type: "numeric", nullable: false, comment: "forminputlabel[Volume Demolição]\r\nforminputsize[15]\r\nforminputclass[required number]\r\n\r\ngeragridmain[false]"),
                    demolicaopeso = table.Column<decimal>(type: "numeric", nullable: false, comment: "forminputlabel[Peso Demolição]\r\nforminputsize[15]\r\nforminputclass[required number]\r\n\r\ngeragridmain[false]"),
                    botaforavolume = table.Column<decimal>(type: "numeric", nullable: false, comment: "forminputlabel[Volume Bota-fora]\r\nforminputsize[15]\r\nforminputclass[required number]\r\n\r\ngeragridmain[false]"),
                    botaforapeso = table.Column<decimal>(type: "numeric", nullable: false, comment: "forminputlabel[Peso Bota-fora]\r\nforminputsize[15]\r\nforminputclass[required number]\r\n\r\ngeragridmain[false]"),
                    emprestvolume = table.Column<decimal>(type: "numeric", nullable: false, comment: "forminputlabel[Volume Empréstimo]\r\nforminputsize[15]\r\nforminputclass[required number]\r\n\r\ngeragridmain[false]"),
                    emprestpeso = table.Column<decimal>(type: "numeric", nullable: false, comment: "forminputlabel[Peso Empréstimo]\r\nforminputsize[15]\r\nforminputclass[required number]\r\n\r\ngeragridmain[false]"),
                    segregacaomat = table.Column<int>(type: "integer", nullable: false, comment: "0-Sim / 1-Nao\r\nforminputlabel[Haverá Segregação do material no canteiro de obras?]\r\nforminputsize[15]\r\nforminputclass[required number]\r\n\r\ngeragridmain[false]"),
                    usuarioaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    grupoaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    version = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    unidadeaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    status = table.Column<int>(type: "integer", nullable: true, comment: "forminputlabel[Status]\r\nforminputsize[180]\r\n\r\nsearchmode[combobox]\r\ncomboboxresultfield[status.descricao]\r\n\r\ncolumngridid[status.descricao]\r\ncolumngridtitle[Status]\r\ncolumngridtype[ro]\r\ncolumngridsize[50]\r\ncolumngridalign[left]"),
                    datahoracadastro = table.Column<DateTime>(type: "timestamp without time zone", nullable: true, comment: "forminputlabel[Data Cadastro]\r\nforminputsize[15]\r\nforminputclass[]\r\n\r\ngeragridmain[false]"),
                    inscricaoimobiliaria = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    proprietario = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    prfage = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("controleresiduo_pkey", x => x.controleresiduoid);
                    table.ForeignKey(
                        name: "controleresiduo_fk",
                        column: x => x.status,
                        principalSchema: "agenda",
                        principalTable: "status",
                        principalColumn: "statusid");
                    table.ForeignKey(
                        name: "controleresiduo_fk1",
                        column: x => x.caracteristicaemp,
                        principalSchema: "agenda",
                        principalTable: "caracteristicaemp",
                        principalColumn: "caracteristicaempid");
                    table.ForeignKey(
                        name: "controleresiduo_fk2",
                        column: x => x.controleresiduoid,
                        principalSchema: "agenda",
                        principalTable: "prfage",
                        principalColumn: "codprf");
                },
                comment: "template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Controle de Resíduo]\r\nfiltersgrid[#text_filter,#text_filter,#text_filter,#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Controles de Resíduos]");

            migrationBuilder.CreateTable(
                name: "ctr",
                schema: "agenda",
                columns: table => new
                {
                    ctrid = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Código]\r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    controleresiduo = table.Column<int>(type: "integer", nullable: true, comment: "forminputlabel[controleresiduo]\r\nforminputsize[15]\r\nforminputclass[]\r\n\r\ngeragridmain[false]"),
                    numeroctr = table.Column<string>(type: "character varying(22)", maxLength: 22, nullable: true, comment: "forminputlabel[Número-CTR]\r\nforminputsize[15]\r\nforminputclass[required number]\r\n\r\ngeragridmain[false]"),
                    transportador = table.Column<int>(type: "integer", nullable: true, comment: "forminputlabel[Transportadora]\r\nforminputsize[180]\r\n\r\nsearchmode[combobox]\r\ncomboboxresultfield[transportadora.nome]\r\n\r\ncolumngridid[transportadora.nome]\r\ncolumngridtitle[Transportadora]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    placaveiculo = table.Column<string>(type: "character varying(22)", maxLength: 22, nullable: true, comment: "forminputlabel[Placa Veículo]\r\nforminputsize[15]\r\nforminputclass[required uppercase]\r\n\r\ngeragridmain[false]"),
                    nomecondutor = table.Column<string>(type: "character varying(99)", maxLength: 99, nullable: true, comment: "forminputlabel[Nome Condutor]\r\nforminputsize[15]\r\nforminputclass[required uppercase]\r\n\r\ngeragridmain[false]"),
                    areareceptora = table.Column<int>(type: "integer", nullable: true, comment: "forminputlabel[Área Receptora]\r\nforminputsize[180]\r\n\r\nsearchmode[combobox]\r\ncomboboxresultfield[areareceptora.nome]\r\n\r\ncolumngridid[areareceptora.nome]\r\ncolumngridtitle[Área Receptora]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    volumeclassea = table.Column<decimal>(type: "numeric(10,2)", precision: 10, scale: 2, nullable: true, comment: "forminputlabel[volume classe a]\r\nforminputsize[15]\r\nforminputclass[number]\r\n\r\ngeragridmain[false]"),
                    volumeclasseb = table.Column<decimal>(type: "numeric(10,2)", precision: 10, scale: 2, nullable: true, comment: "forminputlabel[volume classe b]\r\nforminputsize[15]\r\nforminputclass[number]\r\n\r\ngeragridmain[false]"),
                    volumeclassec = table.Column<decimal>(type: "numeric(10,2)", precision: 10, scale: 2, nullable: true, comment: "forminputlabel[volume classe c]\r\nforminputsize[15]\r\nforminputclass[number]\r\n\r\ngeragridmain[false]"),
                    volumeclassed = table.Column<decimal>(type: "numeric(10,2)", precision: 10, scale: 2, nullable: true, comment: "forminputlabel[volume classe d]\r\nforminputsize[15]\r\nforminputclass[number]\r\n\r\ngeragridmain[false]"),
                    usuarioaud = table.Column<int>(type: "integer", nullable: true, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    unidadeaud = table.Column<int>(type: "integer", nullable: true, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    grupoaud = table.Column<int>(type: "integer", nullable: true, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    version = table.Column<int>(type: "integer", nullable: true, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    inscricaoimobiliaria = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true),
                    status = table.Column<int>(type: "integer", nullable: true),
                    datahoracadastro = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    proprietario = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    datahorabaixa = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    prfage = table.Column<int>(type: "integer", nullable: true),
                    processo = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ctr_pkey", x => x.ctrid);
                    table.ForeignKey(
                        name: "ctr_fk",
                        column: x => x.transportador,
                        principalSchema: "agenda",
                        principalTable: "transportador",
                        principalColumn: "transportadorid");
                    table.ForeignKey(
                        name: "ctr_fk1",
                        column: x => x.areareceptora,
                        principalSchema: "agenda",
                        principalTable: "areareceptora",
                        principalColumn: "areareceptoraid");
                    table.ForeignKey(
                        name: "ctr_fk2",
                        column: x => x.status,
                        principalSchema: "agenda",
                        principalTable: "status",
                        principalColumn: "statusid");
                    table.ForeignKey(
                        name: "ctr_fk3",
                        column: x => x.prfage,
                        principalSchema: "agenda",
                        principalTable: "prfage",
                        principalColumn: "codprf");
                },
                comment: "template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de CTR]\r\nfiltersgrid[#text_filter,#text_filter,#text_filter,#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de CTR]");

            migrationBuilder.CreateTable(
                name: "projeto",
                schema: "agenda",
                columns: table => new
                {
                    projetoid = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Código]\r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    datacriacao = table.Column<DateTime>(type: "timestamp without time zone", nullable: true, comment: "forminputlabel[Data Criacao]\r\nforminputsize[30]\r\nforminputclass[datetime]\r\n\r\ngeragridmain[false]"),
                    datahomologacao = table.Column<DateTime>(type: "timestamp without time zone", nullable: true, comment: "forminputlabel[Data Homologacao]\r\nforminputsize[30]\r\nforminputclass[datetime]\r\n\r\ngeragridmain[false]"),
                    profissional = table.Column<int>(type: "integer", nullable: true, comment: "forminputlabel[Profissional]\r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Profissional]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    grupoaud = table.Column<int>(type: "integer", nullable: true, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    usuarioaud = table.Column<int>(type: "integer", nullable: true, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    unidadeaud = table.Column<int>(type: "integer", nullable: true, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    version = table.Column<int>(type: "integer", nullable: true, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    analista = table.Column<int>(type: "integer", nullable: true),
                    dataencaminhamento = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    finalizado = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    processo = table.Column<string>(type: "character varying", nullable: false),
                    proprietario = table.Column<string>(type: "character varying", nullable: true),
                    inscricao = table.Column<string>(type: "character varying", nullable: true),
                    codificacao = table.Column<int>(type: "integer", nullable: true),
                    codseguranca = table.Column<long>(type: "bigint", nullable: true),
                    assunto = table.Column<int>(type: "integer", nullable: true),
                    processoexp = table.Column<string>(type: "character varying(12)", maxLength: 12, nullable: false),
                    alvara = table.Column<string>(type: "character varying", nullable: true),
                    natureza = table.Column<int>(type: "integer", nullable: true),
                    atividade = table.Column<int>(type: "integer", nullable: true),
                    rua = table.Column<string>(type: "character varying", nullable: true),
                    numero = table.Column<int>(type: "integer", nullable: true),
                    numart = table.Column<string>(type: "character varying", nullable: true),
                    status = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "0 - Configuracao - nao aparece em lugar nenuhm\r\n=================== TRIAGEM ================\r\n1 - Não analisado - Triagem(Primeira remessa enviada)	\r\n2 -  Ja analisei e retornei para o Profissional - Triagem (A remessa é analisada e retornada pela triagem.)\r\n3 - Voltou do Profissional corrigido - Triagem (A remessa é respondida pelo profissional (criação de uma nova remessa))\r\n==================== ANALISTA =================\r\n4 - Não analisado - Analista (Primeira remessa enviada)\r\n5 -  Ja analisei e retornei para o Profissional - Analista (A remessa é analisada e retornada pelo analista.)\r\n6 - Voltou do Profissional corrigido - Analista (A remessa é respondida pelo profissional (criação de uma nova remessa))\r\n=================== ADMINISTRADOR ===============\r\n7 - De acordo (Quando o analista gera a remessa final e envia arquivos para análise. Gera assinatura digital também. Profissional não pode ver a Remessa Final.)\r\n===================== DIRETOR ==================\r\n8 - Encaminhado ao Diretor (Quando o administrador confere os dados da remessa final e clica no botao encaminhar para diretor)\r\n9 - Aprovado (Quando o projeto foi efetivamente concluído e aceito. Profissional só visualizará a Remessa Final.)\r\n10 - Negado (Diretor retorna o projeto ao analista para corrigir os arquivos da Remessa Final.)"),
                    exportado = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    dataexportado = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    quadra = table.Column<string>(type: "character varying", nullable: true),
                    lote = table.Column<string>(type: "character varying", nullable: true),
                    bairro = table.Column<string>(type: "character varying", nullable: true),
                    dataulttram = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    despacho = table.Column<string>(type: "character varying", nullable: true),
                    cpfproprietario = table.Column<string>(type: "character varying", nullable: true),
                    numerolaudoavaliacao = table.Column<int>(type: "integer", nullable: true),
                    anolaudoavaliacao = table.Column<int>(type: "integer", nullable: true),
                    arealote = table.Column<decimal>(type: "numeric(10,2)", precision: 10, scale: 2, nullable: true),
                    lotefrente = table.Column<string>(type: "character varying", nullable: true),
                    lotefundo = table.Column<string>(type: "character varying", nullable: true),
                    lotedireita = table.Column<string>(type: "character varying", nullable: true),
                    loteesquerda = table.Column<string>(type: "character varying", nullable: true),
                    areaprojecao = table.Column<decimal>(type: "numeric(10,2)", precision: 10, scale: 2, nullable: true),
                    enquadramento1 = table.Column<string>(type: "character varying", nullable: true),
                    enquadramento2 = table.Column<string>(type: "character varying", nullable: true),
                    enquadramento3 = table.Column<string>(type: "character varying", nullable: true),
                    enquadramento4 = table.Column<string>(type: "character varying", nullable: true),
                    enquadramento5 = table.Column<string>(type: "character varying", nullable: true),
                    enquadramento6 = table.Column<string>(type: "character varying", nullable: true),
                    enquadramentofinal = table.Column<string>(type: "character varying", nullable: true),
                    valormetroquadrado = table.Column<decimal>(type: "numeric(10,2)", precision: 10, scale: 2, nullable: true),
                    zoneamento = table.Column<int>(type: "integer", nullable: true),
                    datalaudoavaliacao = table.Column<DateOnly>(type: "date", nullable: true),
                    areaexcedente = table.Column<decimal>(type: "numeric(10,2)", precision: 10, scale: 2, nullable: true),
                    valorcontrapartida = table.Column<decimal>(type: "numeric(10,2)", precision: 10, scale: 2, nullable: true),
                    valorcontrapartidaextenso = table.Column<string>(type: "character varying", nullable: true),
                    valormetroquadradoextenso = table.Column<string>(type: "character varying", nullable: true),
                    areax = table.Column<decimal>(type: "numeric(10,2)", precision: 10, scale: 2, nullable: true),
                    areay = table.Column<decimal>(type: "numeric(10,2)", precision: 10, scale: 2, nullable: true),
                    cnpjempresa = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    razaosocialempresa = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    proprietario1 = table.Column<string>(type: "character varying", nullable: true),
                    proprietario2 = table.Column<string>(type: "character varying", nullable: true),
                    proprietario3 = table.Column<string>(type: "character varying", nullable: true),
                    cpfprop1 = table.Column<string>(type: "character varying", nullable: true),
                    cpfprop2 = table.Column<string>(type: "character varying", nullable: true),
                    cpfprop3 = table.Column<string>(type: "character varying", nullable: true),
                    usuaval = table.Column<string>(type: "character varying", nullable: true),
                    emailproprietario = table.Column<string>(type: "character varying", nullable: true),
                    procsubstituto = table.Column<string>(type: "character varying", nullable: true),
                    fiscal = table.Column<int>(type: "integer", nullable: true),
                    assuntoalt = table.Column<int>(type: "integer", nullable: true),
                    assuntogrup = table.Column<int>(type: "integer", nullable: true),
                    classificacao = table.Column<string>(type: "character varying(5)", maxLength: 5, nullable: true, defaultValueSql: "'NOR'::character varying", comment: "NOR = NORMAL(PADRAO)\r\nESP = ESPECIAL\r\nAPR = APROVE FACIL\nHAB = HABITE-SE LEGAL"),
                    regiao = table.Column<int>(type: "integer", nullable: true),
                    telcontato = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true),
                    status_anistia = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("projeto_pkey", x => x.projetoid);
                    table.ForeignKey(
                        name: "projeto_fk",
                        column: x => x.analista,
                        principalSchema: "agenda",
                        principalTable: "analista",
                        principalColumn: "analistaid");
                    table.ForeignKey(
                        name: "projeto_fk1",
                        column: x => x.codificacao,
                        principalSchema: "agenda",
                        principalTable: "codificacao",
                        principalColumn: "codificacaoid");
                    table.ForeignKey(
                        name: "projeto_fk2",
                        column: x => x.assunto,
                        principalSchema: "agenda",
                        principalTable: "assunto",
                        principalColumn: "assuntoid");
                    table.ForeignKey(
                        name: "projeto_fk3",
                        column: x => x.natureza,
                        principalSchema: "agenda",
                        principalTable: "natureza",
                        principalColumn: "naturezaid");
                    table.ForeignKey(
                        name: "projeto_fk4",
                        column: x => x.atividade,
                        principalSchema: "agenda",
                        principalTable: "atividade",
                        principalColumn: "atividadeid");
                    table.ForeignKey(
                        name: "projeto_fk5",
                        column: x => x.profissional,
                        principalSchema: "agenda",
                        principalTable: "prfage",
                        principalColumn: "codprf");
                    table.ForeignKey(
                        name: "projeto_fk6",
                        column: x => x.zoneamento,
                        principalSchema: "agenda",
                        principalTable: "zoneamento",
                        principalColumn: "zoneamentoid");
                    table.ForeignKey(
                        name: "projeto_fk7",
                        column: x => x.fiscal,
                        principalSchema: "agenda",
                        principalTable: "analista",
                        principalColumn: "analistaid");
                    table.ForeignKey(
                        name: "projeto_fk8",
                        column: x => x.assuntoalt,
                        principalSchema: "agenda",
                        principalTable: "assunto",
                        principalColumn: "assuntoid");
                    table.ForeignKey(
                        name: "projeto_fk9",
                        column: x => x.regiao,
                        principalSchema: "agenda",
                        principalTable: "regiao",
                        principalColumn: "regiaoid");
                },
                comment: "template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Projetos]\r\n\r\nfiltersgrid[#text_filter,#text_filter]\r\n\r\n\r\ngridtitle[Lista de Projetos]\r\n\r\nmasterdetails[true]\r\ndetails[remessa]");

            migrationBuilder.CreateTable(
                name: "empresa",
                schema: "divulgacao",
                columns: table => new
                {
                    empresaid = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Código]\r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "character varying", nullable: false, comment: "forminputlabel[Nome]\r\nforminputsize[50]\r\nforminputclass[uppercase]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Nome]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    rua = table.Column<int>(type: "integer", nullable: true, comment: "forminputlabel[Rua]\r\nforminputsize[12]\r\nforminputclass[ro]\r\n\r\ngeragridmain[false]"),
                    cep = table.Column<int>(type: "integer", nullable: true, comment: "forminputlabel[CEP]\r\nforminputsize[10]\r\nforminputclass[number]\r\n\r\ngeragridmain[false]"),
                    numero = table.Column<int>(type: "integer", nullable: true, comment: "forminputlabel[N&ordm;]\r\nforminputsize[10]\r\nforminputclass[number]\r\n\r\ngeragridmain[false]"),
                    complemento = table.Column<string>(type: "character varying", nullable: true, comment: "forminputlabel[Complemento]\r\nforminputsize[30]\r\nforminputclass[uppercase]\r\n\r\ngeragridmain[false]"),
                    telefone = table.Column<string>(type: "character varying", nullable: true, comment: "forminputlabel[Telefone]\r\nforminputsize[12]\r\nforminputclass[phone]\r\n\r\ngeragridmain[false]"),
                    celular = table.Column<string>(type: "character varying", nullable: true, comment: "forminputlabel[Celular]\r\nforminputsize[12]\r\nforminputclass[phone]\r\n\r\ngeragridmain[false]"),
                    responsavel = table.Column<string>(type: "character varying", nullable: true, comment: "forminputlabel[Responsável]\r\nforminputsize[50]\r\nforminputclass[uppercase]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Responsável]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    usuarioaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    grupoaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    unidadeaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    version = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
                },
                constraints: table =>
                {
                    table.PrimaryKey("empresa_pkey", x => x.empresaid);
                    table.ForeignKey(
                        name: "empresa_fk",
                        column: x => x.rua,
                        principalTable: "rua",
                        principalColumn: "ruaid");
                },
                comment: "template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Responsável]\r\nfiltersgrid[#text_filter,#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Responsáveis]");

            migrationBuilder.CreateTable(
                name: "proprietario",
                schema: "divulgacao",
                columns: table => new
                {
                    proprietarioid = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Código]\r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "character varying", nullable: false, comment: "forminputlabel[Nome]\r\nforminputsize[50]\r\nforminputclass[uppercase]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Nome]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    rua = table.Column<int>(type: "integer", nullable: true, comment: "forminputlabel[Rua]\r\nforminputsize[12]\r\nforminputclass[ro]\r\n\r\ngeragridmain[false]"),
                    cep = table.Column<int>(type: "integer", nullable: true, comment: "forminputlabel[CEP]\r\nforminputsize[10]\r\nforminputclass[number]\r\n\r\ngeragridmain[false]"),
                    numero = table.Column<int>(type: "integer", nullable: true, comment: "forminputlabel[N&ordm;]\r\nforminputsize[10]\r\nforminputclass[number]\r\n\r\ngeragridmain[false]"),
                    complemento = table.Column<string>(type: "character varying", nullable: true, comment: "forminputlabel[Complemento]\r\nforminputsize[30]\r\nforminputclass[uppercase]\r\n\r\ngeragridmain[false]"),
                    telefone = table.Column<string>(type: "character varying", nullable: true, comment: "forminputlabel[Telefone]\r\nforminputsize[12]\r\nforminputclass[phone]\r\n\r\ngeragridmain[false]"),
                    celular = table.Column<string>(type: "character varying", nullable: true, comment: "forminputlabel[Celular]\r\nforminputsize[12]\r\nforminputclass[phone]\r\n\r\ngeragridmain[false]"),
                    usuarioaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    grupoaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    unidadeaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    version = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
                },
                constraints: table =>
                {
                    table.PrimaryKey("proprietario_pkey", x => x.proprietarioid);
                    table.ForeignKey(
                        name: "proprietario_fk",
                        column: x => x.rua,
                        principalTable: "rua",
                        principalColumn: "ruaid");
                },
                comment: "template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Proprietário]\r\nfiltersgrid[#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Proprietários]");

            migrationBuilder.CreateTable(
                name: "obraandamento",
                schema: "sisobra",
                columns: table => new
                {
                    obraandamentoid = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Código] \r\nforminputsize[7]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Código] \r\ncolumngridtype[ro] \r\ncolumngridsize[80] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    obra = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Obra] \r\nforminputsize[10]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Obra] \r\ncolumngridtype[ro] \r\ncolumngridsize[10] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]"),
                    dataandamento = table.Column<DateOnly>(type: "date", nullable: false, comment: "forminputlabel[Data] \r\nforminputsize[10]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Data] \r\ncolumngridtype[ro] \r\ncolumngridsize[20] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]"),
                    obs = table.Column<string>(type: "character varying", nullable: false, comment: "forminputlabel[Observação] \r\nforminputsize[70]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Observação] \r\ncolumngridtype[ro] \r\ncolumngridsize[*] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]"),
                    usuarioaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    grupoaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    unidadeaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    version = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    dataprazo = table.Column<DateOnly>(type: "date", nullable: true, comment: "forminputlabel[Data Prazo] \r\nforminputsize[10]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Data-Prazo] \r\ncolumngridtype[ro] \r\ncolumngridsize[20] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]"),
                    situacaoprazo = table.Column<int>(type: "integer", nullable: true, comment: "1 - Andamento\r\n2 - Concluída\r\n3 - Cancelada\r\n\r\nforminputlabel[Situação] \r\nforminputsize[10]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Situação] \r\ncolumngridtype[ro] \r\ncolumngridsize[20] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]"),
                    datasituacao = table.Column<DateOnly>(type: "date", nullable: true, comment: "forminputlabel[Data Situação] \r\nforminputsize[10]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Data Situação] \r\ncolumngridtype[ro] \r\ncolumngridsize[20] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
                },
                constraints: table =>
                {
                    table.PrimaryKey("obraandamento_pkey", x => x.obraandamentoid);
                    table.ForeignKey(
                        name: "obraandamento_fk",
                        column: x => x.obra,
                        principalSchema: "sisobra",
                        principalTable: "obra",
                        principalColumn: "obraid");
                },
                comment: "template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro do Andamento da Obra]\r\nfiltersgrid[#text_filter,#text_filter,#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Andamentos da Obra]");

            migrationBuilder.CreateTable(
                name: "obradata",
                schema: "sisobra",
                columns: table => new
                {
                    obradataid = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Código] \r\nforminputsize[7]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Código] \r\ncolumngridtype[ro] \r\ncolumngridsize[80] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    obra = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Obra] \r\nforminputsize[10]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Obra] \r\ncolumngridtype[ro] \r\ncolumngridsize[10] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]"),
                    data = table.Column<DateOnly>(type: "date", nullable: false, comment: "forminputlabel[Data] \r\nforminputsize[10]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Data] \r\ncolumngridtype[ro] \r\ncolumngridsize[20] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]"),
                    status = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Status] \r\nforminputsize[20]\r\n\r\nsearchmode[combobox] \r\ncomboboxresultfield[nome]\r\n\r\ncolumngridid[] \r\ncolumngridtitle[Status] \r\ncolumngridtype[ro] \r\ncolumngridsize[20] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]"),
                    tipocontrole = table.Column<int>(type: "integer", nullable: true, comment: "forminputlabel[Tipo Controle] \r\nforminputsize[20]\r\n\r\nsearchmode[combobox] \r\ncomboboxresultfield[nome]\r\n\r\ncolumngridid[] \r\ncolumngridtitle[Tipo Controle] \r\ncolumngridtype[ro] \r\ncolumngridsize[20] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]"),
                    controle = table.Column<string>(type: "character varying", nullable: true, comment: "forminputlabel[Nº Controle] \r\nforminputsize[10]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Nº Controle] \r\ncolumngridtype[ro] \r\ncolumngridsize[20] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]"),
                    obs = table.Column<string>(type: "character varying", nullable: true, comment: "forminputlabel[Observação] \r\nforminputsize[70]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Observação] \r\ncolumngridtype[ro] \r\ncolumngridsize[*] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]"),
                    usuarioaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    grupoaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    unidadeaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    version = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
                },
                constraints: table =>
                {
                    table.PrimaryKey("obradata_pkey", x => x.obradataid);
                    table.ForeignKey(
                        name: "obradata_fk",
                        column: x => x.obra,
                        principalSchema: "sisobra",
                        principalTable: "obra",
                        principalColumn: "obraid");
                    table.ForeignKey(
                        name: "obradata_fk1",
                        column: x => x.status,
                        principalSchema: "sisobra",
                        principalTable: "status",
                        principalColumn: "statusid");
                    table.ForeignKey(
                        name: "obradata_fk2",
                        column: x => x.tipocontrole,
                        principalSchema: "sisobra",
                        principalTable: "tipocontrole",
                        principalColumn: "tipocontroleid");
                },
                comment: "template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro do Andamento da Obra]\r\nfiltersgrid[#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Andamentos da Obra]");

            migrationBuilder.CreateTable(
                name: "obraevento",
                schema: "sisobra",
                columns: table => new
                {
                    obraeventoid = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Código]\r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[]")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    obra = table.Column<int>(type: "integer", nullable: false, comment: "geragridmain[false]"),
                    evento = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Evento]\r\nforminputsize[70]\r\n\r\nsearchmode[popup]\r\npopupresultfield[evento.nome]\r\npopupfieldsgrid[eventoid,nome]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Evento]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[]"),
                    usuarioaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    grupoaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    unidadeaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    version = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
                },
                constraints: table =>
                {
                    table.PrimaryKey("obraevento_pkey", x => x.obraeventoid);
                    table.ForeignKey(
                        name: "obraevento_fk1",
                        column: x => x.obra,
                        principalSchema: "sisobra",
                        principalTable: "obra",
                        principalColumn: "obraid");
                    table.ForeignKey(
                        name: "obraevento_fk2",
                        column: x => x.evento,
                        principalSchema: "sisobra",
                        principalTable: "evento",
                        principalColumn: "eventoid");
                },
                comment: "template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Obra-Evento]\r\nfiltersgrid[#text_filter,#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Obra-Eventos]");

            migrationBuilder.CreateTable(
                name: "obraparlamentar",
                schema: "sisobra",
                columns: table => new
                {
                    obraparlamentarid = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Código]\r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[]")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    obra = table.Column<int>(type: "integer", nullable: false, comment: "geragridmain[false]"),
                    parlamentar = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Parlamentar]\r\nforminputsize[70]\r\n\r\nsearchmode[popup]\r\npopupresultfield[parlamentar.nome]\r\npopupfieldsgrid[parlamentarid,nome]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Parlamentar]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[]"),
                    usuarioaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    grupoaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    unidadeaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    version = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    tipo = table.Column<string>(type: "character varying(1)", maxLength: 1, nullable: true),
                    anoemenda = table.Column<string>(type: "character varying(9)", maxLength: 9, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("obraparlamentar_pkey", x => x.obraparlamentarid);
                    table.ForeignKey(
                        name: "obraparlamentar_fk1",
                        column: x => x.obra,
                        principalSchema: "sisobra",
                        principalTable: "obra",
                        principalColumn: "obraid");
                    table.ForeignKey(
                        name: "obraparlamentar_fk2",
                        column: x => x.parlamentar,
                        principalSchema: "sisobra",
                        principalTable: "parlamentar",
                        principalColumn: "parlamentarid");
                },
                comment: "template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Obra-Parlamentar]\r\nfiltersgrid[#text_filter,#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Obra-Parlamentares]");

            migrationBuilder.CreateTable(
                name: "documento",
                schema: "cartografia",
                columns: table => new
                {
                    documentoid = table.Column<int>(type: "integer", nullable: false, comment: "Código do documento")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    situacao = table.Column<int>(type: "integer", nullable: false, comment: "Situação do documento"),
                    remessa = table.Column<int>(type: "integer", nullable: false, comment: "Remessa vinculado"),
                    arquivo = table.Column<int>(type: "integer", nullable: false, comment: "Arquivo vinculado")
                },
                constraints: table =>
                {
                    table.PrimaryKey("documento_pkey", x => x.documentoid);
                    table.ForeignKey(
                        name: "documento_fk",
                        column: x => x.remessa,
                        principalSchema: "cartografia",
                        principalTable: "remessa",
                        principalColumn: "remessaid");
                    table.ForeignKey(
                        name: "documento_fk1",
                        column: x => x.situacao,
                        principalSchema: "cartografia",
                        principalTable: "situacao",
                        principalColumn: "situacaoid");
                    table.ForeignKey(
                        name: "documento_fk2",
                        column: x => x.arquivo,
                        principalSchema: "cartografia",
                        principalTable: "arquivo",
                        principalColumn: "arquivoid");
                });

            migrationBuilder.CreateTable(
                name: "unidadeusuario",
                columns: table => new
                {
                    unidadeusuarioid = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Código]\r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    unidade = table.Column<int>(type: "integer", nullable: true, comment: "forminputlabel[Unidade]\r\nforminputsize[250]\r\n\r\nsearchmode[combobox]\r\ncomboboxresultfield[nome]\r\n\r\ngeragridmain[false]\r\n"),
                    usuario = table.Column<int>(type: "integer", nullable: true, comment: "forminputlabel[Usuario]\r\nforminputsize[250]\r\n\r\nsearchmode[combobox]\r\ncomboboxresultfield[nome]\r\n\r\ngeragridmain[false]\r\n"),
                    version = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    unidadeaud = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    usuarioaud = table.Column<int>(type: "integer", nullable: true),
                    grupoaud = table.Column<int>(type: "integer", nullable: true),
                    grupousuario = table.Column<int>(type: "integer", nullable: true, comment: "forminputlabel[Grupo Usuario]\r\nforminputsize[250]\r\n\r\nsearchmode[combobox]\r\ncomboboxresultfield[nome]\r\n\r\ngeragridmain[false]\r\n")
                },
                constraints: table =>
                {
                    table.PrimaryKey("unidadeusuario_pkey", x => x.unidadeusuarioid);
                    table.ForeignKey(
                        name: "unidadeusuario_fk",
                        column: x => x.unidade,
                        principalTable: "unidade",
                        principalColumn: "unidadeid");
                    table.ForeignKey(
                        name: "unidadeusuario_fk1",
                        column: x => x.usuario,
                        principalTable: "usuario",
                        principalColumn: "usuarioid");
                    table.ForeignKey(
                        name: "unidadeusuario_fk2",
                        column: x => x.grupousuario,
                        principalTable: "grupousuario",
                        principalColumn: "grupousuarioid");
                },
                comment: "template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Usuario x Unidade] \r\n\r\nfieldsgrid[usuariounidadeid,unidade.nome,usuario.nome:usuariounidadeid]\r\nfiltersgrid[#text_filter,#text_filter] \r\n\r\nfieldsform[usuariounidadeid,unidade.nome,usuario.nome]\r\n\r\ngridtitle[Lista de Usuario x Unidade]");

            migrationBuilder.CreateTable(
                name: "arquivo",
                columns: table => new
                {
                    arquivoid = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Código] \r\nforminputsize[7]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Código] \r\ncolumngridtype[ro] \r\ncolumngridsize[80] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false, comment: "forminputlabel[Nome] \r\nforminputsize[50]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Nome] \r\ncolumngridtype[ro] \r\ncolumngridsize[*] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]"),
                    url = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false, comment: "forminputlabel[URL] \r\nforminputsize[50]"),
                    modulosistema = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Módulo Sistema]\r\nforminputsize[250]\r\n\r\nsearchmode[combobox]\r\ncomboboxresultfield[modulo.nome]\r\n\r\ncolumngridid[modulosistema.modulo.nome]\r\ncolumngridtitle[Módulo Sistema]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    usuarioaud = table.Column<int>(type: "integer", nullable: true),
                    grupoaud = table.Column<int>(type: "integer", nullable: true),
                    version = table.Column<int>(type: "integer", nullable: true),
                    unidadeaud = table.Column<int>(type: "integer", nullable: true, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("arquivo_pk", x => x.arquivoid);
                    table.ForeignKey(
                        name: "arquivo_fk",
                        column: x => x.modulosistema,
                        principalTable: "modulosistema",
                        principalColumn: "modulosistemaid");
                },
                comment: "template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Arquivo]\r\nfieldsgrid[arquivoid,nome,url,modulo.nome:arquivoid]\r\nfiltersgrid[#text_filter,#text_filter,#text_filter,#text_filter] \r\n\r\nfieldsform[arquivoid,nome,url,modulo.moduloid,modulo.nome] \r\n\r\ngridtitle[Lista de Arquivos]\r\n\r\n");

            migrationBuilder.CreateTable(
                name: "modulogrupo",
                columns: table => new
                {
                    modulogrupoid = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Código] \r\nforminputsize[7]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Código] \r\ncolumngridtype[ro] \r\ncolumngridsize[80] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    grupo = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Grupo]\r\nforminputsize[250]\r\n\r\nsearchmode[combobox]\r\ncomboboxresultfield[nome]\r\n\r\ncolumngridid[grupo.nome]\r\ncolumngridtitle[Grupo]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    modulosistema = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Módulo Sistema]\r\nforminputsize[250]\r\n\r\nsearchmode[combobox]\r\ncomboboxresultfield[modulo.nome]\r\n\r\ncolumngridid[modulosistema.modulo.nome]\r\ncolumngridtitle[Módulo Sistema]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    menu = table.Column<string>(type: "character varying", nullable: true, comment: "forminputlabel[MENU] \r\nforminputsize[50]  \r\n\r\ngeragridmain[false]"),
                    usuarioaud = table.Column<int>(type: "integer", nullable: true),
                    grupoaud = table.Column<int>(type: "integer", nullable: true),
                    version = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    unidadeaud = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    imagemtopo = table.Column<string>(type: "character varying", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("modulogrupo_pk", x => x.modulogrupoid);
                    table.ForeignKey(
                        name: "grupo_modulogrupo_fk",
                        column: x => x.grupo,
                        principalTable: "grupo",
                        principalColumn: "grupoid");
                    table.ForeignKey(
                        name: "modulogrupo_fk",
                        column: x => x.modulosistema,
                        principalTable: "modulosistema",
                        principalColumn: "modulosistemaid");
                },
                comment: "template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]  \r\n\r\nformtitle[Cadastro de Módulos / Grupo]   \r\nfieldsgrid[modulogrupoid,grupo.nome,modulosistema.modulo.nome,menu:modulogrupoid] \r\n\r\nfieldsform[modulogrupoid,grupo.grupoid,grupo.nome,modulosistema.modulosistemaid,modulosistema.modulo.nome,menu] \r\n\r\ngridtitle[Lista de Módulos / Grupo]");

            migrationBuilder.CreateTable(
                name: "modulosistemausuario",
                columns: table => new
                {
                    modulosistemausuarioid = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Código]\r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    modulosistema = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[ModuloSistema]\r\nforminputsize[250]\r\n\r\nsearchmode[combobox]\r\ncomboboxresultfield[modulosistema.modulo.nome]\r\n\r\ngeragridmain[true]\r\n\r\ncolumngridid[modulosistema.modulo.nome]\r\ncolumngridtitle[Modulo Sistema]\r\ncolumngridtype[ro]\r\ncolumngridsize[180]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    usuario = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Usuário]\r\nforminputsize[50]\r\n\r\nsearchmode[popup]\r\npopupresultfield[nome]\r\npopupfieldsgrid[usuarioid,nome,login,senha:usuarioid]\r\n\r\ncolumngridid[usuario.nome]\r\ncolumngridtitle[Usuário]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    grantmodulo = table.Column<string>(type: "character varying", nullable: false, comment: "forminputlabel[GrantModulo]\r\nforminputsize[50]\r\n\r\ngeragridmain[false]"),
                    denymodulo = table.Column<string>(type: "character varying", nullable: false, comment: "forminputlabel[DenyModulo]\r\nforminputsize[50]\r\n\r\ngeragridmain[false]"),
                    usuarioaud = table.Column<int>(type: "integer", nullable: true),
                    grupoaud = table.Column<int>(type: "integer", nullable: true),
                    version = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    unidadeaud = table.Column<int>(type: "integer", nullable: true, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("modulosistemausuario_pkey", x => x.modulosistemausuarioid);
                    table.ForeignKey(
                        name: "modulosistemausuario_fk",
                        column: x => x.modulosistema,
                        principalTable: "modulosistema",
                        principalColumn: "modulosistemaid");
                    table.ForeignKey(
                        name: "modulosistemausuario_fk1",
                        column: x => x.usuario,
                        principalTable: "usuario",
                        principalColumn: "usuarioid");
                },
                comment: "template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]  \r\n\r\nformtitle[Cadastro de Modulo/ Sistema / Usuário]   \r\nfieldsgrid[modulosistemausuarioid,modulosistema.modulo.nome,usuario.nome:modulosistemausuarioid] \r\n\r\nfieldsform[modulosistemausuarioid,modulosistema.modulosistemaid,modulosistema.modulo.nome,usuario.usuarioid,usuario.nome,grantmodulo,denymodulo] \r\n\r\ngridtitle[Lista de Modulo/ Sistema / Usuário]   ");

            migrationBuilder.CreateTable(
                name: "ctrresiduo",
                schema: "residuos",
                columns: table => new
                {
                    ctrresiduoid = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ctr = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Ctr]\r\nforminputsize[10]\r\n\r\ngeragridmain[false]"),
                    residuo = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Resíduo]\nforminputsize[30]\nforminputclass[uppercase]\n\nsearchmode[popupdet]\npopupresultfield[nome]\npopupfieldsgrid[residuoid,nome,estadofisico.nome:residuoid]\n\ncolumngridid[residuo.nome]\ncolumngridtitle[Resíduo]\ncolumngridtype[ro]\ncolumngridsize[150]\ncolumngridalign[left]\ncolumngridcolor[white]"),
                    qtde = table.Column<int>(type: "integer", nullable: true, comment: "forminputlabel[Quantidade]\nforminputsize[50]\nforminputclass[uppercase]\n\ncolumngridid[]\ncolumngridtitle[Quantidade]\ncolumngridtype[ro]\ncolumngridsize[*]\ncolumngridalign[left]\ncolumngridcolor[white]"),
                    unidade = table.Column<int>(type: "integer", nullable: true, comment: "forminputlabel[Unidade]\r\nforminputsize[110]\r\n\r\nsearchmode[combobox]\r\ncomboboxresultfield[unidade.nome]\r\n\r\ngeragridmain[false]"),
                    qtdetrans = table.Column<int>(type: "integer", nullable: true),
                    unidadetrans = table.Column<int>(type: "integer", nullable: true, comment: "forminputlabel[Unidade Transportadora]\r\nforminputsize[110]\r\n\r\nsearchmode[combobox]\r\ncomboboxresultfield[unidadetrans.nome]\r\n\r\ngeragridmain[false]"),
                    codigobaixa = table.Column<string>(type: "character varying", nullable: true, comment: "forminputlabel[Codigo Baixa]\nforminputsize[50]\nforminputclass[uppercase]\n\ncolumngridid[]\ncolumngridtitle[Codigo Baixa]\ncolumngridtype[ro]\ncolumngridsize[*]\ncolumngridalign[left]\ncolumngridcolor[white]"),
                    numeromanifesto = table.Column<string>(type: "character varying", nullable: true, comment: "forminputlabel[Numero Manifesto]\nforminputsize[50]\nforminputclass[uppercase]\n\ncolumngridid[]\ncolumngridtitle[Numero Manifesto]\ncolumngridtype[ro]\ncolumngridsize[*]\ncolumngridalign[left]\ncolumngridcolor[white]"),
                    usuarioaud = table.Column<int>(type: "integer", nullable: true, comment: "geraentity[false]\ngeraform[false]\ngeraformdet[false]\ngeragridmain[false]"),
                    grupoaud = table.Column<int>(type: "integer", nullable: true, comment: "geraentity[false]\ngeraform[false]\ngeraformdet[false]\ngeragridmain[false]"),
                    unidadeaud = table.Column<int>(type: "integer", nullable: true, comment: "geraentity[false]\ngeraform[false]\ngeraformdet[false]\ngeragridmain[false]"),
                    version = table.Column<int>(type: "integer", nullable: true, comment: "geraentity[false]\ngeraform[false]\ngeraformdet[false]\ngeragridmain[false]")
                },
                constraints: table =>
                {
                    table.PrimaryKey("ctrresiduo_pkey", x => x.ctrresiduoid);
                    table.ForeignKey(
                        name: "ctrresiduo_fk",
                        column: x => x.ctr,
                        principalSchema: "residuos",
                        principalTable: "ctr",
                        principalColumn: "ctrid");
                    table.ForeignKey(
                        name: "ctrresiduo_fk2",
                        column: x => x.unidade,
                        principalSchema: "residuos",
                        principalTable: "unidade",
                        principalColumn: "unidadeid");
                    table.ForeignKey(
                        name: "ctrresiduo_fk3",
                        column: x => x.unidadetrans,
                        principalSchema: "residuos",
                        principalTable: "unidade",
                        principalColumn: "unidadeid");
                });

            migrationBuilder.CreateTable(
                name: "valorcoluna",
                schema: "agenda",
                columns: table => new
                {
                    valorcolunaid = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Código]\r\nforminputsize[7]\r\n\r\ncolumngridid[]\r\ncolumngridtitle[Código]\r\ncolumngridtype[ro]\r\ncolumngridsize[80]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    residuo = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Coluna]\r\nforminputsize[180]\r\n\r\nsearchmode[combobox]\r\ncomboboxresultfield[nomecoluna.nome]\r\n\r\ncolumngridid[nomecoluna.nome]\r\ncolumngridtitle[Coluna]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    controleresiduo = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Controle-Resíduo]\r\nforminputsize[12]\r\nforminputclass[ro]\r\n\r\ngeragridmain[false]"),
                    reutilizacao = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    processo = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    aplicacao = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    quantidade = table.Column<decimal>(type: "numeric", nullable: true),
                    construcao = table.Column<decimal>(type: "numeric", nullable: true),
                    demolicao = table.Column<decimal>(type: "numeric", nullable: true),
                    total = table.Column<decimal>(type: "numeric", nullable: true),
                    destinofinal = table.Column<int>(type: "integer", nullable: true),
                    usuarioaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    grupoaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    unidadeaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    version = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]")
                },
                constraints: table =>
                {
                    table.PrimaryKey("valorcoluna_pkey", x => x.valorcolunaid);
                    table.ForeignKey(
                        name: "valorcoluna_fk",
                        column: x => x.residuo,
                        principalSchema: "agenda",
                        principalTable: "residuo",
                        principalColumn: "residuoid");
                    table.ForeignKey(
                        name: "valorcoluna_fk1",
                        column: x => x.controleresiduo,
                        principalSchema: "agenda",
                        principalTable: "controleresiduo",
                        principalColumn: "controleresiduoid");
                    table.ForeignKey(
                        name: "valorcoluna_fk2",
                        column: x => x.destinofinal,
                        principalSchema: "agenda",
                        principalTable: "destinofinal",
                        principalColumn: "destinofinalid");
                },
                comment: "template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Valor de Coluna]\r\nfiltersgrid[#text_filter,#text_filter]\r\n\r\ngridtitle[Lista de Valores de Coluna]");

            migrationBuilder.CreateTable(
                name: "analiseprojeto",
                schema: "agenda",
                columns: table => new
                {
                    analiseprojetoid = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    projeto = table.Column<int>(type: "integer", nullable: true),
                    analista = table.Column<int>(type: "integer", nullable: true),
                    datahora = table.Column<string>(type: "character varying", nullable: true),
                    numeroanalise = table.Column<int>(type: "integer", nullable: true),
                    numeroanalisereal = table.Column<int>(type: "integer", nullable: true),
                    grupoaud = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    unidadeaud = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    usuarioaud = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    version = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    codificacao = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("analiseprojeto_pkey", x => x.analiseprojetoid);
                    table.ForeignKey(
                        name: "analiseprojeto_fk",
                        column: x => x.projeto,
                        principalSchema: "agenda",
                        principalTable: "projeto",
                        principalColumn: "projetoid");
                    table.ForeignKey(
                        name: "analiseprojeto_fk1",
                        column: x => x.analista,
                        principalSchema: "agenda",
                        principalTable: "analista",
                        principalColumn: "analistaid");
                    table.ForeignKey(
                        name: "analiseprojeto_fk2",
                        column: x => x.codificacao,
                        principalSchema: "agenda",
                        principalTable: "codificacao",
                        principalColumn: "codificacaoid");
                });

            migrationBuilder.CreateTable(
                name: "historico",
                schema: "agenda",
                columns: table => new
                {
                    historicoid = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    projeto = table.Column<int>(type: "integer", nullable: false),
                    datahora = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    sequencia = table.Column<int>(type: "integer", nullable: false),
                    despacho = table.Column<string>(type: "character varying", nullable: false),
                    autor = table.Column<string>(type: "character varying", nullable: false),
                    grupoaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    usuarioaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    unidadeaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    version = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    exportado = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    dataexportado = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("historico_pkey", x => x.historicoid);
                    table.ForeignKey(
                        name: "historico_fk",
                        column: x => x.projeto,
                        principalSchema: "agenda",
                        principalTable: "projeto",
                        principalColumn: "projetoid");
                });

            migrationBuilder.CreateTable(
                name: "remessa",
                schema: "agenda",
                columns: table => new
                {
                    remessaid = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Código] \r\nforminputsize[7]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Código] \r\ncolumngridtype[ro] \r\ncolumngridsize[80] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    titulo = table.Column<string>(type: "character varying", nullable: true, comment: "forminputlabel[Titulo] \r\nforminputsize[70]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Titulo] \r\ncolumngridtype[ro] \r\ncolumngridsize[*] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]"),
                    data = table.Column<DateTime>(type: "timestamp without time zone", nullable: true, comment: "forminputlabel[Data Criacao] \r\nforminputsize[30]  \r\nforminputclass[datetime]\r\n\r\ngeragridmain[false]"),
                    descricao = table.Column<string>(type: "character varying", nullable: true, comment: "forminputlabel[Descricao] \r\nforminputsize[80]  \r\n\r\ngeragridmain[false]"),
                    grupoaud = table.Column<int>(type: "integer", nullable: true, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    usuarioaud = table.Column<int>(type: "integer", nullable: true, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    unidadeaud = table.Column<int>(type: "integer", nullable: true, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    version = table.Column<int>(type: "integer", nullable: true, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    projeto = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Projeto]\r\nforminputsize[250]\r\n\r\nsearchmode[combobox]\r\ncomboboxresultfield[projeto.titulo]\r\n\r\ngeragridmain[false]"),
                    remetente = table.Column<string>(type: "character(3)", fixedLength: true, maxLength: 3, nullable: true),
                    status = table.Column<string>(type: "character varying", nullable: true, comment: "PROF - Remessa em construção pelo Profissional.\r\nCONF - Remessa Conferida pelo Ananalista/Supervisor\r\nFIN - Remessa finalizada pelo Profissional.\r\nRMF - Remessa Final"),
                    exigido = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    despacho = table.Column<string>(type: "character varying", nullable: true),
                    despachosemadur = table.Column<string>(type: "character varying", nullable: true),
                    datahoraexigencia = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    analista = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("remessa_pkey", x => x.remessaid);
                    table.ForeignKey(
                        name: "remessa_fk",
                        column: x => x.projeto,
                        principalSchema: "agenda",
                        principalTable: "projeto",
                        principalColumn: "projetoid");
                    table.ForeignKey(
                        name: "remessa_fk1",
                        column: x => x.analista,
                        principalSchema: "agenda",
                        principalTable: "analista",
                        principalColumn: "analistaid");
                },
                comment: "template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Remessa]\r\n\r\nfiltersgrid[#text_filter,#text_filter] \r\n\r\n\r\ngridtitle[Lista de Remessa]\r\n\r\nmasterdetails[true]\r\ndetails[documento]");

            migrationBuilder.CreateTable(
                name: "arquivousuario",
                columns: table => new
                {
                    arquivousuarioid = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Código] forminputsize[7]  columngridid[] columngridtitle[Código] columngridtype[ro] columngridsize[80] columngridalign[left] columngridcolor[white]")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    usuario = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Usuário]\r\nforminputsize[50]\r\n\r\nsearchmode[popup]\r\npopupresultfield[nome]\r\npopupfieldsgrid[usuarioid,nome,login,senha:usuarioid]\r\n\r\ncolumngridid[usuario.nome]\r\ncolumngridtitle[Usuário]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    arquivo = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Arquivo]\r\nforminputsize[250]\r\n\r\nsearchmode[popup]\r\npopupresultfield[nome]\r\npopupfieldsgrid[arquivoid,nome,url,modulo.nome:arquivoid]\r\n\r\ncolumngridid[arquivo.nome]\r\ncolumngridtitle[Arquivo]\r\ncolumngridtype[ro]\r\ncolumngridsize[*]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    grantarquivo = table.Column<string>(type: "character varying", nullable: false, comment: "forminputlabel[GrantArquivo]\r\nforminputsize[50]\r\n\r\ngeragridmain[false]"),
                    denyarquivo = table.Column<string>(type: "character varying", nullable: false, comment: "forminputlabel[DenyArquivo]\r\nforminputsize[50]\r\n\r\ngeragridmain[false]"),
                    usuarioaud = table.Column<int>(type: "integer", nullable: true),
                    grupoaud = table.Column<int>(type: "integer", nullable: true),
                    unidadeaud = table.Column<int>(type: "integer", nullable: true, defaultValue: 0),
                    version = table.Column<int>(type: "integer", nullable: true, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("arquivousuario_pk", x => x.arquivousuarioid);
                    table.ForeignKey(
                        name: "arquivo_arquivousuario_fk",
                        column: x => x.arquivo,
                        principalTable: "arquivo",
                        principalColumn: "arquivoid");
                    table.ForeignKey(
                        name: "usuario_arquivousuario_fk",
                        column: x => x.usuario,
                        principalTable: "usuario",
                        principalColumn: "usuarioid");
                },
                comment: "template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]  \r\n\r\nformtitle[Cadastro de Arquivo / Usuário]   \r\nfieldsgrid[arquivousuarioid,usuario.nome,arquivo.url,permissao.nome:arquivousuarioid] \r\n\r\nfieldsform[arquivousuarioid,usuario.usuarioid,usuario.nome,arquivo.arquivoid,arquivo.url,permissao.permissaoid,permissao.nome] \r\n\r\ngridtitle[Lista de Arquivos / Usuário]");

            migrationBuilder.CreateTable(
                name: "documento",
                schema: "agenda",
                columns: table => new
                {
                    documentoid = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Código] \r\nforminputsize[7]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Código] \r\ncolumngridtype[ro] \r\ncolumngridsize[80] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    titulo = table.Column<string>(type: "character varying", nullable: true, comment: "forminputlabel[Titulo] \r\nforminputsize[70]  \r\n\r\ncolumngridid[] \r\ncolumngridtitle[Titulo] \r\ncolumngridtype[ro] \r\ncolumngridsize[*] \r\ncolumngridalign[left] \r\ncolumngridcolor[white]"),
                    caminho = table.Column<string>(type: "character varying", nullable: true, comment: "forminputlabel[Caminho] \r\nforminputsize[70]  \r\n\r\ngeragridmain[false]"),
                    situacao = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Situacao] \r\nforminputsize[250]  \r\n\r\n\r\nsearchmode[combobox]\r\ncomboboxresultfield[situacao.descricao]\r\n\r\ncolumngridid[situacao.descricao]\r\ncolumngridtitle[Situacao]\r\ncolumngridtype[ro]\r\ncolumngridsize[300]\r\ncolumngridalign[left]\r\ncolumngridcolor[white]"),
                    grupoaud = table.Column<int>(type: "integer", nullable: true, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    usuarioaud = table.Column<int>(type: "integer", nullable: true, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    unidadeaud = table.Column<int>(type: "integer", nullable: true, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    version = table.Column<int>(type: "integer", nullable: true, comment: "geraentity[false]\r\ngeraform[false]\r\ngeragridmain[false]"),
                    remessa = table.Column<int>(type: "integer", nullable: false, comment: "forminputlabel[Remessa]\r\nforminputsize[250]\r\n\r\nsearchmode[combobox]\r\ncomboboxresultfield[remessa.titulo]\r\n\r\ngeragridmain[false]"),
                    arquivo = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("documento_pkey", x => x.documentoid);
                    table.ForeignKey(
                        name: "documento_fk",
                        column: x => x.remessa,
                        principalSchema: "agenda",
                        principalTable: "remessa",
                        principalColumn: "remessaid");
                    table.ForeignKey(
                        name: "documento_fk1",
                        column: x => x.situacao,
                        principalSchema: "agenda",
                        principalTable: "situacao",
                        principalColumn: "situacaoid");
                    table.ForeignKey(
                        name: "documento_fk2",
                        column: x => x.arquivo,
                        principalSchema: "agenda",
                        principalTable: "arquivo",
                        principalColumn: "arquivoid");
                },
                comment: "template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]\r\n\r\nformtitle[Cadastro de Documentos]\r\n\r\nfiltersgrid[#text_filter,#text_filter] \r\n\r\n\r\ngridtitle[Lista de Documentos]\r\n");

            migrationBuilder.CreateTable(
                name: "remessaexigencia",
                schema: "agenda",
                columns: table => new
                {
                    remessaexigenciaid = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    remessa = table.Column<int>(type: "integer", nullable: false),
                    exigencia = table.Column<int>(type: "integer", nullable: true),
                    usuarioaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    grupoaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    unidadeaud = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    version = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    descricao = table.Column<string>(type: "character varying", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("remessaexigencia_pkey", x => x.remessaexigenciaid);
                    table.ForeignKey(
                        name: "remessaexigencia_fk",
                        column: x => x.remessa,
                        principalSchema: "agenda",
                        principalTable: "remessa",
                        principalColumn: "remessaid");
                    table.ForeignKey(
                        name: "remessaexigencia_fk1",
                        column: x => x.exigencia,
                        principalSchema: "agenda",
                        principalTable: "exigencia",
                        principalColumn: "exigenciaid");
                });

            migrationBuilder.CreateIndex(
                name: "IX_analiseprojeto_analista",
                schema: "agenda",
                table: "analiseprojeto",
                column: "analista");

            migrationBuilder.CreateIndex(
                name: "IX_analiseprojeto_codificacao",
                schema: "agenda",
                table: "analiseprojeto",
                column: "codificacao");

            migrationBuilder.CreateIndex(
                name: "IX_analiseprojeto_projeto",
                schema: "agenda",
                table: "analiseprojeto",
                column: "projeto");

            migrationBuilder.CreateIndex(
                name: "areareceptora_idx",
                schema: "residuos",
                table: "areareceptora",
                column: "inscricaomunicipal");

            migrationBuilder.CreateIndex(
                name: "IX_areareceptora_empresa",
                schema: "residuos",
                table: "areareceptora",
                column: "empresa");

            migrationBuilder.CreateIndex(
                name: "IX_areareceptora_transportadora",
                schema: "residuos",
                table: "areareceptora",
                column: "transportadora");

            migrationBuilder.CreateIndex(
                name: "IX_arquivo_modulosistema",
                table: "arquivo",
                column: "modulosistema");

            migrationBuilder.CreateIndex(
                name: "IX_arquivo_tipoarquivo1",
                schema: "agenda",
                table: "arquivo",
                column: "tipoarquivo");

            migrationBuilder.CreateIndex(
                name: "IX_arquivo_tipoarquivo",
                schema: "cartografia",
                table: "arquivo",
                column: "tipoarquivo");

            migrationBuilder.CreateIndex(
                name: "IX_arquivousuario_arquivo",
                table: "arquivousuario",
                column: "arquivo");

            migrationBuilder.CreateIndex(
                name: "IX_arquivousuario_usuario",
                table: "arquivousuario",
                column: "usuario");

            migrationBuilder.CreateIndex(
                name: "bairro_nome_idx",
                table: "bairro",
                column: "nome");

            migrationBuilder.CreateIndex(
                name: "bairro_uf_idx",
                table: "bairro",
                column: "estado");

            migrationBuilder.CreateIndex(
                name: "IX_bairro_regiaourbana",
                table: "bairro",
                column: "regiaourbana");

            migrationBuilder.CreateIndex(
                name: "IX_bairro_regiaourbana1",
                schema: "sisobra",
                table: "bairro",
                column: "regiaourbana");

            migrationBuilder.CreateIndex(
                name: "IX_certidao_tipoveiculodivulgacao",
                schema: "divulgacao",
                table: "certidao",
                column: "tipoveiculodivulgacao");

            migrationBuilder.CreateIndex(
                name: "IX_certidaoconformidade_tipoveiculodivulgacao",
                schema: "divulgacao",
                table: "certidaoconformidade",
                column: "tipoveiculodivulgacao");

            migrationBuilder.CreateIndex(
                name: "cidade_estado_idx",
                table: "cidade",
                column: "estado");

            migrationBuilder.CreateIndex(
                name: "cidade_nome_idx",
                table: "cidade",
                column: "nome");

            migrationBuilder.CreateIndex(
                name: "IX_controleresiduo_caracteristicaemp",
                schema: "agenda",
                table: "controleresiduo",
                column: "caracteristicaemp");

            migrationBuilder.CreateIndex(
                name: "IX_controleresiduo_status",
                schema: "agenda",
                table: "controleresiduo",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "IX_ctr_areareceptora",
                schema: "agenda",
                table: "ctr",
                column: "areareceptora");

            migrationBuilder.CreateIndex(
                name: "IX_ctr_prfage",
                schema: "agenda",
                table: "ctr",
                column: "prfage");

            migrationBuilder.CreateIndex(
                name: "IX_ctr_status",
                schema: "agenda",
                table: "ctr",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "IX_ctr_transportador",
                schema: "agenda",
                table: "ctr",
                column: "transportador");

            migrationBuilder.CreateIndex(
                name: "IX_ctr_areareceptora1",
                schema: "residuos",
                table: "ctr",
                column: "areareceptora");

            migrationBuilder.CreateIndex(
                name: "IX_ctr_areareceptora2",
                schema: "residuos",
                table: "ctr",
                column: "areareceptora2");

            migrationBuilder.CreateIndex(
                name: "IX_ctr_armazenamento",
                schema: "residuos",
                table: "ctr",
                column: "armazenamento");

            migrationBuilder.CreateIndex(
                name: "IX_ctr_empresa",
                schema: "residuos",
                table: "ctr",
                column: "empresa");

            migrationBuilder.CreateIndex(
                name: "IX_ctr_transportadora",
                schema: "residuos",
                table: "ctr",
                column: "transportadora");

            migrationBuilder.CreateIndex(
                name: "IX_ctr_unidade",
                schema: "residuos",
                table: "ctr",
                column: "unidade");

            migrationBuilder.CreateIndex(
                name: "IX_ctrresiduo_ctr",
                schema: "residuos",
                table: "ctrresiduo",
                column: "ctr");

            migrationBuilder.CreateIndex(
                name: "IX_ctrresiduo_unidade",
                schema: "residuos",
                table: "ctrresiduo",
                column: "unidade");

            migrationBuilder.CreateIndex(
                name: "IX_ctrresiduo_unidadetrans",
                schema: "residuos",
                table: "ctrresiduo",
                column: "unidadetrans");

            migrationBuilder.CreateIndex(
                name: "documento_arquivo_idx",
                schema: "agenda",
                table: "documento",
                column: "arquivo");

            migrationBuilder.CreateIndex(
                name: "documento_remessa_idx",
                schema: "agenda",
                table: "documento",
                column: "remessa");

            migrationBuilder.CreateIndex(
                name: "documento_situacao_idx",
                schema: "agenda",
                table: "documento",
                column: "situacao");

            migrationBuilder.CreateIndex(
                name: "IX_documento_arquivo",
                schema: "cartografia",
                table: "documento",
                column: "arquivo");

            migrationBuilder.CreateIndex(
                name: "IX_documento_remessa",
                schema: "cartografia",
                table: "documento",
                column: "remessa");

            migrationBuilder.CreateIndex(
                name: "IX_documento_situacao",
                schema: "cartografia",
                table: "documento",
                column: "situacao");

            migrationBuilder.CreateIndex(
                name: "empresa_cpfcnpj_idx",
                table: "empresa",
                column: "cpfcnpj");

            migrationBuilder.CreateIndex(
                name: "empresa_inscricaomunicipal_idx",
                table: "empresa",
                column: "inscricaomunicipal");

            migrationBuilder.CreateIndex(
                name: "IX_empresa_rua",
                schema: "divulgacao",
                table: "empresa",
                column: "rua");

            migrationBuilder.CreateIndex(
                name: "empresa_inscricaomunicipal_key1",
                schema: "residuos",
                table: "empresa",
                column: "inscricaomunicipal",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_empresaresiduo_armazenamento",
                schema: "residuos",
                table: "empresaresiduo",
                column: "armazenamento");

            migrationBuilder.CreateIndex(
                name: "IX_empresaresiduo_empresa",
                schema: "residuos",
                table: "empresaresiduo",
                column: "empresa");

            migrationBuilder.CreateIndex(
                name: "IX_extrato_tipoveiculodivulgacao",
                schema: "divulgacao",
                table: "extrato",
                column: "tipoveiculodivulgacao");

            migrationBuilder.CreateIndex(
                name: "IX_grupousuario_grupo",
                table: "grupousuario",
                column: "grupo");

            migrationBuilder.CreateIndex(
                name: "IX_grupousuario_sistema",
                table: "grupousuario",
                column: "sistema");

            migrationBuilder.CreateIndex(
                name: "IX_grupousuario_usuario",
                table: "grupousuario",
                column: "usuario");

            migrationBuilder.CreateIndex(
                name: "IX_historico_projeto",
                schema: "agenda",
                table: "historico",
                column: "projeto");

            migrationBuilder.CreateIndex(
                name: "IX_logacesso_sistema",
                table: "logacesso",
                column: "sistema");

            migrationBuilder.CreateIndex(
                name: "IX_logacesso_usuario",
                table: "logacesso",
                column: "usuario");

            migrationBuilder.CreateIndex(
                name: "IX_logsistema_sistema",
                table: "logsistema",
                column: "sistema");

            migrationBuilder.CreateIndex(
                name: "IX_modulogrupo_grupo",
                table: "modulogrupo",
                column: "grupo");

            migrationBuilder.CreateIndex(
                name: "IX_modulogrupo_modulosistema",
                table: "modulogrupo",
                column: "modulosistema");

            migrationBuilder.CreateIndex(
                name: "IX_modulosistema_modulo",
                table: "modulosistema",
                column: "modulo");

            migrationBuilder.CreateIndex(
                name: "IX_modulosistema_sistema",
                table: "modulosistema",
                column: "sistema");

            migrationBuilder.CreateIndex(
                name: "IX_modulosistemausuario_modulosistema",
                table: "modulosistemausuario",
                column: "modulosistema");

            migrationBuilder.CreateIndex(
                name: "IX_modulosistemausuario_usuario",
                table: "modulosistemausuario",
                column: "usuario");

            migrationBuilder.CreateIndex(
                name: "IX_nomecoluna_residuo",
                schema: "agenda",
                table: "nomecoluna",
                column: "residuo");

            migrationBuilder.CreateIndex(
                name: "IX_obra_bairro",
                schema: "sisobra",
                table: "obra",
                column: "bairro");

            migrationBuilder.CreateIndex(
                name: "IX_obra_classificacao",
                schema: "sisobra",
                table: "obra",
                column: "classificacao");

            migrationBuilder.CreateIndex(
                name: "IX_obra_contratado",
                schema: "sisobra",
                table: "obra",
                column: "contratado");

            migrationBuilder.CreateIndex(
                name: "IX_obra_evento",
                schema: "sisobra",
                table: "obra",
                column: "evento");

            migrationBuilder.CreateIndex(
                name: "IX_obra_faseobra",
                schema: "sisobra",
                table: "obra",
                column: "faseobra");

            migrationBuilder.CreateIndex(
                name: "IX_obra_fiscal",
                schema: "sisobra",
                table: "obra",
                column: "fiscal");

            migrationBuilder.CreateIndex(
                name: "IX_obra_fonterecurso",
                schema: "sisobra",
                table: "obra",
                column: "fonterecurso");

            migrationBuilder.CreateIndex(
                name: "IX_obra_ministerio",
                schema: "sisobra",
                table: "obra",
                column: "ministerio");

            migrationBuilder.CreateIndex(
                name: "IX_obra_recurso",
                schema: "sisobra",
                table: "obra",
                column: "recurso");

            migrationBuilder.CreateIndex(
                name: "IX_obra_status",
                schema: "sisobra",
                table: "obra",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "IX_obraandamento_obra",
                schema: "sisobra",
                table: "obraandamento",
                column: "obra");

            migrationBuilder.CreateIndex(
                name: "IX_obradata_obra",
                schema: "sisobra",
                table: "obradata",
                column: "obra");

            migrationBuilder.CreateIndex(
                name: "IX_obradata_status",
                schema: "sisobra",
                table: "obradata",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "IX_obradata_tipocontrole",
                schema: "sisobra",
                table: "obradata",
                column: "tipocontrole");

            migrationBuilder.CreateIndex(
                name: "IX_obraevento_evento",
                schema: "sisobra",
                table: "obraevento",
                column: "evento");

            migrationBuilder.CreateIndex(
                name: "IX_obraevento_obra",
                schema: "sisobra",
                table: "obraevento",
                column: "obra");

            migrationBuilder.CreateIndex(
                name: "IX_obraparlamentar_obra",
                schema: "sisobra",
                table: "obraparlamentar",
                column: "obra");

            migrationBuilder.CreateIndex(
                name: "IX_obraparlamentar_parlamentar",
                schema: "sisobra",
                table: "obraparlamentar",
                column: "parlamentar");

            migrationBuilder.CreateIndex(
                name: "IX_parlamentar_tipomandato",
                schema: "sisobra",
                table: "parlamentar",
                column: "tipomandato");

            migrationBuilder.CreateIndex(
                name: "IX_permissaoentidade_entidade",
                table: "permissaoentidade",
                column: "entidade");

            migrationBuilder.CreateIndex(
                name: "IX_permissaoentidade_grupo",
                table: "permissaoentidade",
                column: "grupo");

            migrationBuilder.CreateIndex(
                name: "IX_permissaoentidade_sistema",
                table: "permissaoentidade",
                column: "sistema");

            migrationBuilder.CreateIndex(
                name: "IX_pessoa_endereco",
                table: "pessoa",
                column: "endereco");

            migrationBuilder.CreateIndex(
                name: "IX_prfage_usuario",
                schema: "agenda",
                table: "prfage",
                column: "usuario");

            migrationBuilder.CreateIndex(
                name: "IX_projeto_assunto",
                schema: "agenda",
                table: "projeto",
                column: "assunto");

            migrationBuilder.CreateIndex(
                name: "IX_projeto_assuntoalt",
                schema: "agenda",
                table: "projeto",
                column: "assuntoalt");

            migrationBuilder.CreateIndex(
                name: "IX_projeto_atividade",
                schema: "agenda",
                table: "projeto",
                column: "atividade");

            migrationBuilder.CreateIndex(
                name: "IX_projeto_codificacao",
                schema: "agenda",
                table: "projeto",
                column: "codificacao");

            migrationBuilder.CreateIndex(
                name: "IX_projeto_fiscal",
                schema: "agenda",
                table: "projeto",
                column: "fiscal");

            migrationBuilder.CreateIndex(
                name: "IX_projeto_natureza",
                schema: "agenda",
                table: "projeto",
                column: "natureza");

            migrationBuilder.CreateIndex(
                name: "IX_projeto_profissional",
                schema: "agenda",
                table: "projeto",
                column: "profissional");

            migrationBuilder.CreateIndex(
                name: "IX_projeto_regiao",
                schema: "agenda",
                table: "projeto",
                column: "regiao");

            migrationBuilder.CreateIndex(
                name: "IX_projeto_zoneamento",
                schema: "agenda",
                table: "projeto",
                column: "zoneamento");

            migrationBuilder.CreateIndex(
                name: "projeto_analista_idx",
                schema: "agenda",
                table: "projeto",
                column: "analista");

            migrationBuilder.CreateIndex(
                name: "projeto_codseguranca_key",
                schema: "agenda",
                table: "projeto",
                column: "codseguranca",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "projeto_processo_key",
                schema: "agenda",
                table: "projeto",
                column: "processo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "projeto_processoexp_key",
                schema: "agenda",
                table: "projeto",
                column: "processoexp",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "projeto_status_idx",
                schema: "agenda",
                table: "projeto",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "projeto_teste",
                schema: "agenda",
                table: "projeto",
                column: "processo");

            migrationBuilder.CreateIndex(
                name: "IX_projeto_assunto1",
                schema: "cartografia",
                table: "projeto",
                column: "assunto");

            migrationBuilder.CreateIndex(
                name: "IX_projeto_status",
                schema: "cartografia",
                table: "projeto",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "IX_projetoana_analista",
                schema: "cartografia",
                table: "projetoana",
                column: "analista");

            migrationBuilder.CreateIndex(
                name: "IX_projetoana_projeto",
                schema: "cartografia",
                table: "projetoana",
                column: "projeto");

            migrationBuilder.CreateIndex(
                name: "IX_projetoins_projeto",
                schema: "cartografia",
                table: "projetoins",
                column: "projeto");

            migrationBuilder.CreateIndex(
                name: "IX_proprietario_rua",
                schema: "divulgacao",
                table: "proprietario",
                column: "rua");

            migrationBuilder.CreateIndex(
                name: "IX_remessa_analista",
                schema: "agenda",
                table: "remessa",
                column: "analista");

            migrationBuilder.CreateIndex(
                name: "IX_remessa_projeto",
                schema: "agenda",
                table: "remessa",
                column: "projeto");

            migrationBuilder.CreateIndex(
                name: "IX_remessa_analista1",
                schema: "cartografia",
                table: "remessa",
                column: "analista");

            migrationBuilder.CreateIndex(
                name: "IX_remessa_projeto1",
                schema: "cartografia",
                table: "remessa",
                column: "projeto");

            migrationBuilder.CreateIndex(
                name: "IX_remessaexigencia_exigencia",
                schema: "agenda",
                table: "remessaexigencia",
                column: "exigencia");

            migrationBuilder.CreateIndex(
                name: "IX_remessaexigencia_remessa",
                schema: "agenda",
                table: "remessaexigencia",
                column: "remessa");

            migrationBuilder.CreateIndex(
                name: "IX_requerimento_profissional",
                schema: "planurb",
                table: "requerimento",
                column: "profissional");

            migrationBuilder.CreateIndex(
                name: "IX_residuo_classe",
                schema: "agenda",
                table: "residuo",
                column: "classe");

            migrationBuilder.CreateIndex(
                name: "IX_residuo_armazenamento",
                schema: "residuos",
                table: "residuo",
                column: "armazenamento");

            migrationBuilder.CreateIndex(
                name: "IX_residuo_caracteristica",
                schema: "residuos",
                table: "residuo",
                column: "caracteristica");

            migrationBuilder.CreateIndex(
                name: "IX_residuo_classificacao",
                schema: "residuos",
                table: "residuo",
                column: "classificacao");

            migrationBuilder.CreateIndex(
                name: "IX_residuo_estadofisico",
                schema: "residuos",
                table: "residuo",
                column: "estadofisico");

            migrationBuilder.CreateIndex(
                name: "IX_residuoarea_areareceptora",
                schema: "residuos",
                table: "residuoarea",
                column: "areareceptora");

            migrationBuilder.CreateIndex(
                name: "IX_residuoarea_residuo",
                schema: "residuos",
                table: "residuoarea",
                column: "residuo");

            migrationBuilder.CreateIndex(
                name: "IX_residuocaracteristica_caracteristica",
                schema: "residuos",
                table: "residuocaracteristica",
                column: "caracteristica");

            migrationBuilder.CreateIndex(
                name: "IX_residuocaracteristica_residuo",
                schema: "residuos",
                table: "residuocaracteristica",
                column: "residuo");

            migrationBuilder.CreateIndex(
                name: "IX_residuos_areareceptora_rev",
                schema: "auditoria",
                table: "residuos_areareceptora",
                column: "rev");

            migrationBuilder.CreateIndex(
                name: "IX_residuos_armazenamento_rev",
                schema: "auditoria",
                table: "residuos_armazenamento",
                column: "rev");

            migrationBuilder.CreateIndex(
                name: "IX_residuos_ctr_rev",
                schema: "auditoria",
                table: "residuos_ctr",
                column: "rev");

            migrationBuilder.CreateIndex(
                name: "IX_residuos_ctrresiduo_rev",
                schema: "auditoria",
                table: "residuos_ctrresiduo",
                column: "rev");

            migrationBuilder.CreateIndex(
                name: "IX_residuos_empresa_rev",
                schema: "auditoria",
                table: "residuos_empresa",
                column: "rev");

            migrationBuilder.CreateIndex(
                name: "IX_residuos_estadofisico_rev",
                schema: "auditoria",
                table: "residuos_estadofisico",
                column: "rev");

            migrationBuilder.CreateIndex(
                name: "IX_residuos_residuo_rev",
                schema: "auditoria",
                table: "residuos_residuo",
                column: "rev");

            migrationBuilder.CreateIndex(
                name: "IX_residuos_transportadora_rev",
                schema: "auditoria",
                table: "residuos_transportadora",
                column: "rev");

            migrationBuilder.CreateIndex(
                name: "IX_residuos_unidade_rev",
                schema: "auditoria",
                table: "residuos_unidade",
                column: "rev");

            migrationBuilder.CreateIndex(
                name: "IX_rua_bairrofinal",
                table: "rua",
                column: "bairrofinal");

            migrationBuilder.CreateIndex(
                name: "IX_rua_bairroinicial",
                table: "rua",
                column: "bairroinicial");

            migrationBuilder.CreateIndex(
                name: "rua_cep_idx",
                table: "rua",
                column: "cep");

            migrationBuilder.CreateIndex(
                name: "rua_estado_idx",
                table: "rua",
                column: "estado");

            migrationBuilder.CreateIndex(
                name: "rua_nome_idx",
                table: "rua",
                column: "nome");

            migrationBuilder.CreateIndex(
                name: "IX_sistema_tema",
                table: "sistema",
                column: "tema");

            migrationBuilder.CreateIndex(
                name: "IX_sistemacontexto_sistema",
                table: "sistemacontexto",
                column: "sistema");

            migrationBuilder.CreateIndex(
                name: "transportadora_idx",
                schema: "residuos",
                table: "transportadora",
                column: "inscricaomunicipal");

            migrationBuilder.CreateIndex(
                name: "IX_transportadoraresiduo_residuo",
                schema: "residuos",
                table: "transportadoraresiduo",
                column: "residuo");

            migrationBuilder.CreateIndex(
                name: "IX_transportadoraresiduo_transportadora",
                schema: "residuos",
                table: "transportadoraresiduo",
                column: "transportadora");

            migrationBuilder.CreateIndex(
                name: "IX_unidade_tipounidade",
                table: "unidade",
                column: "tipounidade");

            migrationBuilder.CreateIndex(
                name: "IX_unidadeusuario_grupousuario",
                table: "unidadeusuario",
                column: "grupousuario");

            migrationBuilder.CreateIndex(
                name: "IX_unidadeusuario_unidade",
                table: "unidadeusuario",
                column: "unidade");

            migrationBuilder.CreateIndex(
                name: "IX_unidadeusuario_usuario",
                table: "unidadeusuario",
                column: "usuario");

            migrationBuilder.CreateIndex(
                name: "IX_usuariocargo_usuario",
                schema: "divulgacao",
                table: "usuariocargo",
                column: "usuario");

            migrationBuilder.CreateIndex(
                name: "IX_usuariosistema_sistema",
                table: "usuariosistema",
                column: "sistema");

            migrationBuilder.CreateIndex(
                name: "IX_usuariosistema_tema",
                table: "usuariosistema",
                column: "tema");

            migrationBuilder.CreateIndex(
                name: "IX_usuariosistema_usuario",
                table: "usuariosistema",
                column: "usuario");

            migrationBuilder.CreateIndex(
                name: "IX_valorcoluna_controleresiduo",
                schema: "agenda",
                table: "valorcoluna",
                column: "controleresiduo");

            migrationBuilder.CreateIndex(
                name: "IX_valorcoluna_destinofinal",
                schema: "agenda",
                table: "valorcoluna",
                column: "destinofinal");

            migrationBuilder.CreateIndex(
                name: "IX_valorcoluna_residuo",
                schema: "agenda",
                table: "valorcoluna",
                column: "residuo");

            migrationBuilder.CreateIndex(
                name: "IX_veiculodivulgacao_ocorrencia",
                schema: "divulgacao",
                table: "veiculodivulgacao",
                column: "ocorrencia");

            migrationBuilder.CreateIndex(
                name: "IX_veiculodivulgacao_tipoveiculodivulgacao",
                schema: "divulgacao",
                table: "veiculodivulgacao",
                column: "tipoveiculodivulgacao");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "analiseprojeto",
                schema: "agenda");

            migrationBuilder.DropTable(
                name: "arquivousuario");

            migrationBuilder.DropTable(
                name: "audit");

            migrationBuilder.DropTable(
                name: "audit",
                schema: "agenda");

            migrationBuilder.DropTable(
                name: "aviso");

            migrationBuilder.DropTable(
                name: "bemvindo",
                schema: "agenda");

            migrationBuilder.DropTable(
                name: "certidao",
                schema: "divulgacao");

            migrationBuilder.DropTable(
                name: "certidaoconformidade",
                schema: "divulgacao");

            migrationBuilder.DropTable(
                name: "cidade");

            migrationBuilder.DropTable(
                name: "comunicado",
                schema: "divulgacao");

            migrationBuilder.DropTable(
                name: "ctr",
                schema: "agenda");

            migrationBuilder.DropTable(
                name: "ctrresiduo",
                schema: "residuos");

            migrationBuilder.DropTable(
                name: "documento",
                schema: "agenda");

            migrationBuilder.DropTable(
                name: "documento",
                schema: "cartografia");

            migrationBuilder.DropTable(
                name: "empresa");

            migrationBuilder.DropTable(
                name: "empresa",
                schema: "divulgacao");

            migrationBuilder.DropTable(
                name: "empresaresiduo",
                schema: "residuos");

            migrationBuilder.DropTable(
                name: "extrato",
                schema: "divulgacao");

            migrationBuilder.DropTable(
                name: "historico",
                schema: "agenda");

            migrationBuilder.DropTable(
                name: "logacesso");

            migrationBuilder.DropTable(
                name: "logradouro");

            migrationBuilder.DropTable(
                name: "logsistema");

            migrationBuilder.DropTable(
                name: "mensagem",
                schema: "agenda");

            migrationBuilder.DropTable(
                name: "modulogrupo");

            migrationBuilder.DropTable(
                name: "modulosistemausuario");

            migrationBuilder.DropTable(
                name: "nomecoluna",
                schema: "agenda");

            migrationBuilder.DropTable(
                name: "numeroprocesso",
                schema: "agenda");

            migrationBuilder.DropTable(
                name: "obraandamento",
                schema: "sisobra");

            migrationBuilder.DropTable(
                name: "obradata",
                schema: "sisobra");

            migrationBuilder.DropTable(
                name: "obraevento",
                schema: "sisobra");

            migrationBuilder.DropTable(
                name: "obraparlamentar",
                schema: "sisobra");

            migrationBuilder.DropTable(
                name: "pedidoped",
                schema: "vistoria");

            migrationBuilder.DropTable(
                name: "permissaoentidade");

            migrationBuilder.DropTable(
                name: "pessoa");

            migrationBuilder.DropTable(
                name: "prfage_tmp",
                schema: "agenda");

            migrationBuilder.DropTable(
                name: "profissional",
                schema: "agenda");

            migrationBuilder.DropTable(
                name: "projeto",
                schema: "planurb");

            migrationBuilder.DropTable(
                name: "projeto_anistia",
                schema: "agenda");

            migrationBuilder.DropTable(
                name: "projetoana",
                schema: "cartografia");

            migrationBuilder.DropTable(
                name: "projetoins",
                schema: "cartografia");

            migrationBuilder.DropTable(
                name: "proprietario",
                schema: "divulgacao");

            migrationBuilder.DropTable(
                name: "recibo",
                schema: "auditoria");

            migrationBuilder.DropTable(
                name: "relatorio",
                schema: "divulgacao");

            migrationBuilder.DropTable(
                name: "relobra",
                schema: "sisobra");

            migrationBuilder.DropTable(
                name: "remessaexigencia",
                schema: "agenda");

            migrationBuilder.DropTable(
                name: "requerimento",
                schema: "planurb");

            migrationBuilder.DropTable(
                name: "residuoarea",
                schema: "residuos");

            migrationBuilder.DropTable(
                name: "residuocaracteristica",
                schema: "residuos");

            migrationBuilder.DropTable(
                name: "residuos_areareceptora",
                schema: "auditoria");

            migrationBuilder.DropTable(
                name: "residuos_armazenamento",
                schema: "auditoria");

            migrationBuilder.DropTable(
                name: "residuos_ctr",
                schema: "auditoria");

            migrationBuilder.DropTable(
                name: "residuos_ctrresiduo",
                schema: "auditoria");

            migrationBuilder.DropTable(
                name: "residuos_empresa",
                schema: "auditoria");

            migrationBuilder.DropTable(
                name: "residuos_estadofisico",
                schema: "auditoria");

            migrationBuilder.DropTable(
                name: "residuos_residuo",
                schema: "auditoria");

            migrationBuilder.DropTable(
                name: "residuos_transportadora",
                schema: "auditoria");

            migrationBuilder.DropTable(
                name: "residuos_unidade",
                schema: "auditoria");

            migrationBuilder.DropTable(
                name: "sistemacontexto");

            migrationBuilder.DropTable(
                name: "Teste");

            migrationBuilder.DropTable(
                name: "TesteOld");

            migrationBuilder.DropTable(
                name: "tipologradouro");

            migrationBuilder.DropTable(
                name: "tmpbairroregiao");

            migrationBuilder.DropTable(
                name: "tmpproc",
                schema: "agenda");

            migrationBuilder.DropTable(
                name: "transportadoraresiduo",
                schema: "residuos");

            migrationBuilder.DropTable(
                name: "unidadeusuario");

            migrationBuilder.DropTable(
                name: "usuariocargo",
                schema: "divulgacao");

            migrationBuilder.DropTable(
                name: "usuariosistema");

            migrationBuilder.DropTable(
                name: "valorcoluna",
                schema: "agenda");

            migrationBuilder.DropTable(
                name: "veiculodivulgacao",
                schema: "divulgacao");

            migrationBuilder.DropTable(
                name: "arquivo");

            migrationBuilder.DropTable(
                name: "transportador",
                schema: "agenda");

            migrationBuilder.DropTable(
                name: "areareceptora",
                schema: "agenda");

            migrationBuilder.DropTable(
                name: "ctr",
                schema: "residuos");

            migrationBuilder.DropTable(
                name: "situacao",
                schema: "agenda");

            migrationBuilder.DropTable(
                name: "arquivo",
                schema: "agenda");

            migrationBuilder.DropTable(
                name: "remessa",
                schema: "cartografia");

            migrationBuilder.DropTable(
                name: "situacao",
                schema: "cartografia");

            migrationBuilder.DropTable(
                name: "arquivo",
                schema: "cartografia");

            migrationBuilder.DropTable(
                name: "tipocontrole",
                schema: "sisobra");

            migrationBuilder.DropTable(
                name: "obra",
                schema: "sisobra");

            migrationBuilder.DropTable(
                name: "parlamentar",
                schema: "sisobra");

            migrationBuilder.DropTable(
                name: "entidade");

            migrationBuilder.DropTable(
                name: "endereco");

            migrationBuilder.DropTable(
                name: "rua");

            migrationBuilder.DropTable(
                name: "remessa",
                schema: "agenda");

            migrationBuilder.DropTable(
                name: "exigencia",
                schema: "agenda");

            migrationBuilder.DropTable(
                name: "profissional",
                schema: "planurb");

            migrationBuilder.DropTable(
                name: "revinfo",
                schema: "auditoria");

            migrationBuilder.DropTable(
                name: "residuo",
                schema: "residuos");

            migrationBuilder.DropTable(
                name: "unidade");

            migrationBuilder.DropTable(
                name: "grupousuario");

            migrationBuilder.DropTable(
                name: "residuo",
                schema: "agenda");

            migrationBuilder.DropTable(
                name: "controleresiduo",
                schema: "agenda");

            migrationBuilder.DropTable(
                name: "destinofinal",
                schema: "agenda");

            migrationBuilder.DropTable(
                name: "tipoveiculodivulgacao",
                schema: "divulgacao");

            migrationBuilder.DropTable(
                name: "ocorrencia",
                schema: "divulgacao");

            migrationBuilder.DropTable(
                name: "modulosistema");

            migrationBuilder.DropTable(
                name: "unidade",
                schema: "residuos");

            migrationBuilder.DropTable(
                name: "areareceptora",
                schema: "residuos");

            migrationBuilder.DropTable(
                name: "tipoarquivo",
                schema: "agenda");

            migrationBuilder.DropTable(
                name: "projeto",
                schema: "cartografia");

            migrationBuilder.DropTable(
                name: "analista",
                schema: "cartografia");

            migrationBuilder.DropTable(
                name: "tipoarquivo",
                schema: "cartografia");

            migrationBuilder.DropTable(
                name: "classificacao",
                schema: "sisobra");

            migrationBuilder.DropTable(
                name: "status",
                schema: "sisobra");

            migrationBuilder.DropTable(
                name: "contratado",
                schema: "sisobra");

            migrationBuilder.DropTable(
                name: "fiscal",
                schema: "sisobra");

            migrationBuilder.DropTable(
                name: "faseobra",
                schema: "sisobra");

            migrationBuilder.DropTable(
                name: "bairro",
                schema: "sisobra");

            migrationBuilder.DropTable(
                name: "recurso",
                schema: "sisobra");

            migrationBuilder.DropTable(
                name: "ministerio",
                schema: "sisobra");

            migrationBuilder.DropTable(
                name: "evento",
                schema: "sisobra");

            migrationBuilder.DropTable(
                name: "fonterecurso",
                schema: "sisobra");

            migrationBuilder.DropTable(
                name: "tipomandato",
                schema: "sisobra");

            migrationBuilder.DropTable(
                name: "bairro");

            migrationBuilder.DropTable(
                name: "projeto",
                schema: "agenda");

            migrationBuilder.DropTable(
                name: "estadofisico",
                schema: "residuos");

            migrationBuilder.DropTable(
                name: "classificacao",
                schema: "residuos");

            migrationBuilder.DropTable(
                name: "caracteristica",
                schema: "residuos");

            migrationBuilder.DropTable(
                name: "armazenamento",
                schema: "residuos");

            migrationBuilder.DropTable(
                name: "tipounidade");

            migrationBuilder.DropTable(
                name: "grupo");

            migrationBuilder.DropTable(
                name: "classe",
                schema: "agenda");

            migrationBuilder.DropTable(
                name: "status",
                schema: "agenda");

            migrationBuilder.DropTable(
                name: "caracteristicaemp",
                schema: "agenda");

            migrationBuilder.DropTable(
                name: "modulo");

            migrationBuilder.DropTable(
                name: "sistema");

            migrationBuilder.DropTable(
                name: "empresa",
                schema: "residuos");

            migrationBuilder.DropTable(
                name: "transportadora",
                schema: "residuos");

            migrationBuilder.DropTable(
                name: "status",
                schema: "cartografia");

            migrationBuilder.DropTable(
                name: "assunto",
                schema: "cartografia");

            migrationBuilder.DropTable(
                name: "regiaourbana",
                schema: "sisobra");

            migrationBuilder.DropTable(
                name: "regiaourbana");

            migrationBuilder.DropTable(
                name: "analista",
                schema: "agenda");

            migrationBuilder.DropTable(
                name: "codificacao",
                schema: "agenda");

            migrationBuilder.DropTable(
                name: "assunto",
                schema: "agenda");

            migrationBuilder.DropTable(
                name: "natureza",
                schema: "agenda");

            migrationBuilder.DropTable(
                name: "atividade",
                schema: "agenda");

            migrationBuilder.DropTable(
                name: "prfage",
                schema: "agenda");

            migrationBuilder.DropTable(
                name: "zoneamento",
                schema: "agenda");

            migrationBuilder.DropTable(
                name: "regiao",
                schema: "agenda");

            migrationBuilder.DropTable(
                name: "tema");

            migrationBuilder.DropTable(
                name: "usuario");

            migrationBuilder.DropSequence(
                name: "advogado_advogadoid_seq");

            migrationBuilder.DropSequence(
                name: "agenda_agendaid_seq",
                schema: "agenda");

            migrationBuilder.DropSequence(
                name: "analista_analistaid_seq",
                schema: "agenda");

            migrationBuilder.DropSequence(
                name: "arquivo_arquivoid_seq");

            migrationBuilder.DropSequence(
                name: "arquivo_arquivoid_seq",
                schema: "agenda");

            migrationBuilder.DropSequence(
                name: "arquivousuario_arquivousuarioid_seq");

            migrationBuilder.DropSequence(
                name: "aviso_avisoid_seq");

            migrationBuilder.DropSequence(
                name: "documento_documentoid_seq",
                schema: "agenda");

            migrationBuilder.DropSequence(
                name: "entidade_entidadeid_seq");

            migrationBuilder.DropSequence(
                name: "grupo_grupoid_seq");

            migrationBuilder.DropSequence(
                name: "grupousuario_grupousuarioid_seq");

            migrationBuilder.DropSequence(
                name: "hibernate_sequence",
                schema: "auditoria");

            migrationBuilder.DropSequence(
                name: "local_localid_seq");

            migrationBuilder.DropSequence(
                name: "logacesso_logacessoid_seq");

            migrationBuilder.DropSequence(
                name: "logsistema_logsistemaid_seq");

            migrationBuilder.DropSequence(
                name: "modulo_moduloid_seq");

            migrationBuilder.DropSequence(
                name: "modulogrupo_modulogrupoid_seq");

            migrationBuilder.DropSequence(
                name: "modulosistema_modulosistemaid_seq");

            migrationBuilder.DropSequence(
                name: "modulosistemausuario_modulosistemausuarioid_seq");

            migrationBuilder.DropSequence(
                name: "permissaoentidade_permissaoentidadeid_seq");

            migrationBuilder.DropSequence(
                name: "prfage_codprf_seq",
                schema: "agenda");

            migrationBuilder.DropSequence(
                name: "processo_processoid_seq");

            migrationBuilder.DropSequence(
                name: "processo_sequencia_seq");

            migrationBuilder.DropSequence(
                name: "projeto_projetoid_seq",
                schema: "agenda");

            migrationBuilder.DropSequence(
                name: "relatorioid_seq",
                schema: "divulgacao");

            migrationBuilder.DropSequence(
                name: "remessa_remessaid_seq",
                schema: "agenda");

            migrationBuilder.DropSequence(
                name: "sistema_sistemaid_seq");

            migrationBuilder.DropSequence(
                name: "situacao_situacaoid_seq");

            migrationBuilder.DropSequence(
                name: "situacao_situacaoid_seq",
                schema: "agenda");

            migrationBuilder.DropSequence(
                name: "tema_temaid_seq");

            migrationBuilder.DropSequence(
                name: "tipoarquivo_tipoarquivoid_seq",
                schema: "agenda");

            migrationBuilder.DropSequence(
                name: "tipoprocesso_tipoprocessoid_seq");

            migrationBuilder.DropSequence(
                name: "tipounidade_tipounidadeid_seq");

            migrationBuilder.DropSequence(
                name: "tramiteinterno_tramiteinternoid_seq");

            migrationBuilder.DropSequence(
                name: "transportadoraresiduo_transportadoraresiduoid_seq",
                schema: "residuos");

            migrationBuilder.DropSequence(
                name: "unidade_unidadeid_seq");

            migrationBuilder.DropSequence(
                name: "unidadeusuario_unidadeusuarioid_seq");

            migrationBuilder.DropSequence(
                name: "usuario_usuarioid_seq");

            migrationBuilder.DropSequence(
                name: "usuariosistema_usuariosistemaid_seq");
        }
    }
}

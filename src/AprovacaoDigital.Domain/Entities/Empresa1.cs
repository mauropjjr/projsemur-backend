using AprovacaoDigital.Domain.Common;
namespace AprovacaoDigital.Domain.Entities;

/// <summary>
/// template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs]
/// 
/// formtitle[Cadastro de Empresa]
/// filtersgrid[#text_filter,#text_filter,#text_filter]
/// 
/// gridtitle[Lista de Empresas]
/// </summary>
public class Empresa1 : BaseEntity
{
    /// <summary>
    /// forminputlabel[Código] 
    /// forminputsize[7]
    /// 
    /// columngridid[]
    /// columngridtitle[Código]
    /// columngridtype[ro]
    /// columngridsize[80]
    /// columngridalign[left]
    /// columngridcolor[white]
    /// </summary>
    public int Empresaid { get; set; }

    /// <summary>
    /// TIPO DA PESSOA ( PF / PJ / PFE)
    /// 
    /// forminputlabel[Tipo Pessoa]
    /// forminputsize[5]
    /// forminputclass[uppercase]
    /// 
    /// columngridid[]
    /// columngridtitle[Tipo-Pessoa]
    /// columngridtype[ro]
    /// columngridsize[80]
    /// columngridalign[left]
    /// columngridcolor[white]
    /// </summary>
    public string? Tipopessoa { get; set; }

    /// <summary>
    /// forminputlabel[Inscrição Municipal] 
    /// forminputsize[15]
    /// forminputclass[number]
    /// 
    /// columngridid[]
    /// columngridtitle[Inscrição Municipal]
    /// columngridtype[ro]
    /// columngridsize[100]
    /// columngridalign[left]
    /// columngridcolor[white]
    /// </summary>
    public string? Inscricaomunicipal { get; set; }

    /// <summary>
    /// forminputlabel[Nome Fantasia]
    /// forminputsize[50]
    /// forminputclass[uppercase]
    /// 
    /// columngridid[]
    /// columngridtitle[Nome-Fantasia]
    /// columngridtype[ro]
    /// columngridsize[*]
    /// columngridalign[left]
    /// columngridcolor[white]
    /// </summary>
    public string? Nomefantasia { get; set; }

    /// <summary>
    /// forminputlabel[Inscrição Estadual] 
    /// forminputsize[15]
    /// forminputclass[number]
    /// 
    /// columngridid[]
    /// columngridtitle[Inscrição Estadual]
    /// columngridtype[ro]
    /// columngridsize[100]
    /// columngridalign[left]
    /// columngridcolor[white]
    /// </summary>
    public string? Inscricaoestadual { get; set; }

    /// <summary>
    /// forminputlabel[CPF/CNPJ] 
    /// forminputsize[15]
    /// forminputclass[number]
    /// 
    /// columngridid[]
    /// columngridtitle[CPF/CNPJ]
    /// columngridtype[ro]
    /// columngridsize[100]
    /// columngridalign[left]
    /// columngridcolor[white]
    /// </summary>
    public string? Cpfcnpj { get; set; }

    /// <summary>
    /// forminputlabel[Contador]
    /// forminputsize[10]
    /// geragridmain[false]
    /// </summary>
    public int? Contador { get; set; }

    /// <summary>
    /// forminputlabel[Razão Social] 
    /// forminputsize[40]
    /// forminputclass[uppercase]
    /// geragridmain[false]
    /// </summary>
    public string? Razaosocial { get; set; }

    /// <summary>
    /// forminputlabel[Razão Social Reduzido] 
    /// forminputsize[30]
    /// forminputclass[uppercase]
    /// geragridmain[false]
    /// </summary>
    public string? Razaosocialreduzido { get; set; }

    /// <summary>
    /// SITUAÇÃO ( A / I )
    /// 
    /// forminputlabel[Situação] 
    /// forminputsize[10]
    /// forminputclass[uppercase]
    /// geragridmain[false]
    /// </summary>
    public string? Situacao { get; set; }

    /// <summary>
    /// forminputlabel[DDD-Fone Correspondência] 
    /// forminputsize[10]
    /// forminputclass[number]
    /// geragridmain[false]
    /// </summary>
    public string? Dddfonecorresp { get; set; }

    /// <summary>
    /// forminputlabel[Fone Correspondência] 
    /// forminputsize[15]
    /// forminputclass[uppercase]
    /// geragridmain[false]
    /// </summary>
    public string? Fonecorresp { get; set; }

    /// <summary>
    /// forminputlabel[DDD-Fax Correspondência]
    /// forminputsize[10]
    /// forminputclass[number]
    /// geragridmain[false]
    /// </summary>
    public string? Dddfaxcorresp { get; set; }

    /// <summary>
    /// forminputlabel[Fax Correspondência]
    /// forminputsize[15]
    /// forminputclass[uppercase]
    /// geragridmain[false]
    /// </summary>
    public string? Faxcorresp { get; set; }

    /// <summary>
    /// forminputlabel[DDD-Cel. Correspondência]
    /// forminputsize[10]
    /// forminputclass[number]
    /// geragridmain[false]
    /// </summary>
    public string? Dddcelcorresp { get; set; }

    /// <summary>
    /// forminputlabel[Cel. Correspondência]
    /// forminputsize[15]
    /// forminputclass[uppercase]
    /// geragridmain[false]
    /// </summary>
    public string? Celcorresp { get; set; }

    /// <summary>
    /// forminputlabel[Tipo Logradouro Correspondência]
    /// forminputsize[30]
    /// forminputclass[uppercase]
    /// geragridmain[false]
    /// </summary>
    public string? Tipologcorresp { get; set; }

    /// <summary>
    /// forminputlabel[Logradouro Correspondência]
    /// forminputsize[30]
    /// forminputclass[uppercase]
    /// geragridmain[false]
    /// </summary>
    public string? Logradourocorresp { get; set; }

    /// <summary>
    /// forminputlabel[Nº Correspondência]
    /// forminputsize[10]
    /// forminputclass[number]
    /// geragridmain[false]
    /// </summary>
    public int? Numeroendcorresp { get; set; }

    /// <summary>
    /// forminputlabel[Complemento Correspondência]
    /// forminputsize[30]
    /// forminputclass[uppercase]
    /// geragridmain[false]
    /// </summary>
    public string? Complendcorresp { get; set; }

    /// <summary>
    /// forminputlabel[Tipo Bairro Correspondência]
    /// forminputsize[20]
    /// forminputclass[uppercase]
    /// geragridmain[false]
    /// </summary>
    public string? Tipobairrocorresp { get; set; }

    /// <summary>
    /// forminputlabel[Bairro Correspondência]
    /// forminputsize[40]
    /// forminputclass[uppercase]
    /// geragridmain[false]
    /// </summary>
    public string? Bairrocorresp { get; set; }

    /// <summary>
    /// forminputlabel[CEP Correspondência]
    /// forminputsize[10]
    /// forminputclass[cep]
    /// geragridmain[false]
    /// </summary>
    public string? Cepcorresp { get; set; }

    /// <summary>
    /// forminputlabel[Distrito Correspondência]
    /// forminputsize[30]
    /// forminputclass[uppercase]
    /// geragridmain[false]
    /// </summary>
    public string? Distritocorresp { get; set; }

    /// <summary>
    /// forminputlabel[Cidade Correspondência]
    /// forminputsize[40]
    /// forminputclass[uppercase]
    /// geragridmain[false]
    /// </summary>
    public string? Cidadecorresp { get; set; }

    /// <summary>
    /// forminputlabel[UF Correspondência]
    /// forminputsize[20]
    /// forminputclass[uppercase]
    /// geragridmain[false]
    /// </summary>
    public string? Ufcorresp { get; set; }

    /// <summary>
    /// forminputlabel[Cod. País Correspondência]
    /// forminputsize[20]
    /// forminputclass[number]
    /// geragridmain[false]
    /// </summary>
    public int? Codpaiscorresp { get; set; }

    /// <summary>
    /// forminputlabel[DDD-Fone Localização]
    /// forminputsize[10]
    /// forminputclass[number]
    /// geragridmain[false]
    /// </summary>
    public string? Dddfonelocal { get; set; }

    /// <summary>
    /// forminputlabel[Fone Localização]
    /// forminputsize[15]
    /// forminputclass[uppercase]
    /// geragridmain[false]
    /// </summary>
    public string? Fonelocal { get; set; }

    /// <summary>
    /// forminputlabel[DDD-Fax Localização]
    /// forminputsize[10]
    /// forminputclass[number]
    /// geragridmain[false]
    /// </summary>
    public string? Dddfaxlocal { get; set; }

    /// <summary>
    /// forminputlabel[Fax Localização]
    /// forminputsize[15]
    /// forminputclass[uppercase]
    /// geragridmain[false]
    /// </summary>
    public string? Faxlocal { get; set; }

    /// <summary>
    /// forminputlabel[Tipo Logradouro Localização]
    /// forminputsize[20]
    /// forminputclass[uppercase]
    /// geragridmain[false]
    /// </summary>
    public string? Tipologlocal { get; set; }

    /// <summary>
    /// forminputlabel[Logradouro Localização]
    /// forminputsize[30]
    /// forminputclass[uppercase]
    /// geragridmain[false]
    /// </summary>
    public string? Logradourolocal { get; set; }

    /// <summary>
    /// forminputlabel[Complemento Endereço Localização]
    /// forminputsize[20]
    /// forminputclass[uppercase]
    /// geragridmain[false]
    /// </summary>
    public string? Complendlocal { get; set; }

    /// <summary>
    /// forminputlabel[Bairro Localização]
    /// forminputsize[30]
    /// forminputclass[uppercase]
    /// geragridmain[false]
    /// </summary>
    public string? Bairrolocal { get; set; }

    /// <summary>
    /// forminputlabel[Distrito Localização]
    /// forminputsize[30]
    /// forminputclass[uppercase]
    /// geragridmain[false]
    /// </summary>
    public string? Distritolocal { get; set; }

    /// <summary>
    /// forminputlabel[Cidade Localização]
    /// forminputsize[30]
    /// forminputclass[uppercase]
    /// geragridmain[false]
    /// </summary>
    public string? Cidadelocal { get; set; }

    /// <summary>
    /// forminputlabel[UF Localização]
    /// forminputsize[15]
    /// forminputclass[uppercase]
    /// geragridmain[false]
    /// </summary>
    public string? Uflocal { get; set; }

    /// <summary>
    /// forminputlabel[Código País Localização]
    /// forminputsize[30]
    /// forminputclass[number]
    /// geragridmain[false]
    /// </summary>
    public int? Codpaislocal { get; set; }

    /// <summary>
    /// forminputlabel[CEP Localização]
    /// forminputsize[10]
    /// forminputclass[cep]
    /// geragridmain[false]
    /// </summary>
    public string? Ceplocal { get; set; }

    /// <summary>
    /// forminputlabel[Número NIRE] 
    /// forminputsize[10]
    /// forminputclass[number]
    /// geragridmain[false]
    /// </summary>
    public string? Numeronire { get; set; }

    /// <summary>
    /// forminputlabel[Observação] 
    /// forminputsize[50]
    /// forminputclass[uppercase]
    /// </summary>
    public string? Observacao { get; set; }

    public string? Endlocal { get; set; }

    public string? Endcorresp { get; set; }

    /// <summary>
    /// geraform[false]
    /// geragridmain[false]
    /// </summary>
    public DateTime? Datahoraalteracao { get; set; }

    /// <summary>
    /// geraform[false]
    /// geragridmain[false]
    /// </summary>
    public string? Ipalteracao { get; set; }

    /// <summary>
    /// forminputlabel[Email]
    /// forminputsize[40]
    /// forminputclass[email]
    /// geragridmain[false]
    /// </summary>
    public string? Email { get; set; }

    public string? Senha { get; set; }

    public int? Usuario { get; set; }

    /// <summary>
    /// geraentity[false]
    /// geraform[false]
    /// geragridmain[false]
    /// </summary>
    public int? Usuarioaud { get; set; }

    /// <summary>
    /// geraentity[false]
    /// geraform[false]
    /// geragridmain[false]
    /// </summary>
    public int? Grupoaud { get; set; }

    /// <summary>
    /// geraentity[false]
    /// geraform[false]
    /// geragridmain[false]
    /// </summary>
    public int? Version { get; set; }

    /// <summary>
    /// geraentity[false]
    /// geraform[false]
    /// geragridmain[false]
    /// </summary>
    public int? Unidadeaud { get; set; }

    public string? Dddcellocal { get; set; }

    public string? Cellocal { get; set; }

    public int? Numeroendlocal { get; set; }

    public int? Usuarioalteracao { get; set; }

    public string? Cpfresponsavel { get; set; }

    public bool? Atualizadosiat { get; set; }

    public bool? Primeiraatualizacao { get; set; }

    /// <summary>
    /// Empresas ques estao visiveis (listagem grid) para o login da prefeitura
    /// </summary>
    public bool? Disponivel { get; set; }

    /// <summary>
    /// Este campo serve para validar quais empresas podem ou nao logar.
    /// </summary>
    public bool? Ativo { get; set; }

    public string? Respostaxml { get; set; }

    public int? Etapa { get; set; }
}

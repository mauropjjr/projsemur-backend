using AprovacaoDigital.Domain.Common;
namespace AprovacaoDigital.Domain.Entities;

/// <summary>
/// template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]  
/// 
/// formtitle[Cadastro de Log do sistema]   
/// fieldsgrid[logsistemaid,sistema.nome,versao,data:logsistemaid] 
/// 
/// fieldsform[logsistemaid,sistema.sistemaid,sistema.nome,versao,data] 
/// 
/// gridtitle[Lista de Logs do sistema]
/// </summary>
public class Logsistema : BaseEntity
{
    /// <summary>
    /// forminputlabel[Código] forminputsize[7]  columngridid[] columngridtitle[Código] columngridtype[ro] columngridsize[80] columngridalign[left] columngridcolor[white]
    /// </summary>
    public int Logsistemaid { get; set; }

    /// <summary>
    /// forminputlabel[Sistema]
    /// forminputsize[250]
    /// 
    /// searchmode[combobox]
    /// comboboxresultfield[nome]
    /// 
    /// columngridid[sistema.nome]
    /// columngridtitle[Sistema]
    /// columngridtype[ro]
    /// columngridsize[*]
    /// columngridalign[left]
    /// columngridcolor[white]
    /// </summary>
    public int Sistema { get; set; }

    /// <summary>
    /// forminputlabel[Versão] forminputsize[50]  columngridid[] columngridtitle[Versão] columngridtype[ro] columngridsize[100] columngridalign[left] columngridcolor[white]
    /// </summary>
    public string Versao { get; set; } = null!;

    public DateTime? Data { get; set; }

    public int? Usuarioaud { get; set; }

    public int? Grupoaud { get; set; }

    public int? Unidade { get; set; }

    public int? Version { get; set; }

    public int? Unidadeaud { get; set; }

    public virtual Sistema SistemaNavigation { get; set; } = null!;
}

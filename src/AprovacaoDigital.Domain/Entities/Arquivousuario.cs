using AprovacaoDigital.Domain.Common;
namespace AprovacaoDigital.Domain.Entities;

/// <summary>
/// template.build[geradaoimpl,geradaointer,geraentity,geralogica,geragridmain,geraform,gerajs,core]  
/// 
/// formtitle[Cadastro de Arquivo / Usuário]   
/// fieldsgrid[arquivousuarioid,usuario.nome,arquivo.url,permissao.nome:arquivousuarioid] 
/// 
/// fieldsform[arquivousuarioid,usuario.usuarioid,usuario.nome,arquivo.arquivoid,arquivo.url,permissao.permissaoid,permissao.nome] 
/// 
/// gridtitle[Lista de Arquivos / Usuário]
/// </summary>
public class Arquivousuario : BaseEntity
{
    /// <summary>
    /// forminputlabel[Código] forminputsize[7]  columngridid[] columngridtitle[Código] columngridtype[ro] columngridsize[80] columngridalign[left] columngridcolor[white]
    /// </summary>
    public int Arquivousuarioid { get; set; }

    /// <summary>
    /// forminputlabel[Usuário]
    /// forminputsize[50]
    /// 
    /// searchmode[popup]
    /// popupresultfield[nome]
    /// popupfieldsgrid[usuarioid,nome,login,senha:usuarioid]
    /// 
    /// columngridid[usuario.nome]
    /// columngridtitle[Usuário]
    /// columngridtype[ro]
    /// columngridsize[*]
    /// columngridalign[left]
    /// columngridcolor[white]
    /// </summary>
    public int Usuario { get; set; }

    /// <summary>
    /// forminputlabel[Arquivo]
    /// forminputsize[250]
    /// 
    /// searchmode[popup]
    /// popupresultfield[nome]
    /// popupfieldsgrid[arquivoid,nome,url,modulo.nome:arquivoid]
    /// 
    /// columngridid[arquivo.nome]
    /// columngridtitle[Arquivo]
    /// columngridtype[ro]
    /// columngridsize[*]
    /// columngridalign[left]
    /// columngridcolor[white]
    /// </summary>
    public int Arquivo { get; set; }

    /// <summary>
    /// forminputlabel[GrantArquivo]
    /// forminputsize[50]
    /// 
    /// geragridmain[false]
    /// </summary>
    public string Grantarquivo { get; set; } = null!;

    /// <summary>
    /// forminputlabel[DenyArquivo]
    /// forminputsize[50]
    /// 
    /// geragridmain[false]
    /// </summary>
    public string Denyarquivo { get; set; } = null!;

    public int? Usuarioaud { get; set; }

    public int? Grupoaud { get; set; }

    public int? Unidadeaud { get; set; }

    public int? Version { get; set; }

    public virtual Arquivo ArquivoNavigation { get; set; } = null!;

    public virtual Usuario UsuarioNavigation { get; set; } = null!;
}

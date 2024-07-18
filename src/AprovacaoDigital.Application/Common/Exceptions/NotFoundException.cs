
namespace AprovacaoDigital.Common.Exceptions;
public class NotFoundException : Exception
{
    public NotFoundException(string message, int id) : base(message)
    {
    }
}
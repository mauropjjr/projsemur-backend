
using FluentValidation.Results;
namespace AprovacaoDigital.Common.Exceptions;

public class BadRequestException : Exception
{
    public BadRequestException() : base("Uma ou mais validações")
    {
        Errors = new Dictionary<string, string[]>();
    }

    public BadRequestException(IEnumerable<ValidationFailure> failures) : this()
    {
        Errors = failures.GroupBy(e => e.PropertyName, e => e.ErrorMessage)
            .ToDictionary(failureGroup => failureGroup.Key, failureGroup => failureGroup.ToArray());
    }

    public IDictionary<string, string[]> Errors { get; }
}
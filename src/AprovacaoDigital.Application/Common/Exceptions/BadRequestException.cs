
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
            .ToDictionary(
                failureGroup => ToLowerCamelCase(failureGroup.Key),
                failureGroup => failureGroup.ToArray()
            );
    }

    public IDictionary<string, string[]> Errors { get; }

    private string ToLowerCamelCase(string str)
    {
        if (string.IsNullOrEmpty(str) || char.IsLower(str[0]))
        {
            return str;
        }

        return char.ToLower(str[0]) + str.Substring(1);
    }
}
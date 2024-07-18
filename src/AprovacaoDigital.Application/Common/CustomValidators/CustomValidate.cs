using System.Text.RegularExpressions;
namespace AprovacaoDigital.Common.CustomValidators;

public static class CustomValidate
{
    public static bool IsBase64String(string input)
    {
        /*
         Se for obrigatorio, trato direto no fluent
        */
        if (string.IsNullOrEmpty(input)) return true;
        try
        {
            byte[] buffer = Convert.FromBase64String(input);
            return true;
        }
        catch (FormatException)
        {
            return false;
        }
    }

    public static bool IsUrl(string input)
    {
        if (string.IsNullOrEmpty(input)) return true;
        // Regex pattern to validate URL
        string pattern = @"^(http|https)://([\w-]+\.)+[\w-]+(/[\w-./?%&=]*)?$";
        Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);

        return regex.IsMatch(input);
    }
    public static bool IsEmail(string input)
    {
        if (string.IsNullOrEmpty(input)) return true;

        string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
        Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);

        return regex.IsMatch(input);
    }


}


using System.Globalization;

namespace CubicEquationApp;

public static class NumericParser
{
    public static bool TryParse(string? input, out double value)
    {
        value = 0;

        if (string.IsNullOrWhiteSpace(input))
        {
            return false;
        }

        var trimmed = input.Trim();

        foreach (var ch in trimmed)
        {
            if (char.IsLetter(ch))
            {
                return false;
            }
        }

        var normalized = trimmed.Replace(',', '.');

        if (!double.TryParse(
                normalized,
                NumberStyles.Float | NumberStyles.AllowLeadingSign,
                CultureInfo.InvariantCulture,
                out value))
        {
            return false;
        }

        if (double.IsNaN(value) || double.IsInfinity(value))
        {
            return false;
        }

        return true;
    }
}

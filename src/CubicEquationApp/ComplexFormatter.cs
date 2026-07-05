using System.Globalization;
using System.Numerics;

namespace CubicEquationApp;

public static class ComplexFormatter
{
    private const double DisplayEpsilon = 1E-6;

    public static string Format(Complex value)
    {
        var real = NormalizeSmallValue(value.Real);
        var imag = NormalizeSmallValue(value.Imaginary);

        if (Math.Abs(imag) < DisplayEpsilon)
        {
            return FormatReal(real);
        }

        if (Math.Abs(real) < DisplayEpsilon)
        {
            if (Math.Abs(imag - 1) < DisplayEpsilon)
            {
                return "i";
            }

            if (Math.Abs(imag + 1) < DisplayEpsilon)
            {
                return "-i";
            }

            return $"{FormatReal(imag)}i";
        }

        var imagAbs = Math.Abs(imag);
        var imagPart = Math.Abs(imagAbs - 1) < DisplayEpsilon
            ? "i"
            : $"{FormatReal(imagAbs)}i";

        return imag < 0
            ? $"{FormatReal(real)} - {imagPart}"
            : $"{FormatReal(real)} + {imagPart}";
    }

    private static double NormalizeSmallValue(double value)
    {
        return Math.Abs(value) < DisplayEpsilon ? 0 : value;
    }

    private static string FormatReal(double value)
    {
        value = NormalizeSmallValue(value);

        if (Math.Abs(value - Math.Round(value)) < DisplayEpsilon)
        {
            return ((long)Math.Round(value)).ToString(CultureInfo.InvariantCulture);
        }

        return value.ToString("0.######", CultureInfo.InvariantCulture);
    }
}

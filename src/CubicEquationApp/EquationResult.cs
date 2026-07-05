using System.Numerics;

namespace CubicEquationApp;

public class EquationResult
{
    public EquationKind Kind { get; }

    public List<Complex> Roots { get; }

    public string Message { get; }

    public EquationResult(EquationKind kind, List<Complex>? roots, string? message)
    {
        Kind = kind;
        Roots = roots ?? new List<Complex>();
        Message = message ?? string.Empty;
    }
}

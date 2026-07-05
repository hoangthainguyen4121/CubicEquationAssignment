using System.Numerics;

namespace CubicEquationApp;

public static class CubicEquationSolver
{
    private const double Epsilon = 1E-10;

    public static EquationResult Solve(double a, double b, double c, double d)
    {
        if (!IsZero(a))
        {
            return SolveCubic(a, b, c, d);
        }

        if (!IsZero(b))
        {
            return SolveQuadratic(b, c, d);
        }

        if (!IsZero(c))
        {
            return SolveLinear(c, d);
        }

        if (IsZero(d))
        {
            return new EquationResult(
                EquationKind.InfiniteSolutions,
                new List<Complex>(),
                "Phương trình có vô số nghiệm.");
        }

        return new EquationResult(
            EquationKind.NoSolution,
            new List<Complex>(),
            "Phương trình vô nghiệm.");
    }

    private static EquationResult SolveCubic(double a, double b, double c, double d)
    {
        var bigA = b / a;
        var bigB = c / a;
        var bigC = d / a;

        var p = bigB - (bigA * bigA) / 3.0;
        var q = (2.0 * bigA * bigA * bigA) / 27.0 - (bigA * bigB) / 3.0 + bigC;
        var delta = Math.Pow(q / 2.0, 2) + Math.Pow(p / 3.0, 3);

        if (delta > Epsilon)
        {
            var sqrtDelta = Math.Sqrt(delta);
            var u = CubeRoot(-q / 2.0 + sqrtDelta);
            var v = CubeRoot(-q / 2.0 - sqrtDelta);

            var x1 = u + v - bigA / 3.0;
            var realPart = -(u + v) / 2.0 - bigA / 3.0;
            var imaginaryPart = Math.Sqrt(3.0) * (u - v) / 2.0;

            var roots = new List<Complex>
            {
                new(NormalizeSmallValue(x1), 0),
                new(NormalizeSmallValue(realPart), NormalizeSmallValue(imaginaryPart)),
                new(NormalizeSmallValue(realPart), NormalizeSmallValue(-imaginaryPart))
            };

            return new EquationResult(
                EquationKind.Cubic,
                roots,
                "Phương trình có một nghiệm thực và hai nghiệm phức liên hợp.");
        }

        if (Math.Abs(delta) <= Epsilon)
        {
            var u = CubeRoot(-q / 2.0);
            var x1 = 2.0 * u - bigA / 3.0;
            var x2 = -u - bigA / 3.0;

            var roots = new List<Complex>
            {
                new(NormalizeSmallValue(x1), 0),
                new(NormalizeSmallValue(x2), 0),
                new(NormalizeSmallValue(x2), 0)
            };

            var message = IsZero(u)
                ? "Phương trình có một nghiệm thực bội ba."
                : "Phương trình có một nghiệm đơn và một nghiệm kép.";

            return new EquationResult(EquationKind.Cubic, roots, message);
        }

        var negPOver3Cubed = -(p / 3.0);
        var radius = 2.0 * Math.Sqrt(negPOver3Cubed);
        var cosArg = -q / (2.0 * Math.Sqrt(Math.Pow(negPOver3Cubed, 3)));
        cosArg = Math.Clamp(cosArg, -1.0, 1.0);

        var theta = Math.Acos(cosArg);
        var shift = bigA / 3.0;

        var realRoots = new List<Complex>
        {
            new(NormalizeSmallValue(radius * Math.Cos(theta / 3.0) - shift), 0),
            new(NormalizeSmallValue(radius * Math.Cos((theta + 2.0 * Math.PI) / 3.0) - shift), 0),
            new(NormalizeSmallValue(radius * Math.Cos((theta + 4.0 * Math.PI) / 3.0) - shift), 0)
        };

        SortRoots(realRoots);

        return new EquationResult(
            EquationKind.Cubic,
            realRoots,
            "Phương trình có ba nghiệm thực phân biệt.");
    }

    private static EquationResult SolveQuadratic(double b, double c, double d)
    {
        var delta = c * c - 4.0 * b * d;

        if (delta > Epsilon)
        {
            var sqrtDelta = Math.Sqrt(delta);
            var x1 = (-c + sqrtDelta) / (2.0 * b);
            var x2 = (-c - sqrtDelta) / (2.0 * b);

            var roots = new List<Complex>
            {
                new(NormalizeSmallValue(x1), 0),
                new(NormalizeSmallValue(x2), 0)
            };

            SortRoots(roots);

            return new EquationResult(
                EquationKind.Quadratic,
                roots,
                "Phương trình có hai nghiệm thực phân biệt.");
        }

        if (Math.Abs(delta) <= Epsilon)
        {
            var x = -c / (2.0 * b);
            var root = new Complex(NormalizeSmallValue(x), 0);

            return new EquationResult(
                EquationKind.Quadratic,
                new List<Complex> { root, root },
                "Phương trình có một nghiệm kép.");
        }

        var realPart = -c / (2.0 * b);
        var imagPart = Math.Sqrt(-delta) / (2.0 * b);

        return new EquationResult(
            EquationKind.Quadratic,
            new List<Complex>
            {
                new(NormalizeSmallValue(realPart), NormalizeSmallValue(imagPart)),
                new(NormalizeSmallValue(realPart), NormalizeSmallValue(-imagPart))
            },
            "Phương trình có hai nghiệm phức liên hợp.");
    }

    private static EquationResult SolveLinear(double c, double d)
    {
        var x = -d / c;

        return new EquationResult(
            EquationKind.Linear,
            new List<Complex> { new(NormalizeSmallValue(x), 0) },
            "Phương trình bậc nhất có một nghiệm thực.");
    }

    private static double CubeRoot(double value)
    {
        if (IsZero(value))
        {
            return 0;
        }

        return Math.Sign(value) * Math.Pow(Math.Abs(value), 1.0 / 3.0);
    }

    private static bool IsZero(double value)
    {
        return Math.Abs(value) <= Epsilon;
    }

    private static double NormalizeSmallValue(double value)
    {
        return IsZero(value) ? 0 : value;
    }

    private static void SortRoots(List<Complex> roots)
    {
        roots.Sort((left, right) =>
        {
            var realCompare = left.Real.CompareTo(right.Real);
            if (realCompare != 0)
            {
                return realCompare;
            }

            return left.Imaginary.CompareTo(right.Imaginary);
        });
    }
}

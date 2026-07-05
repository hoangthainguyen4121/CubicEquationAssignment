using System.Numerics;
using CubicEquationApp;

namespace CubicEquationApp.Tests;

[TestClass]
public class CubicEquationSolverTests
{
    private const double Tolerance = 1E-6;

    [TestMethod]
    public void Solve_CubicThreeDistinctRealRoots_ReturnsOneTwoThree()
    {
        var result = CubicEquationSolver.Solve(1, -6, 11, -6);

        Assert.AreEqual(EquationKind.Cubic, result.Kind);
        Assert.AreEqual(3, result.Roots.Count);
        AssertRoot(result.Roots[0], 1);
        AssertRoot(result.Roots[1], 2);
        AssertRoot(result.Roots[2], 3);
    }

    [TestMethod]
    public void Solve_CubicDoubleAndSingleRoot_ReturnsMinusTwoOneOne()
    {
        var result = CubicEquationSolver.Solve(1, 0, -3, 2);

        Assert.AreEqual(EquationKind.Cubic, result.Kind);
        Assert.AreEqual(3, result.Roots.Count);
        AssertRoot(result.Roots[0], -2);
        AssertRoot(result.Roots[1], 1);
        AssertRoot(result.Roots[2], 1);
    }

    [TestMethod]
    public void Solve_CubicTripleRoot_ReturnsZeroZeroZero()
    {
        var result = CubicEquationSolver.Solve(1, 0, 0, 0);

        Assert.AreEqual(EquationKind.Cubic, result.Kind);
        Assert.AreEqual(3, result.Roots.Count);
        AssertRoot(result.Roots[0], 0);
        AssertRoot(result.Roots[1], 0);
        AssertRoot(result.Roots[2], 0);
    }

    [TestMethod]
    public void Solve_CubicOneRealTwoComplex_ReturnsExpectedRoots()
    {
        var result = CubicEquationSolver.Solve(1, 0, 0, 1);

        Assert.AreEqual(EquationKind.Cubic, result.Kind);
        Assert.AreEqual(3, result.Roots.Count);
        AssertRoot(result.Roots[0], -1);
        AssertRoot(result.Roots[1], 0.5, 0.866025);
        AssertRoot(result.Roots[2], 0.5, -0.866025);
    }

    [TestMethod]
    public void Solve_QuadraticTwoRealRoots_ReturnsTwoAndThree()
    {
        var result = CubicEquationSolver.Solve(0, 1, -5, 6);

        Assert.AreEqual(EquationKind.Quadratic, result.Kind);
        Assert.AreEqual(2, result.Roots.Count);
        AssertRoot(result.Roots[0], 2);
        AssertRoot(result.Roots[1], 3);
    }

    [TestMethod]
    public void Solve_QuadraticDoubleRoot_ReturnsMinusOneMinusOne()
    {
        var result = CubicEquationSolver.Solve(0, 1, 2, 1);

        Assert.AreEqual(EquationKind.Quadratic, result.Kind);
        Assert.AreEqual(2, result.Roots.Count);
        AssertRoot(result.Roots[0], -1);
        AssertRoot(result.Roots[1], -1);
    }

    [TestMethod]
    public void Solve_QuadraticComplexRoots_ReturnsPlusMinusI()
    {
        var result = CubicEquationSolver.Solve(0, 1, 0, 1);

        Assert.AreEqual(EquationKind.Quadratic, result.Kind);
        Assert.AreEqual(2, result.Roots.Count);
        AssertRoot(result.Roots[0], 0, 1);
        AssertRoot(result.Roots[1], 0, -1);
    }

    [TestMethod]
    public void Solve_LinearEquation_ReturnsTwo()
    {
        var result = CubicEquationSolver.Solve(0, 0, 2, -4);

        Assert.AreEqual(EquationKind.Linear, result.Kind);
        Assert.AreEqual(1, result.Roots.Count);
        AssertRoot(result.Roots[0], 2);
    }

    [TestMethod]
    public void Solve_AllZeroCoefficients_ReturnsInfiniteSolutions()
    {
        var result = CubicEquationSolver.Solve(0, 0, 0, 0);

        Assert.AreEqual(EquationKind.InfiniteSolutions, result.Kind);
        Assert.AreEqual(0, result.Roots.Count);
    }

    [TestMethod]
    public void Solve_ConstantNonZeroEquation_ReturnsNoSolution()
    {
        var result = CubicEquationSolver.Solve(0, 0, 0, 5);

        Assert.AreEqual(EquationKind.NoSolution, result.Kind);
        Assert.AreEqual(0, result.Roots.Count);
    }

    [TestMethod]
    public void NumericParser_AcceptsCommaDecimalSeparator()
    {
        Assert.IsTrue(NumericParser.TryParse("1,5", out var value));
        Assert.AreEqual(1.5, value, Tolerance);
    }

    [TestMethod]
    public void NumericParser_RejectsInvalidInput()
    {
        Assert.IsFalse(NumericParser.TryParse("abc", out _));
        Assert.IsFalse(NumericParser.TryParse(string.Empty, out _));
        Assert.IsFalse(NumericParser.TryParse("Infinity", out _));
    }

    private static void AssertRoot(Complex actual, double expectedReal, double expectedImag = 0)
    {
        Assert.AreEqual(expectedReal, actual.Real, Tolerance);
        Assert.AreEqual(expectedImag, actual.Imaginary, Tolerance);
    }
}

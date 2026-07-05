namespace CubicEquationApp;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void btnSolve_Click(object sender, EventArgs e)
    {
        if (!TryReadCoefficient(txtA, "a", out var a))
        {
            return;
        }

        if (!TryReadCoefficient(txtB, "b", out var b))
        {
            return;
        }

        if (!TryReadCoefficient(txtC, "c", out var c))
        {
            return;
        }

        if (!TryReadCoefficient(txtD, "d", out var d))
        {
            return;
        }

        var result = CubicEquationSolver.Solve(a, b, c, d);

        lblEquationType.Text = GetEquationKindText(result.Kind);
        lblMessage.Text = result.Message;

        txtX1.Text = result.Roots.Count > 0 ? ComplexFormatter.Format(result.Roots[0]) : string.Empty;
        txtX2.Text = result.Roots.Count > 1 ? ComplexFormatter.Format(result.Roots[1]) : string.Empty;
        txtX3.Text = result.Roots.Count > 2 ? ComplexFormatter.Format(result.Roots[2]) : string.Empty;
    }

    private void btnReset_Click(object sender, EventArgs e)
    {
        txtA.Clear();
        txtB.Clear();
        txtC.Clear();
        txtD.Clear();
        txtX1.Clear();
        txtX2.Clear();
        txtX3.Clear();
        lblEquationType.Text = "—";
        lblMessage.Text = "—";
        txtA.Focus();
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
        var answer = MessageBox.Show(
            "Bạn có muốn thoát chương trình không?",
            "Xác nhận",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (answer == DialogResult.Yes)
        {
            Close();
        }
    }

    private bool TryReadCoefficient(TextBox textBox, string coefficientName, out double value)
    {
        if (NumericParser.TryParse(textBox.Text, out value))
        {
            return true;
        }

        MessageBox.Show(
            $"Hệ số {coefficientName} không hợp lệ. Vui lòng nhập một số thực.",
            "Dữ liệu không hợp lệ",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning);

        textBox.Focus();
        textBox.SelectAll();
        value = 0;
        return false;
    }

    private static string GetEquationKindText(EquationKind kind)
    {
        return kind switch
        {
            EquationKind.Cubic => "Phương trình bậc ba",
            EquationKind.Quadratic => "Phương trình bậc hai",
            EquationKind.Linear => "Phương trình bậc nhất",
            EquationKind.InfiniteSolutions => "Phương trình có vô số nghiệm",
            EquationKind.NoSolution => "Phương trình vô nghiệm",
            _ => "—"
        };
    }
}

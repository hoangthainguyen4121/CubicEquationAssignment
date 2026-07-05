namespace CubicEquationApp;

partial class MainForm
{
    private System.ComponentModel.IContainer components = null;

    private GroupBox grpInput;
    private TableLayoutPanel tblEquation;
    private Label lblTitle;
    private TextBox txtA;
    private Label lblX3;
    private TextBox txtB;
    private Label lblX2;
    private TextBox txtC;
    private Label lblX1;
    private TextBox txtD;
    private Label lblEqualZero;
    private FlowLayoutPanel pnlButtons;
    private Button btnSolve;
    private Button btnReset;
    private Button btnExit;
    private GroupBox grpResult;
    private TableLayoutPanel tblResult;
    private Label lblEquationTypeCaption;
    private Label lblEquationType;
    private Label lblRoot1Caption;
    private TextBox txtX1;
    private Label lblRoot2Caption;
    private TextBox txtX2;
    private Label lblRoot3Caption;
    private TextBox txtX3;
    private GroupBox grpMessage;
    private Label lblMessageCaption;
    private Label lblMessage;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null)
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        grpInput = new GroupBox();
        tblEquation = new TableLayoutPanel();
        lblTitle = new Label();
        txtA = new TextBox();
        lblX3 = new Label();
        txtB = new TextBox();
        lblX2 = new Label();
        txtC = new TextBox();
        lblX1 = new Label();
        txtD = new TextBox();
        lblEqualZero = new Label();
        pnlButtons = new FlowLayoutPanel();
        btnSolve = new Button();
        btnReset = new Button();
        btnExit = new Button();
        grpResult = new GroupBox();
        tblResult = new TableLayoutPanel();
        lblEquationTypeCaption = new Label();
        lblEquationType = new Label();
        lblRoot1Caption = new Label();
        txtX1 = new TextBox();
        lblRoot2Caption = new Label();
        txtX2 = new TextBox();
        lblRoot3Caption = new Label();
        txtX3 = new TextBox();
        grpMessage = new GroupBox();
        lblMessageCaption = new Label();
        lblMessage = new Label();
        grpInput.SuspendLayout();
        tblEquation.SuspendLayout();
        pnlButtons.SuspendLayout();
        grpResult.SuspendLayout();
        tblResult.SuspendLayout();
        grpMessage.SuspendLayout();
        SuspendLayout();
        // 
        // grpInput
        // 
        grpInput.Controls.Add(tblEquation);
        grpInput.Controls.Add(pnlButtons);
        grpInput.Dock = DockStyle.Top;
        grpInput.Font = new Font("Segoe UI", 10F);
        grpInput.Location = new Point(12, 12);
        grpInput.Name = "grpInput";
        grpInput.Padding = new Padding(12);
        grpInput.Size = new Size(826, 170);
        grpInput.TabIndex = 0;
        grpInput.TabStop = false;
        grpInput.Text = "Nhập hệ số";
        // 
        // tblEquation
        // 
        tblEquation.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        tblEquation.ColumnCount = 9;
        tblEquation.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
        tblEquation.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
        tblEquation.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
        tblEquation.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
        tblEquation.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
        tblEquation.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
        tblEquation.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
        tblEquation.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
        tblEquation.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tblEquation.Controls.Add(lblTitle, 0, 0);
        tblEquation.SetColumnSpan(lblTitle, 9);
        tblEquation.Controls.Add(txtA, 0, 1);
        tblEquation.Controls.Add(lblX3, 1, 1);
        tblEquation.Controls.Add(txtB, 2, 1);
        tblEquation.Controls.Add(lblX2, 3, 1);
        tblEquation.Controls.Add(txtC, 4, 1);
        tblEquation.Controls.Add(lblX1, 5, 1);
        tblEquation.Controls.Add(txtD, 6, 1);
        tblEquation.Controls.Add(lblEqualZero, 7, 1);
        tblEquation.Location = new Point(15, 28);
        tblEquation.Name = "tblEquation";
        tblEquation.RowCount = 2;
        tblEquation.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        tblEquation.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        tblEquation.Size = new Size(796, 80);
        tblEquation.TabIndex = 0;
        // 
        // lblTitle
        // 
        lblTitle.Anchor = AnchorStyles.None;
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        lblTitle.Location = new Point(262, 6);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(272, 25);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "GIẢI PHƯƠNG TRÌNH BẬC BA";
        lblTitle.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // txtA
        // 
        txtA.Dock = DockStyle.Fill;
        txtA.Location = new Point(3, 43);
        txtA.Name = "txtA";
        txtA.Size = new Size(74, 25);
        txtA.TabIndex = 0;
        // 
        // lblX3
        // 
        lblX3.Anchor = AnchorStyles.Left;
        lblX3.AutoSize = true;
        lblX3.Location = new Point(83, 47);
        lblX3.Name = "lblX3";
        lblX3.Size = new Size(22, 19);
        lblX3.TabIndex = 1;
        lblX3.Text = "x³";
        // 
        // txtB
        // 
        txtB.Dock = DockStyle.Fill;
        txtB.Location = new Point(111, 43);
        txtB.Name = "txtB";
        txtB.Size = new Size(74, 25);
        txtB.TabIndex = 1;
        // 
        // lblX2
        // 
        lblX2.Anchor = AnchorStyles.Left;
        lblX2.AutoSize = true;
        lblX2.Location = new Point(191, 47);
        lblX2.Name = "lblX2";
        lblX2.Size = new Size(22, 19);
        lblX2.TabIndex = 2;
        lblX2.Text = "x²";
        // 
        // txtC
        // 
        txtC.Dock = DockStyle.Fill;
        txtC.Location = new Point(219, 43);
        txtC.Name = "txtC";
        txtC.Size = new Size(74, 25);
        txtC.TabIndex = 2;
        // 
        // lblX1
        // 
        lblX1.Anchor = AnchorStyles.Left;
        lblX1.AutoSize = true;
        lblX1.Location = new Point(299, 47);
        lblX1.Name = "lblX1";
        lblX1.Size = new Size(15, 19);
        lblX1.TabIndex = 3;
        lblX1.Text = "x";
        // 
        // txtD
        // 
        txtD.Dock = DockStyle.Fill;
        txtD.Location = new Point(327, 43);
        txtD.Name = "txtD";
        txtD.Size = new Size(74, 25);
        txtD.TabIndex = 3;
        // 
        // lblEqualZero
        // 
        lblEqualZero.Anchor = AnchorStyles.Left;
        lblEqualZero.AutoSize = true;
        lblEqualZero.Location = new Point(407, 47);
        lblEqualZero.Name = "lblEqualZero";
        lblEqualZero.Size = new Size(30, 19);
        lblEqualZero.TabIndex = 4;
        lblEqualZero.Text = "= 0";
        // 
        // pnlButtons
        // 
        pnlButtons.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        pnlButtons.Controls.Add(btnSolve);
        pnlButtons.Controls.Add(btnReset);
        pnlButtons.Controls.Add(btnExit);
        pnlButtons.Location = new Point(15, 114);
        pnlButtons.Name = "pnlButtons";
        pnlButtons.Size = new Size(796, 45);
        pnlButtons.TabIndex = 1;
        // 
        // btnSolve
        // 
        btnSolve.Location = new Point(3, 3);
        btnSolve.Name = "btnSolve";
        btnSolve.Size = new Size(150, 35);
        btnSolve.TabIndex = 4;
        btnSolve.Text = "Giải phương trình";
        btnSolve.UseVisualStyleBackColor = true;
        btnSolve.Click += btnSolve_Click;
        // 
        // btnReset
        // 
        btnReset.Location = new Point(159, 3);
        btnReset.Name = "btnReset";
        btnReset.Size = new Size(120, 35);
        btnReset.TabIndex = 5;
        btnReset.Text = "Nhập lại";
        btnReset.UseVisualStyleBackColor = true;
        btnReset.Click += btnReset_Click;
        // 
        // btnExit
        // 
        btnExit.Location = new Point(285, 3);
        btnExit.Name = "btnExit";
        btnExit.Size = new Size(120, 35);
        btnExit.TabIndex = 6;
        btnExit.Text = "Thoát";
        btnExit.UseVisualStyleBackColor = true;
        btnExit.Click += btnExit_Click;
        // 
        // grpResult
        // 
        grpResult.Controls.Add(tblResult);
        grpResult.Dock = DockStyle.Top;
        grpResult.Font = new Font("Segoe UI", 10F);
        grpResult.Location = new Point(12, 182);
        grpResult.Name = "grpResult";
        grpResult.Padding = new Padding(12);
        grpResult.Size = new Size(826, 220);
        grpResult.TabIndex = 1;
        grpResult.TabStop = false;
        grpResult.Text = "Kết quả";
        // 
        // tblResult
        // 
        tblResult.ColumnCount = 2;
        tblResult.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 160F));
        tblResult.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tblResult.Controls.Add(lblEquationTypeCaption, 0, 0);
        tblResult.Controls.Add(lblEquationType, 1, 0);
        tblResult.Controls.Add(lblRoot1Caption, 0, 1);
        tblResult.Controls.Add(txtX1, 1, 1);
        tblResult.Controls.Add(lblRoot2Caption, 0, 2);
        tblResult.Controls.Add(txtX2, 1, 2);
        tblResult.Controls.Add(lblRoot3Caption, 0, 3);
        tblResult.Controls.Add(txtX3, 1, 3);
        tblResult.Dock = DockStyle.Fill;
        tblResult.Location = new Point(12, 28);
        tblResult.Name = "tblResult";
        tblResult.RowCount = 4;
        tblResult.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        tblResult.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        tblResult.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        tblResult.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        tblResult.Size = new Size(802, 180);
        tblResult.TabIndex = 0;
        // 
        // lblEquationTypeCaption
        // 
        lblEquationTypeCaption.Anchor = AnchorStyles.Left;
        lblEquationTypeCaption.AutoSize = true;
        lblEquationTypeCaption.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblEquationTypeCaption.Location = new Point(3, 10);
        lblEquationTypeCaption.Name = "lblEquationTypeCaption";
        lblEquationTypeCaption.Size = new Size(130, 19);
        lblEquationTypeCaption.TabIndex = 0;
        lblEquationTypeCaption.Text = "Loại phương trình:";
        // 
        // lblEquationType
        // 
        lblEquationType.Anchor = AnchorStyles.Left;
        lblEquationType.AutoSize = true;
        lblEquationType.Location = new Point(163, 10);
        lblEquationType.Name = "lblEquationType";
        lblEquationType.Size = new Size(17, 19);
        lblEquationType.TabIndex = 1;
        lblEquationType.Text = "—";
        // 
        // lblRoot1Caption
        // 
        lblRoot1Caption.Anchor = AnchorStyles.Left;
        lblRoot1Caption.AutoSize = true;
        lblRoot1Caption.Location = new Point(3, 50);
        lblRoot1Caption.Name = "lblRoot1Caption";
        lblRoot1Caption.Size = new Size(76, 19);
        lblRoot1Caption.TabIndex = 2;
        lblRoot1Caption.Text = "Nghiệm x1:";
        // 
        // txtX1
        // 
        txtX1.Dock = DockStyle.Fill;
        txtX1.Location = new Point(163, 43);
        txtX1.Name = "txtX1";
        txtX1.ReadOnly = true;
        txtX1.Size = new Size(636, 25);
        txtX1.TabIndex = 7;
        // 
        // lblRoot2Caption
        // 
        lblRoot2Caption.Anchor = AnchorStyles.Left;
        lblRoot2Caption.AutoSize = true;
        lblRoot2Caption.Location = new Point(3, 90);
        lblRoot2Caption.Name = "lblRoot2Caption";
        lblRoot2Caption.Size = new Size(76, 19);
        lblRoot2Caption.TabIndex = 4;
        lblRoot2Caption.Text = "Nghiệm x2:";
        // 
        // txtX2
        // 
        txtX2.Dock = DockStyle.Fill;
        txtX2.Location = new Point(163, 83);
        txtX2.Name = "txtX2";
        txtX2.ReadOnly = true;
        txtX2.Size = new Size(636, 25);
        txtX2.TabIndex = 8;
        // 
        // lblRoot3Caption
        // 
        lblRoot3Caption.Anchor = AnchorStyles.Left;
        lblRoot3Caption.AutoSize = true;
        lblRoot3Caption.Location = new Point(3, 130);
        lblRoot3Caption.Name = "lblRoot3Caption";
        lblRoot3Caption.Size = new Size(76, 19);
        lblRoot3Caption.TabIndex = 6;
        lblRoot3Caption.Text = "Nghiệm x3:";
        // 
        // txtX3
        // 
        txtX3.Dock = DockStyle.Fill;
        txtX3.Location = new Point(163, 123);
        txtX3.Name = "txtX3";
        txtX3.ReadOnly = true;
        txtX3.Size = new Size(636, 25);
        txtX3.TabIndex = 9;
        // 
        // grpMessage
        // 
        grpMessage.Controls.Add(lblMessageCaption);
        grpMessage.Controls.Add(lblMessage);
        grpMessage.Dock = DockStyle.Top;
        grpMessage.Font = new Font("Segoe UI", 10F);
        grpMessage.Location = new Point(12, 402);
        grpMessage.Name = "grpMessage";
        grpMessage.Padding = new Padding(12);
        grpMessage.Size = new Size(826, 150);
        grpMessage.TabIndex = 2;
        grpMessage.TabStop = false;
        grpMessage.Text = "Thông báo";
        // 
        // lblMessageCaption
        // 
        lblMessageCaption.AutoSize = true;
        lblMessageCaption.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblMessageCaption.Location = new Point(15, 28);
        lblMessageCaption.Name = "lblMessageCaption";
        lblMessageCaption.Size = new Size(79, 19);
        lblMessageCaption.TabIndex = 0;
        lblMessageCaption.Text = "Thông báo:";
        // 
        // lblMessage
        // 
        lblMessage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        lblMessage.AutoEllipsis = true;
        lblMessage.Location = new Point(15, 55);
        lblMessage.Name = "lblMessage";
        lblMessage.Size = new Size(796, 80);
        lblMessage.TabIndex = 1;
        lblMessage.Text = "—";
        // 
        // MainForm
        // 
        AcceptButton = btnSolve;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        CancelButton = btnExit;
        ClientSize = new Size(850, 600);
        Controls.Add(grpMessage);
        Controls.Add(grpResult);
        Controls.Add(grpInput);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "GIẢI PHƯƠNG TRÌNH BẬC BA";
        Load += MainForm_Load;
        grpInput.ResumeLayout(false);
        tblEquation.ResumeLayout(false);
        tblEquation.PerformLayout();
        pnlButtons.ResumeLayout(false);
        grpResult.ResumeLayout(false);
        tblResult.ResumeLayout(false);
        tblResult.PerformLayout();
        grpMessage.ResumeLayout(false);
        grpMessage.PerformLayout();
        ResumeLayout(false);
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        txtA.Focus();
    }
}

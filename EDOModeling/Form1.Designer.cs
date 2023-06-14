namespace EDOModeling
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pboxBoard = new System.Windows.Forms.PictureBox();
            this.numudStep = new System.Windows.Forms.NumericUpDown();
            this.numudSlopeLength = new System.Windows.Forms.NumericUpDown();
            this.numudUnits = new System.Windows.Forms.NumericUpDown();
            this.numudPrecision = new System.Windows.Forms.NumericUpDown();
            this.lblStep = new System.Windows.Forms.Label();
            this.lblLineLength = new System.Windows.Forms.Label();
            this.lblUnits = new System.Windows.Forms.Label();
            this.lblPrecision = new System.Windows.Forms.Label();
            this.txtFunction = new System.Windows.Forms.TextBox();
            this.lblFunction = new System.Windows.Forms.Label();
            this.lblMI = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblConfig = new System.Windows.Forms.Label();
            this.txtSolution = new System.Windows.Forms.TextBox();
            this.labelSolution = new System.Windows.Forms.Label();
            this.lblSolution = new System.Windows.Forms.Label();
            this.numudX = new System.Windows.Forms.NumericUpDown();
            this.numudY = new System.Windows.Forms.NumericUpDown();
            this.numudIter = new System.Windows.Forms.NumericUpDown();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblIterations = new System.Windows.Forms.Label();
            this.gboxDF = new System.Windows.Forms.GroupBox();
            this.gboxAxes = new System.Windows.Forms.GroupBox();
            this.gboxSolution = new System.Windows.Forms.GroupBox();
            this.gboxEuler = new System.Windows.Forms.GroupBox();
            this.gboxPVI = new System.Windows.Forms.GroupBox();
            this.lblLegend = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chboxDF = new System.Windows.Forms.CheckBox();
            this.chboxSolution = new System.Windows.Forms.CheckBox();
            this.chboxEuler = new System.Windows.Forms.CheckBox();
            this.txtIsoclines = new System.Windows.Forms.TextBox();
            this.lblIsoclines = new System.Windows.Forms.Label();
            this.lblIsoFunction = new System.Windows.Forms.Label();
            this.lblShowIso = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chBoxIso = new System.Windows.Forms.CheckBox();
            this.gboxIso = new System.Windows.Forms.GroupBox();
            this.lblIsoBot = new System.Windows.Forms.Label();
            this.numudIsoBot = new System.Windows.Forms.NumericUpDown();
            this.numudIsoStep = new System.Windows.Forms.NumericUpDown();
            this.numudIsoTp = new System.Windows.Forms.NumericUpDown();
            this.lblIsoDensity = new System.Windows.Forms.Label();
            this.lblIsoTop = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBoard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numudStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numudSlopeLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numudUnits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numudPrecision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numudX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numudY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numudIter)).BeginInit();
            this.gboxDF.SuspendLayout();
            this.gboxAxes.SuspendLayout();
            this.gboxSolution.SuspendLayout();
            this.gboxEuler.SuspendLayout();
            this.gboxPVI.SuspendLayout();
            this.gboxIso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numudIsoBot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numudIsoStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numudIsoTp)).BeginInit();
            this.SuspendLayout();
            // 
            // pboxBoard
            // 
            this.pboxBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboxBoard.Location = new System.Drawing.Point(12, 12);
            this.pboxBoard.Name = "pboxBoard";
            this.pboxBoard.Size = new System.Drawing.Size(700, 700);
            this.pboxBoard.TabIndex = 0;
            this.pboxBoard.TabStop = false;
            this.pboxBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.imgboxBoard_Paint);
            // 
            // numudStep
            // 
            this.numudStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numudStep.Location = new System.Drawing.Point(126, 20);
            this.numudStep.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numudStep.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numudStep.Name = "numudStep";
            this.numudStep.ReadOnly = true;
            this.numudStep.Size = new System.Drawing.Size(75, 26);
            this.numudStep.TabIndex = 1;
            this.numudStep.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numudStep.ValueChanged += new System.EventHandler(this.numudStep_ValueChanged);
            // 
            // numudSlopeLength
            // 
            this.numudSlopeLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numudSlopeLength.Location = new System.Drawing.Point(126, 52);
            this.numudSlopeLength.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numudSlopeLength.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numudSlopeLength.Name = "numudSlopeLength";
            this.numudSlopeLength.ReadOnly = true;
            this.numudSlopeLength.Size = new System.Drawing.Size(75, 26);
            this.numudSlopeLength.TabIndex = 1;
            this.numudSlopeLength.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numudSlopeLength.ValueChanged += new System.EventHandler(this.numudSlopeLength_ValueChanged);
            // 
            // numudUnits
            // 
            this.numudUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numudUnits.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numudUnits.Location = new System.Drawing.Point(126, 25);
            this.numudUnits.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numudUnits.Name = "numudUnits";
            this.numudUnits.ReadOnly = true;
            this.numudUnits.Size = new System.Drawing.Size(75, 26);
            this.numudUnits.TabIndex = 1;
            this.numudUnits.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numudUnits.ValueChanged += new System.EventHandler(this.numudUnits_ValueChanged);
            // 
            // numudPrecision
            // 
            this.numudPrecision.DecimalPlaces = 2;
            this.numudPrecision.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numudPrecision.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numudPrecision.Location = new System.Drawing.Point(131, 25);
            this.numudPrecision.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numudPrecision.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numudPrecision.Name = "numudPrecision";
            this.numudPrecision.ReadOnly = true;
            this.numudPrecision.Size = new System.Drawing.Size(75, 26);
            this.numudPrecision.TabIndex = 1;
            this.numudPrecision.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numudPrecision.ValueChanged += new System.EventHandler(this.numudPrecision_ValueChanged);
            // 
            // lblStep
            // 
            this.lblStep.AutoSize = true;
            this.lblStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStep.Location = new System.Drawing.Point(6, 22);
            this.lblStep.Name = "lblStep";
            this.lblStep.Size = new System.Drawing.Size(43, 20);
            this.lblStep.TabIndex = 3;
            this.lblStep.Text = "Step";
            // 
            // lblLineLength
            // 
            this.lblLineLength.AutoSize = true;
            this.lblLineLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLineLength.Location = new System.Drawing.Point(6, 54);
            this.lblLineLength.Name = "lblLineLength";
            this.lblLineLength.Size = new System.Drawing.Size(104, 20);
            this.lblLineLength.TabIndex = 3;
            this.lblLineLength.Text = "Slope Length";
            // 
            // lblUnits
            // 
            this.lblUnits.AutoSize = true;
            this.lblUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnits.Location = new System.Drawing.Point(6, 27);
            this.lblUnits.Name = "lblUnits";
            this.lblUnits.Size = new System.Drawing.Size(46, 20);
            this.lblUnits.TabIndex = 3;
            this.lblUnits.Text = "Units";
            // 
            // lblPrecision
            // 
            this.lblPrecision.AutoSize = true;
            this.lblPrecision.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecision.Location = new System.Drawing.Point(11, 27);
            this.lblPrecision.Name = "lblPrecision";
            this.lblPrecision.Size = new System.Drawing.Size(73, 20);
            this.lblPrecision.TabIndex = 3;
            this.lblPrecision.Text = "Precision";
            // 
            // txtFunction
            // 
            this.txtFunction.Location = new System.Drawing.Point(798, 41);
            this.txtFunction.Name = "txtFunction";
            this.txtFunction.Size = new System.Drawing.Size(282, 26);
            this.txtFunction.TabIndex = 4;
            this.txtFunction.Text = "(cosy)^2/(2*x^(1/2))";
            // 
            // lblFunction
            // 
            this.lblFunction.AutoSize = true;
            this.lblFunction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFunction.Location = new System.Drawing.Point(756, 12);
            this.lblFunction.Name = "lblFunction";
            this.lblFunction.Size = new System.Drawing.Size(102, 25);
            this.lblFunction.TabIndex = 5;
            this.lblFunction.Text = "Function:";
            // 
            // lblMI
            // 
            this.lblMI.AutoSize = true;
            this.lblMI.Location = new System.Drawing.Point(738, 41);
            this.lblMI.Name = "lblMI";
            this.lblMI.Size = new System.Drawing.Size(54, 20);
            this.lblMI.TabIndex = 6;
            this.lblMI.Text = "dy/dx=";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(980, 234);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 32);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblConfig
            // 
            this.lblConfig.AutoSize = true;
            this.lblConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfig.Location = new System.Drawing.Point(737, 260);
            this.lblConfig.Name = "lblConfig";
            this.lblConfig.Size = new System.Drawing.Size(93, 25);
            this.lblConfig.TabIndex = 5;
            this.lblConfig.Text = "Configs:";
            // 
            // txtSolution
            // 
            this.txtSolution.Location = new System.Drawing.Point(798, 117);
            this.txtSolution.Name = "txtSolution";
            this.txtSolution.Size = new System.Drawing.Size(282, 26);
            this.txtSolution.TabIndex = 4;
            this.txtSolution.Text = "atn(x^(1/2)-1)";
            // 
            // labelSolution
            // 
            this.labelSolution.AutoSize = true;
            this.labelSolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSolution.Location = new System.Drawing.Point(756, 88);
            this.labelSolution.Name = "labelSolution";
            this.labelSolution.Size = new System.Drawing.Size(98, 25);
            this.labelSolution.TabIndex = 5;
            this.labelSolution.Text = "Solution:";
            // 
            // lblSolution
            // 
            this.lblSolution.AutoSize = true;
            this.lblSolution.Location = new System.Drawing.Point(738, 117);
            this.lblSolution.Name = "lblSolution";
            this.lblSolution.Size = new System.Drawing.Size(40, 20);
            this.lblSolution.TabIndex = 6;
            this.lblSolution.Text = "f(x)=";
            // 
            // numudX
            // 
            this.numudX.DecimalPlaces = 2;
            this.numudX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numudX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numudX.Location = new System.Drawing.Point(128, 24);
            this.numudX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numudX.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numudX.Name = "numudX";
            this.numudX.Size = new System.Drawing.Size(75, 26);
            this.numudX.TabIndex = 1;
            this.numudX.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numudX.ValueChanged += new System.EventHandler(this.numudX_ValueChanged);
            // 
            // numudY
            // 
            this.numudY.DecimalPlaces = 2;
            this.numudY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numudY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numudY.Location = new System.Drawing.Point(128, 56);
            this.numudY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numudY.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numudY.Name = "numudY";
            this.numudY.Size = new System.Drawing.Size(75, 26);
            this.numudY.TabIndex = 1;
            this.numudY.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numudY.ValueChanged += new System.EventHandler(this.numudY_ValueChanged);
            // 
            // numudIter
            // 
            this.numudIter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numudIter.Location = new System.Drawing.Point(126, 24);
            this.numudIter.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numudIter.Name = "numudIter";
            this.numudIter.Size = new System.Drawing.Size(75, 26);
            this.numudIter.TabIndex = 1;
            this.numudIter.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numudIter.ValueChanged += new System.EventHandler(this.numudIter_ValueChanged);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(8, 24);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(25, 20);
            this.lblX.TabIndex = 3;
            this.lblX.Text = "x0";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblY.Location = new System.Drawing.Point(8, 56);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(25, 20);
            this.lblY.TabIndex = 3;
            this.lblY.Text = "y0";
            // 
            // lblIterations
            // 
            this.lblIterations.AutoSize = true;
            this.lblIterations.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIterations.Location = new System.Drawing.Point(6, 24);
            this.lblIterations.Name = "lblIterations";
            this.lblIterations.Size = new System.Drawing.Size(76, 20);
            this.lblIterations.TabIndex = 3;
            this.lblIterations.Text = "Iterations";
            // 
            // gboxDF
            // 
            this.gboxDF.Controls.Add(this.lblStep);
            this.gboxDF.Controls.Add(this.numudStep);
            this.gboxDF.Controls.Add(this.numudSlopeLength);
            this.gboxDF.Controls.Add(this.lblLineLength);
            this.gboxDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxDF.Location = new System.Drawing.Point(742, 355);
            this.gboxDF.Name = "gboxDF";
            this.gboxDF.Size = new System.Drawing.Size(213, 87);
            this.gboxDF.TabIndex = 8;
            this.gboxDF.TabStop = false;
            this.gboxDF.Text = "Directions field";
            // 
            // gboxAxes
            // 
            this.gboxAxes.Controls.Add(this.lblUnits);
            this.gboxAxes.Controls.Add(this.numudUnits);
            this.gboxAxes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxAxes.Location = new System.Drawing.Point(742, 288);
            this.gboxAxes.Name = "gboxAxes";
            this.gboxAxes.Size = new System.Drawing.Size(213, 61);
            this.gboxAxes.TabIndex = 9;
            this.gboxAxes.TabStop = false;
            this.gboxAxes.Text = "Axes";
            // 
            // gboxSolution
            // 
            this.gboxSolution.Controls.Add(this.numudPrecision);
            this.gboxSolution.Controls.Add(this.lblPrecision);
            this.gboxSolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxSolution.Location = new System.Drawing.Point(742, 448);
            this.gboxSolution.Name = "gboxSolution";
            this.gboxSolution.Size = new System.Drawing.Size(213, 60);
            this.gboxSolution.TabIndex = 9;
            this.gboxSolution.TabStop = false;
            this.gboxSolution.Text = "Grapher precision";
            // 
            // gboxEuler
            // 
            this.gboxEuler.Controls.Add(this.lblIterations);
            this.gboxEuler.Controls.Add(this.numudIter);
            this.gboxEuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxEuler.Location = new System.Drawing.Point(742, 613);
            this.gboxEuler.Name = "gboxEuler";
            this.gboxEuler.Size = new System.Drawing.Size(213, 61);
            this.gboxEuler.TabIndex = 9;
            this.gboxEuler.TabStop = false;
            this.gboxEuler.Text = "Euler method";
            // 
            // gboxPVI
            // 
            this.gboxPVI.Controls.Add(this.lblX);
            this.gboxPVI.Controls.Add(this.numudX);
            this.gboxPVI.Controls.Add(this.numudY);
            this.gboxPVI.Controls.Add(this.lblY);
            this.gboxPVI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxPVI.Location = new System.Drawing.Point(742, 514);
            this.gboxPVI.Name = "gboxPVI";
            this.gboxPVI.Size = new System.Drawing.Size(213, 93);
            this.gboxPVI.TabIndex = 9;
            this.gboxPVI.TabStop = false;
            this.gboxPVI.Text = "PVI initial point";
            // 
            // lblLegend
            // 
            this.lblLegend.AutoSize = true;
            this.lblLegend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLegend.Location = new System.Drawing.Point(12, 715);
            this.lblLegend.Name = "lblLegend";
            this.lblLegend.Size = new System.Drawing.Size(91, 25);
            this.lblLegend.TabIndex = 10;
            this.lblLegend.Text = "Legend:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 750);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Directions field";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(13, 770);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "/";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 750);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Solution";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(175, 774);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "........";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(324, 750);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Euler aprox.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(466, 774);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "........";
            // 
            // chboxDF
            // 
            this.chboxDF.AutoSize = true;
            this.chboxDF.Checked = true;
            this.chboxDF.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chboxDF.Location = new System.Drawing.Point(94, 778);
            this.chboxDF.Name = "chboxDF";
            this.chboxDF.Size = new System.Drawing.Size(22, 21);
            this.chboxDF.TabIndex = 13;
            this.chboxDF.UseVisualStyleBackColor = true;
            this.chboxDF.CheckedChanged += new System.EventHandler(this.chboxDF_CheckedChanged);
            // 
            // chboxSolution
            // 
            this.chboxSolution.AutoSize = true;
            this.chboxSolution.Checked = true;
            this.chboxSolution.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chboxSolution.Location = new System.Drawing.Point(257, 778);
            this.chboxSolution.Name = "chboxSolution";
            this.chboxSolution.Size = new System.Drawing.Size(22, 21);
            this.chboxSolution.TabIndex = 14;
            this.chboxSolution.UseVisualStyleBackColor = true;
            this.chboxSolution.CheckedChanged += new System.EventHandler(this.chboxSolution_CheckedChanged);
            // 
            // chboxEuler
            // 
            this.chboxEuler.AutoSize = true;
            this.chboxEuler.Checked = true;
            this.chboxEuler.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chboxEuler.Location = new System.Drawing.Point(409, 778);
            this.chboxEuler.Name = "chboxEuler";
            this.chboxEuler.Size = new System.Drawing.Size(22, 21);
            this.chboxEuler.TabIndex = 15;
            this.chboxEuler.UseVisualStyleBackColor = true;
            this.chboxEuler.CheckedChanged += new System.EventHandler(this.chboxEuler_CheckedChanged);
            // 
            // txtIsoclines
            // 
            this.txtIsoclines.Location = new System.Drawing.Point(798, 191);
            this.txtIsoclines.Name = "txtIsoclines";
            this.txtIsoclines.Size = new System.Drawing.Size(282, 26);
            this.txtIsoclines.TabIndex = 4;
            this.txtIsoclines.Text = "acs((m*(2*x^(1/2)))^(1/2))";
            // 
            // lblIsoclines
            // 
            this.lblIsoclines.AutoSize = true;
            this.lblIsoclines.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsoclines.Location = new System.Drawing.Point(756, 162);
            this.lblIsoclines.Name = "lblIsoclines";
            this.lblIsoclines.Size = new System.Drawing.Size(104, 25);
            this.lblIsoclines.TabIndex = 5;
            this.lblIsoclines.Text = "Isoclines:";
            // 
            // lblIsoFunction
            // 
            this.lblIsoFunction.AutoSize = true;
            this.lblIsoFunction.Location = new System.Drawing.Point(738, 191);
            this.lblIsoFunction.Name = "lblIsoFunction";
            this.lblIsoFunction.Size = new System.Drawing.Size(57, 20);
            this.lblIsoFunction.TabIndex = 6;
            this.lblIsoFunction.Text = "f(x,m)=";
            // 
            // lblShowIso
            // 
            this.lblShowIso.AutoSize = true;
            this.lblShowIso.Location = new System.Drawing.Point(467, 750);
            this.lblShowIso.Name = "lblShowIso";
            this.lblShowIso.Size = new System.Drawing.Size(71, 20);
            this.lblShowIso.TabIndex = 11;
            this.lblShowIso.Text = "Isoclines";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(323, 774);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 29);
            this.label7.TabIndex = 11;
            this.label7.Text = "........";
            // 
            // chBoxIso
            // 
            this.chBoxIso.AutoSize = true;
            this.chBoxIso.Checked = true;
            this.chBoxIso.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chBoxIso.Location = new System.Drawing.Point(552, 778);
            this.chBoxIso.Name = "chBoxIso";
            this.chBoxIso.Size = new System.Drawing.Size(22, 21);
            this.chBoxIso.TabIndex = 15;
            this.chBoxIso.UseVisualStyleBackColor = true;
            this.chBoxIso.CheckedChanged += new System.EventHandler(this.chBoxIso_CheckedChanged);
            // 
            // gboxIso
            // 
            this.gboxIso.Controls.Add(this.lblIsoBot);
            this.gboxIso.Controls.Add(this.numudIsoBot);
            this.gboxIso.Controls.Add(this.numudIsoStep);
            this.gboxIso.Controls.Add(this.numudIsoTp);
            this.gboxIso.Controls.Add(this.lblIsoDensity);
            this.gboxIso.Controls.Add(this.lblIsoTop);
            this.gboxIso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxIso.Location = new System.Drawing.Point(742, 680);
            this.gboxIso.Name = "gboxIso";
            this.gboxIso.Size = new System.Drawing.Size(213, 120);
            this.gboxIso.TabIndex = 8;
            this.gboxIso.TabStop = false;
            this.gboxIso.Text = "Isoclines";
            // 
            // lblIsoBot
            // 
            this.lblIsoBot.AutoSize = true;
            this.lblIsoBot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsoBot.Location = new System.Drawing.Point(6, 22);
            this.lblIsoBot.Name = "lblIsoBot";
            this.lblIsoBot.Size = new System.Drawing.Size(83, 20);
            this.lblIsoBot.TabIndex = 3;
            this.lblIsoBot.Text = "Min. Slope";
            // 
            // numudIsoBot
            // 
            this.numudIsoBot.DecimalPlaces = 2;
            this.numudIsoBot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numudIsoBot.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numudIsoBot.Location = new System.Drawing.Point(126, 20);
            this.numudIsoBot.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numudIsoBot.Name = "numudIsoBot";
            this.numudIsoBot.Size = new System.Drawing.Size(75, 26);
            this.numudIsoBot.TabIndex = 1;
            this.numudIsoBot.ValueChanged += new System.EventHandler(this.numudIsoBot_ValueChanged);
            // 
            // numudIsoStep
            // 
            this.numudIsoStep.DecimalPlaces = 2;
            this.numudIsoStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numudIsoStep.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numudIsoStep.Location = new System.Drawing.Point(126, 84);
            this.numudIsoStep.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numudIsoStep.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numudIsoStep.Name = "numudIsoStep";
            this.numudIsoStep.Size = new System.Drawing.Size(75, 26);
            this.numudIsoStep.TabIndex = 1;
            this.numudIsoStep.Value = new decimal(new int[] {
            2,
            0,
            0,
            131072});
            this.numudIsoStep.ValueChanged += new System.EventHandler(this.numudIsoStep_ValueChanged);
            // 
            // numudIsoTp
            // 
            this.numudIsoTp.DecimalPlaces = 2;
            this.numudIsoTp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numudIsoTp.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numudIsoTp.Location = new System.Drawing.Point(126, 52);
            this.numudIsoTp.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numudIsoTp.Name = "numudIsoTp";
            this.numudIsoTp.Size = new System.Drawing.Size(75, 26);
            this.numudIsoTp.TabIndex = 1;
            this.numudIsoTp.Value = new decimal(new int[] {
            4,
            0,
            0,
            65536});
            this.numudIsoTp.ValueChanged += new System.EventHandler(this.numudIsoTp_ValueChanged);
            // 
            // lblIsoDensity
            // 
            this.lblIsoDensity.AutoSize = true;
            this.lblIsoDensity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsoDensity.Location = new System.Drawing.Point(6, 86);
            this.lblIsoDensity.Name = "lblIsoDensity";
            this.lblIsoDensity.Size = new System.Drawing.Size(43, 20);
            this.lblIsoDensity.TabIndex = 3;
            this.lblIsoDensity.Text = "Step";
            // 
            // lblIsoTop
            // 
            this.lblIsoTop.AutoSize = true;
            this.lblIsoTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsoTop.Location = new System.Drawing.Point(6, 54);
            this.lblIsoTop.Name = "lblIsoTop";
            this.lblIsoTop.Size = new System.Drawing.Size(87, 20);
            this.lblIsoTop.TabIndex = 3;
            this.lblIsoTop.Text = "Max. Slope";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 816);
            this.Controls.Add(this.chBoxIso);
            this.Controls.Add(this.chboxEuler);
            this.Controls.Add(this.chboxSolution);
            this.Controls.Add(this.chboxDF);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblShowIso);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLegend);
            this.Controls.Add(this.gboxPVI);
            this.Controls.Add(this.gboxEuler);
            this.Controls.Add(this.gboxSolution);
            this.Controls.Add(this.gboxAxes);
            this.Controls.Add(this.gboxIso);
            this.Controls.Add(this.gboxDF);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblIsoFunction);
            this.Controls.Add(this.lblSolution);
            this.Controls.Add(this.lblMI);
            this.Controls.Add(this.lblConfig);
            this.Controls.Add(this.lblIsoclines);
            this.Controls.Add(this.labelSolution);
            this.Controls.Add(this.txtIsoclines);
            this.Controls.Add(this.lblFunction);
            this.Controls.Add(this.txtSolution);
            this.Controls.Add(this.txtFunction);
            this.Controls.Add(this.pboxBoard);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Differential Equations";
            ((System.ComponentModel.ISupportInitialize)(this.pboxBoard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numudStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numudSlopeLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numudUnits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numudPrecision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numudX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numudY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numudIter)).EndInit();
            this.gboxDF.ResumeLayout(false);
            this.gboxDF.PerformLayout();
            this.gboxAxes.ResumeLayout(false);
            this.gboxAxes.PerformLayout();
            this.gboxSolution.ResumeLayout(false);
            this.gboxSolution.PerformLayout();
            this.gboxEuler.ResumeLayout(false);
            this.gboxEuler.PerformLayout();
            this.gboxPVI.ResumeLayout(false);
            this.gboxPVI.PerformLayout();
            this.gboxIso.ResumeLayout(false);
            this.gboxIso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numudIsoBot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numudIsoStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numudIsoTp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxBoard;
        private System.Windows.Forms.NumericUpDown numudStep;
        private System.Windows.Forms.NumericUpDown numudSlopeLength;
        private System.Windows.Forms.NumericUpDown numudUnits;
        private System.Windows.Forms.NumericUpDown numudPrecision;
        private System.Windows.Forms.Label lblStep;
        private System.Windows.Forms.Label lblLineLength;
        private System.Windows.Forms.Label lblUnits;
        private System.Windows.Forms.Label lblPrecision;
        private System.Windows.Forms.TextBox txtFunction;
        private System.Windows.Forms.Label lblFunction;
        private System.Windows.Forms.Label lblMI;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblConfig;
        private System.Windows.Forms.TextBox txtSolution;
        private System.Windows.Forms.Label labelSolution;
        private System.Windows.Forms.Label lblSolution;
        private System.Windows.Forms.NumericUpDown numudX;
        private System.Windows.Forms.NumericUpDown numudY;
        private System.Windows.Forms.NumericUpDown numudIter;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblIterations;
        private System.Windows.Forms.GroupBox gboxDF;
        private System.Windows.Forms.GroupBox gboxAxes;
        private System.Windows.Forms.GroupBox gboxSolution;
        private System.Windows.Forms.GroupBox gboxEuler;
        private System.Windows.Forms.GroupBox gboxPVI;
        private System.Windows.Forms.Label lblLegend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chboxDF;
        private System.Windows.Forms.CheckBox chboxSolution;
        private System.Windows.Forms.CheckBox chboxEuler;
        private System.Windows.Forms.TextBox txtIsoclines;
        private System.Windows.Forms.Label lblIsoclines;
        private System.Windows.Forms.Label lblIsoFunction;
        private System.Windows.Forms.Label lblShowIso;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chBoxIso;
        private System.Windows.Forms.GroupBox gboxIso;
        private System.Windows.Forms.Label lblIsoBot;
        private System.Windows.Forms.NumericUpDown numudIsoBot;
        private System.Windows.Forms.NumericUpDown numudIsoTp;
        private System.Windows.Forms.Label lblIsoTop;
        private System.Windows.Forms.NumericUpDown numudIsoStep;
        private System.Windows.Forms.Label lblIsoDensity;
    }
}


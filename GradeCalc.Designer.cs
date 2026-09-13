namespace GuiGradeCalc
{
    partial class GradeCalc
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            viewGrades = new ListView();
            btnAddGrade = new Button();
            inputGrade = new NumericUpDown();
            lblGrades = new Label();
            btnDelGrades = new Button();
            btnClearGrades = new Button();
            lblResult = new Label();
            btnLoadCsv = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)inputGrade).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // viewGrades
            // 
            tableLayoutPanel1.SetColumnSpan(viewGrades, 2);
            viewGrades.Dock = DockStyle.Fill;
            viewGrades.FullRowSelect = true;
            viewGrades.GridLines = true;
            viewGrades.HeaderStyle = ColumnHeaderStyle.None;
            viewGrades.HideSelection = true;
            viewGrades.LabelEdit = true;
            viewGrades.Location = new Point(3, 32);
            viewGrades.Name = "viewGrades";
            viewGrades.ShowGroups = false;
            viewGrades.Size = new Size(237, 147);
            viewGrades.TabIndex = 4;
            viewGrades.UseCompatibleStateImageBehavior = false;
            viewGrades.View = View.List;
            viewGrades.AfterLabelEdit += ViewGrades_AfterLabelEdit;
            // 
            // btnAddGrade
            // 
            btnAddGrade.AutoSize = true;
            btnAddGrade.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddGrade.Dock = DockStyle.Fill;
            btnAddGrade.Location = new Point(3, 185);
            btnAddGrade.Name = "btnAddGrade";
            btnAddGrade.Size = new Size(115, 25);
            btnAddGrade.TabIndex = 5;
            btnAddGrade.Text = "Add Grade:";
            btnAddGrade.Click += BtnAddGrade_Click;
            // 
            // inputGrade
            // 
            inputGrade.AutoSize = true;
            inputGrade.DecimalPlaces = 2;
            inputGrade.Dock = DockStyle.Fill;
            inputGrade.Location = new Point(124, 185);
            inputGrade.Name = "inputGrade";
            inputGrade.Size = new Size(116, 23);
            inputGrade.TabIndex = 0;
            inputGrade.TextAlign = HorizontalAlignment.Center;
            inputGrade.ThousandsSeparator = true;
            inputGrade.UpDownAlign = LeftRightAlignment.Left;
            // 
            // lblGrades
            // 
            lblGrades.AutoSize = true;
            lblGrades.Dock = DockStyle.Fill;
            lblGrades.Location = new Point(3, 0);
            lblGrades.Name = "lblGrades";
            lblGrades.Size = new Size(115, 29);
            lblGrades.TabIndex = 3;
            lblGrades.Text = "Grades:";
            lblGrades.TextAlign = ContentAlignment.BottomLeft;
            // 
            // btnDelGrades
            // 
            btnDelGrades.AutoSize = true;
            btnDelGrades.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.SetColumnSpan(btnDelGrades, 2);
            btnDelGrades.Dock = DockStyle.Fill;
            btnDelGrades.Location = new Point(3, 216);
            btnDelGrades.Name = "btnDelGrades";
            btnDelGrades.Size = new Size(237, 25);
            btnDelGrades.TabIndex = 1;
            btnDelGrades.Text = "Remove Selected Grades";
            btnDelGrades.UseVisualStyleBackColor = true;
            btnDelGrades.Click += BtnDelGrades_Click;
            // 
            // btnClearGrades
            // 
            btnClearGrades.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.SetColumnSpan(btnClearGrades, 2);
            btnClearGrades.Dock = DockStyle.Fill;
            btnClearGrades.Location = new Point(3, 247);
            btnClearGrades.Name = "btnClearGrades";
            btnClearGrades.Size = new Size(237, 23);
            btnClearGrades.TabIndex = 2;
            btnClearGrades.Text = "Clear All Grades";
            btnClearGrades.UseVisualStyleBackColor = true;
            btnClearGrades.Click += BtnClearGrades_Click;
            // 
            // lblResult
            // 
            lblResult.AutoEllipsis = true;
            lblResult.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(lblResult, 2);
            lblResult.Dock = DockStyle.Fill;
            lblResult.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblResult.Location = new Point(3, 273);
            lblResult.Name = "lblResult";
            lblResult.Padding = new Padding(4);
            lblResult.Size = new Size(237, 28);
            lblResult.TabIndex = 6;
            lblResult.Text = "Average Grade: {0}";
            lblResult.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnLoadCsv
            // 
            btnLoadCsv.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLoadCsv.Dock = DockStyle.Fill;
            btnLoadCsv.Location = new Point(124, 3);
            btnLoadCsv.Name = "btnLoadCsv";
            btnLoadCsv.Size = new Size(116, 23);
            btnLoadCsv.TabIndex = 3;
            btnLoadCsv.Text = "Load CSV...";
            btnLoadCsv.UseVisualStyleBackColor = true;
            btnLoadCsv.Click += BtnLoadCsv_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnAddGrade, 0, 2);
            tableLayoutPanel1.Controls.Add(lblResult, 0, 5);
            tableLayoutPanel1.Controls.Add(btnLoadCsv, 1, 0);
            tableLayoutPanel1.Controls.Add(btnClearGrades, 0, 4);
            tableLayoutPanel1.Controls.Add(lblGrades, 0, 0);
            tableLayoutPanel1.Controls.Add(btnDelGrades, 0, 3);
            tableLayoutPanel1.Controls.Add(viewGrades, 0, 1);
            tableLayoutPanel1.Controls.Add(inputGrade, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(243, 301);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // GradeCalc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(243, 301);
            Controls.Add(tableLayoutPanel1);
            Name = "GradeCalc";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "GradeCalc";
            Load += GradeCalc_Load;
            ((System.ComponentModel.ISupportInitialize)inputGrade).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListView viewGrades;
        private Button btnAddGrade;
        private NumericUpDown inputGrade;
        private Label lblGrades;
        private Button btnDelGrades;
        private Button btnClearGrades;
        private Label lblResult;
        private Button btnLoadCsv;
        private TableLayoutPanel tableLayoutPanel1;
    }
}

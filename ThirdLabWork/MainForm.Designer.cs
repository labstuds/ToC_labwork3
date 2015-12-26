namespace ThirdLabWork
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.открытьВыборкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildReport = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvSelection = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbCounting = new System.Windows.Forms.GroupBox();
            this.tbRo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbKxy = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbDispersionY = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbDispersionX = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbRootMeanSqY = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbRootMeanSqX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbExpectedValueY = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbExpectedValueX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuildDiagram = new System.Windows.Forms.Button();
            this.ofdReadSelection = new System.Windows.Forms.OpenFileDialog();
            this.gbLog = new System.Windows.Forms.GroupBox();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelection)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbCounting.SuspendLayout();
            this.gbLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьВыборкуToolStripMenuItem,
            this.buildReport});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(952, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // открытьВыборкуToolStripMenuItem
            // 
            this.открытьВыборкуToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.открытьВыборкуToolStripMenuItem.Name = "открытьВыборкуToolStripMenuItem";
            this.открытьВыборкуToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.открытьВыборкуToolStripMenuItem.Text = "Открыть выборку";
            this.открытьВыборкуToolStripMenuItem.Click += new System.EventHandler(this.открытьВыборкуToolStripMenuItem_Click);
            // 
            // buildReport
            // 
            this.buildReport.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buildReport.Name = "buildReport";
            this.buildReport.Size = new System.Drawing.Size(223, 24);
            this.buildReport.Text = "Построить отчет по выборке";
            this.buildReport.ToolTipText = "Будут записаны математические характеристики выборки, сама выборка и ее объем.";
            this.buildReport.Click += new System.EventHandler(this.построитьОтчетToolStripMenuItem_Click);
            // 
            // dgvSelection
            // 
            this.dgvSelection.AllowUserToAddRows = false;
            this.dgvSelection.AllowUserToDeleteRows = false;
            this.dgvSelection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelection.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.dgvSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSelection.Location = new System.Drawing.Point(3, 18);
            this.dgvSelection.Name = "dgvSelection";
            this.dgvSelection.ReadOnly = true;
            this.dgvSelection.Size = new System.Drawing.Size(261, 367);
            this.dgvSelection.TabIndex = 1;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.ReadOnly = true;
            // 
            // Y
            // 
            this.Y.HeaderText = "Y";
            this.Y.Name = "Y";
            this.Y.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.dgvSelection);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 388);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выборка";
            // 
            // gbCounting
            // 
            this.gbCounting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCounting.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbCounting.Controls.Add(this.tbRo);
            this.gbCounting.Controls.Add(this.label5);
            this.gbCounting.Controls.Add(this.tbKxy);
            this.gbCounting.Controls.Add(this.label6);
            this.gbCounting.Controls.Add(this.tbDispersionY);
            this.gbCounting.Controls.Add(this.label7);
            this.gbCounting.Controls.Add(this.tbDispersionX);
            this.gbCounting.Controls.Add(this.label8);
            this.gbCounting.Controls.Add(this.tbRootMeanSqY);
            this.gbCounting.Controls.Add(this.label3);
            this.gbCounting.Controls.Add(this.tbRootMeanSqX);
            this.gbCounting.Controls.Add(this.label4);
            this.gbCounting.Controls.Add(this.tbExpectedValueY);
            this.gbCounting.Controls.Add(this.label2);
            this.gbCounting.Controls.Add(this.tbExpectedValueX);
            this.gbCounting.Controls.Add(this.label1);
            this.gbCounting.Controls.Add(this.btnBuildDiagram);
            this.gbCounting.Enabled = false;
            this.gbCounting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbCounting.Location = new System.Drawing.Point(285, 27);
            this.gbCounting.Name = "gbCounting";
            this.gbCounting.Size = new System.Drawing.Size(658, 231);
            this.gbCounting.TabIndex = 3;
            this.gbCounting.TabStop = false;
            this.gbCounting.Text = "Расчеты";
            // 
            // tbRo
            // 
            this.tbRo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbRo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbRo.Location = new System.Drawing.Point(389, 142);
            this.tbRo.Name = "tbRo";
            this.tbRo.ReadOnly = true;
            this.tbRo.Size = new System.Drawing.Size(263, 22);
            this.tbRo.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(7, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(313, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Выборочный коэффициент корреляции";
            // 
            // tbKxy
            // 
            this.tbKxy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbKxy.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbKxy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbKxy.Location = new System.Drawing.Point(389, 108);
            this.tbKxy.Name = "tbKxy";
            this.tbKxy.ReadOnly = true;
            this.tbKxy.Size = new System.Drawing.Size(263, 22);
            this.tbKxy.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(7, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(299, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Выборочный корреляционный момент";
            // 
            // tbDispersionY
            // 
            this.tbDispersionY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDispersionY.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbDispersionY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDispersionY.Location = new System.Drawing.Point(389, 73);
            this.tbDispersionY.Name = "tbDispersionY";
            this.tbDispersionY.ReadOnly = true;
            this.tbDispersionY.Size = new System.Drawing.Size(263, 22);
            this.tbDispersionY.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(273, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Дисперсия y";
            // 
            // tbDispersionX
            // 
            this.tbDispersionX.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbDispersionX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDispersionX.Location = new System.Drawing.Point(152, 73);
            this.tbDispersionX.Name = "tbDispersionX";
            this.tbDispersionX.ReadOnly = true;
            this.tbDispersionX.Size = new System.Drawing.Size(100, 22);
            this.tbDispersionX.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(7, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Дисперсия x";
            // 
            // tbRootMeanSqY
            // 
            this.tbRootMeanSqY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRootMeanSqY.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbRootMeanSqY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbRootMeanSqY.Location = new System.Drawing.Point(529, 44);
            this.tbRootMeanSqY.Name = "tbRootMeanSqY";
            this.tbRootMeanSqY.ReadOnly = true;
            this.tbRootMeanSqY.Size = new System.Drawing.Size(123, 22);
            this.tbRootMeanSqY.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(273, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Среднее квадратическое y";
            // 
            // tbRootMeanSqX
            // 
            this.tbRootMeanSqX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRootMeanSqX.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbRootMeanSqX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbRootMeanSqX.Location = new System.Drawing.Point(529, 18);
            this.tbRootMeanSqX.Name = "tbRootMeanSqX";
            this.tbRootMeanSqX.ReadOnly = true;
            this.tbRootMeanSqX.Size = new System.Drawing.Size(123, 22);
            this.tbRootMeanSqX.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(273, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Среднее квадратическое x";
            // 
            // tbExpectedValueY
            // 
            this.tbExpectedValueY.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbExpectedValueY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbExpectedValueY.Location = new System.Drawing.Point(152, 42);
            this.tbExpectedValueY.Name = "tbExpectedValueY";
            this.tbExpectedValueY.ReadOnly = true;
            this.tbExpectedValueY.Size = new System.Drawing.Size(100, 22);
            this.tbExpectedValueY.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Мат. ожидание y";
            // 
            // tbExpectedValueX
            // 
            this.tbExpectedValueX.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbExpectedValueX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbExpectedValueX.Location = new System.Drawing.Point(152, 18);
            this.tbExpectedValueX.Name = "tbExpectedValueX";
            this.tbExpectedValueX.ReadOnly = true;
            this.tbExpectedValueX.Size = new System.Drawing.Size(100, 22);
            this.tbExpectedValueX.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Мат. ожидание x";
            // 
            // btnBuildDiagram
            // 
            this.btnBuildDiagram.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuildDiagram.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBuildDiagram.Location = new System.Drawing.Point(6, 170);
            this.btnBuildDiagram.Name = "btnBuildDiagram";
            this.btnBuildDiagram.Size = new System.Drawing.Size(646, 52);
            this.btnBuildDiagram.TabIndex = 0;
            this.btnBuildDiagram.Text = "Построить диаграмму рессеивания";
            this.btnBuildDiagram.UseVisualStyleBackColor = true;
            this.btnBuildDiagram.Click += new System.EventHandler(this.btnBuildDiagram_Click);
            // 
            // gbLog
            // 
            this.gbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbLog.Controls.Add(this.rtbLog);
            this.gbLog.Location = new System.Drawing.Point(285, 264);
            this.gbLog.Name = "gbLog";
            this.gbLog.Size = new System.Drawing.Size(658, 151);
            this.gbLog.TabIndex = 4;
            this.gbLog.TabStop = false;
            this.gbLog.Text = "Ход вычислений";
            // 
            // rtbLog
            // 
            this.rtbLog.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rtbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbLog.Location = new System.Drawing.Point(3, 16);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ReadOnly = true;
            this.rtbLog.Size = new System.Drawing.Size(652, 132);
            this.rtbLog.TabIndex = 1;
            this.rtbLog.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 421);
            this.Controls.Add(this.gbLog);
            this.Controls.Add(this.gbCounting);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(968, 460);
            this.Name = "MainForm";
            this.Text = "Третья лабораторная работа";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelection)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.gbCounting.ResumeLayout(false);
            this.gbCounting.PerformLayout();
            this.gbLog.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem открытьВыборкуToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvSelection;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbCounting;
        private System.Windows.Forms.Button btnBuildDiagram;
        private System.Windows.Forms.OpenFileDialog ofdReadSelection;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.GroupBox gbLog;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.TextBox tbRo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbKxy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbDispersionY;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbDispersionX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbRootMeanSqY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbRootMeanSqX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbExpectedValueY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbExpectedValueX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem buildReport;
    }
}


namespace ThirdLabWork
{
    partial class DispersionDiagramForm
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
            this.components = new System.ComponentModel.Container();
            this.zgDispersionDiagram = new ZedGraph.ZedGraphControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.построитьОтчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // zgDispersionDiagram
            // 
            this.zgDispersionDiagram.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zgDispersionDiagram.Location = new System.Drawing.Point(0, 28);
            this.zgDispersionDiagram.Name = "zgDispersionDiagram";
            this.zgDispersionDiagram.ScrollGrace = 0D;
            this.zgDispersionDiagram.ScrollMaxX = 0D;
            this.zgDispersionDiagram.ScrollMaxY = 0D;
            this.zgDispersionDiagram.ScrollMaxY2 = 0D;
            this.zgDispersionDiagram.ScrollMinX = 0D;
            this.zgDispersionDiagram.ScrollMinY = 0D;
            this.zgDispersionDiagram.ScrollMinY2 = 0D;
            this.zgDispersionDiagram.Size = new System.Drawing.Size(662, 347);
            this.zgDispersionDiagram.TabIndex = 0;
            this.zgDispersionDiagram.Load += new System.EventHandler(this.zgDispersionDiagram_Load);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.построитьОтчетToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(662, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // построитьОтчетToolStripMenuItem
            // 
            this.построитьОтчетToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.построитьОтчетToolStripMenuItem.Name = "построитьОтчетToolStripMenuItem";
            this.построитьОтчетToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.построитьОтчетToolStripMenuItem.Text = "Сохранить график";
            this.построитьОтчетToolStripMenuItem.ToolTipText = "Текущий график будет сохранен как изображение.\r\nРазмер изображения будет таким же" +
    ", как текущий размер графика. \r\nДля лучшего качества разверните окно.";
            this.построитьОтчетToolStripMenuItem.Click += new System.EventHandler(this.saveGraphToolStripMenuItem_Click);
            // 
            // DispersionDiagramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 375);
            this.Controls.Add(this.zgDispersionDiagram);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DispersionDiagramForm";
            this.Text = "Диаграмма рассеивания";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl zgDispersionDiagram;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem построитьОтчетToolStripMenuItem;
    }
}
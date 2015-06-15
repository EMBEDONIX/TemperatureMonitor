namespace TempMonitor.Controls
{
    partial class SensorWithTextBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SpPerfChart.ChartPen chartPen9 = new SpPerfChart.ChartPen();
            SpPerfChart.ChartPen chartPen10 = new SpPerfChart.ChartPen();
            SpPerfChart.ChartPen chartPen11 = new SpPerfChart.ChartPen();
            SpPerfChart.ChartPen chartPen12 = new SpPerfChart.ChartPen();
            this.tbSamples = new MetroFramework.Controls.MetroTextBox();
            this.panelLabels.SuspendLayout();
            this.SuspendLayout();
            // 
            // graph
            // 
            this.graph.PerfChartStyle.AntiAliasing = true;
            chartPen9.Color = System.Drawing.Color.Black;
            chartPen9.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            chartPen9.Width = 1F;
            this.graph.PerfChartStyle.AvgLinePen = chartPen9;
            this.graph.PerfChartStyle.BackgroundColorBottom = System.Drawing.Color.DodgerBlue;
            this.graph.PerfChartStyle.BackgroundColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            chartPen10.Color = System.Drawing.Color.Gold;
            chartPen10.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            chartPen10.Width = 2F;
            this.graph.PerfChartStyle.ChartLinePen = chartPen10;
            chartPen11.Color = System.Drawing.Color.Black;
            chartPen11.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            chartPen11.Width = 0.5F;
            this.graph.PerfChartStyle.HorizontalGridPen = chartPen11;
            this.graph.PerfChartStyle.ShowAverageLine = true;
            this.graph.PerfChartStyle.ShowHorizontalGridLines = true;
            this.graph.PerfChartStyle.ShowVerticalGridLines = false;
            chartPen12.Color = System.Drawing.Color.DarkRed;
            chartPen12.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            chartPen12.Width = 1F;
            this.graph.PerfChartStyle.VerticalGridPen = chartPen12;
            this.panelLabels.Controls.SetChildIndex(this.labelName, 0);
            // 
            // tbSamples
            // 
            this.tbSamples.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSamples.Lines = new string[0];
            this.tbSamples.Location = new System.Drawing.Point(4, 331);
            this.tbSamples.MaxLength = 65535;
            this.tbSamples.Multiline = true;
            this.tbSamples.Name = "tbSamples";
            this.tbSamples.PasswordChar = '\0';
            this.tbSamples.ReadOnly = true;
            this.tbSamples.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbSamples.SelectedText = "";
            this.tbSamples.Size = new System.Drawing.Size(395, 129);
            this.tbSamples.TabIndex = 9;
            this.tbSamples.UseSelectable = true;
            // 
            // SensorWithTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbSamples);
            this.Name = "SensorWithTextBox";
            this.Size = new System.Drawing.Size(402, 463);
            this.Controls.SetChildIndex(this.graph, 0);
            this.Controls.SetChildIndex(this.metroLabel1, 0);
            this.Controls.SetChildIndex(this.metroLabel2, 0);
            this.Controls.SetChildIndex(this.metroLabel3, 0);
            this.Controls.SetChildIndex(this.labelHighest, 0);
            this.Controls.SetChildIndex(this.LabelLowest, 0);
            this.Controls.SetChildIndex(this.labelAverage, 0);
            this.Controls.SetChildIndex(this.panelLabels, 0);
            this.Controls.SetChildIndex(this.tbSamples, 0);
            this.panelLabels.ResumeLayout(false);
            this.panelLabels.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox tbSamples;
    }
}

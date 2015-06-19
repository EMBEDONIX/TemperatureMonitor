using MetroFramework.Controls;

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
            SensorChart.ChartPen chartPen1 = new SensorChart.ChartPen();
            SensorChart.ChartPen chartPen2 = new SensorChart.ChartPen();
            SensorChart.ChartPen chartPen3 = new SensorChart.ChartPen();
            SensorChart.ChartPen chartPen4 = new SensorChart.ChartPen();
            this.tbSamples = new MetroFramework.Controls.MetroTextBox();
            this.panelLabels.SuspendLayout();
            this.SuspendLayout();
            // 
            // graph
            // 
            this.graph.ChartStyle.AntiAliasing = true;
            chartPen1.Color = System.Drawing.Color.Black;
            chartPen1.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            chartPen1.Width = 1F;
            this.graph.ChartStyle.AvgLinePen = chartPen1;
            this.graph.ChartStyle.BackgroundColorBottom = System.Drawing.Color.DodgerBlue;
            this.graph.ChartStyle.BackgroundColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            chartPen2.Color = System.Drawing.Color.Gold;
            chartPen2.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            chartPen2.Width = 2F;
            this.graph.ChartStyle.ChartLinePen = chartPen2;
            chartPen3.Color = System.Drawing.Color.Black;
            chartPen3.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            chartPen3.Width = 0.5F;
            this.graph.ChartStyle.HorizontalGridPen = chartPen3;
            this.graph.ChartStyle.ShowAverageLine = true;
            this.graph.ChartStyle.ShowHorizontalGridLines = true;
            this.graph.ChartStyle.ShowVerticalGridLines = false;
            chartPen4.Color = System.Drawing.Color.DarkRed;
            chartPen4.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            chartPen4.Width = 1F;
            this.graph.ChartStyle.VerticalGridPen = chartPen4;
            this.panelLabels.Controls.SetChildIndex(this.labelName, 0);
            // 
            // tbSamples
            // 
            this.tbSamples.Lines = new string[] {
        "metroTextBox1"};
            this.tbSamples.Location = new System.Drawing.Point(5, 274);
            this.tbSamples.MaxLength = 32767;
            this.tbSamples.Multiline = true;
            this.tbSamples.Name = "tbSamples";
            this.tbSamples.PasswordChar = '\0';
            this.tbSamples.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbSamples.SelectedText = "";
            this.tbSamples.Size = new System.Drawing.Size(394, 176);
            this.tbSamples.TabIndex = 9;
            this.tbSamples.Text = "metroTextBox1";
            this.tbSamples.UseSelectable = true;
            // 
            // SensorWithTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.tbSamples);
            this.Name = "SensorWithTextBox";
            this.Size = new System.Drawing.Size(402, 453);
            this.Controls.SetChildIndex(this.graph, 0);
            this.Controls.SetChildIndex(this.panelLabels, 0);
            this.Controls.SetChildIndex(this.tbSamples, 0);
            this.panelLabels.ResumeLayout(false);
            this.panelLabels.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroTextBox tbSamples;
    }
}

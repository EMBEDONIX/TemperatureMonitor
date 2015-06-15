namespace TempMonitor.Controls
{
    partial class SensorBase
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
            SpPerfChart.ChartPen chartPen1 = new SpPerfChart.ChartPen();
            SpPerfChart.ChartPen chartPen2 = new SpPerfChart.ChartPen();
            SpPerfChart.ChartPen chartPen3 = new SpPerfChart.ChartPen();
            SpPerfChart.ChartPen chartPen4 = new SpPerfChart.ChartPen();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.labelHighest = new MetroFramework.Controls.MetroLabel();
            this.LabelLowest = new MetroFramework.Controls.MetroLabel();
            this.labelAverage = new MetroFramework.Controls.MetroLabel();
            this.panelLabels = new MetroFramework.Controls.MetroPanel();
            this.labelName = new MetroFramework.Controls.MetroLabel();
            this.graph = new SpPerfChart.RunnigGraph();
            this.panelLabels.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(4, 270);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(91, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Highest Temp:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(4, 289);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(87, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Lowest Temp:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(4, 308);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(97, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Average Temp:";
            // 
            // labelHighest
            // 
            this.labelHighest.AutoSize = true;
            this.labelHighest.Location = new System.Drawing.Point(107, 270);
            this.labelHighest.Name = "labelHighest";
            this.labelHighest.Size = new System.Drawing.Size(46, 19);
            this.labelHighest.TabIndex = 5;
            this.labelHighest.Text = "100 °C";
            // 
            // LabelLowest
            // 
            this.LabelLowest.AutoSize = true;
            this.LabelLowest.Location = new System.Drawing.Point(107, 289);
            this.LabelLowest.Name = "LabelLowest";
            this.LabelLowest.Size = new System.Drawing.Size(46, 19);
            this.LabelLowest.TabIndex = 6;
            this.LabelLowest.Text = "100 °C";
            // 
            // labelAverage
            // 
            this.labelAverage.AutoSize = true;
            this.labelAverage.Location = new System.Drawing.Point(107, 308);
            this.labelAverage.Name = "labelAverage";
            this.labelAverage.Size = new System.Drawing.Size(46, 19);
            this.labelAverage.TabIndex = 7;
            this.labelAverage.Text = "100 °C";
            // 
            // panelLabels
            // 
            this.panelLabels.Controls.Add(this.labelName);
            this.panelLabels.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLabels.HorizontalScrollbarBarColor = true;
            this.panelLabels.HorizontalScrollbarHighlightOnWheel = false;
            this.panelLabels.HorizontalScrollbarSize = 10;
            this.panelLabels.Location = new System.Drawing.Point(0, 0);
            this.panelLabels.Name = "panelLabels";
            this.panelLabels.Size = new System.Drawing.Size(402, 39);
            this.panelLabels.TabIndex = 8;
            this.panelLabels.VerticalScrollbarBarColor = true;
            this.panelLabels.VerticalScrollbarHighlightOnWheel = false;
            this.panelLabels.VerticalScrollbarSize = 10;
            this.panelLabels.MouseEnter += new System.EventHandler(this.panelLabels_MouseEnter);
            this.panelLabels.MouseLeave += new System.EventHandler(this.panelLabels_MouseLeave);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labelName.Location = new System.Drawing.Point(3, 7);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(126, 25);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Channel Name";
            // 
            // graph
            // 
            this.graph.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.graph.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.graph.Location = new System.Drawing.Point(3, 39);
            this.graph.Name = "graph";
            this.graph.PerfChartStyle.AntiAliasing = true;
            chartPen1.Color = System.Drawing.Color.Black;
            chartPen1.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            chartPen1.Width = 1F;
            this.graph.PerfChartStyle.AvgLinePen = chartPen1;
            this.graph.PerfChartStyle.BackgroundColorBottom = System.Drawing.Color.DodgerBlue;
            this.graph.PerfChartStyle.BackgroundColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            chartPen2.Color = System.Drawing.Color.Gold;
            chartPen2.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            chartPen2.Width = 2F;
            this.graph.PerfChartStyle.ChartLinePen = chartPen2;
            chartPen3.Color = System.Drawing.Color.Black;
            chartPen3.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            chartPen3.Width = 0.5F;
            this.graph.PerfChartStyle.HorizontalGridPen = chartPen3;
            this.graph.PerfChartStyle.ShowAverageLine = true;
            this.graph.PerfChartStyle.ShowHorizontalGridLines = true;
            this.graph.PerfChartStyle.ShowVerticalGridLines = false;
            chartPen4.Color = System.Drawing.Color.DarkRed;
            chartPen4.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            chartPen4.Width = 1F;
            this.graph.PerfChartStyle.VerticalGridPen = chartPen4;
            this.graph.ScaleMode = SpPerfChart.ScaleMode.Relative;
            this.graph.Size = new System.Drawing.Size(396, 228);
            this.graph.TabIndex = 0;
            this.graph.TimerInterval = 1000;
            this.graph.TimerMode = SpPerfChart.TimerMode.Disabled;
            // 
            // SensorBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelLabels);
            this.Controls.Add(this.labelAverage);
            this.Controls.Add(this.LabelLowest);
            this.Controls.Add(this.labelHighest);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.graph);
            this.Name = "SensorBase";
            this.Size = new System.Drawing.Size(402, 331);
            this.Load += new System.EventHandler(this.SensorControl_Load);
            this.panelLabels.ResumeLayout(false);
            this.panelLabels.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected SpPerfChart.RunnigGraph graph;
        protected MetroFramework.Controls.MetroLabel metroLabel1;
        protected MetroFramework.Controls.MetroLabel metroLabel2;
        protected MetroFramework.Controls.MetroLabel metroLabel3;
        protected MetroFramework.Controls.MetroLabel labelHighest;
        protected MetroFramework.Controls.MetroLabel LabelLowest;
        protected MetroFramework.Controls.MetroLabel labelAverage;
        protected MetroFramework.Controls.MetroLabel labelName;
        protected MetroFramework.Controls.MetroPanel panelLabels;
    }
}

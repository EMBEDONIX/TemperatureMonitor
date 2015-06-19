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
            SensorChart.ChartPen chartPen1 = new SensorChart.ChartPen();
            SensorChart.ChartPen chartPen2 = new SensorChart.ChartPen();
            SensorChart.ChartPen chartPen3 = new SensorChart.ChartPen();
            SensorChart.ChartPen chartPen4 = new SensorChart.ChartPen();
            this.panelLabels = new MetroFramework.Controls.MetroPanel();
            this.labelName = new MetroFramework.Controls.MetroLabel();
            this.graph = new SensorChart.RunnigGraph();
            this.panelLabels.SuspendLayout();
            this.SuspendLayout();
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
            this.labelName.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.labelName_MouseDoubleClick);
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
            this.graph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graph.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.graph.Location = new System.Drawing.Point(0, 0);
            this.graph.Name = "graph";
            this.graph.ScaleMode = SensorChart.ScaleMode.Absolute;
            this.graph.Size = new System.Drawing.Size(402, 276);
            this.graph.TabIndex = 0;
            this.graph.TimerInterval = 1000;
            this.graph.TimerMode = SensorChart.TimerMode.Disabled;
            // 
            // SensorBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelLabels);
            this.Controls.Add(this.graph);
            this.Name = "SensorBase";
            this.Size = new System.Drawing.Size(402, 276);
            this.Load += new System.EventHandler(this.SensorControl_Load);
            this.panelLabels.ResumeLayout(false);
            this.panelLabels.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected SensorChart.RunnigGraph graph;
        protected MetroFramework.Controls.MetroLabel labelName;
        protected MetroFramework.Controls.MetroPanel panelLabels;
    }
}

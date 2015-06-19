namespace TempMonitor.Controls.Dialogs
{
    partial class SensorOptionsDialogForm
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
            this.tabCharts = new MetroFramework.Controls.MetroTabPage();
            this.nudMin = new System.Windows.Forms.NumericUpDown();
            this.nudMax = new System.Windows.Forms.NumericUpDown();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tShowAlarmLine = new MetroFramework.Controls.MetroToggle();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.tShowAvrLineInChart = new MetroFramework.Controls.MetroToggle();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.tShowMinInChart = new MetroFramework.Controls.MetroToggle();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.tShowAvrInChart = new MetroFramework.Controls.MetroToggle();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.tShowMaxInChart = new MetroFramework.Controls.MetroToggle();
            this.tabGeneral = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.tDataLogging = new MetroFramework.Controls.MetroToggle();
            this.labelLogFolder = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.tabs = new MetroFramework.Controls.MetroTabControl();
            this.tabCharts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).BeginInit();
            this.tabGeneral.SuspendLayout();
            this.tabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(293, 307);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(216, 307);
            // 
            // tabCharts
            // 
            this.tabCharts.Controls.Add(this.nudMin);
            this.tabCharts.Controls.Add(this.nudMax);
            this.tabCharts.Controls.Add(this.metroLabel3);
            this.tabCharts.Controls.Add(this.metroLabel2);
            this.tabCharts.Controls.Add(this.metroLabel1);
            this.tabCharts.Controls.Add(this.tShowAlarmLine);
            this.tabCharts.Controls.Add(this.metroLabel4);
            this.tabCharts.Controls.Add(this.tShowAvrLineInChart);
            this.tabCharts.Controls.Add(this.metroLabel5);
            this.tabCharts.Controls.Add(this.tShowMinInChart);
            this.tabCharts.Controls.Add(this.metroLabel6);
            this.tabCharts.Controls.Add(this.tShowAvrInChart);
            this.tabCharts.Controls.Add(this.metroLabel7);
            this.tabCharts.Controls.Add(this.tShowMaxInChart);
            this.tabCharts.HorizontalScrollbarBarColor = true;
            this.tabCharts.HorizontalScrollbarHighlightOnWheel = false;
            this.tabCharts.HorizontalScrollbarSize = 10;
            this.tabCharts.Location = new System.Drawing.Point(4, 38);
            this.tabCharts.Name = "tabCharts";
            this.tabCharts.Size = new System.Drawing.Size(333, 196);
            this.tabCharts.TabIndex = 1;
            this.tabCharts.Text = "Sensors Charts";
            this.tabCharts.VerticalScrollbarBarColor = true;
            this.tabCharts.VerticalScrollbarHighlightOnWheel = false;
            this.tabCharts.VerticalScrollbarSize = 10;
            this.tabCharts.Click += new System.EventHandler(this.tabCharts_Click);
            // 
            // nudMin
            // 
            this.nudMin.Location = new System.Drawing.Point(250, 156);
            this.nudMin.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudMin.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudMin.Name = "nudMin";
            this.nudMin.Size = new System.Drawing.Size(79, 20);
            this.nudMin.TabIndex = 35;
            this.nudMin.Visible = false;
            this.nudMin.ValueChanged += new System.EventHandler(this.nudMin_ValueChanged);
            // 
            // nudMax
            // 
            this.nudMax.Location = new System.Drawing.Point(250, 130);
            this.nudMax.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudMax.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudMax.Name = "nudMax";
            this.nudMax.Size = new System.Drawing.Size(79, 20);
            this.nudMax.TabIndex = 34;
            this.nudMax.Visible = false;
            this.nudMax.ValueChanged += new System.EventHandler(this.nudMax_ValueChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(3, 156);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(102, 19);
            this.metroLabel3.TabIndex = 33;
            this.metroLabel3.Text = "Maximum Value";
            this.metroLabel3.Visible = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 132);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(102, 19);
            this.metroLabel2.TabIndex = 31;
            this.metroLabel2.Text = "Maximum Value";
            this.metroLabel2.Visible = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 108);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(102, 19);
            this.metroLabel1.TabIndex = 30;
            this.metroLabel1.Text = "Show alarm line";
            // 
            // tShowAlarmLine
            // 
            this.tShowAlarmLine.AutoSize = true;
            this.tShowAlarmLine.Checked = true;
            this.tShowAlarmLine.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tShowAlarmLine.Location = new System.Drawing.Point(250, 108);
            this.tShowAlarmLine.Name = "tShowAlarmLine";
            this.tShowAlarmLine.Size = new System.Drawing.Size(80, 17);
            this.tShowAlarmLine.TabIndex = 29;
            this.tShowAlarmLine.Text = "On";
            this.tShowAlarmLine.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(3, 85);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(115, 19);
            this.metroLabel4.TabIndex = 28;
            this.metroLabel4.Text = "Show average line";
            // 
            // tShowAvrLineInChart
            // 
            this.tShowAvrLineInChart.AutoSize = true;
            this.tShowAvrLineInChart.Checked = true;
            this.tShowAvrLineInChart.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tShowAvrLineInChart.Location = new System.Drawing.Point(250, 85);
            this.tShowAvrLineInChart.Name = "tShowAvrLineInChart";
            this.tShowAvrLineInChart.Size = new System.Drawing.Size(80, 17);
            this.tShowAvrLineInChart.TabIndex = 27;
            this.tShowAvrLineInChart.Text = "On";
            this.tShowAvrLineInChart.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(3, 39);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(134, 19);
            this.metroLabel5.TabIndex = 26;
            this.metroLabel5.Text = "Show minimum value";
            // 
            // tShowMinInChart
            // 
            this.tShowMinInChart.AutoSize = true;
            this.tShowMinInChart.Checked = true;
            this.tShowMinInChart.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tShowMinInChart.Location = new System.Drawing.Point(250, 39);
            this.tShowMinInChart.Name = "tShowMinInChart";
            this.tShowMinInChart.Size = new System.Drawing.Size(80, 17);
            this.tShowMinInChart.TabIndex = 25;
            this.tShowMinInChart.Text = "On";
            this.tShowMinInChart.UseSelectable = true;
            this.tShowMinInChart.CheckedChanged += new System.EventHandler(this.tShowMinInChart_CheckedChanged);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(3, 62);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(129, 19);
            this.metroLabel6.TabIndex = 24;
            this.metroLabel6.Text = "Show average  value";
            // 
            // tShowAvrInChart
            // 
            this.tShowAvrInChart.AutoSize = true;
            this.tShowAvrInChart.Checked = true;
            this.tShowAvrInChart.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tShowAvrInChart.Location = new System.Drawing.Point(250, 62);
            this.tShowAvrInChart.Name = "tShowAvrInChart";
            this.tShowAvrInChart.Size = new System.Drawing.Size(80, 17);
            this.tShowAvrInChart.TabIndex = 23;
            this.tShowAvrInChart.Text = "On";
            this.tShowAvrInChart.UseSelectable = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(3, 16);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(137, 19);
            this.metroLabel7.TabIndex = 22;
            this.metroLabel7.Text = "Show maximum value";
            // 
            // tShowMaxInChart
            // 
            this.tShowMaxInChart.AutoSize = true;
            this.tShowMaxInChart.Checked = true;
            this.tShowMaxInChart.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tShowMaxInChart.Location = new System.Drawing.Point(250, 16);
            this.tShowMaxInChart.Name = "tShowMaxInChart";
            this.tShowMaxInChart.Size = new System.Drawing.Size(80, 17);
            this.tShowMaxInChart.TabIndex = 21;
            this.tShowMaxInChart.Text = "On";
            this.tShowMaxInChart.UseSelectable = true;
            this.tShowMaxInChart.CheckedChanged += new System.EventHandler(this.tShowMaxInChart_CheckedChanged);
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.metroLabel9);
            this.tabGeneral.Controls.Add(this.tDataLogging);
            this.tabGeneral.Controls.Add(this.labelLogFolder);
            this.tabGeneral.Controls.Add(this.metroButton1);
            this.tabGeneral.Controls.Add(this.metroLabel8);
            this.tabGeneral.HorizontalScrollbarBarColor = true;
            this.tabGeneral.HorizontalScrollbarHighlightOnWheel = false;
            this.tabGeneral.HorizontalScrollbarSize = 10;
            this.tabGeneral.Location = new System.Drawing.Point(4, 38);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Size = new System.Drawing.Size(333, 196);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "General";
            this.tabGeneral.VerticalScrollbarBarColor = true;
            this.tabGeneral.VerticalScrollbarHighlightOnWheel = false;
            this.tabGeneral.VerticalScrollbarSize = 10;
            this.tabGeneral.Click += new System.EventHandler(this.tabGeneral_Click);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(3, 16);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(88, 19);
            this.metroLabel9.TabIndex = 19;
            this.metroLabel9.Text = "Data Logging";
            // 
            // tDataLogging
            // 
            this.tDataLogging.AutoSize = true;
            this.tDataLogging.Checked = true;
            this.tDataLogging.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tDataLogging.Location = new System.Drawing.Point(250, 16);
            this.tDataLogging.Name = "tDataLogging";
            this.tDataLogging.Size = new System.Drawing.Size(80, 17);
            this.tDataLogging.TabIndex = 18;
            this.tDataLogging.Text = "On";
            this.tDataLogging.UseSelectable = true;
            // 
            // labelLogFolder
            // 
            this.labelLogFolder.AutoSize = true;
            this.labelLogFolder.FontSize = MetroFramework.MetroLabelSize.Small;
            this.labelLogFolder.Location = new System.Drawing.Point(15, 72);
            this.labelLogFolder.Name = "labelLogFolder";
            this.labelLogFolder.Size = new System.Drawing.Size(19, 15);
            this.labelLogFolder.TabIndex = 17;
            this.labelLogFolder.Text = "c:\\";
            this.labelLogFolder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(250, 39);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(80, 23);
            this.metroButton1.TabIndex = 16;
            this.metroButton1.Text = "BROWSE...";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(3, 43);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(70, 19);
            this.metroLabel8.TabIndex = 15;
            this.metroLabel8.Text = "Log folder";
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabGeneral);
            this.tabs.Controls.Add(this.tabCharts);
            this.tabs.Location = new System.Drawing.Point(23, 63);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 1;
            this.tabs.Size = new System.Drawing.Size(341, 238);
            this.tabs.TabIndex = 2;
            this.tabs.UseSelectable = true;
            // 
            // SensorOptionsDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 352);
            this.Controls.Add(this.tabs);
            this.Name = "SensorOptionsDialogForm";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.SensorOptionsDialogForm_Load);
            this.Controls.SetChildIndex(this.tabs, 0);
            this.Controls.SetChildIndex(this.buttonApply, 0);
            this.Controls.SetChildIndex(this.buttonCancel, 0);
            this.tabCharts.ResumeLayout(false);
            this.tabCharts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).EndInit();
            this.tabGeneral.ResumeLayout(false);
            this.tabGeneral.PerformLayout();
            this.tabs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabPage tabCharts;
        private MetroFramework.Controls.MetroTabPage tabGeneral;
        private MetroFramework.Controls.MetroTabControl tabs;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroToggle tShowAvrLineInChart;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroToggle tShowMinInChart;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroToggle tShowAvrInChart;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroToggle tShowMaxInChart;
        private MetroFramework.Controls.MetroLabel labelLogFolder;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroToggle tDataLogging;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroToggle tShowAlarmLine;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.NumericUpDown nudMin;
        private System.Windows.Forms.NumericUpDown nudMax;
    }
}
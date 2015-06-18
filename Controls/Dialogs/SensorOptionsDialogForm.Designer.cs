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
            this.tabGeneral = new MetroFramework.Controls.MetroTabPage();
            this.tabs = new MetroFramework.Controls.MetroTabControl();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroToggle3 = new MetroFramework.Controls.MetroToggle();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroToggle2 = new MetroFramework.Controls.MetroToggle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroToggle1 = new MetroFramework.Controls.MetroToggle();
            this.lShowLabelNext = new MetroFramework.Controls.MetroLabel();
            this.tShowLabelMax = new MetroFramework.Controls.MetroToggle();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroToggle4 = new MetroFramework.Controls.MetroToggle();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroToggle5 = new MetroFramework.Controls.MetroToggle();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroToggle6 = new MetroFramework.Controls.MetroToggle();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroToggle7 = new MetroFramework.Controls.MetroToggle();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.tabCharts.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.tabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(293, 495);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(216, 495);
            // 
            // tabCharts
            // 
            this.tabCharts.Controls.Add(this.metroLabel4);
            this.tabCharts.Controls.Add(this.metroToggle4);
            this.tabCharts.Controls.Add(this.metroLabel5);
            this.tabCharts.Controls.Add(this.metroToggle5);
            this.tabCharts.Controls.Add(this.metroLabel6);
            this.tabCharts.Controls.Add(this.metroToggle6);
            this.tabCharts.Controls.Add(this.metroLabel7);
            this.tabCharts.Controls.Add(this.metroToggle7);
            this.tabCharts.Controls.Add(this.metroLabel3);
            this.tabCharts.Controls.Add(this.metroToggle3);
            this.tabCharts.Controls.Add(this.metroLabel2);
            this.tabCharts.Controls.Add(this.metroToggle2);
            this.tabCharts.Controls.Add(this.metroLabel1);
            this.tabCharts.Controls.Add(this.metroToggle1);
            this.tabCharts.Controls.Add(this.lShowLabelNext);
            this.tabCharts.Controls.Add(this.tShowLabelMax);
            this.tabCharts.HorizontalScrollbarBarColor = true;
            this.tabCharts.HorizontalScrollbarHighlightOnWheel = false;
            this.tabCharts.HorizontalScrollbarSize = 10;
            this.tabCharts.Location = new System.Drawing.Point(4, 38);
            this.tabCharts.Name = "tabCharts";
            this.tabCharts.Size = new System.Drawing.Size(333, 384);
            this.tabCharts.TabIndex = 1;
            this.tabCharts.Text = "Sensors Charts";
            this.tabCharts.VerticalScrollbarBarColor = true;
            this.tabCharts.VerticalScrollbarHighlightOnWheel = false;
            this.tabCharts.VerticalScrollbarSize = 10;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.metroLabel9);
            this.tabGeneral.Controls.Add(this.metroButton1);
            this.tabGeneral.Controls.Add(this.metroLabel8);
            this.tabGeneral.HorizontalScrollbarBarColor = true;
            this.tabGeneral.HorizontalScrollbarHighlightOnWheel = false;
            this.tabGeneral.HorizontalScrollbarSize = 10;
            this.tabGeneral.Location = new System.Drawing.Point(4, 38);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Size = new System.Drawing.Size(333, 384);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "General";
            this.tabGeneral.VerticalScrollbarBarColor = true;
            this.tabGeneral.VerticalScrollbarHighlightOnWheel = false;
            this.tabGeneral.VerticalScrollbarSize = 10;
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabGeneral);
            this.tabs.Controls.Add(this.tabCharts);
            this.tabs.Location = new System.Drawing.Point(23, 63);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(341, 426);
            this.tabs.TabIndex = 2;
            this.tabs.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(3, 106);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(97, 19);
            this.metroLabel3.TabIndex = 20;
            this.metroLabel3.Text = "Enable log box";
            // 
            // metroToggle3
            // 
            this.metroToggle3.AutoSize = true;
            this.metroToggle3.Checked = true;
            this.metroToggle3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.metroToggle3.Location = new System.Drawing.Point(250, 108);
            this.metroToggle3.Name = "metroToggle3";
            this.metroToggle3.Size = new System.Drawing.Size(80, 17);
            this.metroToggle3.TabIndex = 19;
            this.metroToggle3.Text = "On";
            this.metroToggle3.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 44);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(144, 19);
            this.metroLabel2.TabIndex = 18;
            this.metroLabel2.Text = "Show MIN value as text";
            // 
            // metroToggle2
            // 
            this.metroToggle2.AutoSize = true;
            this.metroToggle2.Checked = true;
            this.metroToggle2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.metroToggle2.Location = new System.Drawing.Point(250, 46);
            this.metroToggle2.Name = "metroToggle2";
            this.metroToggle2.Size = new System.Drawing.Size(80, 17);
            this.metroToggle2.TabIndex = 17;
            this.metroToggle2.Text = "On";
            this.metroToggle2.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 76);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(143, 19);
            this.metroLabel1.TabIndex = 16;
            this.metroLabel1.Text = "Show AVR value as text";
            // 
            // metroToggle1
            // 
            this.metroToggle1.AutoSize = true;
            this.metroToggle1.Checked = true;
            this.metroToggle1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.metroToggle1.Location = new System.Drawing.Point(250, 78);
            this.metroToggle1.Name = "metroToggle1";
            this.metroToggle1.Size = new System.Drawing.Size(80, 17);
            this.metroToggle1.TabIndex = 15;
            this.metroToggle1.Text = "On";
            this.metroToggle1.UseSelectable = true;
            // 
            // lShowLabelNext
            // 
            this.lShowLabelNext.AutoSize = true;
            this.lShowLabelNext.Location = new System.Drawing.Point(3, 16);
            this.lShowLabelNext.Name = "lShowLabelNext";
            this.lShowLabelNext.Size = new System.Drawing.Size(148, 19);
            this.lShowLabelNext.TabIndex = 14;
            this.lShowLabelNext.Text = "Show MAX value as text";
            // 
            // tShowLabelMax
            // 
            this.tShowLabelMax.AutoSize = true;
            this.tShowLabelMax.Checked = true;
            this.tShowLabelMax.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tShowLabelMax.Location = new System.Drawing.Point(250, 18);
            this.tShowLabelMax.Name = "tShowLabelMax";
            this.tShowLabelMax.Size = new System.Drawing.Size(80, 17);
            this.tShowLabelMax.TabIndex = 13;
            this.tShowLabelMax.Text = "On";
            this.tShowLabelMax.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(9, 228);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(168, 19);
            this.metroLabel4.TabIndex = 28;
            this.metroLabel4.Text = "Show average line in charts";
            // 
            // metroToggle4
            // 
            this.metroToggle4.AutoSize = true;
            this.metroToggle4.Checked = true;
            this.metroToggle4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.metroToggle4.Location = new System.Drawing.Point(250, 230);
            this.metroToggle4.Name = "metroToggle4";
            this.metroToggle4.Size = new System.Drawing.Size(80, 17);
            this.metroToggle4.TabIndex = 27;
            this.metroToggle4.Text = "On";
            this.metroToggle4.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(9, 166);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(156, 19);
            this.metroLabel5.TabIndex = 26;
            this.metroLabel5.Text = "Show MIN value in charts";
            // 
            // metroToggle5
            // 
            this.metroToggle5.AutoSize = true;
            this.metroToggle5.Checked = true;
            this.metroToggle5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.metroToggle5.Location = new System.Drawing.Point(250, 168);
            this.metroToggle5.Name = "metroToggle5";
            this.metroToggle5.Size = new System.Drawing.Size(80, 17);
            this.metroToggle5.TabIndex = 25;
            this.metroToggle5.Text = "On";
            this.metroToggle5.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(9, 198);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(182, 19);
            this.metroLabel6.TabIndex = 24;
            this.metroLabel6.Text = "Show average  value in charts";
            // 
            // metroToggle6
            // 
            this.metroToggle6.AutoSize = true;
            this.metroToggle6.Checked = true;
            this.metroToggle6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.metroToggle6.Location = new System.Drawing.Point(250, 200);
            this.metroToggle6.Name = "metroToggle6";
            this.metroToggle6.Size = new System.Drawing.Size(80, 17);
            this.metroToggle6.TabIndex = 23;
            this.metroToggle6.Text = "On";
            this.metroToggle6.UseSelectable = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(9, 138);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(160, 19);
            this.metroLabel7.TabIndex = 22;
            this.metroLabel7.Text = "Show MAX value in charts";
            // 
            // metroToggle7
            // 
            this.metroToggle7.AutoSize = true;
            this.metroToggle7.Checked = true;
            this.metroToggle7.CheckState = System.Windows.Forms.CheckState.Checked;
            this.metroToggle7.Location = new System.Drawing.Point(250, 140);
            this.metroToggle7.Name = "metroToggle7";
            this.metroToggle7.Size = new System.Drawing.Size(80, 17);
            this.metroToggle7.TabIndex = 21;
            this.metroToggle7.Text = "On";
            this.metroToggle7.UseSelectable = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(3, 16);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(70, 19);
            this.metroLabel8.TabIndex = 15;
            this.metroLabel8.Text = "Log folder";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(226, 11);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(104, 23);
            this.metroButton1.TabIndex = 16;
            this.metroButton1.Text = "BROWSE...";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel9
            // 
            this.metroLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(307, 37);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(23, 19);
            this.metroLabel9.TabIndex = 17;
            this.metroLabel9.Text = "c:\\";
            this.metroLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SensorOptionsDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 541);
            this.Controls.Add(this.tabs);
            this.Name = "SensorOptionsDialogForm";
            this.Text = "Options";
            this.Controls.SetChildIndex(this.tabs, 0);
            this.Controls.SetChildIndex(this.buttonApply, 0);
            this.Controls.SetChildIndex(this.buttonCancel, 0);
            this.tabCharts.ResumeLayout(false);
            this.tabCharts.PerformLayout();
            this.tabGeneral.ResumeLayout(false);
            this.tabGeneral.PerformLayout();
            this.tabs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabPage tabCharts;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroToggle metroToggle3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroToggle metroToggle2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroToggle metroToggle1;
        private MetroFramework.Controls.MetroLabel lShowLabelNext;
        private MetroFramework.Controls.MetroToggle tShowLabelMax;
        private MetroFramework.Controls.MetroTabPage tabGeneral;
        private MetroFramework.Controls.MetroTabControl tabs;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroToggle metroToggle4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroToggle metroToggle5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroToggle metroToggle6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroToggle metroToggle7;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel8;
    }
}
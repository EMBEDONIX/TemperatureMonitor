namespace TempMonitor.UserInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusPanel = new MetroFramework.Controls.MetroPanel();
            this.labelRxState = new MetroFramework.Controls.MetroLabel();
            this.pictureBoxStatus = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnConnect = new MetroFramework.Controls.MetroButton();
            this.cbPorts = new MetroFramework.Controls.MetroComboBox();
            this.sensorPanel = new TempMonitor.Controls.SensorPanel();
            this.statusPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // statusPanel
            // 
            this.statusPanel.Controls.Add(this.labelRxState);
            this.statusPanel.Controls.Add(this.pictureBoxStatus);
            this.statusPanel.Controls.Add(this.metroLabel1);
            this.statusPanel.Controls.Add(this.btnConnect);
            this.statusPanel.Controls.Add(this.cbPorts);
            this.statusPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusPanel.HorizontalScrollbarBarColor = true;
            this.statusPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.statusPanel.HorizontalScrollbarSize = 10;
            this.statusPanel.Location = new System.Drawing.Point(20, 631);
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.Size = new System.Drawing.Size(985, 42);
            this.statusPanel.TabIndex = 6;
            this.statusPanel.VerticalScrollbarBarColor = true;
            this.statusPanel.VerticalScrollbarHighlightOnWheel = false;
            this.statusPanel.VerticalScrollbarSize = 10;
            // 
            // labelRxState
            // 
            this.labelRxState.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelRxState.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labelRxState.Location = new System.Drawing.Point(673, 8);
            this.labelRxState.Name = "labelRxState";
            this.labelRxState.Size = new System.Drawing.Size(267, 25);
            this.labelRxState.TabIndex = 10;
            this.labelRxState.Text = "DISCONNECTED";
            this.labelRxState.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBoxStatus
            // 
            this.pictureBoxStatus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBoxStatus.BackgroundImage = global::TempMonitor.UserInterface.Properties.Resources.disconnected;
            this.pictureBoxStatus.Image = global::TempMonitor.UserInterface.Properties.Resources.disconnected;
            this.pictureBoxStatus.Location = new System.Drawing.Point(946, 3);
            this.pictureBoxStatus.Name = "pictureBoxStatus";
            this.pictureBoxStatus.Size = new System.Drawing.Size(36, 36);
            this.pictureBoxStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxStatus.TabIndex = 9;
            this.pictureBoxStatus.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(5, 10);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(64, 25);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "PORTS";
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnConnect.Location = new System.Drawing.Point(268, 8);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(124, 29);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "CONNECT";
            this.btnConnect.UseSelectable = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // cbPorts
            // 
            this.cbPorts.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbPorts.FormattingEnabled = true;
            this.cbPorts.ItemHeight = 23;
            this.cbPorts.Location = new System.Drawing.Point(74, 8);
            this.cbPorts.Name = "cbPorts";
            this.cbPorts.Size = new System.Drawing.Size(188, 29);
            this.cbPorts.TabIndex = 5;
            this.cbPorts.UseSelectable = true;
            this.cbPorts.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbPorts_MouseClick);
            this.cbPorts.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.cbPorts_MouseDoubleClick);
            // 
            // sensorPanel
            // 
            this.sensorPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sensorPanel.Location = new System.Drawing.Point(11, 63);
            this.sensorPanel.Name = "sensorPanel";
            this.sensorPanel.Size = new System.Drawing.Size(1004, 562);
            this.sensorPanel.TabIndex = 5;
            this.sensorPanel.UseSelectable = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 693);
            this.Controls.Add(this.statusPanel);
            this.Controls.Add(this.sensorPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Temperature Monitor";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusPanel.ResumeLayout(false);
            this.statusPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.SensorPanel sensorPanel;
        private System.Windows.Forms.ToolStripStatusLabel stlPorts;
        private MetroFramework.Controls.MetroPanel statusPanel;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnConnect;
        private MetroFramework.Controls.MetroComboBox cbPorts;
        private System.Windows.Forms.PictureBox pictureBoxStatus;
        private MetroFramework.Controls.MetroLabel labelRxState;


    }
}


namespace TempMonitor.Controls
{
    partial class SensorPanel
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.sensor1 = new TempMonitor.Controls.SensorBase();
            this.sensor2 = new TempMonitor.Controls.SensorBase();
            this.sensor3 = new TempMonitor.Controls.SensorBase();
            this.sensor4 = new TempMonitor.Controls.SensorBase();
            this.sensorAgg = new TempMonitor.Controls.SensorBase();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayout);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.sensorAgg);
            this.splitContainer1.Size = new System.Drawing.Size(1118, 668);
            this.splitContainer1.SplitterDistance = 245;
            this.splitContainer1.TabIndex = 2;
            // 
            // tableLayout
            // 
            this.tableLayout.ColumnCount = 4;
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayout.Controls.Add(this.sensor1, 0, 0);
            this.tableLayout.Controls.Add(this.sensor2, 1, 0);
            this.tableLayout.Controls.Add(this.sensor3, 2, 0);
            this.tableLayout.Controls.Add(this.sensor4, 3, 0);
            this.tableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout.Location = new System.Drawing.Point(0, 0);
            this.tableLayout.Name = "tableLayout";
            this.tableLayout.RowCount = 1;
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout.Size = new System.Drawing.Size(1118, 245);
            this.tableLayout.TabIndex = 3;
            // 
            // sensor1
            // 
            this.sensor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sensor1.Id = 0;
            this.sensor1.Location = new System.Drawing.Point(3, 3);
            this.sensor1.Manager = null;
            this.sensor1.Name = "sensor1";
            this.sensor1.Options = null;
            this.sensor1.SensorName = null;
            this.sensor1.Size = new System.Drawing.Size(273, 239);
            this.sensor1.TabIndex = 0;
            this.sensor1.UseSelectable = true;
            // 
            // sensor2
            // 
            this.sensor2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sensor2.Id = 0;
            this.sensor2.Location = new System.Drawing.Point(282, 3);
            this.sensor2.Manager = null;
            this.sensor2.Name = "sensor2";
            this.sensor2.Options = null;
            this.sensor2.SensorName = null;
            this.sensor2.Size = new System.Drawing.Size(273, 239);
            this.sensor2.TabIndex = 1;
            this.sensor2.UseSelectable = true;
            // 
            // sensor3
            // 
            this.sensor3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sensor3.Id = 0;
            this.sensor3.Location = new System.Drawing.Point(561, 3);
            this.sensor3.Manager = null;
            this.sensor3.Name = "sensor3";
            this.sensor3.Options = null;
            this.sensor3.SensorName = null;
            this.sensor3.Size = new System.Drawing.Size(273, 239);
            this.sensor3.TabIndex = 2;
            this.sensor3.UseSelectable = true;
            // 
            // sensor4
            // 
            this.sensor4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sensor4.Id = 0;
            this.sensor4.Location = new System.Drawing.Point(840, 3);
            this.sensor4.Manager = null;
            this.sensor4.Name = "sensor4";
            this.sensor4.Options = null;
            this.sensor4.SensorName = null;
            this.sensor4.Size = new System.Drawing.Size(275, 239);
            this.sensor4.TabIndex = 3;
            this.sensor4.UseSelectable = true;
            // 
            // sensorAgg
            // 
            this.sensorAgg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sensorAgg.Id = 0;
            this.sensorAgg.Location = new System.Drawing.Point(0, 0);
            this.sensorAgg.Manager = null;
            this.sensorAgg.Name = "sensorAgg";
            this.sensorAgg.Options = null;
            this.sensorAgg.SensorName = null;
            this.sensorAgg.Size = new System.Drawing.Size(1118, 419);
            this.sensorAgg.TabIndex = 2;
            this.sensorAgg.UseSelectable = true;
            // 
            // SensorPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "SensorPanel";
            this.Size = new System.Drawing.Size(1118, 668);
            this.Load += new System.EventHandler(this.SensorPanel_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayout;
        private SensorBase sensor1;
        private SensorBase sensor2;
        private SensorBase sensor3;
        private SensorBase sensor4;
        private SensorBase sensorAgg;



    }
}

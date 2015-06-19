using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TempMonitor.Controls.Sensors;

namespace TempMonitor.Controls.Dialogs
{
    public partial class SensorOptionsDialogForm : DialogForm
    {
        public SensorOptions Options { get; private set; }

        public SensorOptionsDialogForm()
        {
            InitializeComponent();
        }

        public SensorOptionsDialogForm(SensorOptions options) : this()
        {
            Options = options;
        }

        private void SensorOptionsDialogForm_Load(object sender, EventArgs e)
        {
            //Logging
            labelLogFolder.Text = Options.LogFolder;
            tDataLogging.Checked = Options.LoggingEnabled;

            //Chart
            tShowAvrInChart.Checked = Options.ShowChartAvrValue;
            tShowMaxInChart.Checked = Options.ShowChartMaxValue;
            tShowMinInChart.Checked = Options.ShowChartMinValue;
            tShowAvrLineInChart.Checked = Options.ShowChartAvrLine;
            tShowAlarmLine.Checked = Options.ShowChartCriticalLine;

            nudMax.Value = Options.ChartMaxValue;
            nudMin.Value = Options.ChartMinValue;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.SelectedPath = Options.LogFolder;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                labelLogFolder.Text = fbd.SelectedPath;
            }
        }

        protected override void buttonApply_Click(object sender, EventArgs e)
        {
            //Logging
            Options.LogFolder = labelLogFolder.Text;
            Options.LoggingEnabled = tDataLogging.Checked;

            //Chart
            Options.ShowChartAvrValue = tShowAvrInChart.Checked;
            Options.ShowChartMaxValue = tShowMaxInChart.Checked;
            Options.ShowChartMinValue = tShowMinInChart.Checked;
            Options.ShowChartAvrLine = tShowAvrLineInChart.Checked;
            Options.ShowChartCriticalLine = tShowAlarmLine.Checked;

            Options.ChartMaxValue = (int)nudMax.Value;
            Options.ChartMinValue = (int) nudMin.Value;

            base.buttonApply_Click(sender, e);
        }

        private void tShowMaxInChart_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tShowMinInChart_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabCharts_Click(object sender, EventArgs e)
        {

        }

        private void tabGeneral_Click(object sender, EventArgs e)
        {

        }

        private void nudMax_ValueChanged(object sender, EventArgs e)
        {
            if (nudMax.Value - 10 <= nudMin.Value)
            {
                nudMax.Value = nudMin.Value + 10;
            }
        }

        private void nudMin_ValueChanged(object sender, EventArgs e)
        {
            if (nudMin.Value + 10 >= nudMax.Value)
            {
                nudMin.Value = nudMax.Value - 10;
            }
        }
    }
}
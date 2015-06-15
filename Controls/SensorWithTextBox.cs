using System;

namespace TempMonitor.Controls
{
    public partial class SensorWithTextBox : SensorBase
    {
        public SensorWithTextBox()
        {
            InitializeComponent();
        }

        public override void OnSampleReceived(GraphPoint sample)
        {
            var dt = string.Format("{0:d-MM-yyyy hh:mm:ss:fff}", sample.ReceiveTime);
            var val = string.Format("{0:F2}", sample.Value);

            tbSamples.AppendText(dt + "\t" + val + Environment.NewLine);
        }
    }
}
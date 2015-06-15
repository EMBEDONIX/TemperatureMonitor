using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            var dt = String.Format("{0:d-MM-yyyy hh:mm:ss:fff}", sample.ReceiveTime);
            var val = String.Format("{0:F2}", sample.Value);

            tbSamples.AppendText(dt + "\t" + val + Environment.NewLine);
        }
    }
}

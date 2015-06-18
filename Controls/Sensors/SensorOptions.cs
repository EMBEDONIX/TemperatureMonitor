using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempMonitor.Controls
{
    [Serializable]
    public class SensorOptions
    {
        public bool ShowLabelMax { get; set; }
        public bool ShowLabelMin { get; set; }
        public bool ShowLabelAvr { get; set; }
        public bool ShowReceivedTextBox { get; set; }

        public decimal CriticalValue { get; set; }

        //CHART OPTIONS
        public int ChartMaxValue { get; set; }
        public int ChartMinValue { get; set; }
        public bool ShowChartMinValue { get; set; }
        public bool ShowChartMaxValue { get; set; }
        public bool ShowChartAvrValue { get; set; }
        public bool ShowChartAvrLine { get; set; }

        public SensorOptions()
        {
            ShowLabelMax = ShowLabelMin = ShowLabelAvr = ShowReceivedTextBox = true;

            ChartMaxValue = 140;
            ChartMinValue = -40;

            ShowChartMinValue = ShowChartMaxValue = ShowChartAvrValue = ShowChartAvrLine = true;
        }


        public SensorOptions(int chartMaxValue, int chartMinValue, decimal criticalValue
            , bool showChartAvrLine, bool showChartAvrValue
            , bool showChartMaxValue, bool showChartMinValue, bool showLabelAvr
            , bool showLabelMax, bool showLabelMin, bool showReceivedTextBox)
        {
            ChartMaxValue = chartMaxValue;
            ChartMinValue = chartMinValue;
            CriticalValue = criticalValue;
            ShowChartAvrLine = showChartAvrLine;
            ShowChartAvrValue = showChartAvrValue;
            ShowChartMaxValue = showChartMaxValue;
            ShowChartMinValue = showChartMinValue;
            ShowLabelAvr = showLabelAvr;
            ShowLabelMax = showLabelMax;
            ShowLabelMin = showLabelMin;
            ShowReceivedTextBox = showReceivedTextBox;
        }

        public void ResetOptions()
        {
            ShowLabelMax = ShowLabelMin = ShowLabelAvr = ShowReceivedTextBox = true;

            ChartMaxValue = 140;
            ChartMinValue = -40;

            ShowChartMinValue = ShowChartMaxValue = ShowChartAvrValue = ShowChartAvrLine = true;
        }
    }
}

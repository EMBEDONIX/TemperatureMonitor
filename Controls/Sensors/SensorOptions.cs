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

        public decimal CriticalValue { get; set; }

        //CHART OPTIONS
        public int ChartMaxValue { get; set; }
        public int ChartMinValue { get; set; }
        public bool ShowChartMinValue { get; set; }
        public bool ShowChartMaxValue { get; set; }
        public bool ShowChartAvrValue { get; set; }
        public bool ShowChartAvrLine { get; set; }
        public bool ShowChartCriticalLine { get; set; }

        //Logging
        public string LogFolder { get; set; }
        public bool LoggingEnabled { get; set; }

        public SensorOptions()
        {
            ResetOptions();
        }

        public void ResetOptions()
        {

            ChartMaxValue = 120;
            ChartMinValue = -20;

            ShowChartMinValue = ShowChartMaxValue = ShowChartAvrValue
                = ShowChartCriticalLine  = ShowChartAvrLine = true;

            LogFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            LoggingEnabled = true;
        }
    }
}

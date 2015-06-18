using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempMonitor.Controls.Sensors
{
    public class AlarmItem
    {
        public SensorSettings Sensor { get; private set; }
        public TemperatureStateEventArgs EventArgs { get; private set; }

        public string AlarmText { get; private set; }

        public AlarmItem(SensorSettings sensor, TemperatureStateEventArgs eventArgs, string alarmText)
        {
            Sensor = sensor;
            EventArgs = eventArgs;
            AlarmText = alarmText;
        }
    }
}

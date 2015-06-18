using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempMonitor.Controls.Sensors
{
    /// <summary>
    /// This is sensor specific settings like name and alarm value
    /// </summary>
    [Serializable]
    public class SensorSettings
    {
        public int SensorId { get; set; }
        public int AlarmPoint { get; set; }
        public string SensorName { get; set; }
        public bool SpeechEnabled { get; set; }

        public SensorSettings()
        {
            AlarmPoint = 80;
            SensorName = "Sensor";
            SpeechEnabled = true;
        }
    }
}

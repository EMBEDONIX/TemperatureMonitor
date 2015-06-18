using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempMonitor.Controls.Sensors
{

    public enum AlarmState
    {
        Critical,
        Normal
    }

    public class TemperatureStateEventArgs : EventArgs
    {
        public AlarmState State { get; private set; }
        public string SensorName { get; private set; }
        public int SensorId { get; private set; }
        public double CurrentTemp { get; private set; }
        public int AlarmPoint { get; private set; }
        public string TextToSpeech { get; private set; }

        public TemperatureStateEventArgs(AlarmState state, string sensorName, int sensorId, double currentTemp, int alarmPoint)
        {
            State = state;
            SensorName = sensorName;
            SensorId = sensorId;
            CurrentTemp = currentTemp;
            AlarmPoint = alarmPoint;
            if(State == AlarmState.Critical)
                TextToSpeech = "Warning! " + SensorName + " is critical";
            if (State == AlarmState.Normal)
                TextToSpeech = "" + SensorName + " is back to normal";
        }
    }
}

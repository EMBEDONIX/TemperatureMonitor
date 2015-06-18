using System;

namespace TempMonitor.Controls
{
    public class GraphPoint
    {
        public GraphPoint(DateTime receiveTime, string sourceName, decimal value)
        {
            ReceiveTime = receiveTime;
            SourceName = sourceName;
            Value = 140*(value)/4096;
            Value -= 20;
        }

        public GraphPoint(DateTime receiveTime, string sourceName, decimal value, bool convertToDegrees)
        {
            ReceiveTime = receiveTime;
            SourceName = sourceName;
            if (convertToDegrees)
            {
                Value = 140*(value)/4096;
                Value -= 20;
            }
            else
                Value = value;
        }

        public string SourceName { get; private set; }
        public DateTime ReceiveTime { get; private set; }
        public decimal Value { get; private set; }
    }
}
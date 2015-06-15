using System;
using MetroFramework.Controls;
using MetroFramework.Interfaces;

namespace TempMonitor.Controls
{
    public partial class SensorPanel : MetroUserControl, IMetroControl
    {
        public SensorPanel()
        {
            InitializeComponent();
        }

        private void SensorPanel_Load(object sender, EventArgs e)
        {
        }

        public void AddSample(GraphPoint sample, int sensorNumber)
        {
            switch (sensorNumber)
            {
                case 1:
                    sensor1.AddSample(sample);
                    break;
                case 2:
                    sensor2.AddSample(sample);
                    break;
                case 3:
                    sensor3.AddSample(sample);
                    break;
                case 4:
                    sensor4.AddSample(sample);
                    break;
            }
        }

        public void AddSample(GraphPoint[] samples)
        {
            decimal sum = 0;

            for (var i = 0; i < samples.Length; i++)
            {
                var j = int.Parse(samples[i].SourceName);
                sum += samples[i].Value;
                AddSample(samples[i], j);
            }

            sensorAgg.AddSample(new GraphPoint(samples[0].ReceiveTime, "AGG", sum/4M, false));
        }
    }
}
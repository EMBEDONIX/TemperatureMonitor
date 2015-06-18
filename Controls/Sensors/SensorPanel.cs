using System;
using System.Collections.Generic;
using System.Speech.Synthesis;
using System.Threading;
using MetroFramework.Controls;
using MetroFramework.Interfaces;
using TempMonitor.Controls.Sensors;

namespace TempMonitor.Controls
{
    public partial class SensorPanel : MetroUserControl, IMetroControl
    {

        public SensorPanel()
        {
            InitializeComponent();

            sensor1.SetId(1);
            sensor2.SetId(2);
            sensor3.SetId(3);
            sensor4.SetId(4);

            sensor1.SetManager(this);
            sensor2.SetManager(this);
            sensor3.SetManager(this);
            sensor4.SetManager(this);

            sensorAgg.SetId(5);

            sensor1.SetName("Sensor 1");
            sensor2.SetName("Sensor 2");
            sensor3.SetName("Sensor 3");
            sensor4.SetName("Sensor 4");
            sensorAgg.SetName("Total Average");
        }

        private void SensorPanel_Load(object sender, EventArgs e)
        {

        }

        public void UpdateSensorSettings()
        {
            sensor1.LoadSettings();
            sensor2.LoadSettings();
            sensor3.LoadSettings();
            sensor4.LoadSettings();
            sensorAgg.LoadSettings();
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
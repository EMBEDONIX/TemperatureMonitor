using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework.Interfaces;
using TempMonitor.Controls.Dialogs;
using TempMonitor.Controls.Sensors;

namespace TempMonitor.Controls
{
    
    public partial class SensorPanel : MetroUserControl, IMetroControl
    {

        public SensorOptions Options { get; private set; }

        private Queue<string> _queue;
        private SpeechSynthesizer _speech;
        private bool _lastSpeechCompleted;
        private Thread _thread;

        private LogHolder[] _logHolders;

        public void AddSpeech(string textToSpeech)
        {
            _queue.Enqueue(textToSpeech);
        }

        public SensorPanel()
        {
            InitializeComponent();


            sensor1.SetManager(this);
            sensor2.SetManager(this);
            sensor3.SetManager(this);
            sensor4.SetManager(this);
            sensorAgg.SetManager(this);

            sensor1.SetId(1);
            sensor2.SetId(2);
            sensor3.SetId(3);
            sensor4.SetId(4);

            sensorAgg.SetId(5);

            sensor1.SetName("Sensor 1");
            sensor2.SetName("Sensor 2");
            sensor3.SetName("Sensor 3");
            sensor4.SetName("Sensor 4");
            sensorAgg.SetName("Total Average");

            _queue = new Queue<string>();
            _speech = new SpeechSynthesizer();
            _speech.SpeakCompleted += (sender, args) =>
            {
                _lastSpeechCompleted = true;
            };
        }

        private void SensorPanel_Load(object sender, EventArgs e)
        {
            Options = SerializerManager.DeSerializeObject<SensorOptions>(SerializerManager.OptionsFile);
            if (Options == null)
            {
                Options = new SensorOptions();
                SerializerManager.SerializeObject(Options, SerializerManager.OptionsFile);
            }

            SetSensorsOptions();
        }

        private void SetSensorsOptions()
        {
            sensor1.SetOptions(Options);
            sensor2.SetOptions(Options);
            sensor3.SetOptions(Options);
            sensor4.SetOptions(Options);
            sensorAgg.SetOptions(Options);
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
                    if (Options.LoggingEnabled)
                        _logHolders[0].DataList.Add($"{sample.ReceiveTime:dd-MM-yy hh:mm:ss:fff}\t{sample.Value:F}");
                    break;
                case 2:
                    sensor2.AddSample(sample);
                    if (Options.LoggingEnabled)
                        _logHolders[1].DataList.Add($"{sample.ReceiveTime:dd-MM-yy hh:mm:ss:fff}\t{sample.Value:F}");
                    break;
                case 3:
                    sensor3.AddSample(sample);
                    if (Options.LoggingEnabled)
                        _logHolders[2].DataList.Add($"{sample.ReceiveTime:dd-MM-yy hh:mm:ss:fff}\t{sample.Value:F}");
                    break;
                case 4:
                    sensor4.AddSample(sample);
                    if (Options.LoggingEnabled)
                        _logHolders[3].DataList.Add($"{sample.ReceiveTime:dd-MM-yy hh:mm:ss:fff}\t{sample.Value:F}");
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

            sensorAgg.AddSample(new GraphPoint(samples[0].ReceiveTime, "AGG", sum / 4M, false));
        }

        public void OnDisconnected()
        {
            _speech.SpeakAsyncCancelAll();
            _queue.Clear();
            if (_thread != null)
            {
                _thread.Abort();
                _thread = null;
            }

            if (_logHolders != null)
            {
                foreach (var log  in _logHolders)
                {
                    log.SetFolderName(DateTime.Now.ToString("dd-MM-yyyy hh-mm-ss"));
                    log.FlushToDisk();
                }
            }
        }

        public void OnConnected()
        {
            if (Options.LoggingEnabled)
            {

                _logHolders = new LogHolder[4];
                _logHolders[0] = new LogHolder(sensor1.SensorName, Options);
                _logHolders[1] = new LogHolder(sensor2.SensorName, Options);
                _logHolders[2] = new LogHolder(sensor3.SensorName, Options);
                _logHolders[3] = new LogHolder(sensor4.SensorName, Options);
            }

            _thread = new Thread((() =>
            {
                while (true)
                {
                    if (_queue.Count > 0)
                    {
                        _speech.SpeakAsync(_queue.Dequeue());
                        _lastSpeechCompleted = false;
                        while (!_lastSpeechCompleted); //wait until speech is completed
                    }
                }
            }));
            _thread.Start();
        }

        public void ShowSensorOptionsDialog()
        {
            using (var dlg = new SensorOptionsDialogForm(Options))
            {

                //dlg.Text += " '" + _settings.SensorName + "'";

                var result = dlg.ShowDialog();
                dlg.Location = new Point(Location.X, Location.Y);
                dlg.BringToFront();
                dlg.Focus();
                if (result == DialogResult.OK)
                {
                    SetSensorsOptions();
                    Options = dlg.Options;
                    SerializerManager.SerializeObject(Options, SerializerManager.OptionsFile);
                    
                }
            }
        }
    }

    public class LogHolder
    {
        public string FileName;
        public List<string> DataList;
        public SensorOptions Options;
        private string folder;

        public LogHolder(string fileName, SensorOptions options)
        {
            DataList = new List<string>();
            FileName = fileName;
            FileName = FileName.Replace(" ", "_");
            Options = options;
        }

        public void SetFolderName(string toString)
        {
            folder = "log" + toString;
        }

        public void FlushToDisk()
        {
                if (DataList == null || DataList.Count == 0)
                    return;

            try
            {
                var dir = Options.LogFolder + Path.DirectorySeparatorChar + folder;
                Directory.CreateDirectory(dir);
                var path = dir + Path.DirectorySeparatorChar + FileName + "_" +
                           DataList[0].Split('\t')[0].Replace(":", "_") +
                           +DateTime.Now.Millisecond + ".tsv";


                File.WriteAllLines(path, DataList);
            }
            catch(Exception e)
            {
                Debug.WriteLine(e.Message);
            }

        }


    }
}
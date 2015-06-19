using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Speech.Synthesis;
using System.Threading;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework.Interfaces;
using SensorChart;
using TempMonitor.Controls.Dialogs;
using TempMonitor.Controls.Properties;
using TempMonitor.Controls.Sensors;
using Timer = System.Windows.Forms.Timer;

namespace TempMonitor.Controls
{
    public partial class SensorBase : MetroUserControl
    {

        //TODO move speech to SensorPanel to manage speechs...so they dont interfere with eachother!

        public event EventHandler<TemperatureStateEventArgs> CriticalState;
        public event EventHandler<TemperatureStateEventArgs> NormalState;

        private Timer _timer;


        public double CurrentValue { get; private set; }
        public AlarmState State;
        public SensorPanel Manager { get; set; }

        public SensorOptions Options { get; set; }
        public decimal AlarmPoint { get; private set; }
        public int Id { get; set; }

        private Func<double, double> _runningAverage = SimpleMovingAverage(65535);
        private int counter; //to count received samples
        private PictureBox pbEditLabel; //to edit label
        private SensorSettings _settings;

        private bool _hasSentSpeech; //To see if we ever sent a audio message to manager
        private SensorSettingsDialog _renameDialog;

        public SensorBase()
        {
            InitializeComponent();
            State = AlarmState.Normal;
            HighestSample = 0;
            LowestSample = 0;
            Average = _runningAverage(0);
            graph.ScaleMode = SensorChart.ScaleMode.Relative;

            UpdateLabels();
        }

        public SensorBase(SensorOptions options) : this()
        {

            Options = options;
            HighestSample = 0;
            LowestSample = 0;
            Average = _runningAverage(0);

            UpdateLabels();
        }

        public void LoadSettings()
        {
            SensorSettings setting = null;

            try
            {
                setting =
                    SerializerManager.DeSerializeObject<SensorSettings>
                        (SerializerManager.OptionsFolder + "sensor" + Id + ".bin");
            }
            catch (IOException ioe)
            {

            }
            catch (Exception e)
            {

            }


            if (setting == null)
            {
                try
                {
                    setting = new SensorSettings();
                    setting.SensorId = Id;
                    setting.SensorName = "sensor " + Id;
                    setting.AlarmPoint = 80;
                    SerializerManager.SerializeObject(setting, SerializerManager.OptionsFolder + "sensor" + Id + ".bin");
                }
                catch (IOException ioe)
                {

                }
                catch (Exception e)
                {
                    setting = null;
                }
            }

            SetName(setting.SensorName);
            SetAlarm(setting.AlarmPoint);
            SetId(setting.SensorId);
            _settings = setting;

            Options = new SensorOptions();
            Options.ResetOptions();
        }

        private void SetAlarm(decimal alarmValue)
        {
            AlarmPoint = alarmValue;
        }

        


        public string SensorName { get; set; }
        public double HighestSample { get; private set; }
        public double LowestSample { get; private set; }
        public double Average { get; private set; }

        protected void UpdateLabels()
        {
            //labelHighest.Text = string.Format("MAX: {0:F}", HighestSample) + " °C";
            //LabelLowest.Text = string.Format("MIN: {0:F}", LowestSample) + " °C";
            //labelAverage.Text = string.Format("AVR: {0:F}", Average) + " °C";
            graph.SetTotalAverage(Average);
        }

        private static Func<double, double> SimpleMovingAverage(int window)
        {
            var s = new Queue<double>(window);
            return x =>
            {
                if (s.Count >= window)
                    s.Dequeue();

                s.Enqueue(x);
                return s.Average();
            };
        }

        private void SensorControl_Load(object sender, EventArgs e)
        {
        }

        public void AddSample(GraphPoint sample)
        {
            CurrentValue = (double) sample.Value;


            //check if new value is bigger than alarm point
            if (sample.Value > _settings.AlarmPoint)
            {
                State = AlarmState.Critical; //set state to critical 
                var critArgs = OnCriticalState(); //raise event also get arguments for speech! lol 2 targets with 1 bullet

                if (_settings.SpeechEnabled) //if should speak 
                {
                    if (_timer == null) //if we are not already in critical state make new timer
                    {
                        _timer = new Timer();
                        _timer.Interval = 2000; //TODO put this in global options
                        _timer.Tick += (sender, args) =>
                        {
                            if (CurrentValue > _settings.AlarmPoint) //if still in critical 
                            {
                                    Manager.AddSpeech(critArgs.TextToSpeech);
                                    _hasSentSpeech = true;
                                    _timer.Interval = 20000; //initial message sent, so increase timer to next message
                            }
                        };
                        _timer.Start();
                    }
                    else
                    {
                        // do nothing, timer will raise the event on its next interval
                    }
                }
            }
            else
            {
                if (State == AlarmState.Critical)
                {
                    var args = OnNormalState();
                    if (_timer != null)
                    {
                        _timer.Stop();
                        _timer = null;
                    }
                    if (_settings.SpeechEnabled)
                    {
                        if (_hasSentSpeech == true)
                        {
                            Manager.AddSpeech(args.TextToSpeech);
                            _hasSentSpeech = false;
                        }
                    }
                }
                State = AlarmState.Normal;
            }

            if (counter == 0)
            {
                HighestSample = CurrentValue;
                LowestSample = CurrentValue;
                Average = CurrentValue;
                Average = _runningAverage(CurrentValue);
                counter++;
            }
            else
            {
                //Check for highest, lowest
                if (CurrentValue > HighestSample)
                    HighestSample = CurrentValue;

                if (CurrentValue < LowestSample)
                    LowestSample = CurrentValue;

                //Update running average
                Average = _runningAverage(CurrentValue);
            }

            //update labels
            UpdateLabels();

            OnSampleReceived(sample);

            //Add the point to graph
            graph.AddValue(sample, HighestSample, LowestSample, Average, _settings.AlarmPoint);
        }

        
        private TemperatureStateEventArgs OnCriticalState()
        {
            var args = new TemperatureStateEventArgs(AlarmState.Critical, _settings.SensorName, Id, CurrentValue,
                _settings.AlarmPoint);

            if (CriticalState != null)
            {
                CriticalState(this, args);
            }

            return args;
        }

        private TemperatureStateEventArgs OnNormalState()
        {
            var args = new TemperatureStateEventArgs(AlarmState.Normal, _settings.SensorName, Id, CurrentValue,
                _settings.AlarmPoint);

            if (NormalState != null)
            {
                NormalState(this, args);
            }

            return args;
        }


        public virtual void OnSampleReceived(GraphPoint sample)
        {
        }

        public void SetName(string name)
        {
            labelName.Text = name;
            SensorName = name;
        }


        public void SetId(int id)
        {
            Id = id;
        }


        public void SetManager(SensorPanel sensorPanel)
        {
            Manager = sensorPanel;
        }

        
        private void panelLabels_MouseEnter(object sender, EventArgs e)
        {
            //panelLabels.Focus();
            //pbEditLabel = new PictureBox();
            //pbEditLabel.Image = Resources.edit;
            //pbEditLabel.SizeMode = PictureBoxSizeMode.StretchImage;
            //pbEditLabel.Size = new Size(labelName.Height - 4, labelName.Height - 4);
            //pbEditLabel.Location = new Point(labelName.Location.X + labelName.Width + 5, labelName.Location.Y);

            //panelLabels.SuspendLayout();
            //panelLabels.Controls.Add(pbEditLabel);
            //panelLabels.ResumeLayout();
        }

        private void panelLabels_MouseLeave(object sender, EventArgs e)
        {
            //if (pbEditLabel != null)
            //{
            //    panelLabels.SuspendLayout();
            //    panelLabels.Controls.Remove(pbEditLabel);
            //    panelLabels.ResumeLayout();
            //    pbEditLabel = null;
            //}
        }

        private void labelName_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            using (var dlg = new SensorSettingsDialog(_settings, Options))
            {
                dlg.Location = new Point(Location.X , Location.Y);
                dlg.BringToFront();
                dlg.Focus();
                dlg.Text += " '" + _settings.SensorName + "'";
                var result = dlg.ShowDialog();
                if (result == DialogResult.OK)
                {
                    _settings = dlg.NewSettings;
                    SetName(_settings.SensorName);
                    SetAlarm(_settings.AlarmPoint);
                    if (!_settings.SpeechEnabled) //if speec was perviously enabled
                    {
                        //stop all speech threads and timers
                        if (_timer != null)
                        {
                            _timer.Stop();
                            _timer = null;
                        }
                    }

                    
                    SerializerManager.SerializeObject(_settings, SerializerManager.OptionsFolder + "sensor" + Id + ".bin");
                }
            }

        }

        public void SetOptions(SensorOptions options)
        {
            Options = options;
            _runningAverage = SimpleMovingAverage(65535);
            State = AlarmState.Normal;
            HighestSample = 0;
            LowestSample = 0;
            Average = _runningAverage(0);
            graph.ScaleMode = SensorChart.ScaleMode.Relative;

            UpdateLabels();

            graph.UpdatOptions(options);

           //labelHighest.Visible = options.ShowLabelAvr;
           //LabelLowest.Visible = options.ShowLabelAvr;
           //labelAverage.Visible = options.ShowLabelAvr;
        }
    }
}